using System.ComponentModel.DataAnnotations;

namespace AdminPortal.Models
{
    public class CourseModel
    {
        public int? Id { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "You must enter a title.")]
        public string Title { get; set; } = null!;

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "You must enter a header description.")]
        public string HeaderDescription { get; set; } = null!;

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "You must enter a course description.")]
        public string Description { get; set; } = null!;

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "You must enter an author.")]
        public string Author { get; set; } = null!;

        [DataType(DataType.Text)]
        [RegularExpression("^\\-?[0-9]+(?:\\.[0-9]+)?$", ErrorMessage = "Enter a valid price.")]
        [Required(ErrorMessage = "You must enter a price.")]
        public string Price { get; set; } = null!;

        [DataType(DataType.Text)]
        [RegularExpression("^\\-?[0-9]+(?:\\.[0-9]+)?$", ErrorMessage = "Enter a valid price.")]
        public string? DiscountedPrice { get; set; }

        [DataType(DataType.Text)]
        [RegularExpression("^[0-9]+$", ErrorMessage = "Enter a valid number.")]
        [Required(ErrorMessage = "You must enter the course length in hours.")]
        public string Hours { get; set; } = null!;

        [DataType(DataType.Text)]
        [RegularExpression("^[0-9]+$", ErrorMessage = "Enter a valid number.")]
        public string? Likes { get; set; }

        [DataType(DataType.Text)]
        [RegularExpression("^[0-9]+$", ErrorMessage = "Enter a valid number.")]
        public string? LikePercentage { get; set; }
        public string IsBestSeller { get; set; } = null!;
        public string? Rating { get; set; }

        [DataType(DataType.Text)]
        [RegularExpression("^[0-9]+$", ErrorMessage = "Enter a valid number.")]
        public string? Reviews { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "You must enter an image URL.")]
        public string ImageUrl { get; set; } = null!;

        public bool OnInitAlreadyLoaded { get; set; } = false;
    }
}
