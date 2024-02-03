namespace TennisGames
{
    public class Player
    {
        public Player(string name)
        {
            Name = name;
        }
        public int Score { get; set; } = 0;
        public string Name { get; set; }

        public void Scored()
        {
            Score++;
        }

    }

}



