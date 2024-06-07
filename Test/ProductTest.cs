using NUnit.Framework;
using eCommerceApp;

namespace Test
{
    public class ProductTests
    {
        [Test]
        public void ProductConstructor_ValidInputMacBook_SetsProductIDCorrectly()
        {
            //Arrange
            int productID = 90;
            string productName = "Mac Book";
            int price = 650;
            int stock = 7;

            int expected = 90;

            //Act
            Product product = new Product(productID, productName, price, stock);
            int actual = product.ProductID;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }


        [Test]
        public void ProductConstructor_ValidInputAsusVivoBook_SetsProductIDCorrectly()
        {
            //Arrange
            int productID = 60000;
            string productName = "Asus VivoBook";
            int price = 650;
            int stock = 7;

            int expected = 60000;

            //Act
            Product product = new Product(productID, productName, price, stock);
            int actual = product.ProductID;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ProductConstructor_ValidInputSchoolbag_SetsProductIDCorrectly()
        {
            //Arrange
            int productID = 45000;
            string productName = "School bag";
            int price = 650;
            int stock = 7;

            int expected = 45000;

            //Act
            Product product = new Product(productID, productName, price, stock);
            int actual = product.ProductID;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ProductConstructor_ValidInputDellInspirion_SetsProductIDCorrectly()
        {
            //Arrange
            int productID = 6;
            string productName = "Dell Inspirion";
            int price = 650;
            int stock = 7;

            string expected = "Dell Inspirion";

            //Act
            Product product = new Product(productID, productName, price, stock);
            string actual = product.ProductName;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ProductConstructor_ValidInputMacBookPro_SetsProductIDCorrectly()
        {
            //Arrange
            int productID = 6;
            string productName = "Mac Book Pro";
            int price = 650;
            int stock = 7;

            string expected = "Mac Book Pro";

            //Act
            Product product = new Product(productID, productName, price, stock);
            string actual = product.ProductName;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ProductConstructor_ValidInputDellXPS15_SetsProductIDCorrectly()
        {
            //Arrange
            int productID = 6;
            string productName = "Dell XPS 15";
            int price = 650;
            int stock = 7;

            string expected = "Dell XPS 15";

            //Act
            Product product = new Product(productID, productName, price, stock);
            string actual = product.ProductName;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ProductConstructor_ValidInputHPSpectrex360_SetsProductIDCorrectly()
        {
            //Arrange
            int productID = 6;
            string productName = "HP Spectre x360";
            int price = 250;
            int stock = 6;

            int expected = 6;

            //Act
            Product product = new Product(productID, productName, price, stock);
            int actual = product.Stock;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ProductConstructor_ValidInputLenovoThinkPadX1Carbon_SetsProductIDCorrectly()
        {
            //Arrange
            int productID = 6;
            string productName = "Lenovo ThinkPad X1 Carbon";
            int price = 250;
            int stock = 600000;

            int expected = 600000;

            //Act
            Product product = new Product(productID, productName, price, stock);
            int actual = product.Stock;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ProductConstructor_ValidInputMicrosoftSurface_SetsProductIDCorrectly()
        {
            //Arrange
            int productID = 6;
            string productName = "Microsoft Surface";
            int price = 250;
            int stock = 450000;

            int expected = 450000;

            //Act
            Product product = new Product(productID, productName, price, stock);
            int actual = product.Stock;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ProductConstructor_ValidInputAsusROGZephyrus_SetsProductIDCorrectly()
        {
            //Arrange
            int productID = 6;
            string productName = "Asus ROG Zephyrus";
            int price = 6;
            int stock = 6;

            double expected = 6;

            //Act
            Product product = new Product(productID, productName, price, stock);
            double actual = (double)product.Price;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ProductConstructor_ValidInputRazerBlade15_SetsProductIDCorrectly()
        {
            //Arrange
            int productID = 6;
            string productName = "Razer Blade 15";
            int price = 6000;
            int stock = 6;

            double expected = 6000;

            //Act
            Product product = new Product(productID, productName, price, stock);
            double actual = (double)product.Price;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ProductConstructor_ValidInputAcerSwift3_SetsProductIDCorrectly()
        {
            //Arrange
            int productID = 6;
            string productName = "Acer Swift 3";
            int price = 4500;
            int stock = 6;

            int expected = 4500;

            //Act
            Product product = new Product(productID, productName, price, stock);
            double actual = (double)product.Price;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ProductConstructor_ValidInputLGGram17_SetsProductIDCorrectly()
        {
            //Arrange
            int productID = 750;
            string productName = "LG Gram 17";
            int price = 2700;
            int stock = 100;
            int increaseStock = 6;

            int expected = 106;

            //Act
            Product product = new Product(productID, productName, price, stock);
            product.IncreaseStock(increaseStock);
            int actual = product.Stock;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ProductConstructor_ValidInputSamsungGalaxyBookPro_SetsProductIDCorrectly()
        {
            //Arrange
            int productID = 750;
            string productName = "Samsung Galaxy Book Pro";
            int price = 2700;
            int stock = 100;
            int increaseStock = 600000;

            int expected = 600100;

            //Act
            Product product = new Product(productID, productName, price, stock);
            product.IncreaseStock(increaseStock);
            int actual = product.Stock;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ProductConstructor_ValidInputHPEnvy_SetsProductIDCorrectly()
        {
            //Arrange
            int productID = 750;
            string productName = "HP Envy";
            int price = 2700;
            int stock = 100;
            int increaseStock = 255500;

            int expected = 255600;

            //Act
            Product product = new Product(productID, productName, price, stock);
            product.IncreaseStock(increaseStock);
            int actual = product.Stock;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ProductConstructor_ValidInputLenovoYoga_SetsProductIDCorrectly()
        {
            //Arrange
            int productID = 750;
            string productName = "Lenovo Yoga";
            int price = 2700;
            int stock = 100;
            int DecreaseStock = 10;

            int expected = 90;

            //Act
            Product product = new Product(productID, productName, price, stock);
            product.DecreaseStock(DecreaseStock);
            int actual = product.Stock;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ProductConstructor_ValidInputDellPrecision2_SetsProductIDCorrectly()
        {
            //Arrange
            int productID = 750;
            string productName = "Dell Precision ";
            int price = 2700;
            int stock = 6000;
            int DecreaseStock = 250;

            int expected = 5750;

            //Act
            Product product = new Product(productID, productName, price, stock);
            product.DecreaseStock(DecreaseStock);
            int actual = product.Stock;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ProductConstructor_ValidInputAsusZenBook14_SetsProductIDCorrectly()
        {
            //Arrange
            int productID = 750;
            string productName = "Asus ZenBook 14";
            int price = 2700;
            int stock = 6000;
            int DecreaseStock = 1000;

            int expected = 5000;

            //Act
            Product product = new Product(productID, productName, price, stock);
            product.DecreaseStock(DecreaseStock);
            int actual = product.Stock;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }


    }
}
