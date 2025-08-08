//ForLoopEx();


//static void ForLoopEx()
//{
//    Console.WriteLine("enter number");
//    int n = Convert.ToInt32(Console.ReadLine());
//    int count = 0;

//    for (int i = 1; i <= n; i++)
//    {
//        if (i % 2 == 0)
//        {
//            count++;

//        }
//        else
//        {
//            return;
//        }
        
//    }
//    Console.WriteLine($"Number of even numbers till {n} are {count}");

//}

//static void WhileLoopEx()
//{
//    Console.WriteLine("enter number");
//    int n = Convert.ToInt32(Console.ReadLine());
//    int count = 0;
//    int i = 1;
//    while (i <= n)
//    {
//        if (i % 2 == 0)
//        {
//            count++;
//        }
//        i++;
//    }
//    Console.WriteLine($"Number of even numbers till {n} are {count}");

//}

//WhileLoopEx();

//static void DoWhileLoopEx()
//{
//    Console.WriteLine("enter number");
//    int n = Convert.ToInt32(Console.ReadLine());
//    int count = 0;
//    int i = 1;
//    do
//    {
//        if (i % 2 == 0)
//        {
//            count++;
//        }
//        i++;
//    } while (i <= n);
    
//    Console.WriteLine($"Number of even numbers till {n} are {count}");
//}

//DoWhileLoopEx();


Console.WriteLine("Enter the student name:");
string name = Console.ReadLine();
int [] a = new int[5];
Console.WriteLine("Enter marks of the Student of 5 subjects:");
for(int i = 0; i < 5; i++)
{
    Console.WriteLine($"Enter marks for subject {i+1}:");
    a[i]=Convert.ToInt32(Console.ReadLine());

}
Console.WriteLine($"Student {name}");
for(int i = 0; i <5; i++)
{
    Console.WriteLine($"Marks for subject {i+1}: {a[i]}");
}
int total = 0;
for (int i=0; i < 5; i++)
{

    total = total + a[i];
}
double avg= (total / 5);
Console.WriteLine($"total marks {total}");
Console.WriteLine($"Average marks {avg}");

int[,] twoDArays = new int[3, 3]
{
    {1,2,3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};

for (int i = 0; i < twoDArays.GetLength(0); i++)
{
    for (int j = 0; j < twoDArays.GetLength(1); j++)
    {
        Console.Write(twoDArays[i, j] + " ");
    }
    Console.WriteLine();
}