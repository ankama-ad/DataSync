﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.Models
{
    public partial class AdminRole
    {
        public int AdminRoleId { get; set; }
        public int AdminRoleTypeId { get; set; }
        public string AdminRoleName { get; set; }
        public string AdminRoleDescription { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
