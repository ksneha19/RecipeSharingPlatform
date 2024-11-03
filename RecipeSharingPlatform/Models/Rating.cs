namespace RecipeSharingPlatform.Models
{
    public class Rating
    {
        public int RatingId { get; set; }
        public int Score { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
    }
}
