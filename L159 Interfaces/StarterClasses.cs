using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L159_Interfaces
{
    public abstract class Consumable
    {
        protected bool consumed;
        protected int power;
        public Consumable(int inPower)
        {
            consumed = false;
            power = inPower;
        }
        public abstract void Consume();
        public bool IsConsumed()
        {
            return consumed;
        }

    }
    public class Potion : Consumable
    {
        public Potion(int inPower) : base(inPower) 
        { 

        }
        public override void Consume()
        {
            consumed = true;
        }
    }
    public class Snack : Consumable
    {
        protected int portionsLeft;
        public Snack(int portions, int inPower) : base(inPower)
        {
            portionsLeft = portions;
        }
        public override void Consume()
        {
            if (portionsLeft > 0) portionsLeft--;

            if (portionsLeft == 0) consumed = true;
        }
    }

    //Extension:
    public class FlavouredSnack : Snack
    {
        private string flavour;
        public FlavouredSnack(int portions, int inPower, string inFlavour) : base(portions, inPower)
        {
            flavour = inFlavour;
        }
        public string GetFlavour() => flavour;
    }

}
