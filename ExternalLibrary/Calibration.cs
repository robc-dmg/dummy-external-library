namespace ExternalLibrary
{
    public class Calibration
    {
        public bool IsLoaded { get; set; } //this may just be a status that exists within the Studio while running
        public bool IsCompleted { get; set; } //this may be a status that exists within the Studio while running
        public int NumberOfIterations { get; set; }
        public double FitIndex { get; set; }
        public List<ItemCalibrationResult> ItemResults { get; set; } = new List<ItemCalibrationResult>();

        public Calibration()
        {

        }

        public void Perform(AssessmentData pAssessmentData, CalibrationSpecifications pSpecifications)
        {

        }
    }
    public class ItemCalibrationResult
    {
        //rather than held in an object, will exist as Item Attributes?
        public int ItemId { get; set; }
        public List<Parameter> Parameters { get; set; } = new List<Parameter>(); //this will be a list of parameters
        public double FitIndex { get; set; }
        public List<Cut> Cuts { get; set; } = new List<Cut>();
        public List<IccRenderingValue> IccRenderingValues { get; set; } = new List<IccRenderingValue>();
    }
    public class Parameter
    {

    }
    public class Cut
    {
        double Theta { get; set; }
        double ICC { get; set; }
        double IIF { get; set; }
    }
    public class IccRenderingValue
    {
        double QuadratureValue { get; set; }
        double Probability { get; set; }
        double StandardError { get; set; }
    }
}