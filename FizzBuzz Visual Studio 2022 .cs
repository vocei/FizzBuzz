// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine(fizzBuzz());
        Thread.Sleep(1000);
        Thread.Sleep(1000);
        Thread.Sleep(1000);
        Console.WriteLine(fizzBuzz3());
        Thread.Sleep(1000);
        Thread.Sleep(1000);
        Thread.Sleep(1000);
        Console.WriteLine("That was fun, thank you and goodbye!");

        string fizzBuzz()
        {
            Console.Write("Give me a number... \nif that number is divisible by 3 you'll get 'fizz', \nif the number is divisible by 5 you'll get 'buzz', \nif your number is divisible by both you'll get 'fizzbuz', \nWhat is your number?: ");
            var x = int.Parse(Console.ReadLine());

            if (x % 3 == 0)
            {
                if (x % 5 == 0 && x % 3 == 0)
                {
                    return "fizzbuzz";
                }

                return "fizz";
            }
            if (x % 5 == 0)
            {
                if (x % 5 == 0 && x % 3 == 0)
                {
                    return "fizzbuzz";
                }

                return "buzz";
            }
            return "Is not divisible by 3 or 5!";
        }

        string fizzBuzz3()
        {
            Console.Write("Try again! whats your number?: ");
            var j = int.Parse(Console.ReadLine());

            if (j % 3 == 0)
            {
                if (j % 5 == 0 && j % 3 == 0)
                {
                    return "fizzbuzz";
                }

                return "fizz";
            }
            if (j % 5 == 0)
            {
                if (j % 5 == 0 && j % 3 == 0)
                {
                    return "fizzbuzz";
                }

                return "buzz";
            }
            return "Is not divisible by 3 or 5!";
        }
    }
}