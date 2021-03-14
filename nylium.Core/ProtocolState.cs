namespace nylium.Core {

    public enum ProtocolState : ushort {

        Handshaking,
        Status,
        Login,
        Play,
        Unknown = ushort.MaxValue
    }
}
