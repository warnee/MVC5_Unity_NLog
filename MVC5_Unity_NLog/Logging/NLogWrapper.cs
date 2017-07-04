using NLog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using MVC5_Unity_NLog.Logging;

namespace MVC5_Unity_NLog.Logging
{
    public class NLogWrapper : ICommonLogger
    {
        ILogger logger;

        public NLogWrapper()
        {
            logger = LogManager.GetCurrentClassLogger();
        }

        public void Debug(string v)
        {
            logger.Debug(v);
        }
    }
}