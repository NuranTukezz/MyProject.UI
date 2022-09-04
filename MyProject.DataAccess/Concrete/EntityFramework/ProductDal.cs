using MyProject.Core.DataAccess.EntityFramework;
using MyProject.DataAccess.Abstract;
using MyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.DataAccess.Concrete.EntityFramework
{
    public class ProductDal:EntityRepositoryBase<Product,MyDbContext> , IProductDal
    {
        //:EntityRepositoryBase<Product,MyDbContext> =>BUNU YAZDIĞIMIZ ZAMAN
        //, IProductDal ' ı implemente etmemize gerek kalmıyor

        //bu sayede kod tekrarından kurtuluyoruz

        //Custom Operetion ==> Özelleştirelen metodlar
    }
}
