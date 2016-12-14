using System;
using System.Collections.Generic;
using System.Text;
using Zhuang.DbLog.Models;

namespace Zhuang.DbLog.Services
{
    public interface ILogService
    {
        void AddLog(Sys_Log log);
    }
}
