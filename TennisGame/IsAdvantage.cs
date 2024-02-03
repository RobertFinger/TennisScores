namespace TennisGames
{
    internal class Isadvantage : IScoreChain
    {
        private IScoreChain Next;

        public void SendRequest(ScoreRequest request)
        {

            if (request.P1.Score >= 4 || request.P2.Score >= 4) 
            {
                if( request.P1.Score - request.P2.Score == 1)
                {
                    request.ScoreText = $"Advantage {request.P1.Name}";
                    request.Success = true;
                    return;
                }

                if (request.P2.Score - request.P1.Score == 1)
                {
                    request.ScoreText = $"Advantage {request.P2.Name}";
                    request.Success = true;
                    return;
                }

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



