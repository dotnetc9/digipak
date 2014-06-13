using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PepakDigital.Repository
{
    public interface IWayangRepository
    {
        List<Wayang> wayangss { get; }
        Wayang Find(int id);
    }
}