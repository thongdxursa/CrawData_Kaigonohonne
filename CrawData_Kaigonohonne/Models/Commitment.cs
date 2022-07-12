using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawData_Kaigonohonne.Models
{
    public class Commitment
    {
        public string content { get; set; }
        public string href { get; set; }

        public Commitment()
        {
            this.content = "";
            this.href = "";
        }

    }
}
