using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Guide
    {
        public int GuideID { get; set; }
        public string GuideName { get; set; }
        public string GuideDescription { get; set; }
        public string GuideImage { get; set; }
        public string TwitterURL { get; set; }
        public string InstagramURL { get; set; }
        public bool Status { get; set; }

    }
}
