using System;
using System.Collections.Generic;
using System.Text;

namespace nylium.Util {

    public enum ProtocolState : ushort {

        HANDSHAKING = 0,
        STATUS = 1,
        LOGIN = 2,
        PLAY = 3
    }
}
