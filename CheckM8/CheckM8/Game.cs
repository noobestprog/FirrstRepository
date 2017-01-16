namespace CheckM8
{
    public  class Game 
    {
        public const int x = 8;
        public const int y = 8;
        //  public const int fields = 64;
        public bool[,] Squares = new bool[x - 1, y - 1];
        private int unused_squares;

        public  void InitSquares()
        {
            for (var i = 1; i < x; i++)
            for (var j = 1; j < y; j++)
                Squares[i, j] = false;
        }

        public void PlayTheGame()
        {
            Squares[0, 0] = true;
            for (var i = 1; i < x; i++)
            for (var j = 1; j < y; j++)
                if (Squares[i, j] == false)
                    unused_squares += 1;
            while (unused_squares > 0)
                Horse.MoveHorse();
        }
    }
}