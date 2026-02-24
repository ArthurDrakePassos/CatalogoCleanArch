using CatalogoCleanArch.Domain.Validation;

namespace CatalogoCleanArch.Domain.Entities
{
    public sealed class Category
    {
        public Category(string name)
        {
            ValidateDomain(name);
            Name = name;
        }

        public int CategoryId { get; private set; }
        public string Name { get; private set; }

        public ICollection<Product> Products { get; set; }

        public void Update(string name)
        {
            ValidateDomain(name);
            Name = name;
        }

        private void ValidateDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name!");
            DomainExceptionValidation.When(name.Length < 3, "Invalid name! Must have at least 3 characters!");
        }
    }
}
