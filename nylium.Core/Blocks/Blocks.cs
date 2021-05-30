using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;

namespace nylium.Core.Blocks {

    public class Blocks {

        private static ConcurrentDictionary<string, Func<object, BlockBase>> ctors = new();
        private static ConcurrentDictionary<(ushort min, ushort max), Func<ushort, BlockBase>> getCtors = new();

        static Blocks() {
            Parallel.ForEach(AppDomain.CurrentDomain.GetAssemblies()
                       .SelectMany(t => t.GetTypes())
                       .Where(t => t.IsClass && t.Namespace == "nylium.Core.Block.Blocks"), type => {
                           string id = (string) type.GetProperty("Id").GetValue(null);

                           ConstructorInfo constructor = type.GetConstructor(new Type[] { typeof(object) });
                           ParameterExpression parameter = Expression.Parameter(typeof(object));
                           Func<object, BlockBase> ctor = Expression.Lambda<Func<object, BlockBase>>(Expression.New(constructor, parameter), parameter).Compile();

                           ctors.TryAdd(id, ctor);

                           ushort minState = (ushort) type.GetProperty("MinimumState").GetValue(null);
                           ushort maxState = (ushort) type.GetProperty("MaximumState").GetValue(null);

                           constructor = type.GetConstructor(new Type[] { typeof(ushort) });
                           parameter = Expression.Parameter(typeof(ushort));
                           Func<ushort, BlockBase> getCtor = Expression.Lambda<Func<ushort, BlockBase>>(Expression.New(constructor, parameter), parameter).Compile();

                           getCtors.TryAdd((minState, maxState), getCtor);
                       });
        }

        public static Func<object, BlockBase> Get(string id) => ctors[id];

        public static BlockBase Get(ushort state) {
            return getCtors.AsParallel().Where(entry => entry.Key.min <= state && entry.Key.max >= state).First().Value(state);
        }
    }
}