using System.ComponentModel.DataAnnotations;

namespace HamsterWars.Models
{
    public class DisplayHamsterModel
    {
        [Required]
        [StringLength(20, ErrorMessage="Name too long")]
        [MinLength(1, ErrorMessage="Name too short")]
        public string Name { get; set; }

        [Required]
        [Range(0,3)]
        public int Age { get; set; }

        [StringLength(20, ErrorMessage = "Favourite food too long")]
        public string? FavouriteFood { get; set; }

        [StringLength(20, ErrorMessage = "Favourite activity too long")]
        public string? FavouriteActivity { get; set; }

        [Required]
        public string ImageName { get; set; }
        public int Wins { get; set; }
        public int Defeats { get; set; }
        public int Games { get; set; }
        public int Likes { get; set; }
    }
}
