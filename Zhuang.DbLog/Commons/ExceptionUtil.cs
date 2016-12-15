using System;
using System.Collections.Generic;
using System.Text;

namespace Zhuang.DbLog.Commons
{
    public static class ExceptionUtil
    {
        public static string GetAllExceptionInfo(Exception ex)
        {
            StringBuilder sbResult = new StringBuilder();

            Exception currnentEx = ex;
            do
            {
                sbResult.AppendFormat("Message:{0}|StackTrace:{1}", currnentEx.Message, currnentEx.StackTrace);

                if (currnentEx.InnerException != null)
                {
                    sbResult.Append(">>>>>InnerException>>>>>");
                }

                currnentEx = currnentEx.InnerException;
            } while (currnentEx != null);

            return sbResult.ToString();
        }
    }
}
