using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSA
{
    public class My_Class
    {
        public int Add(int data, params int[] value)
        {

            int i = 2 ;
           
            foreach(int num in value)
            {
                i *= num;
            }

            return data + i;
        }
    }
}
