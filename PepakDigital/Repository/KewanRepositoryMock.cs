using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PepakDigital.Repository
{
    public class KewanRepositoryMock : IKewanRepository
    {
        List<Kewan> kewans;

        public KewanRepositoryMock()
        {
            kewans = new List<Kewan>();

            kewans.Add(new Kewan(1, "Ampal", "Embug-e"));
            kewans.Add(new Kewan(2, "Angkrang", "Kroto"));
            kewans.Add(new Kewan(3, "Asu", "Kirik"));

        }

        public Kewan Find(int id)
        {
            Kewan result = (from b in kewans
                            where b.KewanId == id
                            select b).FirstOrDefault<Kewan>();
            return result;
        }  

        public List<Kewan> kewanss
        {
            get { return kewans; }
        }


       

    }     
}