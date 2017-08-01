using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPracticeApp3
{
    abstract class Qwe
    {
        public abstract string Bruh();
        protected string dude = "dude";

    }

    class Brah : Qwe
    {
        public override string Bruh()
        {
            return dude + " WTF";
        }
    }
}
