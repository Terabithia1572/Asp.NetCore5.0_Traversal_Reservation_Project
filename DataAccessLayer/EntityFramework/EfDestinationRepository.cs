using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfDestinationRepository : GenericRepository<Destination>, IDestinationDal
    {
        Context context = new();
        public List<Destination> GetDestinationWithGuide(int id)
        {
            return context.Destinations.Where(x=>x.DestinationID==id).Include(x => x.Guide).ToList();
        }
    }
}
