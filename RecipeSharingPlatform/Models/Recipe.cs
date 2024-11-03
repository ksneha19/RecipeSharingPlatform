namespace RecipeSharingPlatform.Models
{
    public class Recipe
    {
        private ICollection<Rating> ratings;

        public int RecipeId { get; set; }
        public required string Title { get; set; }
        public required string Instructions { get; set; }
        public required ICollection<Ingredient> Ingredients { get; set; }
        public required ICollection<Comment> Comments { get; set; }
        public ICollection<Rating> Ratings { get => ratings; set => ratings = value; }
    }
}
