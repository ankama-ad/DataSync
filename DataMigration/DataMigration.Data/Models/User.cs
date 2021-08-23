using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public int? DepartmentId { get; set; }
        public int? CoworkerId { get; set; }
        public int? ReportingManagerId { get; set; }
        public string Designation { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string CreatedBy { get; set; }

        public virtual Department Department { get; set; }
    }
}
