using System;
using System.Net.Sockets;
using System.Timers;
using Starfield.Core.Networking.Packet;
using Starfield.Core.Networking.Packet.Server.Play;

namespace Starfield.Core.Networking {

    public class KeepAlive {

        private readonly Random random = new();

        private MinecraftClient Client { get; }

        private Action TimeoutAction { get; }

        private Timer KeepAliveTimer { get; }
        private Timer TimeoutTimer { get; }

        public bool HasResponded;

        public KeepAlive(MinecraftClient client, Action timeoutAction, double delayInMilliseconds) {
            Client = client;

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

            SP1FKeepAlive keepAlive = new(Client, LongRandom(random));
            Client.Send(keepAlive);

            HasResponded = false;
            TimeoutTimer.Start();
            TimeoutTimer.Interval = TimeoutTimer.Interval;
        }

        private long LongRandom(Random rand) {
            byte[] buf = new byte[8];
            rand.NextBytes(buf);

            return BitConverter.ToInt64(buf, 0);
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
