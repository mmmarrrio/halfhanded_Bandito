using System;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Transactions;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace zhidocazich
{
    class gambling
    {
        static void Main(string[] args)
        {
            int[] s = [1, 2, 3, 4, 5, 6, 7, 8, 9];
            Random rnd = new Random();
            Console.WriteLine("do u wanna some gumble?) (Y or N for dumbass like you asshole)");
            string Z = Console.ReadLine();
            if (Z == "Y")
            {
                Console.WriteLine("Now enter you'r amount of money");
                ulong B = ulong.Parse(Console.ReadLine());
                if (B == 0)
                {
                    Console.WriteLine("get the fuck out outa here you fckn bun");
                }
                else
                {
                    while (B > 0)
                    {

                        Console.WriteLine("now enter ur bid");
                        ulong I = ulong.Parse(Console.ReadLine());
                        if (I > B){ Console.WriteLine("you don't have enough money acoustic monkey"); return; }
                        else if (I == B) { Console.WriteLine("you're risky guy, i like it"); }
                        Console.WriteLine("i've almost forgot, how many spins do you need?");
                        ulong Q = ulong.Parse(Console.ReadLine());
                        ulong J = Q * I;
                        if (J > B) { Console.WriteLine("ayo lil bro, chillout, you didn't have enought money for this burrito gamblitto!"); return;}
                        else if (J == B) { Console.WriteLine("you're risky guy, i like it"); }
                        Console.WriteLine("let's start GAMBLING!!!");
                        for (;Q > 0;) 
                        {
                        int S = s[rnd.Next(1, 9)];
                        int V = s[rnd.Next(1, 9)];
                        int O = s[rnd.Next(1, 9)];
                            if (S == 7 && V == 7 && O == 7)
                            {
                                    I = I * 100;
                                    ulong B1 = B + I;
                                    Console.WriteLine("YOU CATCHED JACKPOT!!!");
                            }
                            else if (S == V && V == O)
                            {
                                    I = I * 10;
                                    ulong B2 = B + I;
                                    Console.WriteLine("you-ve got many money!");
                            }
                            else
                            {
                                    Console.WriteLine("you-ve got zero");
                                    ulong B3 = B - I;
                            }
                            if (B <= 0)
                            {
                                    Console.WriteLine("you've been lost all ur money, now get ta fck outa here you silly bun, come back when you'll get some of them");
                                    return;
                            }
                            Q--;
                            if (Q == 0)
                            {
                                Console.WriteLine("wanna check ur balance?");
                                string F = Console.ReadLine();
                                if (F == "Y")
                                {
                                    Console.WriteLine(B);
                                }
                                else if (F == "N")
                                {

                                }
                                else
                                {
                                    Console.WriteLine("Y or N you stupid nigger");
                                }
                                Console.WriteLine("wanna do it again?");
                                string m = Console.ReadLine();
                                if (m == "Y")
                                {
                                    Console.WriteLine("Let's pawn our home in this casino!");

                                }
                                else if (m == "N")
                                {
                                    return;
                                }
                            }
                        }
                    }
                }
            }
            else if (Z == "N")
            {
                Console.WriteLine("then tell me, you, not good man, what the reason of your starting this program? actually i don't care just leave");
                return;
            }

        }
    }
}
//ставка == дом == видосик (у тебя больше нет дома, твой дом спиздили евреи в своё еврейское логово!!!)