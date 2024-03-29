﻿namespace Starfield.Core.Networking {

    public enum ProtocolState : ushort {

        Handshaking,
        Status,
        Login,
        Play,
        Unknown = ushort.MaxValue
    }
}
