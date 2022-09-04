using MyProject.Core.DataAccess;
using MyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        //Custom Opetations işlemleri yazabiliriz mesela
    }
}
