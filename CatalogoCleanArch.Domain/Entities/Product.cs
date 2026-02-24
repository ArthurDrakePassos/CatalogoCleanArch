using CatalogoCleanArch.Domain.Validation;

namespace CatalogoCleanArch.Domain.Entities
{
    public sealed class Product
    {
        public Product(string name, string description, decimal price, int stock, string image)
        {
            ValidateDomain(name, description, price, stock, image);
            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
            Image = image;
        }

        public int ProductId { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int Stock { get; private set; }
        public string Image { get; private set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public void Update(string name, string description, decimal price, int stock, string image, int categoryId)
        {
            ValidateDomain(name, description, price, stock, image);
            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
            Image = image;
            CategoryId = categoryId;
        }

        private void ValidateDomain(string name, string description, decimal price, int stock, string image)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name!");
            DomainExceptionValidation.When(name.Length < 3, "Invalid name! Must have at least 3 characters!");
            DomainExceptionValidation.When(string.IsNullOrEmpty(description), "Invalid description!");
            DomainExceptionValidation.When(description.Length < 5, "Invalid description! Must have at least 5 characters!");
            DomainExceptionValidation.When(price < 0, "Invalid price!");
            DomainExceptionValidation.When(stock < 0, "Invalid stock!");
            DomainExceptionValidation.When(image?.Length > 250, "Invalid image, maximum 250 characters!");
        }
    }
}
