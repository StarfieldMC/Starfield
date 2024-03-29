﻿using System;
using Microsoft.IO;

namespace Starfield.Utilities {

    public class RMSManager {

        private static RecyclableMemoryStreamManager Instance { get; set; }

        public static RecyclableMemoryStreamManager Get() {
            if(Instance == null) {
                Instance = new RecyclableMemoryStreamManager(1024, 16 * 1024, 16 * 16 * 1024, false);
                Instance.AggressiveBufferReturn = true;
            }

            return Instance;
        }
    }
}
