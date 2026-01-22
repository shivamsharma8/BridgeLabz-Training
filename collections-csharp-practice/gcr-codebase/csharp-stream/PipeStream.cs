using System;
using System.IO;
using System.IO.Pipes;
using System.Text;
using System.Threading;

class PipedStreamDemo
{
    static void Main(string[] args)
    {
        StartPipeCommunication();
    }

    static void StartPipeCommunication()
    {
        try
        {
            using (AnonymousPipeServerStream server =
                   new AnonymousPipeServerStream(PipeDirection.Out, HandleInheritability.None))
            using (AnonymousPipeClientStream client =
                   new AnonymousPipeClientStream(PipeDirection.In, server.ClientSafePipeHandle))
            {
                Thread writerThread = new Thread(() => Writer(server));
                Thread readerThread = new Thread(() => Reader(client));

                writerThread.Start();
                readerThread.Start();

                writerThread.Join();
                readerThread.Join();
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Pipe I/O Error: " + ex.Message);
        }
    }

    static void Writer(PipeStream pipe)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(pipe, Encoding.UTF8, 1024, leaveOpen: true))
            {
                writer.AutoFlush = true;

                string[] messages =
                {
                    "Hello from Writer Thread","This is inter-thread communication","PipeStream is working","END"};

                foreach (string msg in messages)
                {
                    Console.WriteLine("Writer: " + msg);
                    writer.WriteLine(msg);
                    Thread.Sleep(500); 
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Writer Error: " + ex.Message);
        }
    }

    static void Reader(PipeStream pipe)
    {
        try
        {
            using (StreamReader reader = new StreamReader(pipe, Encoding.UTF8, false, 1024, leaveOpen: true))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line == "END")
                        break;

                    Console.WriteLine("Reader received: " + line);
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Reader Error: " + ex.Message);
        }
    }
}
