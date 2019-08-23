using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShelterAPI.Models
{

    [Table("animals")]
    public class Animal
    {
        [Key]
        public int AnimalId { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public DateTime Admission { get; set; }
        public string ImageURL { get; set; }

        public Breed Breed { get; set; }
    }
}