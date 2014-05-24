using log4net.Layout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Log4netDemo
{
    public class CustomPatternLayout:PatternLayout
    {
        public CustomPatternLayout()
        {
            AddConverter("property", typeof(CustomPatternLayoutConverter));
        }
    }
}