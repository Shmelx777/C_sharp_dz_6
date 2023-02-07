// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int InputNumber(string str)
{
    int number;
    string text;
    int count = 0;
    for(int i=0; i<5; i++)
    {
        Console.Write(str);
        text = Console.ReadLine();
        if(int.TryParse(text, out number))
        {
            if(number > 0){ count++; }
        }
        else System.Console.WriteLine("Не корректное число, попробуйте еще раз");
    }
    return count;
}


int number = InputNumber("Введите число: ");
System.Console.WriteLine(number);