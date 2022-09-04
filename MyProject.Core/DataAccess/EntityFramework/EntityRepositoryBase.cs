using Microsoft.EntityFrameworkCore;
using MyProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Core.DataAccess.EntityFramework
{
    public class EntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public async Task Add(TEntity entity)
        {
            //contex'i böyle usind olarak çağırmamızın sebebi REM'de çok yer kaplamaması için
            using(var context = new TContext())
            {
                context.Entry<TEntity>(entity).State = EntityState.Added;
                await context.SaveChangesAsync();
            }
        }

        public async Task Delete(TEntity entity)
        {
            //contex'i böyle usind olarak çağırmamızın sebebi REM'de çok yer kaplamaması için
            using (var context = new TContext())
            {
                context.Entry<TEntity>(entity).State = EntityState.Deleted;
                await context.SaveChangesAsync();
            }

        }

        public async Task<TEntity> Get(Expression<Func<TEntity, bool>> expression)
        {
            //contex'i böyle usind olarak çağırmamızın sebebi REM'de çok yer kaplamaması için
            using (var context = new TContext())
            {
                return await context.Set<TEntity>().FirstOrDefaultAsync(expression);
            }

        }

        public async Task<IList<TEntity>> GetList(Expression<Func<TEntity, bool>> expression = null)
        {
            //contex'i böyle usind olarak çağırmamızın sebebi REM'de çok yer kaplamaması için
            using (var context = new TContext())
            {
                return expression==null 
                    ? await context.Set<TEntity>().ToListAsync()
                    : await context.Set<TEntity>().Where(expression).ToListAsync();
            }

        }

        public async Task Update(TEntity entity)
        {
            //Modified => güncelleme için kullanılıyor
            //contex'i böyle usind olarak çağırmamızın sebebi REM'de çok yer kaplamaması için
            using (var context = new TContext())
            {
                context.Entry<TEntity>(entity).State = EntityState.Modified;
                await context.SaveChangesAsync();
            }

        }
    }
}
