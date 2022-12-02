Console.Clear();

System.Console.WriteLine("Введите количество элементов в массиве ");
int currentElements;
currentElements = int.Parse(Console.ReadLine() ?? "");
int[]myArray = new int [currentElements];
Random rand = new Random();
int sum = 0;

for(int i = 0; i < myArray.Length; i++)
{
    
    myArray[i] = rand.Next(1,10);
    System.Console.Write(myArray[i] + " ");
}

for(int i = 0; i < myArray.Length; i++)
{
    if(myArray[i] % 2 != 0)
    {
        sum = sum + myArray[i];
        System.Console.Write("\n " + myArray[i]);
    }
}

System.Console.WriteLine("\nСумма ваших нечётных чисел = " + sum);


