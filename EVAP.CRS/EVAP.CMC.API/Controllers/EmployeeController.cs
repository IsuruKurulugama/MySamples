using EVAP.CMC.Services.Services;
using EVAP.CRS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft;
using Newtonsoft.Json;

namespace EVAP.CMC.API.Controllers
{
    public class EmployeeController : ApiController
    {
        [HttpGet]
        public dynamic GetAll()
        {
            return JsonConvert.SerializeObject(new EmployeeServices(new CMCUoW()).GetAllEmployees());
        }
    }
}
