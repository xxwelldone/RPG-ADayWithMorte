﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADayWithMorte.Shared.Base.Interfaces
{
    internal interface IBaseAdapter
    {
        Task<HttpResponseMessage?> GetAPI(string url, HttpMethod method, string? body, string? token);

    }
}
