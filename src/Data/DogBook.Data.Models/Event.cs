namespace DogBook.Data.Models
{
    using System;
    using System.Collections.Generic;

    using DogBook.Data.Common.Models;

    public class Event : BaseDeletableModel<int>
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public ICollection<ApplicationUser> Visitors { get; set; }
    }
}
