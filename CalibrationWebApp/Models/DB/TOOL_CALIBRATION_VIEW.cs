//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalibrationWebApp.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class TOOL_CALIBRATION_VIEW
    {
        public int SYSUserID { get; set; }
        public string EmployeeProfileID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Location { get; set; }
        public string InstrumentID { get; set; }
        public string PlantID { get; set; }
        public string InstrumentBrand { get; set; }
        public string InstrumentDesc { get; set; }
        public System.DateTime CalibrationDueDate { get; set; }
        public string Comments { get; set; }
    }
}