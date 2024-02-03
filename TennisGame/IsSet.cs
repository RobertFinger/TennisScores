namespace TennisGames
{
    internal class IsSet : IScoreChain
    {
        private IScoreChain Next;

        public void SendRequest(ScoreRequest request)
        {

            if (request.P1.Score >= 4 || request.P2.Score >= 4) 
            {
                if( (request.P1.Score - request.P2.Score >= 2))
                {
                    request.ScoreText = $"{request.P1.Name} wins Set";
                    request.Success = true;
                    return;
                }

                if (request.P2.Score - request.P1.Score >= 2)
                {
                    request.ScoreText = $"{request.P2.Name} wins Set";
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



