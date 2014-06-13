using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PepakDigital.Repository
{
    public class KawruhBasaRepositoryMock : IKawruhBasaRepository

    {
        List<KawruhBasa> kawruhBasaa;

        public KawruhBasaRepositoryMock()
        {
            kawruhBasaa = new List<KawruhBasa>();

            kawruhBasaa.Add(new KawruhBasa(1,"Agal","Kasar","Lembut"));
            kawruhBasaa.Add(new KawruhBasa(2, "Aman", "Tentrem","Rusuh"));
            kawruhBasaa.Add(new KawruhBasa(3, "Aos", "Mentes","Gabuk"));
            
        }

       

        public KawruhBasa Find(int id)
        {
            KawruhBasa result = (from b in kawruhBasaa
                           where b.KawruhBasaId == id
                           select b).FirstOrDefault<KawruhBasa>();
            return result;
        }

        public List<KawruhBasa> kawruhBasa          
        {
            get { return kawruhBasaa; }
        }
    }
    }
