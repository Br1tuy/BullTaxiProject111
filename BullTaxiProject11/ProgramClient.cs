using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Text.Json;

namespace BullTaxiProject11
{
    static class ProgramClient
    {
        public static  CookieContainer Cookies = new CookieContainer();
        public static HttpClientHandler Handler;
        public static HttpClient Client;
    }
}
