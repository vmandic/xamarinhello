using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloPCL
{
    public static class StringExtender
    {
        public static string AppendDateNow(this string input)
        {
            return input + " DATE:" + DateTime.Now.ToString("dd.MM.yyyy.");
        }
    }
}
