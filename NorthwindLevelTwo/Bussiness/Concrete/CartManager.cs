using Bussiness.Abstract;
using Entities.Concrete;
using Entities.Concrete.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class CartManager : ICartService
    {
        public void AddToCart(Cart cart, Product product)
        {
            CartLine cartLine = cart.CartLines.FirstOrDefault(p=>p.Product.ProductId == product.ProductId);
            if (cartLine != null)
            {
                cartLine.Quantity++;
                return;
            }
            else
            {

                cart.CartLines.Add(new CartLine { Product=product,Quantity=1});
            }

        }

        public List<CartLine> List(Cart cart)
        {
            return cart.CartLines;
        }

        public void RemoveFromCart(Cart cart, int prductId)
        {
            var cartLine = cart.CartLines.FirstOrDefault(p=> p.Product.ProductId == prductId);   
            if (cartLine.Quantity > 1)
            {
                cartLine.Quantity--;
                return;
            }
            else
            {
                cart.CartLines.Remove(cart.CartLines.FirstOrDefault(c => c.Product.ProductId == prductId));


            }

        }
    }
}
