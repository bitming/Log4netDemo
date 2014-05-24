using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4netDemo
{
    public interface ILogger
    {
        void Write(object message);
    }
}
