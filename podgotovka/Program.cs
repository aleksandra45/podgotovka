using System;

public class MyCustomException : Exception
{
    public MyCustomException(string message) : base(message)
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Создаем массив с пятью различными видами исключений, включая собственный тип
            Exception[] exceptions = new Exception[]
            {
                new MyCustomException("Собственный тип исключения"),
                new InvalidOperationException("Недопустимая операция"),
                new ArgumentNullException("Аргумент равен null"),
                new DivideByZeroException("Деление на ноль"),
                new IndexOutOfRangeException("Выход за пределы массива")
            };

            // Итерация по каждому типу исключения в массиве
            foreach (var exception in exceptions)
            {
                try
                {
                    // Генерируем исключение
                    throw exception;
                }
                catch (Exception ex)
                {
                    // Выводим текст исключения в консоль
                    Console.WriteLine("Текст исключения: " + ex.Message);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Произошла ошибка: " + ex.Message);
        }
    }
}