using EVAP.CRS.Context;
using EVAP.CRS.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVAP.CRS.Repository
{
    public class CMCUoW
    {
        private CRSconnection context;
        private IRepository<EMPLOYEE> EmployeeRepo;

        public CMCUoW()
        {
            this.context = new CRSconnection();
        }

        public IRepository<EMPLOYEE> Employee
        {
            get => EmployeeRepo == null? new EmployeeRepository(context) : EmployeeRepo;
        }
    }
}
