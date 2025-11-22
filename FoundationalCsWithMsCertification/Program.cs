namespace FoundationalCsWithMsCertification
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/* Project overview
				 You're developing a Student GPA Calculator that will help calculate students' overall Grade Point Average. The parameters for your application are:
				 You're given the student's name and class information.
				 Each class has a name, the student's grade, and the number of credit hours for that class.
				 Your application needs to perform basic math operations to calculate the GPA for the given student.
				 Your application needs to output/display the student’s name, class information, and GPA.
					
				 To calculate the GPA:
				 Multiply the grade value for a course by the number of credit hours for that course.
				 Do this for each course, then add these results together.
				 Divide the resulting sum by the total number of credit hours.

				 Expected Output:
				 Student: Sophia Johnson

				 Course          Grade    Credit Hours	
				 English 101         4 A      3
				 Algebra 101         3 B      3
				 Biology 101         3 B      4
				 Computer Science I  3 B      4
				 Psychology 101      4 A      3

				 Final GPA:          3.35
			 */

			string studentName = "Sophia Johnson";
			string courseName1 = "English 101";
			string courseName2 = "Algebra 101";
			string courseName3 = "Biology 101";
			string courseName4 = "Computer Science I";
			string courseName5 = "Psychology 101";

			int courseCredit1 = 3;
			int courseCredit2 = 3;
			int courseCredit3 = 4;
			int courseCredit4 = 4;
			int courseCredit5 = 3;

			int gradeA = 4;
			int gradeB = 3;

			int courseGrade1 = gradeA;
			int courseGrade2 = gradeB;
			int courseGrade3 = gradeB;
			int courseGrade4 = gradeB;
			int courseGrade5 = gradeA;

			int totalCreditHours = 0;

			totalCreditHours += courseCredit1;
			totalCreditHours += courseCredit2;
			totalCreditHours += courseCredit3;
			totalCreditHours += courseCredit4;
			totalCreditHours += courseCredit5;

			int totalGradePoints = 0;

			totalGradePoints += courseGrade1 * courseCredit1;
			totalGradePoints += courseGrade2 * courseCredit2;
			totalGradePoints += courseGrade3 * courseCredit3;
			totalGradePoints += courseGrade4 * courseCredit4;
			totalGradePoints += courseGrade5 * courseCredit5;

			decimal gradePointAverage = (decimal)totalGradePoints / totalCreditHours;

			int leadingDigit = (int)gradePointAverage;
			int firstDigit = (int)(gradePointAverage * 10) % 10;
			int secondDigit = (int)(gradePointAverage * 100) % 10;

			Console.WriteLine($"Student: {studentName}\n");
			Console.WriteLine($"Course\t\t\tGrade\tCredit Hours");

			Console.WriteLine($"{courseName1}\t\t{courseGrade1}\t{courseCredit1}");
			Console.WriteLine($"{courseName2}\t\t{courseGrade2}\t{courseCredit2}");
			Console.WriteLine($"{courseName3}		{courseGrade3}	{courseCredit3}");
			Console.WriteLine($"{courseName4}	{courseGrade4}	{courseCredit4}");
			Console.WriteLine($"{courseName5}		{courseGrade5}	{courseCredit5}");
			Console.WriteLine($"\nFinal GPA:		{leadingDigit}.{firstDigit}{secondDigit}");
		}
	}
}
