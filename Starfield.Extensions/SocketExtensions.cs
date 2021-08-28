using System.Net.Sockets;

namespace Starfield.Extensions {

    public static class SocketExtensions {

        public static bool IsConnected(this Socket s) {
            return !((s.Poll(1, SelectMode.SelectRead) && (s.Available == 0)) || !s.Connected);
        }
    }
}
