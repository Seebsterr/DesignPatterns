using static System.Console;

namespace DesignPatterns.TemplateMethod
{
    public class Chess : Game
    {
        public Chess() : base(2)
        {
        }

        protected override void Start()
        {
            WriteLine($"Starting a game of chess with {_numberOfPlayers} players.");
        }

        protected override bool HaveWinner => turn == maxTurns;

        protected override void TakeTurn()
        {
            WriteLine($"Turn {turn++} taken by player {_currentPlayer}.");
            _currentPlayer = (_currentPlayer + 1) % _numberOfPlayers;
        }

        protected override int WinningPlayer => _currentPlayer;

        private readonly int maxTurns = 10;
        private int turn = 1;
    }
}