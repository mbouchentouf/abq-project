using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace VanillaWebApp.Controllers
{
    public class DefaultDataController : ApiController
    {
        public string[] myData = { "Data-1", "Data-2", "Data-3" };

        public string[] getData()
        {
            return myData;
        }
    }
}
