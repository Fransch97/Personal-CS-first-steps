using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_CS_first_steps
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Funziona");
            Console.Write("Sono Wirte. ");
            Console.Write("Non creo nuove righe. ");
            Console.Write("Quando mi usi occhio agli spazzi ;D. "); //comment
            //commento
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            /*
             multi line
             */

            //variabili
            //integers
            int number = 1;
            Console.WriteLine(number);

            // integers with ,
            double price = 22.11;
            Console.WriteLine(price);

            //single charachters... (solo apici singoli)
            char letter = 'A';
            Console.WriteLine(letter);

            //texts
            string text = "Ciao bello";
            Console.WriteLine(text);

            //var lets decide the programm the types
            //its possible to change in the programm life
            var myVar = 1;
            var myVar2 = "Var ";
            var myVar3 = 1.2;
            var myVar4 = 'A';

            Console.WriteLine(myVar);
            Console.WriteLine(myVar2);
            Console.WriteLine(myVar3);
            Console.WriteLine(myVar4);


            //const don't lets decide the program
            //its not possible to change 
            const int myNumber = 12334324;
            Console.WriteLine(myNumber);


            //concat tests
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("concat tests");
            Console.WriteLine(text + myVar + " <=> Ciao bello +  1 ");
            Console.WriteLine(myVar2 + text + " <=> Var +  Ciao bello ");
            Console.WriteLine(myVar3 + number + " <=>  1.2 + 1  ");
            Console.WriteLine(myVar4 + letter + " <=> 'A' + 'A'  "); // to check why
            Console.WriteLine(myVar4 + myNumber + " <=> 'A' + '12334324'  "); // to check why
            Console.WriteLine(myVar4 + text + " <=> 'A' + 'Ciao bello'  "); // ok...XD

            //Math tests
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Math");
            int a = 1;
            double b = 12323232323333333333333333333333333333333333333333333333333.32323;
            double b2 = 12783232732323989333333090865333333576578879039033333333333339090807333333333333780780780807333333333339.32323;
            double b3 = 23.32;
            int c = 1;
            const int z = 1;
            Console.WriteLine(z + a + "lalala");
            Console.WriteLine("lalala" + z + a );
            Console.WriteLine( z + a + b + c ); // had to use float 6-7 dec's
            Console.WriteLine( z + a + b2 + c ); //had to use float
            Console.WriteLine( z + a + c );
            Console.WriteLine( z + a + c + b3);


            /*
             * think to create a table--------------------------------------------------------------------------->
             * 
                int	    4 bytes	Stores whole numbers from -2,147,483,648 to 2,147,483,647
                long	8 bytes	Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
                float	4 bytes	Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
                double	8 bytes	Stores fractional numbers. Sufficient for storing 15 decimal digits
                bool	1 bit	Stores true or false values
                char	2 bytes	Stores a single character/letter, surrounded by single quotes
                string	2 bytes per character	Stores a sequence of characters, surrounded by double quotes
             */

            Console.WriteLine("");
            Console.WriteLine("");
            //changing types
            // use head and logic...
            double imDouble = 22.11;
            int imInt = (int)imDouble;
            Console.WriteLine( imInt.GetType());
            double imIntimDouble = (double) imInt;
            Console.WriteLine(imIntimDouble.GetType());
            // string imString = (string)imIntimDouble; numbers to string not possible need concat (PS: use Converter)
            string imString = "" + imIntimDouble;
            Console.WriteLine(imString.GetType());



            Console.WriteLine("");
            Console.WriteLine("");
            //converters
            Console.WriteLine(Convert.ToString(imInt));
            string imString2 = Convert.ToString(imInt);
            Console.WriteLine(imString2.GetType());
            // ATTENTION to int need .ToInt32 !


            Console.WriteLine("");
            Console.WriteLine("");
            //inputs
            string userName = Console.ReadLine();
            Console.WriteLine(userName);
            Console.WriteLine("insert name");
            userName = Console.ReadLine();
            Console.WriteLine("username: " + userName);
            Console.WriteLine("Insert youre age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("User age: ");
            int currentYear = 2022;
            int future = 2030;
            int calcBirthYear = currentYear - age;
            int calcFutureAge = future - calcBirthYear;
            Console.WriteLine("In " + future + " u will be " + calcFutureAge);


            //operators are the same i know 
            /*
             *  =	x = 5	x = 5	
                +=	x += 3	x = x + 3	
                -=	x -= 3	x = x - 3	
                *=	x *= 3	x = x * 3	
                /=	x /= 3	x = x / 3	
                %=	x %= 3	x = x % 3	
                &=	x &= 3	x = x & 3	
                |=	x |= 3	x = x | 3	
                ^=	x ^= 3	x = x ^ 3	
                >>=	x >>= 3	x = x >> 3	
                <<=	x <<= 3	x = x << 3


                Comparison always the same
                ==	Equal to	x == y	
                !=	Not equal	x != y	
                >	Greater than	x > y	
                <	Less than	x < y	
                >=	Greater than or equal to	x >= y	
                <=	Less than or equal to	x <= y
             
                logic operators always the same
                && 	Logical and	Returns true if both statements are true	x < 5 &&  x < 10	
                || 	Logical or	Returns true if one of the statements is true	x < 5 || x < 4	
                !	Logical not	Reverse the result, returns false if the result is true	!(x < 5 && x < 10)
             */


            Console.WriteLine("");
            Console.WriteLine("");
            //math methods
            Console.WriteLine(Math.Max(1, 3));//gives highes
            Console.WriteLine(Math.Min(1, 3));//gives lowest
            Console.WriteLine(Math.Min(1, 3));//gives lowest
            Console.WriteLine(Math.Sqrt(12032039));//gives divi result
            Console.WriteLine(Math.Abs(-12032039));//turns positiv
            Console.WriteLine(Math.Round(9.23));
            Console.WriteLine(Math.Round(9.93)); // rounds to nearest




            Console.WriteLine("");
            Console.WriteLine("");
            //string methods are like JS with differenece first letter is big {.Length, varName[0], .ToLower(), .ToUpper(),}
            //so will write only differences

            //template literal of C#
            string userData =   $"Username : {userName} { Environment.NewLine}" +
                                $"Userage : {age} { Environment.NewLine}" +
                                $"User future age : {calcFutureAge} {Environment.NewLine}";
            Console.WriteLine(userData);


        }
    }
}
