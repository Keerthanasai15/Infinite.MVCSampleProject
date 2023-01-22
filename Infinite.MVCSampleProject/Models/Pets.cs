using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Infinite.MVCSampleProject.Models
{
    public class Pets
    {
        public int Id { get; set; }
        [Required]
        public string PetName { get; set; }
        [Required]
        [StringLength(50)]
        public string Description{ get; set;}
        public int BreedsId { get; set; }

        public double Height { get; set;}
        public double Weight { get; set;}
        public int Age { get; set;}

        public Breeds Breeds { get; set; }

        
    }
}