namespace TennisGames
{
    public class ScoreRequest
    {
        public IScoreChain Next { get; set; }
        public bool Success { get; set; }

        public string ScoreText = string.Empty;

        public Player P1 { get; set; }
        public Player P2 { get; set; }
    }

}



