using OnlineShoppingProducts.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingProducts.Services.Commands
{
    public interface IDeleteEntityCommandHandler<TEntity> where TEntity : BaseEntity
    {
        void Delete(int entityId);
    }
}
