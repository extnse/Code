using System.Diagnostics;
using System.IO;


namespace Instrumenting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write to text file in project folder
            Trace.Listeners.Add(new TextWriterTraceListener(File.CreateText("log.txt")));
            // Write text module buffered, thus it calls Flush() for all listeners after writing.
            Trace.AutoFlush = true;
            Debug.WriteLine("Dubugger listens");
            Trace.WriteLine("Tracer active");

            // Switching trace levels
            var ts = new TraceSwitch("PacktSwitch", "This switch is set via a command line argument.");

            if(args.Length > 0)
            {
                if(System.Enum.TryParse<TraceLevel>(args[0], ignoreCase: true, result: out TraceLevel level))
                {
                    ts.Level = level;
                }
            }

            Trace.WriteLineIf(ts.TraceError, "Trace error");
            Trace.WriteLineIf(ts.TraceWarning, "Trace warning");
            Trace.WriteLineIf(ts.TraceInfo, "Trace information");
            Trace.WriteLineIf(ts.TraceVerbose, "Trace verbose");
            // Now enter "info" (without quotes) into arguments in properties/debug
            // Output will be put to log.txt in Debug folder
        }
    }
}
