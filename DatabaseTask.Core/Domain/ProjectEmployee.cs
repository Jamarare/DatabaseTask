using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class ProjectEmployee
    {
        [Key]
        public int ProjectID { get; set; }
        public int EmployeeID { get; set; }
    }
}
