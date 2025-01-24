namespace ShoppingCartProject.Models
{
    public class ShoppingCart
    {
        private List<Product> _products;

        public ShoppingCart()
        {
            _products = new List<Product>();
        }

        public int ProductCount => _products.Count;

        public void AddProduct(string name, double price)
        {
            _products.Add(new Product(name, price));
        }

        public void RemoveProduct(string name)
        {
            var product = _products.FirstOrDefault(p => p.Name == name);
            if (product == null)
            {
                throw new InvalidOperationException($"The product '{name}' is not in the cart.");
            }
            _products.Remove(product);
        }

        public double GetTotalPrice()
        {
            return _products.Sum(p => p.Price);
        }

        public List<Product> GetProducts()
        {
            return new List<Product>(_products);
        }
    }
}
