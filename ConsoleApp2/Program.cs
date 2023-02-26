using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        string[,] board = new string[3, 3];
        string input;
        string input2;
        bool isx;
        bool isnotblock;
        bool oisnotblock;
        string isdone;
        static void Main(string[] args)
        {
            
        }
        public string humanevaualatieinput(string inpu,string inpu2)
        {
            int nuberofinpu = Int32.Parse(inpu);
            int nuberofinpu2 = Int32.Parse(inpu2);
            if (isx)
            {
                board[nuberofinpu, nuberofinpu2] = "1";
            }
            if (!(isx))
            {
                board[nuberofinpu, nuberofinpu2] = "2";
            }
            return isdone = "done";
        } 
        public bool xcheackifvalidhuman(string in1,string in2)
        {
            int nuberofinpu = Int32.Parse(in1);
            int nuberofinpu2 = Int32.Parse(in2);
            if (board[nuberofinpu,nuberofinpu2] == "2")
            {
                isnotblock = false;
            }
            else
            {
                isnotblock = true;
            }
            if (board[nuberofinpu, nuberofinpu2] == "1")
            {
                isnotblock = false;
            }
            else
            {
                isnotblock = true;
            }
            return isnotblock;
        }
        public bool ocheackifvalidhuman(string in1, string in2)
        {
            int nuberofinpu = Int32.Parse(in1);
            int nuberofinpu2 = Int32.Parse(in2);
            if (board[nuberofinpu, nuberofinpu2] == "1")
            {
                isnotblock = false;
            }
            else
            {
                isnotblock = true;
            }
            if (board[nuberofinpu, nuberofinpu2] == "2")
            {
                isnotblock = false;
            }
            else
            {
                isnotblock = true;
            }
            return oisnotblock;
        }
    }
}
