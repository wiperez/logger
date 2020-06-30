using System;
namespace unhsfl_logger
{
    public interface IEventLogger
    {
        public Boolean AuditEvent();


        public Boolean FailureEvent();


        public Boolean SuccessEvent();
        
    }
}
