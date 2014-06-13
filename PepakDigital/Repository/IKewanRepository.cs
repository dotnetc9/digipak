using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PepakDigital.Repository
{
    public interface IKewanRepository
    {
        List<Kewan> kewanss { get; }
        Kewan Find(int id);
    }
}