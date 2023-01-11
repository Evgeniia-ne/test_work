//Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
//меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

Console.Clear();
Console.WriteLine("Введите массив строк через запятую: ");
string[] array;
string stroka = Console.ReadLine();
array = stroka.Split(',');
var newarray = new string[array.Length];
var i = 0;
foreach (var index in array )
{
    if (index.Length <= 3)
    {                    
        newarray[i] = index;
        i++;