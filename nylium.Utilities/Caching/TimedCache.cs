using System;
using System.Collections.Generic;
using System.Runtime.Caching;

namespace nylium.Utilities.Caching {

    public class TimedCache<T> {

        private MemoryCache Cache { get; }
        private CacheItemPolicy Policy { get; }

        public TimedCache(string name, TimeSpan slidingExpiration, long sizeLimit = int.MaxValue) {
            Cache = new(name);
            Policy = new() {
                SlidingExpiration = slidingExpiration
            };
        }

        public bool Contains(string key) {
            return Cache.Contains(key);
        }

        public T Get(string key) {
            return !Cache.Contains(key) ? default : (T) Cache.Get(key);
        }

        public void Set(string key, T value) {
            Cache.Set(key, value, Policy);
        }

        public void Iterate(Action<T> action) {
            foreach(dynamic obj in Cache) {
                action((T) obj.Value);
            }
        }
    }
}