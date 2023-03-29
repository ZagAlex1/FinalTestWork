// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

Console.Clear();

string[] array = { "hello", "2", "world", ":-)" };
string[] arrayOne = { "1234", "1567", "-2", "computer science" };
string[] arrayTwo = { "Russia", "Denmark", "Kazan" };

ReadArray(NewArrayLessThenTreeSymbols(array,CountElementsLessThenTreeSymbols(array)));
ReadArray(NewArrayLessThenTreeSymbols(arrayOne,CountElementsLessThenTreeSymbols(arrayOne)));
ReadArray(NewArrayLessThenTreeSymbols(arrayTwo,CountElementsLessThenTreeSymbols(arrayTwo)));

string[] NewArrayLessThenTreeSymbols(string[] array, int arrayLength)
{
  string[] newArray = new string[arrayLength];
  int newArrayCount = 0;

  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= 3)
    {
      newArray[newArrayCount] = array[i];
      newArrayCount++;
    }
  }
  return newArray;
}

int CountElementsLessThenTreeSymbols(string[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= 3)
      count++;
  }
  return count;
}

void ReadArray(string[] array)
{
  System.Console.WriteLine(string.Join(" ", array));
}
