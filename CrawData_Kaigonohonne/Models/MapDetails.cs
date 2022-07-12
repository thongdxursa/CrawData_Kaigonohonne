using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawData_Kaigonohonne.Models
{
    public class MapDetails
    {
        public string link { get; set; }
        public string address { get; set; }
        public string traffic_access { get; set; }

        public MapDetails()
        {
            this.link = "";
            this.address = "";
            this.traffic_access = "";
        }

    }
}
