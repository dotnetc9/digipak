using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PepakDigital.Repository
{
    public interface IPramasastraRepository
    {
        List<Paramasastra> paramasas { get; }
        Paramasastra Find(int id);
    }
}