using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Inventory
    {
        int weigth; //вместимость
        List<Item> storage = new List<Item>();
        public Inventory(int i) {weigth=i;}
    }
}
