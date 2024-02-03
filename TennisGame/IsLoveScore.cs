namespace TennisGames
{
    internal class IsLoveScore : IScoreChain
    {
        private IScoreChain Next;

        public void SendRequest(ScoreRequest request)
        {

            if (request.P1.Score == 0 && request.P2.Score > 0)
            {
                request.ScoreText = $"Love {ScoreMapper.MapScore(request.P1.Score)}";
                request.Success = true;
                return;
            }

            if (request.P1.Score > 0 && request.P2.Score == 0)
            {
                request.ScoreText = $"{ScoreMapper.MapScore(request.P1.Score)} Love";
                request.Success = true;
                return;
            }

            if (Next != null)
                Next.SendRequest(request);
        }

        public void SetNext(IScoreChain nextScore)
        {
            this.Next = nextScore;
        }
    }

}



