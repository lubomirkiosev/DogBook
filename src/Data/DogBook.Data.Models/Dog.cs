namespace DogBook.Data.Models
{
    using DogBook.Data.Common.Models;

    public class Dog : BaseDeletableModel<int>
    {
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public string Name { get; set; }

        public Gender Gender { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public string Breed { get; set; }

        public int AddressId { get; set; }

        public virtual Address Address { get; set; }
    }
}
