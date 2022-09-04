using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Entities.Abstact
{
    public class BaseEntitiy
    {
        public int Id { get; set; }
        public DateTime InserDateTime { get; set; }
        public string InsertedUser { get; set; }
        public DateTime ModifiedDateTime  { get; set; }
        public string ModifiedUser { get; set; }

        //Bu projede BaseEntity kullanmayacağız bunu oluşturma amacımız
        //product ve category de ortak kullanılan sütunları kalıtım verdirmek
        //yani böyle bir kullanım şekli de var bunu görmek için oluşturduk
        //Product ve Category'kalıtım verdiğimiz zaman BaseEntity'deki propları
        //o classta yani kalıtım verdiğimiz classta kullanabiliyoruz
        //BaseEntity IEntity kalıtım alırsa daha sonrada Product ve Category'i
        //BaseEntity kalıtım veririse artık kalıtım verdiği sınıfta otomatik olarak
        //IEntity'den kalıtım alır çünkü BaseEntity kalıtım veririken bütün özelliklerini 
        //kullandırtıyor



        
        
    }
}
