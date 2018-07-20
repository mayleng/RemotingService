using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RemoteSample
{
    public class RemoteObject: MarshalByRefObject
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public string StrAdd(string a,string b)
        {
            return a+b;
        }
    }
}
