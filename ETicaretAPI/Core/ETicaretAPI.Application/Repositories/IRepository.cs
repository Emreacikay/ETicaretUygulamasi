using ETicaretAPI.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        //hem sorgulama hem de command fonksiyonlar aynı class ın içinde olduğu için solide aykırı. Ancak biz solide uygun bir yapılanma haline getireceğiz.

        DbSet<T> Table { get; }

    }
}
