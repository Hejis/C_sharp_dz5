/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
 */

int Prompt(string message)
{
  Console.Write(message);
  string StringValue = Console.ReadLine() ?? "0";
  bool isNumber = int.TryParse(StringValue, out int value);
  if (isNumber)
  {
    return value;
  }
  throw new Exception("Данное значение невозможно преобразовать в число");

}

int len = Prompt("Введите длину одномерного массива: ");
int[] arr = new int[len];
            Random rnd = new Random();
 
            Console.WriteLine("Исходный массив");
            for (int i = 0; i < len; i++)
            {
                arr[i] = rnd.Next(-100, 100);
                Console.Write(" " +  arr[i]);
            }
Console.WriteLine();
 Array.Sort(arr);
 Console.WriteLine("Разница между максимальным и минимальным значениями равна " + (arr[len-1] - arr[0]));