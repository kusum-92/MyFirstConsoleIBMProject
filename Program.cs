using MyFirstConsoleIBMProject;

static void PersonDetails()
{
    Console.WriteLine("Please enter your name:");
    string name = Console.ReadLine();
    //Console.WriteLine($"Hello, {name}!");

    Console.WriteLine("Please enter your city:");
    string city = Console.ReadLine();
    //Console.WriteLine($"Hello, {name} from {city}!");

    Console.WriteLine("Please enter your age:");
    //int age = Console.ReadLine() != null ? int.Parse(Console.ReadLine()) : 0;
    int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Hello, {name} from {city}, you are {age} years old!");
}

static string CalculationDemo()
{
    Calculator calculator = new Calculator();
    Console.WriteLine("Enter first number:");
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter second number:");
    int secondNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Choose an operation: +, -, *, /");
    string operation = Console.ReadLine();
    int result = 0;
    switch (operation)
    {
        case "+":
            result = calculator.Add(firstNumber, secondNumber);
            break;
        case "-":
            result = calculator.Subtract(firstNumber, secondNumber);
            break;
        case "*":
            result = calculator.Multiply(firstNumber, secondNumber);
            break;
        case "/":
            try
            {
                result = calculator.Division(firstNumber, secondNumber);
            }
            catch (DivideByZeroException ex)
            {
                // Console.WriteLine(ex.Message);
                // return ; // Exit the program if division by zero occurs
                return ex.Message;
            }
            break;
        default:
            // Console.WriteLine("Invalid operation.");
            return $"Invalid Operation";  // Exit the program if an invalid operation is entered
    }

    string endresult = $"The result of {firstNumber} {operation} {secondNumber} is: {result}";
    return endresult;

    // Console.WriteLine($"The result of {firstNumber} {operation} {secondNumber} is: {result}");
}


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


//using MyFirstConsoleIBMProject;

//Console.WriteLine("Enter the student name:");
//string name = Console.ReadLine();
//int [] a = new int[5];
//Console.WriteLine("Enter marks of the Student of 5 subjects:");
//for(int i = 0; i < 5; i++)
//{
//    Console.WriteLine($"Enter marks for subject {i+1}:");
//    a[i]=Convert.ToInt32(Console.ReadLine());

//}
//Console.WriteLine($"Student {name}");
//for(int i = 0; i <5; i++)
//{
//    Console.WriteLine($"Marks for subject {i+1}: {a[i]}");
//}
//int total = 0;
//for (int i=0; i < 5; i++)
//{

//    total = total + a[i];
//}
//double avg= (total / 5);
//Console.WriteLine($"total marks {total}");
//Console.WriteLine($"Average marks {avg}");

//int[,] twoDArays = new int[3, 3]
//{
//    {1,2,3 },
//    { 4, 5, 6 },
//    { 7, 8, 9 }
//};

//for (int i = 0; i < twoDArays.GetLength(0); i++)
//{
//    for (int j = 0; j < twoDArays.GetLength(1); j++)
//    {
//        Console.Write(twoDArays[i, j] + " ");
//    }
//    Console.WriteLine();
//}


Product product = new Product();
Console.WriteLine("enter number of products");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"\nEnter details for product {i + 1}:");
    Console.WriteLine("Enter the product name:");
    product.ProductName = Console.ReadLine();
    Console.WriteLine("Enter product price");
    product.ProductPrice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("enter product quantity");
    product.ProductQuantity = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Choose an Option:\n" +
        "1. Display Product details\n"
        + "2. Calculate Total Price\n"
        + "3. Apply Discount\n" +
        "4. Check Stock\n" +
        "5. Restock Product\n" + "" +
        "6. Update the price\n" + "7. Sell Product\n");

    int ch = Convert.ToInt32(Console.ReadLine());
    switch (ch)
    {
        case 1: product.DisplayProductDetails(); break;
        case 2: Console.WriteLine($"\nTotal Price: {product.CalculateTotalPrice()}"); break;
        case 3:
            Console.WriteLine("\nEnter discount percentage:");
            double discountPercentage = Convert.ToDouble(Console.ReadLine()); break;
        case 4:
            Console.WriteLine("\nIs the product in stock?");
            if (product.IsInStock())
            {
                Console.WriteLine("Product is in stock.");
            }
            else
            {
                Console.WriteLine("Product is out of stock.");
            }
            break;

        case 5: 
            Console.WriteLine("\nEnter quantity to restock");

            product.Restock(Convert.ToInt32(Console.ReadLine()));break;
        case 6:
            Console.WriteLine("\nenter updated price:");
            product.UpdatePrice(Convert.ToInt32(Console.ReadLine())); break;
        case 7:
            Console.WriteLine("\nEnter the quantity to sell:");
            product.SellProduct(Convert.ToInt32(Console.ReadLine()));break;      


        default:
            Console.WriteLine("Invalid Choice");
            return;


    }
    Console.WriteLine("If you want to continue press \"y\" or any other key to exit");
    if (Console.ReadLine().ToLower() == "y")
    {
        continue;
    }
    else
    {
        break;


    }
}//Console.WriteLine("Enter the product name:");
//product.ProductName = Console.ReadLine();
//Console.WriteLine("Enter product price");
//product.ProductPrice = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("enter product quantity");
//product.ProductQuantity= Convert.ToInt32(Console.ReadLine());

//product.DisplayProductDetails();
//Console.WriteLine($"\nTotal Price: {product.CalculateTotalPrice()}");
//Console.WriteLine("\nEnter discount percentage:");
//double discountPercentage = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine($"Discounted Price:{product.ApplyDiscount(discountPercentage)}");
//Console.WriteLine("\nIs the product in stock?");
//if (product.IsInStock())
//{
//    Console.WriteLine("Product is in stock.");
//}
//else
//{
//    Console.WriteLine("Product is out of stock.");
//}

////product.IsInStock() ? Console.WriteLine("Product is in stock") : Console.WriteLine("Product is not in stock")
////;
//Console.WriteLine("\nEnter quantity to restock");

//product.Restock(Convert.ToInt32(Console.ReadLine()));
//Console.WriteLine("\nenter updated price:");

//product.UpdatePrice(Convert.ToInt32(Console.ReadLine()));

//Console.WriteLine("\nEnter the quantity to sell:");
//product.SellProduct(Convert.ToInt32(Console.ReadLine()));

