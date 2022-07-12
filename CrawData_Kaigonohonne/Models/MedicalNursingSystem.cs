using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawData_Kaigonohonne.Models
{
    public class MedicalNursingSystem
    {
        public string content { get; set; }
        public string status { get; set; }

        public MedicalNursingSystem()
        {
            this.content = "";
            this.status = "";
        }

    }
}
