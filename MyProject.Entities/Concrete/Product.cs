using MyProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Entities.Concrete
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        //decimal 18,2 yazar bu şu demek oluyor 18 basamaklı sayı=> 
        //sonra virgülden sonra 2 basamaklı sayı anlamına geliyor.

        //[Column(TypeName="decimal(18,2)")]
        //public decimal? Price { get; set; }
        //=>yukarıdaki propta yazdığımız işlen Solid'e aykırı sakın böyle yapma=>
        //ileride hata alabilirsin zaten solide aykırı

        public int Stock { get; set; }
        public virtual Category Category { get; set; }


    }
}
