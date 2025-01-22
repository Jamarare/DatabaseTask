using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Specialist
    {
        [Key]
        public int SpecialistID { get; set; }
        public string Name { get; set; }
    }
}
