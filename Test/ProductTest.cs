using NUnit.Framework;
using eCommerceApp;

namespace Test
{
    public class ProductTests
    {
        [Test]
        public void ProductID_SetValidValue_ShouldGetSameValue()
        {
            // Arrange
            var product = new Product(1, "Test Product", 10.0m, 10);

            // Act
            product.ProductID = 100;

            // Assert
            Assert.That(product.ProductID, Is.EqualTo(100));
        }

        [Test]
        public void ProductName_SetValidValue_ShouldGetSameValue()
        {
            // Arrange
            var product = new Product(1, "Test Product", 10.0m, 10);

            // Act
            product.ProductName = "New Product Name";

            // Assert
            Assert.That(product.ProductName, Is.EqualTo("New Product Name"));
        }

        [Test]
        public void Price_SetValidValue_ShouldGetSameValue()
        {
            // Arrange
            var product = new Product(1, "Test Product", 10.0m, 10);

            // Act
            product.Price = 20.0m;

            // Assert
            Assert.That(product.Price, Is.EqualTo(20.0m));
        }

        [Test]
        public void Stock_SetValidValue_ShouldGetSameValue()
        {
            // Arrange
            var product = new Product(1, "Test Product", 10.0m, 10);

            // Act
            product.Stock = 100;

            // Assert
            Assert.That(product.Stock, Is.EqualTo(100));
        }

        [Test]
        public void IncreaseStock_ValidAmount_ShouldIncreaseStock()
        {
            // Arrange
            var product = new Product(1, "Test Product", 10.0m, 10);

            // Act
            product.IncreaseStock(5);

            // Assert
            Assert.That(product.Stock, Is.EqualTo(15));
        }

        [Test]
        public void DecreaseStock_ValidAmount_ShouldDecreaseStock()
        {
            // Arrange
            var product = new Product(1, "Test Product", 10.0m, 10);

            // Act
            product.DecreaseStock(5);

            // Assert
            Assert.That(product.Stock, Is.EqualTo(5));
        }

        [Test]
        public void DecreaseStock_MoreThanStock_ShouldNotChangeStock()
        {
            // Arrange
            var product = new Product(1, "Test Product", 10.0m, 10);

            // Act
            product.DecreaseStock(15);

            // Assert
            Assert.That(product.Stock, Is.EqualTo(10));
        }
    }
}
