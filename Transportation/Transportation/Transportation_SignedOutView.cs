//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Transportation
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transportation_SignedOutView
    {
        public long VId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BannerId { get; set; }
        public string DepartmentName { get; set; }
        public string VehicleName { get; set; }
        public string KeyName { get; set; }
        public string GasCardName { get; set; }
        public string Destination { get; set; }
        public Nullable<System.DateTime> CheckOutTime { get; set; }
        public Nullable<System.DateTime> CheckInTime { get; set; }
        public Nullable<System.DateTime> ActivityTime { get; set; }
        public Nullable<int> SignOutId { get; set; }
    }
}