using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
     int choice=666666666;
        while (choice != 0)
        {
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Hello please choose the solution that you wish to see!");
            Console.WriteLine("1. IsPalindrome , 2. RomanToInt");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 0:
                    Console.WriteLine("Goodbye!");
                    break;
                case 1:
                    Console.WriteLine("Please enter the number that you wish to verify is a palindrome ");
                    int palindrome;
                    palindrome = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"The result is : {IsPalindrome(palindrome)}");
                    break;
                case 2:
                    Console.WriteLine("Please enter the Roman numeral:");
                    string roman = Console.ReadLine();
                    Console.WriteLine($"The integer value is: {RomanToInt(roman)}");
                    break;
            }
        }
    }

    
    public static int RomanToInt(string s)
    {
        int sum = 0;
        for (int i = 0; i < s.Length; i++)
        {
            int nbr = 0;
            switch (s[i])
            {
                case 'I':
                    if (i + 1 < s.Length && (s[i + 1] == 'V' || s[i + 1] == 'X'))
                    {
                        nbr = -1;
                    }
                    else
                    {
                        nbr = 1;
                    }
                    break;
                case 'V':
                    nbr = 5;
                    break;
                case 'X':
                    if (i + 1 < s.Length && (s[i + 1] == 'L' || s[i + 1] == 'C'))
                    {
                        nbr = -10;
                    }
                    else
                    {
                        nbr = 10;
                    }
                    break;
                case 'L':
                    nbr = 50;
                    break;
                case 'C':
                    if (i + 1 < s.Length && (s[i + 1] == 'D' || s[i + 1] == 'M'))
                    {
                        nbr = -100;
                    }
                    else
                    {
                        nbr = 100;
                    }
                    break;
                case 'D':
                    nbr = 500;
                    break;
                case 'M':
                    nbr = 1000;
                    break;
            }
            sum += nbr;
        }
        return sum;
    }

    public static bool IsPalindrome(int x)
    {
        int nombreinverse = 0;
        bool answer;
        int temp = x;
        while (x > 0)
        {
            int reste = x % 10;
            nombreinverse = nombreinverse * 10 + reste;
            x /= 10;
        }
        if (temp == nombreinverse)
        {
            answer = true;
        }
        else
            answer = false;
        return answer;
    }
}
