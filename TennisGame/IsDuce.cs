﻿namespace TennisGames
{
    internal class IsDuce : IScoreChain
    {
        private IScoreChain Next;

        public void SendRequest(ScoreRequest request)
        {

            if (request.P1.Score > 3 && request.P2.Score > 3 && request.P1.Score == request.P2.Score)
            {
                request.ScoreText = $"Duce";
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



