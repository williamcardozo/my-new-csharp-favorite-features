namespace MyNewCSharpFavoriteFeatures.ThrowExpressions
{
    public class CartRepository : ICartRepository
    {
        public Cart GetById(int cartId)
        {
            return new Cart();
        }

        public void Update(Cart cart)
        {
            //Update logic
        }
    }
}