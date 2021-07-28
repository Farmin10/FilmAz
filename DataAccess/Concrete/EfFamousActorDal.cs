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
    public class EfFamousActorDal : EfEntityRepositoryBase<FamousActor>,IFamousActorDal
    {
        FilmContext _context;
        public EfFamousActorDal(FilmContext context):base(context)
        {
            _context = context;
        }
    }
}
