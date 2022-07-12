using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawData_Kaigonohonne.Models
{
    public class ShortDescription
    {
        public string title { get; set; }
        public string value { get; set; }
        
        public ShortDescription()
        {
            this.title = "";
            this.value = "";
        }

    }
}
