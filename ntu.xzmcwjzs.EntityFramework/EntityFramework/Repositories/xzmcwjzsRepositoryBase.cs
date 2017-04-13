using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace ntu.xzmcwjzs.EntityFramework.Repositories
{
    public abstract class xzmcwjzsRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<xzmcwjzsDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected xzmcwjzsRepositoryBase(IDbContextProvider<xzmcwjzsDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class xzmcwjzsRepositoryBase<TEntity> : xzmcwjzsRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected xzmcwjzsRepositoryBase(IDbContextProvider<xzmcwjzsDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
