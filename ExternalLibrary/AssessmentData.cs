using MathNet.Numerics.LinearAlgebra;

namespace ExternalLibrary
{
    public class AssessmentData
    {
        public Matrix<int> StudentItemScores { get; set; }
        public Matrix<char> StudentItemResponses { get; set; }
        public List<Item> ItemList { get; set; }
        public List<Person> PersonList { get; set; }
        
        public AssessmentData()
        {
            StudentItemScores = Matrix<int>.Build.Dense(1,1); //ok to not instantiate during constructor or build here and rebuild at correct size later?
            StudentItemResponses = Matrix<char>.Build.Dense(1,1); //ok to not instantiate during constructor or build here and rebuild at correct size later?
            ItemList = new List<Item>();
            PersonList = new List<Person>();    
        }
    }
}
