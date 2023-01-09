using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIProjects_Task1.Model
{
    public class Request
    {
        [Required]
        public string FirstNumber { get; set; }
        [Required]
        public string SecondNumber { get; set; }
    }
}
