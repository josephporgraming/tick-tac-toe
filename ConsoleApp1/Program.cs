using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstrow = { 0, 0, 0 };
            int[] seconedrow = { 0, 0, 0 };
            int[] thridrow = {0, 0, 0 };
            //this is the tictacktoe bourd(the thing on top)
            var points = 0;
            bool isplayerx,isdone,gameover = false;
            //this is for the game loop
            int one, two, three;
            //tis is for chouseing what cloums 
            var howsturn = 0;
            Random setupforhowsturn = new Random();
            int xoro = setupforhowsturn.Next(1,2);
            string ticktacktoeline = "|";
            string tttx = "x";
            string ttto = "o";
            string inputforrow;
            string inputforcoloum;
            do
            {
                xoro = setupforhowsturn.Next(1, 2);
                if (xoro == 1)
                {
                    isplayerx = true;
                }
                else
                {
                    isplayerx = false;
                }
                if (isplayerx)
                {
                    Console.WriteLine(
                        @"
       1)#|#|#
       2)#|#|#
       3)#|#|#
what row do you whant to use?1,2,or 3?
");
                    inputforrow = Console.ReadLine();
                    if(inputforrow == "1")
                    {
                        one = 1;
                    }
                    if (inputforrow == "2")
                    {
                        two = 1;
                    }
                    if (inputforrow == "3")
                    {
                        three = 1;
                    }
                    Console.WriteLine(
                       @"
       1 2 3
       _____
       #|#|#
       #|#|#
       #|#|#
what colum do you whant to use?1,2,or 3?
");
                    inputforcoloum = Console.ReadLine();
                    if (inputforcoloum == "1")
                    {

                        if (inputforrow == "1")
                        {
                            
                        }
                        if (inputforrow == "2") { 

                        }
                        if (inputforrow == "3")
                        {

                        }
                    }
                    if (inputforcoloum == "2")
                    {
                        two = 1;
                    }
                    if (inputforcoloum == "3")
                    {
                        three = 1;
                    }
                }
                isdone = true;
            } while (!(isdone));
        }
    }
}
