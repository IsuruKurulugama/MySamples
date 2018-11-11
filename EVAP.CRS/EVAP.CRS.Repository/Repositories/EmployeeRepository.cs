using EVAP.CRS.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVAP.CRS.Repository.Repositories
{
    public class EmployeeRepository : Repository<EMPLOYEE>
    {
        public EmployeeRepository(DbContext context) : base(context)
        {
        }

        public EmployeeRepository(DbContext context, bool lazyLoadingEnabledEnabled) : base(context, lazyLoadingEnabledEnabled)
        {
        }
    }
}
