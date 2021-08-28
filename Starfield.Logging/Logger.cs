using System;
using System.IO;

namespace Starfield.Logging {
    
    public class Logger {
        
        public static TextWriter Out { get; set; }
        public static LogLevel MinimumLevel { get; set; }

        public static void Info(string text) {
            if(LogLevel.Info >= MinimumLevel) {
                Out.WriteLine($"[{GetCurrentTime()}/INFO] " + text);
            }
        }
        
        public static void Warning(string text) {
            if(LogLevel.Warning >= MinimumLevel) {
                Out.WriteLine($"[{GetCurrentTime()}/WARN] " + text);
            }
        }
        
        public static void Error(string text) {
            if(LogLevel.Error >= MinimumLevel) {
                Out.WriteLine($"[{GetCurrentTime()}/ERROR] " + text);
            }
        }
        
        public static void Fatal(string text, Exception exception) {
            if(LogLevel.Fatal >= MinimumLevel) {
                Out.WriteLine($"[{GetCurrentTime()}/FATAL] " + text);
                Out.WriteLine(exception.Message);
                Out.WriteLine(exception.StackTrace);
            }
        }
        
        public static void Debug(string text) {
            if(LogLevel.Debug >= MinimumLevel) {
                Out.WriteLine($"[{GetCurrentTime()}/DEBUG] " + text);
            }
        }

        private static string GetCurrentTime() {
            return DateTime.Now.ToString("HH:mm:ss.fff");
        }
    }
}