using System;
using NUnit.Framework;

namespace DiscountCalculator.Tests
{
    public class DiscountCalculator
    {
        public int CalculateDiscount(int points)
        {
            if (points < 0)
                return 0;

            if (points >= 500)
                return 10;
            if (points >= 200)
                return 5;
            if (points >= 100)
                return 3;

            return points >= 0 ? 1 : 0;
        }
    }

    [TestFixture]
    public class DiscountCalculatorTests
    {
        private DiscountCalculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new DiscountCalculator();
        }

        [Test]
        [TestCase(-1, 0)]
        [TestCase(0, 1)]
        [TestCase(1, 1)]
        [TestCase(99, 1)]
        [TestCase(100, 3)]
        [TestCase(101, 3)]
        [TestCase(199, 3)]
        [TestCase(200, 5)]
        [TestCase(201, 5)]
        [TestCase(499, 5)]
        [TestCase(500, 10)]
        [TestCase(501, 10)]
        [TestCase(1000, 10)]
        public void CalculateDiscount_WithVariousPoints_ReturnsCorrectDiscount(int points, int expectedDiscount)
        {
            // Act
            var result = _calculator.CalculateDiscount(points);

            // Assert
            Assert.Equals(expectedDiscount, result);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Пример использования калькулятора
            var calculator = new DiscountCalculator();

            Console.WriteLine("Тестирование скидочного калькулятора");
            Console.WriteLine("-----------------------------------");

            TestCalculator(calculator, -1, 0);
            TestCalculator(calculator, 0, 1);
            TestCalculator(calculator, 100, 3);
            TestCalculator(calculator, 200, 5);
            TestCalculator(calculator, 500, 10);
            TestCalculator(calculator, 1000, 10);

            Console.WriteLine("\nВсе тесты выполнены успешно!");

            // Для ручного тестирования
            Console.WriteLine("\nВведите количество баллов для расчета скидки (или 'q' для выхода):");

            while (true)
            {
                Console.Write("> ");
                var input = Console.ReadLine();

                if (input?.ToLower() == "q")
                    break;

                if (int.TryParse(input, out var points))
                {
                    var discount = calculator.CalculateDiscount(points);
                    Console.WriteLine($"При {points} баллах скидка составляет: {discount}%");
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или 'q' для выхода.");
                }
            }
        }

        static void TestCalculator(DiscountCalculator calculator, int points, int expected)
        {
            var result = calculator.CalculateDiscount(points);
            Console.WriteLine($"{points} баллов: {result}% (ожидается {expected}%) - {(result == expected ? "OK" : "ERROR")}");
        }
    }
}