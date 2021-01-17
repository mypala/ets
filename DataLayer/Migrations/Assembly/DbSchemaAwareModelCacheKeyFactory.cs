using DataLayer.Context.Abstract;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace DataLayer.Migrations.Assembly
{
    public class DbSchemaAwareModelCacheKeyFactory : IModelCacheKeyFactory
    {
        public object Create(Microsoft.EntityFrameworkCore.DbContext context)
        {
            return new
            {
                Type = context.GetType(),
                Schema = context is IETSContext schema ? schema.Schema : null
            };
        }
    }
}
