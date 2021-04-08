﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace nylium.Extensions {

    // https://stackoverflow.com/a/11930875
    public static class IEnumerableExtensions {

        public static T RandomElementByWeight<T>(this IEnumerable<T> sequence, Func<T, float> weightSelector, Random random) {
            float totalWeight = sequence.Sum(weightSelector);
            // The weight we are after...
            float itemWeightIndex = (float) random.NextDouble() * totalWeight;
            float currentWeightIndex = 0;

            foreach(var item in from weightedItem in sequence select new { Value = weightedItem, Weight = weightSelector(weightedItem) }) {
                currentWeightIndex += item.Weight;

                // If we've hit or passed the weight we are after for this item then it's the one we want....
                if(currentWeightIndex >= itemWeightIndex) return item.Value;
            }

            return default(T);
        }
    }
}