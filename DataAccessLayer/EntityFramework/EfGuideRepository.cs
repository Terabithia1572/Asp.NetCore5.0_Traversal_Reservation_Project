using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfGuideRepository : GenericRepository<Guide>, IGuideDal
    {
        Context context = new Context();
        public void ChangeToFalseByGuide(int id)
        {
            throw new NotImplementedException();
        }

        public void ChangeToTrueByGuide(int id)
        {
            throw new NotImplementedException();
        }
    }
}
