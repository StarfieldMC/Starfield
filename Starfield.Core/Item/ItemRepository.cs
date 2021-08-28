using System;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Starfield.Logging;
using Starfield.Utilities;
using Starfield.Utilities.Collections;

namespace Starfield.Core.Item {
    
    public class ItemRepository {
        
        private static readonly MultiKeyDictionary<Func<ItemBase>> items = new();
        
        public static void Initialize() {
            Stopwatch stopwatch = new();
            stopwatch.Start();

            Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.Namespace == "Starfield.Core.Item.Items")
                .ToList()
                .ForEach(t => {
                    ConstructorInfo defaultConstructor = t.GetConstructor(Type.EmptyTypes);

                    Func<ItemBase> defaultCtor = Expression.Lambda<Func<ItemBase>>(
                        Expression.New(defaultConstructor)).Compile();

                    ItemAttribute attribute = t.GetCustomAttribute<ItemAttribute>(false);

                    if(attribute == null) {
                        Logger.Warning($"Type [{t.FullName}] has no ItemAttribute attribute.");
                        return;
                    }
                    
                    items.Add(attribute.Id, defaultCtor);
                    items.Add(attribute.ProtocolId, defaultCtor);
                    items.FinishAdd(defaultCtor);
                });
            
            stopwatch.Stop();
            Logger.Debug("Initialized item repository in " + Math.Round(stopwatch.Elapsed.TotalMilliseconds, 2) + "ms");
        }

        public static ItemBase Create(Identifier id) {
            return items.Get(id)();
        }

        public static ItemBase Create(int protocolId) {
            return items.Get(protocolId)();
        }
    }
}