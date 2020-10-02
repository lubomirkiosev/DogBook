namespace DogBook.Data.Models
{
    using DogBook.Data.Common.Models;

    public class Address : BaseDeletableModel<int>
    {
        public string City { get; set; }

        public string Neighborhood { get; set; }

        public string Street { get; set; }

        public int Number { get; set; }
    }
}
