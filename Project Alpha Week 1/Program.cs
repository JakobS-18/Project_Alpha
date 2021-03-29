using System;


namespace Project_Alpha_Week_1
{
    class Program
    {
        static void Main(string[] args)
        {
            { 
                
                //int number, sum = 0, m;
                //Console.WriteLine("Enter a Whole Number");
                //number = Convert.ToInt32(Console.ReadLine());
                //while (number > 0)
                //{
                //    m = number % 10;
                //    sum = sum - m;
                //    number = number / 10;
                //}
                //Console.WriteLine("sum is = {0}", sum);



                int number, sum = 0, m;
                Console.WriteLine("Enter a Whole Number");
                number = Convert.ToInt32(Console.ReadLine());
                while (number >0)
                {
                    m = number % 10;
                    sum = sum + m;
                    number = number / 10;
                }
                Console.WriteLine("sum is = {0}", sum);

                        int num1;
                        int num2;
                        string operand;
                        float answer;

                       Console.Write("Please enter the first integer: ");
                        num1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Please enter an operand (+, -, /, *): ");
                        operand = Console.ReadLine();

                        Console.Write("Please enter the second integer: ");
                       num2 = Convert.ToInt32(Console.ReadLine());

                       switch (operand)
                       {

                            case "-":
                                answer = num1 - num2;
                                break;

                            case "+":
                                answer = num1 + num2;
                                break;

                            case "/":
                                answer = num1 / num2;
                                break;

                           case "*":
                                answer = num1 * num2;
                               break;

                           default:
                                answer = 0;
                               break;
                      }
                        Console.WriteLine(num1.ToString() + " " + operand + " " + num2.ToString() + " = " + answer.ToString());
                        Console.ReadLine();

                   }









                //int marks;
                //Console.WriteLine("Enter your mark");
                //marks = Convert.ToInt32(Console.ReadLine());
                //if (marks >= 95)
                //    Console.WriteLine("You have got an A+, You have aced the Exam!!!");
                //else if (marks >= 80)
                //    Console.WriteLine("You have got an B, Congrats on your results");
                //else if (marks >= 65)
                //    Console.WriteLine("You have got an C, Well Done you passed");
                //else if (marks <= 50)
                //    Console.WriteLine("You have got an D, You could've done better");







                //int number;
                //Console.WriteLine("Enter a number");
                //number = Convert.ToInt32(Console.ReadLine());
                //if (number >= 0)
                //    Console.WriteLine("{0} is an odd number", number);
                //else

                //if (number <= 0)
                //Console.WriteLine("{0} is an even number", number);





                //int Luke, David;
                //Console.WriteLine("Enter David's age");
                //David = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Enter Luke's age");
                //Luke = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine(David > Luke ?"Older by two years" : "Younger by 2 years");

                //Console.ReadKey();     


                //int number;
                //Console.WriteLine("Enter a number");
                //number = Convert.ToInt32(Console.ReadLine());
                //if (number >= 0)
                //    Console.WriteLine("Your number is Positive");
                //else

                //if (number <= 0)
                //    Console.WriteLine("Your number is Negative");



                //int Jakob, Jerome;
                //Console.WriteLine("Enter Jakob's age");
                //Jakob = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Enter Jerome's age");
                //Jerome = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine(Jakob > 18 ?"Jakob is Legal to Vote" : "Jakob is not Legal to vote");
                //Console.WriteLine(Jerome > 18 ? "Jerome is Legal to Vote" : "Jerome is not Legal to vote");
                //Console.ReadKey();



               // int Jakob, Jerome;
                //Console.WriteLine("Enter Jakob's age");
                //Jakob = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Enter Jerome's age");
                //Jerome = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine(Jakob > Jerome ? "Jakob Elder" : "Jerome Elder");


                //Console.WriteLine("Your Name");
                //Console.ReadLine();
                //Console.WriteLine("High School");
                //Console.ReadLine();
                //Console.WriteLine("Techtorium ID");
                //Console.ReadLine();
                //Console.WriteLine("Trainer Name");
                //Console.ReadLine();
                //Console.WriteLine("Contact Number");
                //Console.ReadLine();
                //Console.WriteLine("Hobbies");



                // Console.WriteLine("Confidence = 7/10");
                //Console.WriteLine("Creativity = 3/10");
                // Console.WriteLine("Resilience = 8/10");
                // Console.WriteLine("Positivity = 6/10");
                // Console.WriteLine("Hard Work  = 8/10");
                // Console.WriteLine("Confidence = 10/10");
                // Console.WriteLine("Love for Programming = 7/10");
                
                //Console.WriteLine("Day one of Techtorium was I nice relaxed day. \n All we did was play a quick game of I think it was called scategories. \n Then we tried downloading visual studios but we had to finish it out of class since the download speed was to "); 

                // Console.WriteLine("------");
                //Console.WriteLine("|    |");
                // Console.WriteLine("|    |");
                //Console.WriteLine("------");

                // Console.WriteLine("   /\\");
                //Console.WriteLine("  /  \\");
                //Console.WriteLine(" /    \\");
                //Console.WriteLine(" ------");

                //Console.WriteLine("------------     ------------    ------------");
                //Console.WriteLine("|          |     |          |    |          |");
                //Console.WriteLine("------------     ------------    ------------");

                //Console.WriteLine("          |\\");
                //Console.WriteLine("          | \\");
                //Console.WriteLine("          |   \\");
                //Console.WriteLine("          |     \\");
                //Console.WriteLine("          |_______\\");









                // int number, sum = 0, m;
                // Console.Write("Enter a Whole Number: ");
                //number = Convert.ToInt32(Console.ReadLine());
                //while (number > 0)
                //{
                //  m = number % 10;
                // sum = sum - m;
                // number = number / 10;
                // }

                // Console.Write("Sum is = {0}", sum);


                Console.ReadLine();

            }

        }


    }

            







