namespace MyNewCSharpFavoriteFeatures.ThrowExpressions
{
    public interface ICartRepository
    {
        Cart GetById(int cartId);
        void Update(Cart cart);
    }
}