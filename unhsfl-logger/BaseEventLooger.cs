using System;
using LoggerDTO;

namespace unhsfl_logger
{
    public abstract class BaseEventLooger
    {
        protected virtual AuditDto LogAuditEvent()
        {
            return new AuditDto
            {
                MyProperty1 = "1",
                MyProperty2 = "2",
                MyProperty3 = "3",
                MyProperty4 = "4"
            };
        }

        protected virtual FailureDto LogFailureEvent()
        {
            return new FailureDto
            {
                MyProperty1 = "1",
                MyProperty2 = "2",
                MyProperty3 = "3",
                MyProperty4 = "4",
                MyProperty5 = "5"
            };
        }

        protected virtual SuccessDto LogSuccessEvent()
        {
            return new SuccessDto
            {
                MyProperty1 = "1",
                MyProperty2 = "2",
                MyProperty3 = "3",
                MyProperty4 = "4",
                MyProperty5 = "5"
            };
        }
    }
}
