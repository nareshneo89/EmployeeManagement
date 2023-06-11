using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models.Administration.DynamicMenu
{
    public class MenuPermission
    {
        [Key, Column(Order = 1)]
        public virtual int RoleMenuId { get; set; }

        [Key, Column(Order = 2)]
        public virtual int PermissionId { get; set; }

        public virtual Permission Permission { get; set; }
        public virtual ApplicationRoleMenu RoleMenu { get; set; }
    }
}
