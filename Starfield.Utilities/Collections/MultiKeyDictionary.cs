using System.Collections.Generic;

namespace Starfield.Utilities.Collections {
    
    public class MultiKeyDictionary<T> {

        private Dictionary<string, int> lookupDictionary = new();
        private Dictionary<int, T> valueDictionary = new();

        public T Get(dynamic key) {
            return valueDictionary[lookupDictionary[key.ToString()]];
        }

        public void Add(dynamic key, T value) {
            lookupDictionary.Add(key.ToString(), value.GetHashCode());
        }
            
        public void FinishAdd(T value) {
            valueDictionary.Add(value.GetHashCode(), value);
        }
    }
}