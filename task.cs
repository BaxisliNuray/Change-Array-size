



bool flag = true;
int increment = 0;
Console.WriteLine("Please enter the size of the array");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[sizeArray];
do
{
    Console.WriteLine("Do you want to continue? ");
    string answer = Console.ReadLine();
    int element = Convert.ToInt32(Console.ReadLine());
    if (answer == "y" || answer == "Y")
    {
    Console.WriteLine("Enter element ");
    Console.WriteLine(element);
    numbers[increment] = Convert.ToInt32(Console.ReadLine());
    numbers[increment] = element;
    increment++;
    }
    else if(answer == "no")
    {

        flag = false;
        Console.WriteLine(".......exiting");
        break;
    }

} while (flag);
