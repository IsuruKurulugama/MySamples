//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EVAP.CRS.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class JOB_HISTORY
    {
        public int EMPLOYEE_ID { get; set; }
        public System.DateTime START_DATE { get; set; }
        public System.DateTime END_DATE { get; set; }
        public string JOB_ID { get; set; }
        public Nullable<short> DEPARTMENT_ID { get; set; }
    
        public virtual DEPARTMENT DEPARTMENT { get; set; }
        public virtual EMPLOYEE EMPLOYEE { get; set; }
        public virtual JOB JOB { get; set; }
    }
}
