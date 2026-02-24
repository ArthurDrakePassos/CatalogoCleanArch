using CatalogoCleanArch.Domain.Entities;
using CatalogoCleanArch.Domain.Validation;
using FluentAssertions;

namespace CatalogoCleanArch.Domain.Tests
{
    public class ProductUnitTest
    {
        [Fact]
        public void CreateProduct_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Product("Product Name", "Product Description", 10.0m, 10, "https://images.com/productimage");
            action.Should().NotThrow<DomainExceptionValidation>();
        }

        [Fact]
        public void CreateProduct_InvalidName_DomainExceptionInvalidName()
        {
            Action action = () => new Product("AB", "Product Description", 10.0m, 10, "https://images.com/productimage");
            action.Should().Throw<DomainExceptionValidation>();
        }

        [Fact]
        public void CreateProduct_InvalidDescription_DomainExceptionInvalidDescription()
        {
            Action action = () => new Product("Product Name", "Desc", 10.0m, 10, "https://images.com/productimage");
            action.Should().Throw<DomainExceptionValidation>();
        }

        [Fact]
        public void CreateProduct_InvalidPrice_DomainExceptionInvalidPrice()
        {
            Action action = () => new Product("Product Name", "Product Description", -100m, 10, "https://images.com/productimage");
            action.Should().Throw<DomainExceptionValidation>();
        }

        [Fact]
        public void CreateProduct_InvalidStock_DomainExceptionInvalidStock()
        {
            Action action = () => new Product("Product Name", "Product Description", 10.0m, -5, "https://images.com/productimage");
            action.Should().Throw<DomainExceptionValidation>();
        }

        [Fact]
        public void CreateProduct_InvalidImage_DomainExceptionInvalidImage()
        {
            Action action = () => new Product("Product Name", "Product Description", 10.0m, -5, "https://images.com/eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee");
            action.Should().Throw<DomainExceptionValidation>();
        }
    }
}
