namespace TennisGames
{
    internal class IsScoreScore : IScoreChain
    {
        private IScoreChain Next;

        public void SendRequest(ScoreRequest request)
        {

            if (request.P1.Score > 0 && request.P2.Score > 0  && request.P1.Score < 4 && request.P2.Score < 4 )
            {
                request.ScoreText = $"{ScoreMapper.MapScore(request.P1.Score)} {ScoreMapper.MapScore(request.P2.Score)}";
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



