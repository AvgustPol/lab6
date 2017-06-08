using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AntonVlasiukLab5Home.Models
{
    public abstract class ModelBase
    {
        [Key]
        public int Id { get; set; }
    }
}