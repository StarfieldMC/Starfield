using System;
using Microsoft.IO;

namespace nylium.Utilities {

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
