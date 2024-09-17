using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knowledge_Check_2_for_Software.obj
{
    public class Product
    {
       public string Name { get; set; }
       public decimal Price { get; set; }
       public int Quantity { get; set; }
       public string Description { get; set; }
    }

    public override string ToString()
    {
      return $"Name: {Name}, Price: {Price}, Quantity: {Quantity}, Description: {Description}";
    }
}