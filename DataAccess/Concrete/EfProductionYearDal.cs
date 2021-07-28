using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using DataAccess.RepositoryPattern;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfProductionYearDal : EfEntityRepositoryBase<ProductionYear>,IProductionYearDal
    {
        FilmContext _context;
        public EfProductionYearDal(FilmContext context):base(context)
        {
            _context = context;
        }
    }
}
