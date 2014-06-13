using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PepakDigital.Repository
{
    public class ParikanRepositoryMock : IParikanRepository
    {
        List<Parikan> parikan;

        public ParikanRepositoryMock()
        {
            parikan = new List<Parikan>();

            parikan.Add(new Parikan(1, "'Abang - abang gendera Landa, ana sing ijo kok milih Putih. Bujang maneh ora ngluyura, sing nduwe bojo ora tau mulih"));
            parikan.Add(new Parikan(2, " 'Ana brambang sasen lima. Berjuang labuh negara"));
            parikan.Add(new Parikan(3, "'Bisa ngendhang ora bisa nyuling. Bisa nyawang ora wani nyandhing "));
            
        }



        public Parikan Find(int id)
        {
            Parikan result = (from b in parikan
                           where b.ParikanId == id
                             select b).FirstOrDefault<Parikan>();
            return result;
        }

        public List<Parikan> parikanss          
        {
            get { return parikan; }
        }
    }
}