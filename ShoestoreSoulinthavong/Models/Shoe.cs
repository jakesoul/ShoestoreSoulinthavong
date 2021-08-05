using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShoestoreSoulinthavong.Models
{
    public class Shoe
    {
        public int ShoeId { get; set; }
        [Required(ErrorMessage = "Please enter the brand of shoe.")]
        public string Brand { get; set; }
        [Required(ErrorMessage = "Please enter the shoe style.")]
        public string Style { get; set; }
        [Required(ErrorMessage = "Please enter whether the shoe is unisex, for men, or women.")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Please enter what color the shoe is.")]
        public string Color { get; set; }
        [Required(ErrorMessage = "Please enter the shoe size.")]
        public double? Size { get; set; }
        [Required(ErrorMessage = "Please enter the retail cost of the pair of shoes.")]
        public double? RetailPrice { get; set; }
    }
}
