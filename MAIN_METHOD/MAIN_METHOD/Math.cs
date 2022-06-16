using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAIN_METHOD
{
    public class Math
    {
        public int Add(int data, int value)
        {
            return data + value;
        }

        public int Add(decimal data, int value)
        {
            int dData = Decimal.ToInt32(data);
            return dData + value;
        }

        public int Add(string data, int value)
        {
            int sData = Int32.Parse(data);
            return sData + value;
        }
    }
}
