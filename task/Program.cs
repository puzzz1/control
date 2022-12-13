/*Задача: Написать программу, которая из имеющегося 
массива строк формирует новый массив из строк,
 длина которых меньше, либо равна 3 символам. 
 Первоначальный массив можно ввести с клавиатуры,
  либо задать на старте выполнения алгоритма. 
  При решении не рекомендуется пользоваться 
  коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */


void UserArray(string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($" Введите {i} ");
        array[i] = Convert.ToString(Console.ReadLine());
    }

}
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.Write("]");
}

void ResultArray (string [] array)
{
       Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
      
        if (array[i].Length <=3)
        {
            Console.Write($"{array[i]}");
            if (i< array[i].Length -1)
            {
                Console.Write(", ");
            }
        }
    }
    Console.Write("]");
}

Console.Write(" ВВедите количество элементов массива ");
int a = Convert.ToInt32(Console.ReadLine());
string [] newarray = new string [a];
UserArray(newarray);
Console.WriteLine (" Ваш массив - ");
PrintArray(newarray);
Console.WriteLine ();
Console.WriteLine (" Получился - ");
ResultArray(newarray);