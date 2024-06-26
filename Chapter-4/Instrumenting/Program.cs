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
Debug.WriteLine("I am Watching you!");
Trace.WriteLine("I am Watching you!");

Debug.Close();
Trace.Close();