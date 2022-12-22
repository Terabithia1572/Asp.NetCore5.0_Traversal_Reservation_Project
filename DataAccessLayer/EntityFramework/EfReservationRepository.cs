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
    public class EfReservationRepository : GenericRepository<Reservation>, IReservationDal
    {
        Context context = new();
        public List<Reservation> GetListWithReservationByAccepted(int id)
        {
            return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Onaylandı" && x.AppUserId == id).ToList();

        }

        public List<Reservation> GetListWithReservationByWaitAprroval(int id)
        {
            return context.Reservations.Include(x => x.Destination).Where(x=>x.Status=="Onay Bekliyor" && x.AppUserId==id).ToList();
        }

        public List<Reservation> GetListWithReservationLastPrevious(int id)
        {
            return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Geçmiş Rezervasyon" && x.AppUserId == id).ToList();

        }
    }
}
