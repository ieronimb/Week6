using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6
{
    public class PassByValue
    {
        
        public int Numar { get; set; }

        public  void Calculate (int numar)
        {
           numar *= 2;
           
        }
        
       

    }
}
