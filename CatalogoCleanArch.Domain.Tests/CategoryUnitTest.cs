using CatalogoCleanArch.Domain.Entities;
using CatalogoCleanArch.Domain.Validation;
using FluentAssertions;

namespace CatalogoCleanArch.Domain.Tests
{
    public class CategoryUnitTest
    {
        [Fact]
        public void CreateCategory_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Category("Category Name");
            action.Should().NotThrow<DomainExceptionValidation>();
        }

        [Fact]
        public void CreateCategory_InvalidName_DomainExceptionInvalidName()
        {
            Action action = () => new Category("AB");
            action.Should().Throw<DomainExceptionValidation>();
        }
    }
}
