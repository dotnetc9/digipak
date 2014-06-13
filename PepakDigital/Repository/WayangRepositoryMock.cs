using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PepakDigital.Repository
{
    public class WayangRepositoryMock : IWayangRepository
    {
        List<Wayang> wayangs;

        public WayangRepositoryMock()
        {
            wayangs = new List<Wayang>();

            wayangs.Add(new Wayang(1, "Anggada"));
            wayangs.Add(new Wayang(2, "Anila"));
            wayangs.Add(new Wayang(3, "Anjani"));
            
        }


        public Wayang Find(int id)
        {
            Wayang result = (from b in wayangs
                           where b.WayangId == id
                             select b).FirstOrDefault<Wayang>();
            return result;
        }

        public List<Wayang> wayangss          
        {
            get { return wayangs; }
        }
    }
}