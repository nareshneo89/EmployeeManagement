using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models.DynamicMenu.ViewModels
{
    public class AddMenuItemViewModel
    {
        //public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public int? ParentId { get; set; }

        [StringLength(50)]
        public string Icon { get; set; }

        [StringLength(50)]
        public string Url { get; set; }
    }
}
