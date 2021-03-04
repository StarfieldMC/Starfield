using System;
using System.Net.Sockets;
using System.Timers;
using nylium.Networking.Packets.Server.Play;

namespace nylium.Networking {

    class KeepAlive {

        private readonly Random random = new Random();

        private Socket Socket { get; }
        private Action<Socket, byte[]> Send { get; }
        private Action<Socket> TimeoutAction { get; }

        private Timer KeepAliveTimer { get; }
        private Timer TimeoutTimer { get; }

        public bool HasResponded;

        public KeepAlive(Socket socket, Action<Socket, byte[]> send, Action<Socket> timeoutAction, double delayInMilliseconds) {
            Socket = socket;
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
                TimeoutAction(Socket);
            } else {
                TimeoutTimer.Interval = TimeoutTimer.Interval;
                TimeoutTimer.Stop();
            }
        }

        private void KeepAliveTimer_Elapsed(object sender, ElapsedEventArgs e) {
            TimeoutTimer.Stop();

            SP1FKeepAlive keepAlive = new SP1FKeepAlive(LongRandom(random));
            Send(Socket, keepAlive.ToArray());

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
