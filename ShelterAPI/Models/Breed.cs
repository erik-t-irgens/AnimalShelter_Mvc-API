using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShelterAPI.Models
{
    [Table("breeds")]
    public class Breed
    {
        [Key]
        public int BreedId { get; set; }
        public string Name { get; set; }
        public IList<Animal> Animals { get; set; } = new List<Animal>();
    }
}
