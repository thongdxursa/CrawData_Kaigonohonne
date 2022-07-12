using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawData_Kaigonohonne.Models
{
    public class Photo
    {
        public string src { get; set; }
        public string alt{ get; set; }

        public Photo()
        {
            this.src = "";
            this.alt = "";
        }

    }
}
