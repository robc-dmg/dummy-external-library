namespace ExternalLibrary
{
    public class Scoring
    {
        //Variables
        public List<Score> Scores { get; set; } = new List<Score>();
        //Constructors

        //Methods
        public static void GetScores(List<Score> pScores, List<int> pScoreVector, List<Item> pItemList)
        {
            foreach (Score score in pScores)
            {
               score.Calculate(); 
            }
        }
        //Properties

        //Enumerations
    }
    public class Score
    {
        public double Value { get; set; }
        public ScoreType ScoreType { get; set; }

        public void Calculate() //a holder for calculation call based on ScoreType
        {
            switch (ScoreType)
            {
                default:
                    Value = 1;
                    break;
            }
        }
    }
    public enum ScoreType
    {
        EAP,
        MAP,
        PatternScoring,
        RawScore,
        Tcc
    }
}