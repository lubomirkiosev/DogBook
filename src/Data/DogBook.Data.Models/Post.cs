namespace DogBook.Data.Models
{
    using DogBook.Data.Common.Models;

    public class Post : BaseDeletableModel<int>
    {
        public ApplicationUser User { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }
    }
}
