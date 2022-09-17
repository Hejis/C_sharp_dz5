//Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

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
            int k = 0;
            Random rnd = new Random();
 
            Console.WriteLine("Исходный массив");
            for (int i = 0; i < len; i++)
            {
                arr[i] = rnd.Next(100, 1000);
                Console.Write(" " +  arr[i]);
            }
            Console.WriteLine();
            
            foreach(int element in arr)
            {
                if (element % 2 == 0)
                {
                    k++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Количество четных элементов " + k );


            