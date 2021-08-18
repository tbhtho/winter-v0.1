using System;
using System.Diagnostics;
using System.Threading;


namespace winter_v0._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string serial;
            string option1;

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("+");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("]");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(" winter ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(": marcel");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("#");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("3499 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ");
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("+");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Enter Serial");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ");
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("->");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("] ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            serial = Console.ReadLine();
            if (serial == "1")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" ");
                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("+");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Valid Serial!");
                Console.WriteLine(" ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("1");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
                Console.Write(" Run Cheat...");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" ");
                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("2");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
                Console.WriteLine(" Exit Loader...");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" ");
                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("->");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("] ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                option1 = Console.ReadLine();
                if (option1 == "1")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" ");
                    Console.Write("[");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("+");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("]");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" Running Cheat...");
                    Process[] pname = Process.GetProcessesByName("notepad");
                    if (pname.Length > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(" ");
                        Console.Write("[");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("-");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("]");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Apex Is Running, Ending Process");
                        foreach (Process proc in Process.GetProcessesByName("notepad"))
                        {
                            proc.Kill();
                            Console.WriteLine(" ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("[");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write("+");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("]");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(" Apex Has Been Ended Successfully, Please reload the game");
                            Thread.Sleep(10000);
                            Console.WriteLine(" ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("[");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("+");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("]");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(" Apex Attached");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("[");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write("+");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("]");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(" Loading Modules...");
                            Process.Start("C:/Users/marce/Downloads/men/winter v0.2 menu.exe");
                            int frequency = 300;

                            // Set the Duration
                            int duration = 500;

                            // Play beep sound once
                            Console.Beep(frequency, duration);
                            for (int i = 0; i < 100; i++)
                            {
                                Console.WriteLine(" ");
                                Console.Write("[");
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.Write("+");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("]");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine(" After 60 Seconds The Loader Will Close");
                                Thread.Sleep(500);
                            }
                            Thread.Sleep(60000);
                            
                        }

                    }
                    else

                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(" ");
                        Console.Write("[");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write("+");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("]");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(" Please Launch Apex!");
                        Thread.Sleep(10000);
                        Process[] fname = Process.GetProcessesByName("notepad");
                        if (fname.Length > 0)
                        {

                            Console.WriteLine(" ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("[");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("+");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("]");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(" Apex Attached");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("[");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write("+");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("]");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(" Loading Modules...");
                            Process.Start("C:/Users/marce/Downloads/men/winter v0.2 menu.exe");
                            int frequency = 800;

                            // Set the Duration
                            int duration = 200;

                            // Play beep sound once
                            Console.Beep(frequency, duration);

                            for (int i = 0; i < 100; i++)
                            {
                                Console.WriteLine(" ");
                                Console.Write("[");
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.Write("+");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("]");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine(" After 60 Seconds The Loader Will Close");
                                Thread.Sleep(500);
                            }
                           
                            Thread.Sleep(60000);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("[");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write("+");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("]");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(" Game Still Hasnt Been Launch Resetting The Process..");
                            Thread.Sleep(5000);

                        }


                    }


                }
                else if (option1 == "2")
                {


                    Console.WriteLine(" ");
                    Console.Write("[");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("-");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("]");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" Ending Loader Process");
                }
                else
                {

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" ");
                    Console.Write("[");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("-");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("]");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Invalid Input");

                }



            }
            else
            {

                Console.WriteLine(" ");
                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("-");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Invalid Serial");


            }
        }
    }
}
