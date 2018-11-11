using EVAP.CRS.Context;
using EVAP.CRS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVAP.CMC.Services.Services
{
    public class EmployeeServices
    {
        private CMCUoW uow;
        public EmployeeServices(CMCUoW uow)
        {
            this.uow = uow;
        }

        public IEnumerable<EMPLOYEE> GetAllEmployees()
        {
            var a = uow.Employee.FindAll();
            return a;
        }
    }
}
