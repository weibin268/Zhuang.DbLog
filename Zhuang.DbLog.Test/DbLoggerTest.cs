using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Zhuang.DbLog.Test
{
    [TestClass]
    public class DbLoggerTest
    {
        [TestMethod]
        public void TestLog()
        {
            try
            {
                throw new Exception("aaa");
            }
            catch (Exception ex)
            {
                DbLogger.Instance.Log("test01", Commons.LogModuleType.后台服务, ex);

            }
        }
    }
}
