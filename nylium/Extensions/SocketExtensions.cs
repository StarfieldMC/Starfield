using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace nylium.Extensions {

    static class SocketExtensions {

        public static bool IsConnected(this Socket s) {
            return !((s.Poll(1000, SelectMode.SelectRead) && (s.Available == 0)) || !s.Connected);
        }
    }
}
