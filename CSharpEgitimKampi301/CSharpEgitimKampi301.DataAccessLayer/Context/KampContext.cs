using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Context
{
    public class KampContext : DbContext
    {
        public DbSet<Category> Categories { get; set; } //tırnak arasındaki ifade c#da kullanılacak sınıfın ismi, diğer Categories ise SQL'e yansıyacak tablo ismi
                                                        //bunlar birbirine karışmasın diye yalın hali class, çoğul hali tablo olsun mantığı vardır.
        public DbSet<Product> Products { get; set; }   //product'ı kullanmamızı sağlayan şey referans vermiş olmamız.

        public DbSet<Order> Orders { get; set; }

        public DbSet<Customer> Customers { get; set; } 

        public DbSet<Admin> Admins { get; set; }
    }
}
