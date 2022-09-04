using MyProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Core.DataAccess
{
    public interface IEntityRepository<T>where T : class,IEntity,new()
    {
        //Bu Class'ın amacı şu base bir repository yapayım onuda türeten bu interface olsun
        //IEntity'den türetilen bir class 
        //<T>where T : class,IEntity=> T bir class olmalı ve bu T, IEntityden türemeli diyoruz yani
        //new()=> yenilenebilir anlamındadır yani instace alabilen nesnesi üretilebilen
        //=>Product p = new Product(); bunu yazabilmektir yani


        //Secron programlama => sıralı çalışma =>
        //=> T Get(Expression<Func<T,bool>>expression);

        //Asecron proglamlama => paralelde bir çok işin çalışması yani soğanı kavururken eti doğramak gibi =>

        Task<T> Get(Expression<Func<T, bool>> expression);
        Task<IList<T>> GetList(Expression<Func<T, bool>> expression=null);
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);


    }
}
