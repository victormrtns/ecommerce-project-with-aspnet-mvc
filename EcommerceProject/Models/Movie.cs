using EcommerceProject.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace EcommerceProject.Models
{
    public class Movie
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

    }
}
