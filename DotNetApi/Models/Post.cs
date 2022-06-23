using System.ComponentModel.DataAnnotations;

namespace DotNetApi.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please Enter title.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please Enter title.")]
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

    }
}
