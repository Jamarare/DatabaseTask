using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class ProjectSpecialist
    {
        [Key]
        public int ProjectID { get; set; }
        public int SpecialistID { get; set; }
    }
}
