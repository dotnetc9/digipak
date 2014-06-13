﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PepakDigital.Repository
{
    public interface IHanacarakaRepository
    {
        List<Hanacaraka> Hancarakas { get; }

        Hanacaraka Find(int id);
    }
}