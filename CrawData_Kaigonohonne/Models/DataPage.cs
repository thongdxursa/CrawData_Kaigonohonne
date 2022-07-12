using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawData_Kaigonohonne.Models
{
    public class DataPage
    {
        public string key { get; set; }
        public List<ShortDescription> short_desc { get; set; }
        public List<string> recommend { get; set; }
        public List<Commitment> commitment { get; set; }
        public List<MedicalNursingSystem> medical_nursing_system { get; set; }
        public List<PricePlan> price { get; set; }
        public List<FacilityDetails> facility_details { get; set; }
        public MapDetails map { get; set; }

        public DataPage()
        {
            key = "";
            short_desc = new List<ShortDescription>();
            recommend = new List<string>();
            commitment = new List<Commitment>();
            medical_nursing_system = new List<MedicalNursingSystem>();
            price = new List<PricePlan>();
            facility_details = new List<FacilityDetails>();
            map = new MapDetails();
        }
    }
}
