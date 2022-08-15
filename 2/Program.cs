using System;
class LengthDemo
{

    public static void Main()
    {
        Console.WriteLine("Введите любое число:  ");
        int numbers = Convert.ToInt32(Console.ReadLine());
        char[] arr = numbers.ToString().ToCharArray();
        Console.WriteLine("Размерность массива:  ");
        Console.WriteLine(arr.Length);
        if (arr.Length > 2 && arr.Length < 10)

        {
            Console.WriteLine("Третье число массива:  ");
            var n = arr[2];
            Console.WriteLine(n);
        }


        else 
        {

            Console.WriteLine("Число не имеет третьего элемента.");
        }

    }

}