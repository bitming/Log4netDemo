using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Log4netDemo
{
    public class Log4netErrorLogger : ILogger
    {
        private log4net.ILog _log;

        public Log4netErrorLogger()
        {
            _log = log4net.LogManager.GetLogger("ErrorLogger");
        }


        public void Write(object message)
        {
            if (_log.IsErrorEnabled)
            {
                _log.Error(message);
            }
        }
    }
}