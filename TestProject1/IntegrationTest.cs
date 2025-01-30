using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestProject1.TestViews;

namespace Calculator.Tests.IntegrationTests
{
    [TestClass]
    public class RealCalculatorTests
    {
        private TestViewReal _view;
        private PresenterReal _presenter;

        [TestInitialize]
        public void Setup()
        {
            _view = new TestViewReal();
            _presenter = new PresenterReal(_view);
        }

        [TestMethod]
        public void Addition_ValidNumbers_ReturnsCorrectResult()
        {
            // Arrange
            _view.RealNumberA = "5";
            _view.RealNumberB = "3";

            // Act
            _view.TriggerCalculateSum();

            // Assert
            Assert.AreEqual("8", _view.RealResult);
            Assert.IsNull(_view.LastErrorMessage);
        }

        [TestMethod]
        public void Subtraction_ValidNumbers_ReturnsCorrectResult()
        {
            // Arrange
            _view.RealNumberA = "10";
            _view.RealNumberB = "4";

            // Act
            _view.TriggerCalculateSubtract();

            // Assert
            Assert.AreEqual("6", _view.RealResult);
            Assert.IsNull(_view.LastErrorMessage);
        }

        [TestMethod]
        public void Multiplication_ValidNumbers_ReturnsCorrectResult()
        {
            // Arrange
            _view.RealNumberA = "4";
            _view.RealNumberB = "5";

            // Act
            _view.TriggerCalculateMultiply();

            // Assert
            Assert.AreEqual("20", _view.RealResult);
            Assert.IsNull(_view.LastErrorMessage);
        }

        [TestMethod]
        public void Division_ValidNumbers_ReturnsCorrectResult()
        {
            // Arrange
            _view.RealNumberA = "15";
            _view.RealNumberB = "3";

            // Act
            _view.TriggerCalculateDivide();

            // Assert
            Assert.AreEqual("5", _view.RealResult);
            Assert.IsNull(_view.LastErrorMessage);
        }

        [TestMethod]
        public void Division_DivideByZero_ShowsError()
        {
            // Arrange
            _view.RealNumberA = "10";
            _view.RealNumberB = "0";

            // Act
            _view.TriggerCalculateDivide();

            // Assert
            Assert.IsNotNull(_view.LastErrorMessage);
        }

        [TestMethod]
        public void InvalidInput_ShowsError()
        {
            // Arrange
            _view.RealNumberA = "not a number";
            _view.RealNumberB = "5";

            // Act
            _view.TriggerCalculateSum();

            // Assert
            Assert.IsNotNull(_view.LastErrorMessage);
        }

        [TestMethod]
        public void EmptyInput_ShowsError()
        {
            // Arrange
            _view.RealNumberA = "";
            _view.RealNumberB = "5";

            // Act
            _view.TriggerCalculateSum();

            // Assert
            Assert.IsNotNull(_view.LastErrorMessage);
        }
    }

    [TestClass]
    public class ComplexCalculatorTests
    {
        private TestViewComplex _view;
        private PresenterComplex _presenter;

        [TestInitialize]
        public void Setup()
        {
            _view = new TestViewComplex();
            _presenter = new PresenterComplex(_view);
        }

        [TestMethod]
        public void Addition_ValidNumbers_ReturnsCorrectResult()
        {
            // Arrange
            _view.ComplexRealA = "3";
            _view.ComplexImgA = "2";
            _view.ComplexRealB = "1";
            _view.ComplexImgB = "4";

            // Act
            _view.TriggerCalculateSum();

            // Assert
            Assert.AreEqual("4", _view.ComplexRealResult); // 3 + 1
            Assert.AreEqual("6", _view.ComplexImgResult);  // 2 + 4
            Assert.IsNull(_view.LastErrorMessage);
        }

        [TestMethod]
        public void Subtraction_ValidNumbers_ReturnsCorrectResult()
        {
            // Arrange
            _view.ComplexRealA = "3";
            _view.ComplexImgA = "2";
            _view.ComplexRealB = "1";
            _view.ComplexImgB = "4";

            // Act
            _view.TriggerCalculateSubtract();

            // Assert
            Assert.AreEqual("2", _view.ComplexRealResult);  // 3 - 1
            Assert.AreEqual("-2", _view.ComplexImgResult); // 2 - 4
            Assert.IsNull(_view.LastErrorMessage);
        }

        [TestMethod]
        public void Multiplication_ValidNumbers_ReturnsCorrectResult()
        {
            // Arrange
            _view.ComplexRealA = "3";
            _view.ComplexImgA = "2";
            _view.ComplexRealB = "1";
            _view.ComplexImgB = "4";

            // Act
            _view.TriggerCalculateMultiply();

            // Assert
            Assert.AreEqual("-5", _view.ComplexRealResult);  // (3*1 - 2*4)
            Assert.AreEqual("14", _view.ComplexImgResult);   // (3*4 + 2*1)
            Assert.IsNull(_view.LastErrorMessage);
        }

        [TestMethod]
        public void Division_ValidNumbers_ReturnsCorrectResult()
        {
            // Arrange
            _view.ComplexRealA = "3";
            _view.ComplexImgA = "2";
            _view.ComplexRealB = "1";
            _view.ComplexImgB = "1";

            // Act
            _view.TriggerCalculateDivide();

            // Assert
            Assert.AreEqual("2,5", _view.ComplexRealResult);  // (3*1 + 2*1)/(1*1 + 1*1)
            Assert.AreEqual("-0,5", _view.ComplexImgResult);   // (2*1 - 3*1)/(1*1 + 1*1)
            Assert.IsNull(_view.LastErrorMessage);
        }

        [TestMethod]
        public void Division_ByZero_ShowsError()
        {
            // Arrange
            _view.ComplexRealA = "3";
            _view.ComplexImgA = "2";
            _view.ComplexRealB = "0";
            _view.ComplexImgB = "0";

            // Act
            _view.TriggerCalculateDivide();

            // Assert
            Assert.IsNotNull(_view.LastErrorMessage);
        }

        [TestMethod]
        public void InvalidInput_ShowsError()
        {
            // Arrange
            _view.ComplexRealA = "not a number";
            _view.ComplexImgA = "2";
            _view.ComplexRealB = "1";
            _view.ComplexImgB = "4";

            // Act
            _view.TriggerCalculateSum();

            // Assert
            Assert.IsNotNull(_view.LastErrorMessage);
        }

        [TestMethod]
        public void EmptyInput_ShowsError()
        {
            // Arrange
            _view.ComplexRealA = "";
            _view.ComplexImgA = "2";
            _view.ComplexRealB = "1";
            _view.ComplexImgB = "4";

            // Act
            _view.TriggerCalculateSum();

            // Assert
            Assert.IsNotNull(_view.LastErrorMessage);
        }
    }

    [TestClass]
    public class QuaternionCalculatorTests
    {
        private TestViewQuaternion _view;
        private PresenterQuaternion _presenter;

        [TestInitialize]
        public void Setup()
        {
            _view = new TestViewQuaternion();
            _presenter = new PresenterQuaternion(_view);
        }

        [TestMethod]
        public void Addition_ValidNumbers_ReturnsCorrectResult()
        {
            // Arrange
            _view.QuatRealA = "2";
            _view.QuatVecXA = "1";
            _view.QuatVecYA = "3";
            _view.QuatVecZA = "4";

            _view.QuatRealB = "1";
            _view.QuatVecXB = "2";
            _view.QuatVecYB = "1";
            _view.QuatVecZB = "3";

            // Act
            _view.TriggerCalculateSum();

            // Assert
            Assert.AreEqual("3", _view.QuatRealResult);  // 2 + 1
            Assert.AreEqual("3", _view.QuatVecXResult);  // 1 + 2
            Assert.AreEqual("4", _view.QuatVecYResult);  // 3 + 1
            Assert.AreEqual("7", _view.QuatVecZResult);  // 4 + 3
            Assert.IsNull(_view.LastErrorMessage);
        }

        [TestMethod]
        public void Subtraction_ValidNumbers_ReturnsCorrectResult()
        {
            // Arrange
            _view.QuatRealA = "2";
            _view.QuatVecXA = "1";
            _view.QuatVecYA = "3";
            _view.QuatVecZA = "4";

            _view.QuatRealB = "1";
            _view.QuatVecXB = "2";
            _view.QuatVecYB = "1";
            _view.QuatVecZB = "3";

            // Act
            _view.TriggerCalculateSubtract();

            // Assert
            Assert.AreEqual("1", _view.QuatRealResult);   // 2 - 1
            Assert.AreEqual("-1", _view.QuatVecXResult);  // 1 - 2
            Assert.AreEqual("2", _view.QuatVecYResult);   // 3 - 1
            Assert.AreEqual("1", _view.QuatVecZResult);   // 4 - 3
            Assert.IsNull(_view.LastErrorMessage);
        }

        [TestMethod]
        public void Multiplication_ValidNumbers_ReturnsCorrectResult()
        {
            // Arrange
            _view.QuatRealA = "1";
            _view.QuatVecXA = "2";
            _view.QuatVecYA = "3";
            _view.QuatVecZA = "4";

            _view.QuatRealB = "2";
            _view.QuatVecXB = "1";
            _view.QuatVecYB = "2";
            _view.QuatVecZB = "3";

            // Act
            _view.TriggerCalculateMultiply();

            // Assert
            // Проверяем результат умножения кватернионов
            Assert.IsNotNull(_view.QuatRealResult);
            Assert.IsNotNull(_view.QuatVecXResult);
            Assert.IsNotNull(_view.QuatVecYResult);
            Assert.IsNotNull(_view.QuatVecZResult);
            Assert.IsNull(_view.LastErrorMessage);
        }

        [TestMethod]
        public void Division_ValidNumbers_ReturnsCorrectResult()
        {
            // Arrange
            _view.QuatRealA = "1";
            _view.QuatVecXA = "2";
            _view.QuatVecYA = "3";
            _view.QuatVecZA = "4";

            _view.QuatRealB = "2";
            _view.QuatVecXB = "1";
            _view.QuatVecYB = "2";
            _view.QuatVecZB = "3";

            // Act
            _view.TriggerCalculateDivide();

            // Assert
            Assert.IsNotNull(_view.QuatRealResult);
            Assert.IsNotNull(_view.QuatVecXResult);
            Assert.IsNotNull(_view.QuatVecYResult);
            Assert.IsNotNull(_view.QuatVecZResult);
            Assert.IsNull(_view.LastErrorMessage);
        }

        [TestMethod]
        public void InvalidInput_ShowsError()
        {
            // Arrange
            _view.QuatRealA = "not a number";
            _view.QuatVecXA = "1";
            _view.QuatVecYA = "2";
            _view.QuatVecZA = "3";

            _view.QuatRealB = "2";
            _view.QuatVecXB = "1";
            _view.QuatVecYB = "2";
            _view.QuatVecZB = "3";

            // Act
            _view.TriggerCalculateSum();

            // Assert
            Assert.IsNotNull(_view.LastErrorMessage);
        }

        [TestMethod]
        public void EmptyInput_ShowsError()
        {
            // Arrange
            _view.QuatRealA = "";
            _view.QuatVecXA = "1";
            _view.QuatVecYA = "2";
            _view.QuatVecZA = "3";

            _view.QuatRealB = "2";
            _view.QuatVecXB = "1";
            _view.QuatVecYB = "2";
            _view.QuatVecZB = "3";

            // Act
            _view.TriggerCalculateSum();

            // Assert
            Assert.IsNotNull(_view.LastErrorMessage);
        }
    }
    [TestClass]
    public class ModularCalculatorTests
    {
        private TestViewModular _view;
        private PresenterModular _presenter;

        [TestInitialize]
        public void Setup()
        {
            _view = new TestViewModular();
            _presenter = new PresenterModular(_view);
        }

        [TestMethod]
        public void Addition_ValidNumbers_ReturnsCorrectResult()
        {
            // Arrange
            _view.ModNumberA = "8";
            _view.ModNumberB = "5";
            _view.ModNumberN = "7";  // Модуль

            // Act
            _view.TriggerCalculateSum();

            // Assert
            Assert.AreEqual("6", _view.ModResult);  // (8 + 5) mod 7 = 13 mod 7 = 6
            Assert.IsNull(_view.LastErrorMessage);
        }

        [TestMethod]
        public void Subtraction_ValidNumbers_ReturnsCorrectResult()
        {
            // Arrange
            _view.ModNumberA = "3";
            _view.ModNumberB = "5";
            _view.ModNumberN = "7";  // Модуль

            // Act
            _view.TriggerCalculateSubtract();

            // Assert
            Assert.AreEqual("5", _view.ModResult);  // (3 + 7 - 5) mod 7 = 5
            Assert.IsNull(_view.LastErrorMessage);
        }

        [TestMethod]
        public void Multiplication_ValidNumbers_ReturnsCorrectResult()
        {
            // Arrange
            _view.ModNumberA = "4";
            _view.ModNumberB = "3";
            _view.ModNumberN = "7";  // Модуль

            // Act
            _view.TriggerCalculateMultiply();

            // Assert
            Assert.AreEqual("5", _view.ModResult);  // (4 * 3) mod 7 = 12 mod 7 = 5
            Assert.IsNull(_view.LastErrorMessage);
        }

        [TestMethod]
        public void Division_ValidNumbers_ReturnsCorrectResult()
        {
            // Arrange
            _view.ModNumberA = "3";
            _view.ModNumberB = "2";
            _view.ModNumberN = "5";  // Простой модуль

            // Act
            _view.TriggerCalculateDivide();

            // Assert
            Assert.IsNotNull(_view.ModResult);
            Assert.IsNull(_view.LastErrorMessage);
        }

        [TestMethod]
        public void Division_NonPrimeModulus_ShowsError()
        {
            // Arrange
            _view.ModNumberA = "4";
            _view.ModNumberB = "2";
            _view.ModNumberN = "6";  // Составной модуль

            // Act
            _view.TriggerCalculateDivide();

            // Assert
            Assert.IsNotNull(_view.LastErrorMessage);
            Assert.AreEqual("Деление доступно только для простых оснований", _view.LastErrorMessage);
        }

        [TestMethod]
        public void InvalidInput_ShowsError()
        {
            // Arrange
            _view.ModNumberA = "not a number";
            _view.ModNumberB = "5";
            _view.ModNumberN = "7";

            // Act
            _view.TriggerCalculateSum();

            // Assert
            Assert.IsNotNull(_view.LastErrorMessage);
        }

        [TestMethod]
        public void EmptyInput_ShowsError()
        {
            // Arrange
            _view.ModNumberA = "";
            _view.ModNumberB = "5";
            _view.ModNumberN = "7";

            // Act
            _view.TriggerCalculateSum();

            // Assert
            Assert.IsNotNull(_view.LastErrorMessage);
        }

        [TestMethod]
        public void ZeroModulus_ShowsError()
        {
            // Arrange
            _view.ModNumberA = "4";
            _view.ModNumberB = "3";
            _view.ModNumberN = "0";

            // Act
            _view.TriggerCalculateSum();

            // Assert
            Assert.IsNotNull(_view.LastErrorMessage);
        }
    }
}