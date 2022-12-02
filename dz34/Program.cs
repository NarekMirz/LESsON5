

System.Console.WriteLine("Введите количество элементов в массиве ");
int currentElements;
currentElements = int.Parse(Console.ReadLine() ?? "");
int[]myArray = new int [currentElements];
Random rand = new Random();
int chetNum = 0;

for(int i = 0; i < myArray.Length; i++)
{
    myArray[i] = rand.Next(100,1000);
    System.Console.WriteLine(myArray[i] + " ");
}
for(int i = 0 ; i < myArray.Length; i++)
{
    if(myArray[i] % 2 == 0)
        chetNum++;
}
System.Console.WriteLine("Количество чётных чисел в массиве: " + chetNum);