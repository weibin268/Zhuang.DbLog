using System;
using System.Collections.Generic;
using System.Text;

namespace Zhuang.DbLog.Models
{
    public class Sys_Log
    {
        public string LogId { get; set; }

        public string LogName { get; set; }

        public int ModuleId { get; set; }

        public string ModuleName { get; set; }

        public string ErrorMsg { get; set; }

        public string ErrorStack { get; set; }

        public string ExtraData { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
