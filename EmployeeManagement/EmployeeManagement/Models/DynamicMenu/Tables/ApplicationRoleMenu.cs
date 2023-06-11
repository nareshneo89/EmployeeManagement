using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models.Administration.DynamicMenu
{
    [Table("AspNetRoleMenu")]
    public class ApplicationRoleMenu
    {
        public ApplicationRoleMenu()
        {
            Permissions = new HashSet<MenuPermission>();
        }

        [Key, Column(Order = 1)]
        public virtual int Id { get; set; }

        [Column(Order = 2)]
        public virtual string RoleId { get; set; }

        [Column(Order = 3)]
        public virtual int MenuId { get; set; }

        public virtual ApplicationRole Role { get; set; }
        public virtual MenuItem MenuItem { get; set; }
        public ICollection<MenuPermission> Permissions { get; set; }
    }
}
