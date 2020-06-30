using System;

namespace unhsfl_logger
{
    public static class LoggerFactory
    {
        public static IDispatcher Create(string Sink)
        {
            return Sink switch
            {
                "kafka" => new KafkaLogger(),
                "file" => new FileLogger(),
                _ => new KafkaLogger(),
            };
        }
    }
}
