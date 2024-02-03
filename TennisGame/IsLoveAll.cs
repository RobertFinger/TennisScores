namespace TennisGames
{
    internal class IsLoveAll : IScoreChain
    {
        private IScoreChain? Next;

        public void SendRequest(ScoreRequest request)
        {

            if (request.P1.Score == 0 && request.P2.Score == 0)
            {
                request.ScoreText = "Love All";
                request.Success = true;
                return;
            }

            if(Next != null)
                Next.SendRequest(request);
        }

        public void SetNext(IScoreChain nextScore)
        {
            this.Next = nextScore;
        }
    }

}



