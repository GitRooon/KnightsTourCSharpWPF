using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoonechrAssignment1_Duh
{
    class Knight
    {
        public int xPos;
        public int yPos;
        public int[] xMove = { 2, 1, -1, -2, -2, -1, 1, 2 };
        public int[] yMove = { 1, 2, 2, 1, -1, -2, -2, -1 };
        public int[,] board ={
                { 2, 3,4,4,4,4,3,2 },
                { 3,4,6,6,6,6,4,3 },
                {4,6,8,8,8,8,6,4 },
                {4,6,8,8,8,8,6,4 },
                {4,6,8,8,8,8,6,4 },
                {4,6,8,8,8,8,6,4 },
                { 3,4,6,6,6,6,4,3 },
                { 2,3,4,4,4,4,3,2 }
            };
        public int[,] movesDone =
            {
            {0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0}
        };
        public int moveNumber = 1;

        public Knight(int xPos, int yPos)
        {
            this.xPos = xPos;
            this.yPos = yPos;


        }
        public Knight(int xPos, int yPos, int[,] board)
        {
            this.xPos = xPos;
            this.yPos = yPos;
            this.board = board;

        }

        public void doMove()
        {
            this.movesDone[this.xPos, this.yPos] = this.moveNumber;
            this.moveNumber++;


            List<int> moves = this.getMoves();
            int max = moves.Count();
            int choice = new Random().Next(0, max);
            if (max > 0)
            {
                int x = moves[choice];


                int xMove = this.xMove[x];
                int yMove = this.yMove[x];

                // Console.WriteLine("Position" + this.xPos + ", " + this.yPos + " choice=" + choice + " moves x =" + xMove + " moves y = " + yMove);

                this.xPos += xMove;
                this.yPos += yMove;

                this.board[this.xPos, this.yPos] = 0;

            }
        }
        public void setxPos(int xpos)
        {
            this.xPos = xpos;
        }
        public void setyPos(int ypos)
        {
            this.yPos = ypos;
        }

        public void setBoard(int[,] boardArr)
        {
            this.board = boardArr;
        }
        public void setMoves(int[,] boardArr)
        {
            this.movesDone = boardArr;
        }

        public List<int> getMoves()
        {
            List<int> moves = new List<int>();

            int xPos = this.xPos;
            int yPos = this.yPos;
            int[,] board = this.board;
            int[] xMove = { 2, 1, -1, -2, -2, -1, 1, 2 };
            int[] yMove = { 1, 2, 2, 1, -1, -2, -2, -1 };


            for (int x = 0; x < 8; x++)
            {
                if (xPos + this.xMove[x] >= 0 && xPos + this.xMove[x] <= 7 && yPos + this.yMove[x] >= 0 && yPos 
                    + this.yMove[x] <= 7 && this.movesDone[xPos + this.xMove[x], yPos + this.yMove[x]] == 0)
                {
                    moves.Add(x);
                }


            }


            return moves;
        }

        public void moveSmart()
        {
            this.movesDone[this.xPos, this.yPos] = this.moveNumber;
            this.moveNumber++;
            List<int> thing = new List<int>();//list for multiple hueristic values
            List<int> moves = this.getMoves();
            List<int> hueristicValues = new List<int>();

            for (int i = 0; i < moves.Count(); i++)
            {
                // Console.WriteLine(moves[i]);
                int xMove = this.xMove[moves[i]];
                int yMove = this.yMove[moves[i]];
                int newPosX = this.xPos + xMove;
                int newPosY = this.yPos + yMove;


                int huer = this.board[newPosX, newPosY];
                //Console.WriteLine("hueristic " + huer);

                hueristicValues.Add(huer);


            }
            if (hueristicValues.Count() > 0)
            {
                //value minimum
                int bestChoice = hueristicValues.Min();

                for (int z = 0; z < hueristicValues.Count; z++)
                {
                    if (bestChoice == hueristicValues[z])
                    {
                        thing.Add(z);
                    }
                }
                int max = thing.Count();
                int Rand = new Random().Next(0, max);

                int choice = thing[Rand];


                //index value of ^ num
               // int bcIndex = hueristicValues.IndexOf(bestChoice);
                //Console.WriteLine("bc index"+bcIndex);
                //
                int move = moves[choice];

                this.xPos += this.xMove[move];
                this.yPos += this.yMove[move];

                this.board[this.xPos, this.yPos] = 0;



                // Console.WriteLine("Best choice =" + bestChoice + " index = " + bcIndex + " move = " + move);
            }
        }







    }
}
