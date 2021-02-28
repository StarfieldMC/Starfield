using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;

namespace nylium.Extensions {

    static class TcpClientExtensions {

        public static TcpState GetState(this TcpClient tcpClient) {
            var foo = IPGlobalProperties.GetIPGlobalProperties()
              .GetActiveTcpConnections()
              .SingleOrDefault(x => x.LocalEndPoint.Equals(tcpClient.Client.LocalEndPoint));

            return foo != null ? foo.State : TcpState.Unknown;
        }
    }
}
