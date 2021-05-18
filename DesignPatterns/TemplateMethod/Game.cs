namespace DesignPatterns.TemplateMethod
{
    public abstract class Game
    {
        public void Run()
        {
            Start();
            while (!HaveWinner)
            {
                TakeTurn();
            }

            System.Console.WriteLine($"Player {WinningPlayer} wins.");
        }

        protected abstract void Start();
        protected abstract bool HaveWinner { get; }
        protected abstract void TakeTurn();
        protected abstract int WinningPlayer { get; }

        protected int _currentPlayer;
        protected readonly int _numberOfPlayers;

        public Game(int numberOfPlayers)
        {
            _numberOfPlayers = numberOfPlayers;
        }
    }
}