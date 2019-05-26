using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6
{
    public class OverrideExample
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public override bool Equals(object param)
        {
            OverrideExample overrideExample = param as OverrideExample;
            if (overrideExample == null)
            {
                return false;
            }
             if (!Object.Equals(this.Name, overrideExample.Name))
            {
                return false;
            }
            if (!Object.Equals(this.Age, overrideExample.Age))
            {
                return false;
            }
            return true;

        }

    }
}
