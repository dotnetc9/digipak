using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PepakDigital.Repository
{
    public interface IParibasanRepository
    {
        List<Paribasan> paribasans { get; }
        Paribasan Find(int id);
    }
}