namespace RecipeSharingPlatform.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        //public ICollection<Recipe> Recipes { get; set; }
        //public ICollection<Rating> Ratings { get; set; }
        //public ICollection<Comment> Comments { get; set; }

        // These properties can be null or empty when creating a new user
        public ICollection<Recipe> Recipes { get; set; } = new List<Recipe>(); // Initialized to empty collection
        public ICollection<Rating> Ratings { get; set; } = new List<Rating>(); // Initialized to empty collection
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }

}
