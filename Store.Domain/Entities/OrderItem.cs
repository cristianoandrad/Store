using Flunt.Validations;

namespace Store.Domain.Entities
{
    public class OrderItem : Entity
    {
        public OrderItem(Product product, int quantity)
        {
            AddNotifications(
                new Contract()
                    .Requires()
                    .IsNotNull(product, "Product", "Produto inválido")
                    .IsGreaterThan(quantity, 0, "Quantity", "A quantidade deve ser maior que zero")
            );

            this.Product = product;
            this.Price = Product != null ? product.Price : 0;
            this.Quantity = quantity;

        }
        public Product Product { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public decimal Total()
        {
            return Price * Quantity;
        }

    }
}