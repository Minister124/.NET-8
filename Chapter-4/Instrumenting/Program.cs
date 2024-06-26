using Microsoft.Extensions.Configuration;
using System.Diagnostics;

string logPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "log.txt");
WriteLine($"Writing to {logPath}");

TextWriterTraceListener logFile = new(File.CreateText(logPath));
Trace.Listeners.Add(logFile);

#if DEBUG
//Text Writer is buffered, so this option calls Flush() on all listeners after writing
Trace.AutoFlush = true;
#endif
/*Any type that represents a file usually implements a buffer to 
improve performance. Instead of writing immediately to the file, data is written 
to an in-memory buffer, and only once the buffer is full will it be written in one 
chunk to the file. This behavior can be confusing while debugging because we do 
not immediately see the results! Enabling AutoFlush means the Flush method is 
called automatically after every write. This reduces performance, so you should 
only set it on during debugging and not in production.
*/
Debug.WriteLine("Debug says: I am Watching you!");
Trace.WriteLine("Trace says: I am Watching you!");

string settingFile = "appsettings.json";
string settingPath = Path.Combine(Directory.GetCurrentDirectory(), settingFile);
WriteLine("Processing: {0}", settingPath);
WriteLine("--{0} contents--", settingFile);
WriteLine(File.ReadAllText(settingPath));
WriteLine("----");

ConfigurationBuilder builder = new();
builder.SetBasePath(Directory.GetCurrentDirectory());

// Add the settings file to the processed configuration and make it
// mandatory so an exception will be thrown if the file is not found.

builder.AddJsonFile(settingFile, optional: false, reloadOnChange: true);

IConfigurationRoot config = builder.Build();

TraceSwitch ts = new(displayName: "PacktSwitch", description: "This switch is set via the configuration file");

config.GetSection("PacktSwitch").Bind(ts);

WriteLine($"Trace Switch Value: {ts.Level}");
WriteLine($"Trace Switch Level: {ts.Level}");

Trace.WriteLineIf(ts.TraceError, "Trace Error");
Trace.WriteLineIf(ts.TraceWarning, "Trace Warning");
Trace.WriteLineIf(ts.TraceInfo, "Trace Information");
Trace.WriteLineIf(ts.TraceVerbose, "Trace Verbose");

Debug.Close();
Trace.Close();

WriteLine("Press enter to exit.");
ReadLine();