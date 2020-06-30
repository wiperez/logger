using System;
using LoggerDTO;

namespace unhsfl_logger
{
    public interface IDispatcher
    {
        public Boolean Dispatch(BaseLoggerDto log);
    }
}
