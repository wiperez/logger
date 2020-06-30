using System;
using LoggerDTO;

namespace unhsfl_logger
{
    public class FileLogger: BaseEventLooger, IEventLogger, IDispatcher
    {
        public bool AuditEvent()
        {
            return Dispatch(LogAuditEvent());
        }

        public bool FailureEvent()
        {
            return Dispatch(LogFailureEvent());
        }

        public bool SuccessEvent()
        {
            return Dispatch(LogSuccessEvent());
        }

        public bool Dispatch(BaseLoggerDto log)
        {

            return true;
        }
    }
}
