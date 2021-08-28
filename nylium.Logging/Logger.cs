using System;
using System.IO;

namespace nylium.Logging {
    
    public class Logger {
        
        public static TextWriter Out { get; set; }
        public static LogLevel MinimumLevel { get; set; }

        public static void Info(string text) {
            if(LogLevel.Info >= MinimumLevel) {
                Out.WriteLineAsync($"[{GetCurrentTime()}/INFO] " + text).Start();
            }
        }
        
        public static void Warning(string text) {
            if(LogLevel.Warning >= MinimumLevel) {
                Out.WriteLineAsync($"[{GetCurrentTime()}/WARN] " + text).Start();
            }
        }
        
        public static void Error(string text) {
            if(LogLevel.Error >= MinimumLevel) {
                Out.WriteLineAsync($"[{GetCurrentTime()}/ERROR] " + text).Start();
            }
        }
        
        public static void Fatal(string text, Exception exception) {
            if(LogLevel.Fatal >= MinimumLevel) {
                Out.WriteLineAsync($"[{GetCurrentTime()}/FATAL] " + text).Start();
                Out.WriteLineAsync(exception.Message).Start();
                Out.WriteLineAsync(exception.StackTrace).Start();
            }
        }
        
        public static void Debug(string text) {
            if(LogLevel.Debug >= MinimumLevel) {
                Out.WriteLineAsync($"[{GetCurrentTime()}/DEBUG] " + text).Start();
            }
        }

        private static string GetCurrentTime() {
            return DateTime.Now.ToString("HH:mm:ss.fff");
        }
    }
}