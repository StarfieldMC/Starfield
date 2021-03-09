namespace nylium.Extensions {

    public static class ArrayExtensions {

        public static bool InBounds(this int index, int[] array) {
            return (index >= 0) && (index < array.Length);
        }
    }
}
