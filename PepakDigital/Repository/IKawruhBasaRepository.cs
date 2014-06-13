using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PepakDigital.Repository
{
    public interface IKawruhBasaRepository
    {
        List<KawruhBasa> kawruhBasa { get; }

        KawruhBasa Find(int id);
    }
}