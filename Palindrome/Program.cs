// See https://aka.ms/new-console-template for more information

using System;

public class Palindrome
{
    static bool loop = true;
    public static void Main(string[] args)
    {
        TakeChoice();
    }

    public static void TakeChoice()
    {
        while (loop)
        {
            Console.WriteLine("1.Number");
            Console.WriteLine("2.String");
            Console.WriteLine("0.Exit");
            Console.WriteLine("Eneter your choice");
            int choice = int.Parse(Console.ReadLine());
            SwitchCases(choice);
        }
    }

    public static void SwitchCases (int choice){
        switch (choice) {
            case 0:
                loop = false; 
                break;

            case 1:
                Console.WriteLine("Enter your number");
                int num = int.Parse(Console.ReadLine());
                NumberPalindrome(num);
                break;

            case 2:
                Console.WriteLine("Enter your String");
                String str = Console.ReadLine();
                StringPalindrome(str);
                break;
        }
    }

    public static void NumberPalindrome(int num)
    {
        int temp = num;
        int check = 0;
        while (temp > 0) {
            check = (check * 10) + (temp % 10);
            temp /= 10;
        }
        //Console.WriteLine("check " + check);
        Console.WriteLine((num == check) ? "The given number is palindrome" : "The given number is not palindrome");
        
    }

    public static void StringPalindrome(String str)
    {
        for (int i = 0; i <= str.Length / 2; i++) { 
            if(str[i] != str[str.Length - i - 1])
            {
                Console.WriteLine("The given string is not palindrome");
                return;
            }
        }
        Console.WriteLine("The given string is a palindrome");
    }
}
