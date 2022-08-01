using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldClassLib
{
    public static class TestClass
    {
        public static string SystemTime()
        {
            return System.DateTime.Now.ToLongTimeString();
        }
    }
}
