using System;
using System.Collections.Generic;
using System.Text;
using Zhuang.Data;
using Zhuang.DbLog.Models;

namespace Zhuang.DbLog.Services
{
    class DefaultLogService : ILogService
    {
        public void AddLog(Sys_Log log)
        {
            DbAccessor dba = DbAccessor.Get();
            dba.Insert<Sys_Log>(log);
        }
    }
}
