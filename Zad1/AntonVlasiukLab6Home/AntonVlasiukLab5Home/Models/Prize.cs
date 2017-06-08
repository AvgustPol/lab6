using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AntonVlasiukLab5Home.Models
{
    /// <summary>
    /// earned reward 
    /// </summary>
    public class Prize : ModelBase 
    {
        /// <summary>
        /// Signature of person, who gave this prize
        /// </summary>
        public string Signature { get; set; }

        /// <summary>
        /// where it was
        /// </summary>
        public Adres Where { get; set; }

        /// <summary>
        /// Cheerful comment for motivation
        /// </summary>
        public string Comment { get; set; }
    }
}
