using System;
using System.Collections.Generic;
using System.Text;
using Zhuang.DbLog.Commons;
using Zhuang.DbLog.Models;
using Zhuang.DbLog.Services;

namespace Zhuang.DbLog
{
    public class DbLogger
    {
        private ILogService _logService;

        private static DbLogger _instance;

        private static object _objLock = new object();

        public static DbLogger Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_objLock)
                    {
                        if (_instance == null)
                        {
                            _instance = new DbLogger();
                        }
                    }
                }
                return _instance;
            }
        }
        
        public DbLogger() : this(new DefaultLogService())
        {

        }

        public DbLogger(ILogService logService)
        {
            _logService = logService;
        }

        public void Log(string logName, int moduleId, string moduleName, string errorMsg, string errorStack, string extraData)
        {
            var log = new Sys_Log();

            log.LogId = Guid.NewGuid().ToString();
            log.LogName = logName;
            log.ModuleId = moduleId;
            log.ModuleName = moduleName;
            log.ErrorMsg = errorMsg;
            log.ErrorStack = errorStack;
            log.ExtraData = extraData;
            log.CreatedDate = DateTime.Now;

            _logService.AddLog(log);
        }

        public void Log(string logName, LogModuleType moduleType, Exception ex)
        {
            Log(logName, (int)moduleType, moduleType.ToString(), ex.Message, Commons.ExceptionUtil.GetAllExceptionInfo(ex), string.Empty);
        }

        public void Log(string logName, LogModuleType moduleType, Exception ex, string extraData)
        {
            Log(logName, (int)moduleType, moduleType.ToString(), ex.Message, Commons.ExceptionUtil.GetAllExceptionInfo(ex), extraData);
        }

    }
}
