using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_Traversal_Reservation_Project.Areas.Admin.Models
{
    public class ApiMovieViewModel
    {
        public int rank { get; set; }
        public string title { get; set; }
        public string rating { get; set; }
        public int year { get; set; }
        public string image { get; set; }
        public string trailer { get; set; }
    }
}
