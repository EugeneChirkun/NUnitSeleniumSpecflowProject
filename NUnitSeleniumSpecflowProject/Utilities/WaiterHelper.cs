using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitSeleniumSpecflowProject.Utilities
{
    public class WaiterHelper
    {
        public static void For(Func<bool> func, int numberOfAttempts = 5, int intervalInMilliseconds = 1000)
        {
            for (int i = 0; i < numberOfAttempts; i++)
            {
                if (func.Invoke())
                {
                    return;
                }
                System.Threading.Thread.Sleep(intervalInMilliseconds);
            }
        }

    }
}
