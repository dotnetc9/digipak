using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PepakDigital.Repository
{
    public class PramasastraRepositorymock: IPramasastraRepository
    {
        List<Paramasastra> paramas;

        public PramasastraRepositorymock()
        {
            paramas = new List<Paramasastra>();

            paramas.Add(new Paramasastra(1, "Abang", "Abrit", "Abrit", "Merah"));
            paramas.Add(new Paramasastra(2, "Adhi", "Adhi", "Rayi", "Adik"));
            paramas.Add(new Paramasastra(3, "Adeg","Ngadeg","Jumeneng", "Berdiri"));

        }

        public Paramasastra Find(int id)
        {
            Paramasastra result = (from b in paramas
                            where b.ParamasastraId == id
                            select b).FirstOrDefault<Paramasastra>();
            return result;
        }  

        public List<Paramasastra> paramasas
        {
            get { return paramas; }
        }


       

    }     
}