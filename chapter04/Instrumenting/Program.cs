using Microsoft.Extensions.Configuration;

using System;
using System.Diagnostics;
using System.IO;

using static System.Console;

namespace Instrumenting
{
    class Program
    {
        static void Main(string[] args)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(File.AppendText("log.txt")));
            Trace.AutoFlush = true;

            Debug.WriteLine("Debug says, I am watching.");
            Trace.WriteLine("Trace says, I am watching.");

            IConfigurationBuilder builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            TraceSwitch ts = new TraceSwitch(displayName: "PacktSwitch", description: "This switch is set via a JSON config.");
            configuration.GetSection("PacktSwitch").Bind(ts);
            Trace.WriteLineIf(ts.TraceError, "Trace Error");
            Trace.WriteLineIf(ts.TraceWarning, "Trace Warning");
            Trace.WriteLineIf(ts.TraceInfo, "Trace Information");
            Trace.WriteLineIf(ts.TraceVerbose, "Trace Verbose");

            Exception ex = new Exception("My big error");

            Trace.WriteLine(ex);
            Trace.WriteLine(ex.StackTrace);
        }
    }
}
