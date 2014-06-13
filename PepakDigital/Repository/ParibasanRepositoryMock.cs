using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PepakDigital.Repository
{
    public class ParibasanRepositoryMock : IParibasanRepository
    {

        List<Paribasan> paribasans;

        public ParibasanRepositoryMock()
        {
            paribasans = new List<Paribasan>();

            paribasans.Add(new Paribasan(1, " 'Adigang, adigung, adiguna", " 'Wong sing ngendelake kekuwatan, kaluhuran lan kapinterane"));
            paribasans.Add(new Paribasan(2, " 'Adhang - adhang tetesing embun", " 'Njagakake barang mung saolehe bae"));
            paribasans.Add(new Paribasan(3, " 'Aji godhong garing", " 'Barang kang ora nduwe aji babar pisan"));

        }

        public Paribasan Find(int id)
        {
            Paribasan result = (from b in paribasans
                            where b.ParibasanId == id
                                select b).FirstOrDefault<Paribasan>();
            return result;
        }

        public List<Paribasan> paribasanss
        {
            get { return paribasans; }
        }


        List<Paribasan> IParibasanRepository.paribasans
        {
            get { throw new NotImplementedException(); }
        }
    }
}