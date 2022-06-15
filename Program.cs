
//GPA Calc
//Prompt user for total points
//Prompt user for total hours
//Display GPA

//String
String FirstName;
Console.WriteLine("Enter in your first name");
FirstName = Console.ReadLine();


//double
double totalPoints = 0.0;
Console.WriteLine("Enter in your total points");
totalPoints = double.Parse(Console.ReadLine());

double totalHours = 0.0;
Console.WriteLine("Enter in your total hours");
totalHours = double.Parse(Console.ReadLine());

double GPA;


//Process
GPA = totalPoints/totalHours;

//Output
Console.WriteLine(FirstName +'\t'+ GPA);


