using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlLoadGeneratorUI
{
    static class Globals
    {
        // Globals used throughout the application
        public static Boolean _applicationLogging = false;
        public static int _totalThreadCount = 0;
        public static int _totalCompletedQueryCount = 0;
        public static int _totalFailedQueryCount = 0;
    }
}
