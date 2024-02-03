namespace TennisGames
{
    public static class ScoreMapper
    {
        public static string? MapScore(int score)
        {
            switch (score)
            {
                case 0:
                    return "Love";
                case 1:
                    return "Fifteen";
                case 2:
                    return "Thirty";
                case 3:
                    return "Fourty";
                default:
                    return null;
            }
        }
    }

}



