namespace CodingChallenge;

public class GradingStudents
{
    public List<int> GradingStudentsExecution(List<int> grades)
    {
        var finalGrades = new List<int>();

        foreach (var grade in grades)
        {
            if (grade >= 38 )
            {
                var roudedGrade = RoundGrade(grade);
                finalGrades.Add(roudedGrade); 
            }
            else
            {
                finalGrades.Add(grade);
            }
        }
        
        return finalGrades;
    }

    public int RoundGrade(int grade)
    {
        var multiplier = grade / 5;
        var nextMultiplier = (multiplier + 1) * 5; 
        var difference = nextMultiplier - grade;
        
        if (difference < 3)
        {
            grade = nextMultiplier;
        }

        return grade;
    }
}