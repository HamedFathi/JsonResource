using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JsonResource
{
    public class Person
    {
        [Required(ErrorMessage = "Name")]
        public string Name { get; set; }
        public string FamilyName { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public int Age { get; set; }
    }
}
