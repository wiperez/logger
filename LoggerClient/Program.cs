using System;
using unhsfl_logger;

namespace LoggerClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using Kafka Looger");

            ((IEventLogger)LoggerFactory
                    .Create("kaska"))
                    .AuditEvent();

            Console.WriteLine("Using file Looger");

            ((IEventLogger)LoggerFactory
                    .Create("file"))
                    .SuccessEvent();
        }
    }
}
