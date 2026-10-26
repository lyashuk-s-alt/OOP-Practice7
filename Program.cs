using System;

namespace Rozumatic_OOP_Practice7
{
    // ==========================================================================
    // ЗАГАЛЬНЕ ЗАВДАННЯ: КЛАС STUDENT (Статичні поля та методи)
    // ==========================================================================
    public class Student
    {
        // Приховане статичне поле-лічильник (належить усьому класу, а не окремим об'єктам)
        private static int _studentCount = 0;

        // Звичайні нестатичні властивості об'єкта
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Конструктор класу
        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            
            // Інкрементуємо лічильник при створенні кожного нового об'єкта
            _studentCount++;
        }

        // Статичний метод для отримання поточного значення лічильника
        public static int GetStudentCount()
        {
            return _studentCount;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Студент: {FirstName} {LastName}");
        }
    }

    // ==========================================================================
    // ДОМАШНЄ ЗАВДАННЯ: СТАТИЧНИЙ КЛАС MATHUTILS (Утилітарний метод)
    // ==========================================================================
    public static class MathUtils
    {
        // Статичний метод обчислення факторіала числа
        public static long Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Факторіал не визначений для від'ємних чисел!");
            }

            long result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========================================================================");
            Console.WriteLine("  РОЗУМАТИК // ПРАКТИЧНЕ ЗАНЯТТЯ №7: СТАТИЧНІ ЧЛЕНИ КЛАСУ ТА МЕТОДИ");
            Console.WriteLine("==========================================================================");

            // 1. ТЕСТУВАННЯ ЗАГАЛЬНОГО ЗАВДАННЯ (Класс Student та лічильник)
            Console.WriteLine("\n--- 1. Тестування лічильника об'єктів класу Student ---");
            Console.WriteLine($"Кількість студентів до створення об'єктів: {Student.GetStudentCount()}");

            Student s1 = new Student("Олексій", "Марченко");
            Student s2 = new Student("Тетяна", "Шевченко");
            Student s3 = new Student("Дмитро", "Коваленко");

            s1.PrintInfo();
            s2.PrintInfo();
            s3.PrintInfo();

            // Виведення фінального числа у методі Main за допомогою статичного методу
            Console.WriteLine($"\n📊 Фінальна кількість створених студентів: {Student.GetStudentCount()}");


            // 2. ТЕСТУВАННЯ ДОМАШНЬОГО ЗАВДАННЯ (Статичний клас MathUtils)
            Console.WriteLine("\n--- 2. Тестування утилітарного класу MathUtils ---");
            int num = 5;
            long factResult = MathUtils.Factorial(num);
            Console.WriteLine($"Факторіал числа {num}! дорівнює: {factResult}"); // 120

            int num2 = 6;
            Console.WriteLine($"Факторіал числа {num2}! дорівнює: {MathUtils.Factorial(num2)}"); // 720

            Console.WriteLine("\n✅ Практичне заняття №7 успішно виконано та протестовано!");
        }
    }
}
