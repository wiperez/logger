using System;
using LoggerDTO;

namespace unhsfl_logger
{
    public class KafkaLogger : BaseEventLooger, IEventLogger, IDispatcher
    {
        public Boolean AuditEvent()
        {
            return Dispatch(LogAuditEvent());
        }

        public Boolean FailureEvent()
        {
            return Dispatch(LogFailureEvent());
        }

        public Boolean SuccessEvent()
        {
            return Dispatch(LogSuccessEvent());
        }

        public Boolean Dispatch(BaseLoggerDto log)
        {
            //serialization code
            //stream transfer code

            return true;
        }
    }
}
