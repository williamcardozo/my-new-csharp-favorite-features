using System;

namespace MyNewCSharpFavoriteFeatures.ThrowExpressions
{
    public class CartService
    {

        public readonly ICartRepository cartRepository;

        public CartService()
        {
            cartRepository = new CartRepository();
        }

        //Before throw expressions
        public void AddItemToCart(Item item, int cartId)
        {
            if (item is null)
                throw new Exception("Item can't be null");

            var cart = cartRepository.GetById(cartId);

            if (cart is null)
                throw new Exception("Cart not found");

            cart.AddItem(item);

            cartRepository.Update(cart);
        }

        //After throw expressions
        public void AddItemToCartWithThrowExpressions(Item item, int cartId)
        {
            if (item is null)
                throw new Exception("Item can't be null");

            var cart = cartRepository.GetById(cartId) ?? 
                throw new Exception("Cart not found");

            cart.AddItem(item);
            cartRepository.Update(cart);
        }
    }
}
