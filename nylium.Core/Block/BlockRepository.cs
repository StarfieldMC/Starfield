using System;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using nylium.Utilities.Collections;
using Serilog;
using IntervalTree;
using nylium.Utilities;

namespace nylium.Core.Block {
    
    public class BlockRepository {
        
        private static readonly MultiKeyDictionary<Func<BlockBase>> blocks = new();
        private static readonly IntervalTree<ushort, Func<ushort, BlockBase>> stateBlocks = new();
        
        public static void Initialize() {
            Stopwatch stopwatch = new();
            stopwatch.Start();

            Type[] ctorParams = { typeof(ushort) };

            Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.Namespace == "nylium.Core.Block.Blocks")
                .AsParallel()
                .ForAll(t => {
                    ConstructorInfo constructor = t.GetConstructor(ctorParams);
                    ConstructorInfo defaultConstructor = t.GetConstructor(Type.EmptyTypes);
                    
                    if(constructor == null || defaultConstructor == null) {
                        Log.Debug($"Type [{t.FullName}] is probably not a packet, ignoring");
                        return;
                    }

                    ParameterExpression parameter = Expression.Parameter(typeof(ushort));
                    Func<ushort, BlockBase> ctor = Expression.Lambda<Func<ushort, BlockBase>>(
                        Expression.New(constructor, parameter), parameter).Compile();

                    Func<BlockBase> defaultCtor = Expression.Lambda<Func<BlockBase>>(
                        Expression.New(defaultConstructor)).Compile();

                    BlockAttribute attribute = t.GetCustomAttribute<BlockAttribute>(false);

                    if(attribute == null) {
                        Log.Warning($"Type [{t.FullName}] has no BlockAttribute attribute.");
                        return;
                    }
                    
                    stateBlocks.Add(attribute.MinimumState, attribute.MaximumState, ctor);

                    blocks.Add(attribute.Id, defaultCtor);
                    blocks.Add(attribute.ProtocolId, defaultCtor);
                    blocks.FinishAdd(defaultCtor);
                });
            
            stopwatch.Stop();
            Log.Debug("Initialized block repository in " + Math.Round(stopwatch.Elapsed.TotalMilliseconds, 2) + "ms");
        }

        public static BlockBase Create(ushort state) {
            return stateBlocks.Query(state).First()(state);
        }

        public static BlockBase Create(Identifier id) {
            return blocks.Get(id)();
        }

        public static BlockBase Create(int protocolId) {
            return blocks.Get(protocolId)();
        }
    }
}