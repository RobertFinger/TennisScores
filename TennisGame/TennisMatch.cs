namespace TennisGames
{

    public class TennisMatch
    {

        private Player _One;
        private Player _Two;

        private IsLoveAll _LoveAll = new IsLoveAll();
        private IsDuce _IsDuce = new IsDuce();
        private IsLoveScore _LoveScore = new IsLoveScore();
        private IsScoreAll _ScoreAll = new IsScoreAll();
        private IsScoreScore _ScoreScore = new IsScoreScore();
        private IsSet _IsSet = new IsSet(); 
        private Isadvantage _IsAdvantage = new Isadvantage();


        private string scoreText = "Love Love";

        public TennisMatch(string playerOne, string playerTwo)
        {
            _One = new Player(playerOne);
            _Two = new Player(playerTwo);

            _LoveAll.SetNext(_IsDuce);
            _IsDuce.SetNext(_LoveScore); 
            _LoveScore.SetNext(_ScoreAll);
            _ScoreAll.SetNext(_ScoreScore);
            _ScoreScore.SetNext(_IsAdvantage);
            _IsAdvantage.SetNext(_IsSet);
            _IsSet.SetNext(null);
        }

        public string GetCurrentScore()
        {
            return scoreText;
        }

        public void PLayerScores(int player)
        {
            if (player == 1)
            {
                _One.Scored(); 
            }
            else
            {
                _Two.Scored();
            }
      
            SetScoreText();
        }

        private void SetScoreText()
        {
            var scoreRequest = new ScoreRequest()
            {
                P1 = _One,
                P2 = _Two,
                ScoreText = string.Empty,
                Success = false
            };

            _LoveAll.SendRequest(scoreRequest);

            scoreText = scoreRequest.ScoreText;
        }
    }

}



