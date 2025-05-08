namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string courseName = "TrueCoders";
            int courseLength = 5;
            char courseGrade = 'A';
            bool isCourseFun = true;
            double totalClassAverage= 3.5;
            decimal courseCost = 6500.00m;
            
            Console.WriteLine($"Course Name: {courseName}\nWeeks In Class So Far: {courseLength}\nCurrent Grade: {courseGrade}\nCohort GPA: {totalClassAverage}\nCost: ${courseCost}\nIs the Class Fun?: {isCourseFun}");
            
        }
    }
}
