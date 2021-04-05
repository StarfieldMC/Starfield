using System;
using System.Timers;
using nylium.Core.Networking.Packet;
using nylium.Core.Networking.Packet.Server.Play;
using nylium.Utilities;

namespace nylium.Core.Networking {

    public class KeepAlive {

        private readonly Random random = new();

        private Action<MinecraftPacket> Send { get; }
        private Action TimeoutAction { get; }

        private Timer KeepAliveTimer { get; }
        private Timer TimeoutTimer { get; }

        public bool HasResponded;

        public KeepAlive(Action<MinecraftPacket> send, Action timeoutAction, double delayInMilliseconds) {
            Send = send;
            TimeoutAction = timeoutAction;

            KeepAliveTimer = new Timer(delayInMilliseconds);
            KeepAliveTimer.Elapsed += KeepAliveTimer_Elapsed;
            KeepAliveTimer.AutoReset = true;
            TimeoutTimer = new Timer(30000); // 30 seconds
            TimeoutTimer.Elapsed += TimeoutTimer_Elapsed;
            TimeoutTimer.AutoReset = true;
        }

        private void TimeoutTimer_Elapsed(object sender, ElapsedEventArgs e) {
            if(!HasResponded) {
                KeepAliveTimer.Stop();
                TimeoutTimer.Stop();
                TimeoutAction();
            } else {
                TimeoutTimer.Interval = TimeoutTimer.Interval;
                TimeoutTimer.Stop();
            }
        }

        private void KeepAliveTimer_Elapsed(object sender, ElapsedEventArgs e) {
            TimeoutTimer.Stop();

            SP1FKeepAlive keepAlive = new(RandomUtils.Long(random));
            Send(keepAlive);

            HasResponded = false;
            TimeoutTimer.Start();
            TimeoutTimer.Interval = TimeoutTimer.Interval;
        }

        public void Start() {
            KeepAliveTimer.Start();
            TimeoutTimer.Start();
        }

        public void Stop() {
            KeepAliveTimer.Stop();
            TimeoutTimer.Stop();
        }
    }
}
