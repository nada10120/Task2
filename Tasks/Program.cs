namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            bool cont = true;
            int sum=0;
            int avg = 0;
            while (cont)
            {
                

                Console.WriteLine("Hello There Please select an action  \n  P - Print numbers \n A- Add numbers \n F - find number \n M - Display Mean of numbers \n S- Display the smallest \n L - Display thr Largest num \n Q-Quit ");
                char opt = char.Parse(Console.ReadLine());
                switch (opt)
                {
                    case 'a':
                    case 'A':
                        Console.WriteLine("Enter the number you want to add:");
                        int num = int.Parse(Console.ReadLine());

                        if (numbers.Count == 0)
                        {
                            numbers.Add(num);
                            Console.WriteLine("The number has been added at the position of 0.");
                        }
                        else
                        {
                            bool check = false;
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] == num)
                                {
                                    Console.WriteLine("The number you entered already exists.");
                                    check = true; 
                                    break; 
                                }
                            }
                            if (!check)
                            {
                                numbers.Add(num);
                                Console.WriteLine($"The number is added at the position of { numbers.Count - 1}"); 
                            }
                            
                           
                        }
                        break;

                    case 'p':
                    case 'P':
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("the List is empty");
                        }
                        else
                        {
                            Console.Write("[ ");
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                
                                Console.Write(" "+numbers[i]+ ',');
                                
                            }
                            Console.Write(" ]");
                        }
                        break;
                    case 'f':
                    case 'F':
                        Console.WriteLine("Enter The number you want to find");
                        int snum =int.Parse(Console.ReadLine());
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] ==snum)
                            {
                                Console.WriteLine($"found your num and it's in the position of {i}");
                                break;
                            }
                            else if (numbers[i] != snum && i == numbers.Count-1)
                            {
                                Console.WriteLine("this num doesn't exist ");
                            }
                        }

                        break;
                    case 'm':
                    case 'M':
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            sum = sum + numbers[i];
                            avg = sum / numbers.Count;
                        }
                        Console.WriteLine("The mean of the numbers in the list is"+avg);
                        break;
                    case 's':
                    case 'S':
                        int small = numbers[0];

                        for (int i = 0;i < numbers.Count; i++)
                        {
                            if (numbers[i] < small) { 
                                small = numbers[i];
                            }
                        }
                        Console.WriteLine("The smallest number in this list is"+small);
                        break;

                    case 'l':
                    case 'L':
                        int big = numbers[0];

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] > big)
                            {
                                big = numbers[i];
                            }
                        }
                        Console.WriteLine("the Largest number in this list is"+big);
                        break;
                    case 'q':
                    case 'Q':
                        cont = false;
                        Console.WriteLine("Thank you for your time");
                        break;
                    




                }
            }



        }
    }
}
