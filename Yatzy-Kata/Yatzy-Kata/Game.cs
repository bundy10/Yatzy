using Yatzy_Kata.Interfaces;

namespace Yatzy_Kata;

public class Game
{
    private readonly IPlayer[] _players;

    public Game(IEnumerable<IPlayer> players)
    {
        _players = players.ToArray();
    }

    public void PlayGame()
    {
        _players.All(player => player.PlayAgain());
    }
}