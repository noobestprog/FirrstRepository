using System;
using System.Collections.Generic;
using System.Linq;

namespace CheckM8
{
   public  class Horse : Game{
        private static readonly Random rnd = new Random();
        private int currX;
        private int currY;
        private int nextX;
        private int nextY;


        public void MoveHorse()
        {
            Squares[0, 0] = true; // початок руху
            var moves = new List<Action>();
            moves.Add(() => Move1());
            moves.Add(() => Move2());
            moves.Add(() => Move3());
            moves.Add(() => Move4());
            moves.Add(() => Move5());
            moves.Add(() => Move6());
            moves.Add(() => Move7());
            moves.Add(() => Move8());


            //       List<Action> moves2List = Extensions.Clone(List < Action > moves);
      //      var moves2List = new List<Action>(moves); // копія списку з діями
           
            while (!moves.Any()) // поки копія списку з діями не порожня
            {
                var r = rnd.Next(moves.Count);
                moves[r].Invoke(); // зробити рандомний хід
                if (nextX <= x - 1 && nextY <= y - 1 && nextX >= 0 && nextY >= 0 &&
                    Squares[nextX, nextY] == false)
                {
                    currX = nextX;
                    currY = nextY;
                    Squares[nextX, nextY] = true;
                    Console.WriteLine("x={0} y={1}", currX, currY);
                }
                else moves.Remove(moves[r]);
            } 
            
            {
                
            }
            
        }


        #region SimpleMoves1

        /*    private void Move1(int x, int y)
            {
                currX += 2;
                currY += 1;
            }

            private void Move2(int x, int y)
            {
                currX += 2;
                currY -= 1;
            }

            private void Move3(int x, int y)
            {
                currX += 1;
                currY += 2;
            }

            private void Move4(int x, int y)
            {
                currX += 1;
                currY -= 2;
            }

            private void Move5(int x, int y)
            {
                currX -= 1;
                currY -= 2;
            }

            private void Move6(int x, int y)
            {
                currX -= 1;
                currY += 2;
            }

            private void Move7(int x, int y)
            {
                currX -= 2;
                currY += 1;
            }

            private void Move8(int x, int y)
            {
                currX -= 2;
                currY -= 1;
            } */

        #endregion

        #region SimpleMoves

        private void Move1()
        {
            nextX = currX + 2;
            nextY = currY + 1;
        }

        private void Move2()
        {
            nextX = currX + 2;
            nextY = currY - 1;
        }

        private void Move3()
        {
            nextX = currX + 1;
            nextY = currY + 2;
        }

        private void Move4()
        {
            nextX = currX + 1;
            nextY = currY - 2;
        }

        private void Move5()
        {
            nextX = currX - 1;
            nextY = currY - 2;
        }

        private void Move6()
        {
            nextX = currX - 1;
            nextY = currY + 2;
        }

        private void Move7()
        {
            nextX = currX - 2;
            nextY = currY + 1;
        }

        private void Move8()
        {
            nextX = currX - 2;
            nextY = currY - 1;
        }

        #endregion
    }
}