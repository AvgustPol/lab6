using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AntonVlasiukLab5Home.Models
{
    public class Student : ModelBase      
    {
        [Required(ErrorMessage = "Name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is also required")]
        public string LastName { get; set; }

        [Range(1, 122, ErrorMessage = "Your age must be between 1 and 122 Why 122? Check who is Jeanne Calment from French")]
        public int Age { get; set; }

        public Adres Adres { get; set; }

        public List<Hobby> Hobby { get; set; }
    }
}