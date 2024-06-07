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
            int productID = 7;
            string productName = "Mac Book";
            int price = 1400;
            int stock = 18;

            int expected = 7;

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
            int productID = 15;
            string productName = "Asus VivoBook";
            int price = 899;
            int stock = 70;

            int expected = 15;

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
            int productID = 12;
            string productName = "School bag";
            int price = 650;
            int stock = 40;

            int expected = 12;

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
            int productID = 35;
            string productName = "Dell Inspirion";
            int price = 1250;
            int stock = 11;

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
            int productID = 29;
            string productName = "Mac Book Pro";
            int price = 1950;
            int stock = 10;

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
            int productID = 1;
            string productName = "Dell XPS 15";
            int price = 735;
            int stock = 37;

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
            int productID = 26;
            string productName = "HP Spectre x360";
            int price = 450;
            int stock = 16;

            int expected = 16;

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
            int productID = 16;
            string productName = "Lenovo ThinkPad X1 Carbon";
            int price = 750;
            int stock = 110;

            int expected = 110;

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
            int productID = 23;
            string productName = "Microsoft Surface";
            int price = 800;
            int stock = 120;

            int expected = 120;

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
            int productID = 87;
            string productName = "Asus ROG Zephyrus";
            int price = 1600;
            int stock = 116;

            double expected = 1600;

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
            int productID = 13;
            string productName = "Razer Blade 15";
            int price = 2000;
            int stock = 86;

            double expected = 2000;

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
            int productID = 16;
            string productName = "Acer Swift 3";
            int price = 590;
            int stock = 89;

            int expected = 590;

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
            int productID = 50;
            string productName = "LG Gram 17";
            int price = 1700;
            int stock = 180;
            int increaseStock = 20;

            int expected = 200;

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
            int productID = 75;
            string productName = "Samsung Galaxy Book Pro";
            int price = 2700;
            int stock = 1100;
            int increaseStock = 60;

            int expected = 1160;

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
            int productID = 5;
            string productName = "HP Envy";
            int price = 270;
            int stock = 1000;
            int increaseStock = 20;

            int expected = 1020;
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
            int productID = 1;
            string productName = "Lenovo Yoga";
            int price = 1700;
            int stock = 1500;
            int DecreaseStock = 500;

            int expected = 1000;

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
            int productID = 50;
            string productName = "Dell Precision ";
            int price = 700;
            int stock = 700;
            int DecreaseStock = 250;

            int expected = 450;

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
            int productID = 10;
            string productName = "Asus ZenBook 14";
            int price = 990;
            int stock = 610;
            int DecreaseStock = 110;

            int expected = 500;

            //Act
            Product product = new Product(productID, productName, price, stock);
            product.DecreaseStock(DecreaseStock);
            int actual = product.Stock;

            //Assert
            Assert.That(expected, Is.EqualTo(actual));
        }


    }
}
