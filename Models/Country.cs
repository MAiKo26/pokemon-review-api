﻿namespace PokemonReviewAPI.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string contiennt { get; set; }

        public ICollection<Owner> Owners { get; set;}
        public ICollection<Reviewer> Reviewers { get; set; }
    }
}
