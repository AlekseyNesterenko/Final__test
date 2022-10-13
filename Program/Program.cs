/* Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меные либо равна 3 символа. ПервоначальныЙ массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.
*/

string[] array = new string[7];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите значения элемента массива: ");
    array[i] = Console.ReadLine();
    if(string.IsNullOrWhiteSpace(array[i])) throw new Exception();
}
Console.Write("Исходный массив из 7 элементов: ");
PrintArray(array);

Console.WriteLine();
string[] newArray = RemoveLongEl(array);
Console.Write($"Полученыый массив из {newArray.Length} элементов, где менее 4х символов : ");
PrintArray(newArray);
