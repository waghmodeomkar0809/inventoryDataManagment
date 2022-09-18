using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventoryDataManagment
{
    public class Rice
    {
        public List<TypeOfRice> TypeOfRice;
        public List<TypeOfPluse> TypeOfPluse;
        public List<TypeOfWheat> TypeOfWheat;
    }
    public class TypeOfRice
    {
        public string Name { get; set; }
        public int weight { get; set; }
        public int price { get; set; } 
    }
    public class TypeOfPluse
    {
        public string Name { get; set; }
        public int weight { get; set; }
        public int price { get; set; }
    }
    public class TypeOfWheat
    {
        public string Name { get; set; }
        public int weight { get; set; }
        public int price { get; set; }
    }
}
