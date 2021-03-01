using System.IO;
using System.Text;

namespace nylium.Extensions {

    public static class ArrayExtensions {

        public static void Print(this byte[] arr, TextWriter output) {
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < arr.Length; i++) {
                sb.Append(arr[i]);

                if(i != arr.Length - 1) {
                    sb.Append(", ");
                }
            }

            output.Write(sb.ToString());
        }
    }
}
