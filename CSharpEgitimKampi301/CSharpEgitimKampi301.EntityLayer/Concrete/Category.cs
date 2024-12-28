using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {
        //Table->Query ---------------->  Class->Table ve Property->Column

        //Field-Variable-Property

        //Class'ın içinde direkt olarak tanımlanırsa Field = public class A {  int x;  } yazmak gibi
        //Class'ın içnide get ve setle beraber tanımlanırsa Property = public class A { public int y { get; set; } }
        //Metot içinde tanımlanırsa da Variable olur. = void test () { int z; }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; }


    }
}
