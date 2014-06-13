using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PepakDigital.Repository
{
    public class HancarakaRepositoryMock : IHanacarakaRepository
    {
        List<Hanacaraka> hanacarakas;

        public HancarakaRepositoryMock()
        {
            hanacarakas = new List<Hanacaraka>();

            hanacarakas.Add(new Hanacaraka(1,"Ha","blabal"));
            hanacarakas.Add(new Hanacaraka(2, "Na", "blabal"));
            hanacarakas.Add(new Hanacaraka(3, "Ca", "blabal"));
            hanacarakas.Add(new Hanacaraka(4, "Ra", "blabal"));
        }

        public List<Hanacaraka> Hancarakas
        {
            get { return hanacarakas; }
        }

        public Hanacaraka Find(int id)
        {
            Hanacaraka result = (from b in hanacarakas
                           where b.HanacarakaId == id
                           select b).FirstOrDefault<Hanacaraka>();
            return result;
        }
    }
}