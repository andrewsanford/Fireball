using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Fireball
{
    public class overchannelException : Exception{
        public overchannelException()
            : base("Overchannel can only be used with spells level 5 or lower.")
        {

        }
    }

    public class modifierException : Exception
    {
        public modifierException()
            : base("Trait modifier must range from -5 to 10.")
        {

        }
    }

    public class levelException : Exception
    {
        public levelException()
            : base("Wizard level must range from 1 to 20.")
        {

        }
    }
}
