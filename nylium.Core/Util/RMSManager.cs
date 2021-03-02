using System;
using Microsoft.IO;

namespace nylium.Core.Util {

    public class RMSManager {

        private static RecyclableMemoryStreamManager Instance { get; set; }

        public static RecyclableMemoryStreamManager Get() {
            if(Instance == null) {
                Instance = new RecyclableMemoryStreamManager();
            }

            return Instance;
        }
    }
}
