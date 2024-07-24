namespace ExternalLibrary
{
    public class Drift
    {
        //Variables
        public List<DriftAnalysis> DriftAnalyses { get; set; }
        //Constructors
        public Drift()
        {
            DriftAnalyses = new List<DriftAnalysis>();
        }        
        //Methods
        public static List<DriftAnalysis> PerformDriftAnalyses()
        {
            return new List<DriftAnalysis>();
        }
        //Properties
        //Enumerations
    }

    public class DriftAnalysis
    {
        //Variables
        public DriftAnalysisType DriftAnalysisType { get; set; }
        public bool IsPerformingAnalysis { get; set;}
        public List<AnalysisCriterion> AnalysisCriteria { get; set; } 
        public List<ItemDriftResult> ItemDriftResults { get; set; } = new List<ItemDriftResult>();
        //Constructors
        public DriftAnalysis()
        {
            AnalysisCriteria = new List<AnalysisCriterion>();
            ItemDriftResults = new List<ItemDriftResult>();
        }
    }
    public class AnalysisCriterion //guessing this might be more complex - a placeholder
    {
        public string Name { get; set;} = "";
        public double Value { get; set; } 
    }
    public class ItemDriftResult
    {
        int ItemId { get; set; }
        double Value { get; set; }
        bool IsOutlier { get; set; }
    }
    public enum DriftAnalysisType
    {
        Aa,
        Bb,
        Beta,
        Delta,
        Rescore
    }
}