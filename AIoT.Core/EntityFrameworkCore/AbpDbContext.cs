﻿using Microsoft.EntityFrameworkCore;
using Volo.Abp.DependencyInjection;

namespace AIoT.Core.EntityFrameworkCore
{
    
    public class AbpDbContext<TDbContext> : DbContext, ITransientDependency
        where TDbContext : DbContext
    {
        protected AbpDbContext(DbContextOptions<TDbContext> options)
            : base(options)
        {

        }
    }


    public class AbpDbContext : AbpDbContext<AbpDbContext>
    {
        /// <summary>
        /// 实体上下文基类
        /// </summary>
        public AbpDbContext(DbContextOptions<AbpDbContext> options) : base(options)
        {
        }
    }
    
}
