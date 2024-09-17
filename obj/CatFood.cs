using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knowledge_Check_2_for_Software.obj
{
    internal class CatFood : Product
    {
        public bool KittenFood { get; set; }

        public override string ToString()
        {
            return base.ToString() + $", KittenFood: {KittenFood}";
        }
    }
}