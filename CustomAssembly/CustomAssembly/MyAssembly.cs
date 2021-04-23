using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAssembly
{
    public static class MyAssembly
    {
        public static string Capitalize(string text)
        {

            if (!String.IsNullOrEmpty(text))
                return text.ToUpper();
            else return "No Brand";
        }
    }
}
