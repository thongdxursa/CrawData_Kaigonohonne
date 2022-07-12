using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawData_Kaigonohonne.Models
{
    public class FacilityDetails
    {
        public string name { get; set; }
        public string detail { get; set; }

        public FacilityDetails()
        {
            this.name = "";
            this.detail = "";
        }

    }
}
