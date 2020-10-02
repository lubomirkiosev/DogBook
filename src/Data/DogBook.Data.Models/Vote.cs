namespace DogBook.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using DogBook.Data.Common.Models;

    public class Vote : BaseDeletableModel<int>
    {
        public int PostId { get; set; }

        public virtual Post Post { get; set; }

        [Required]
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public VoteType Type { get; set; }
    }
}
