// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, len] -> 19

//[-4, -6, 89, 6] -> 0

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
            int  sum = 0;
            Random rnd = new Random();
 
            Console.WriteLine("Исходный массив");
            for (int i = 0; i < len; i++)
            {
                arr[i] = rnd.Next(1, 1000);
                Console.Write(" " + arr[i]);
                if ((i + 2) % 2 == 0)
                {
                    sum += arr[i];
                }
            }
            
          
            
      
            Console.WriteLine("Cумма элементов на нечетных позициях  " + sum);
