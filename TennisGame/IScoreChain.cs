namespace TennisGames
{
    public interface IScoreChain
    {
        void SetNext(IScoreChain nextScore);
        void SendRequest(ScoreRequest score);
    }

}



