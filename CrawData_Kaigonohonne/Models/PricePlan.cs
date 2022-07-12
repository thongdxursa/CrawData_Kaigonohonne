using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawData_Kaigonohonne.Models
{
    public class PricePlan
    {
        public string title { get; set; }
        public List<string> detail { get; set; }

        public PricePlan()
        {
            this.title = "";
            this.detail = new List<string>();
        }

    }
}
