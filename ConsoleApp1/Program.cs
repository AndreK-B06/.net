// initialize variables - graded assignments 
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

//Variable to sum their scores
int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

//statements that display the student name and the value of their summed assignment scores
// Console.WriteLine("Sophia: " + sophiaSum);
// Console.WriteLine("Nicolas: " + nicolasSum);
// Console.WriteLine("Zahirah: " + zahirahSum);
// Console.WriteLine("Jeong: " + jeongSum);

//students current scores
decimal sophiaScore = (decimal) sophiaSum / currentAssignments;
decimal nicolasScore = (decimal) nicolasSum / currentAssignments;
decimal zahirahScore = (decimal) zahirahSum / currentAssignments;
decimal jeongScore = (decimal) jeongSum / currentAssignments;

//display the score variables
Console.WriteLine("Student\t\tGrand\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA");
Console.WriteLine("Nicolas:\t" + nicolasScore + "\tB");
Console.WriteLine("Zahirah:\t" + zahirahScore + "\tB");
Console.WriteLine("Jeong:\t\t" + jeongScore + "\tA\n");

// New task
string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int gradeA = 4;
int gradeB = 3;

int curse1Grad = gradeA;
int curse2Grad = gradeB;
int curse3Grad = gradeB;
int curse4Grad = gradeB;
int curse5Grad = gradeA;

int totalCreditHours = 0;
totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;

int totalGradePoints = 0;
totalGradePoints += course1Credit * curse1Grad;
totalGradePoints += course2Credit * curse2Grad;
totalGradePoints += course3Credit * curse3Grad;
totalGradePoints += course4Credit * curse4Grad;
totalGradePoints += course5Credit * curse5Grad;

decimal gradePointAverage = (decimal) totalGradePoints/totalCreditHours;

int leadingDigit = (int) gradePointAverage;
int firstDigit = (int) (gradePointAverage * 10) % 10;
int SecondDigit = (int) (gradePointAverage * 100 ) % 10;

//Display the student grads adn credits.
Console.WriteLine($"Student: {studentName}\n");
Console.WriteLine("Course\t\t\tGrade\t\tCredit Hours");

Console.WriteLine($"{course1Name}\t\t{curse1Grad}\t\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t{curse2Grad}\t\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t{curse3Grad}\t\t{course3Credit}");
Console.WriteLine($"{course4Name}\t{curse4Grad}\t\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t{curse5Grad}\t\t{course5Credit}\n");
Console.WriteLine($"Final GPA: \t\t{leadingDigit}.{firstDigit}{SecondDigit}" );

// Array
string [] fraudulentOrderIDs  = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs [1] = "B456";
fraudulentOrderIDs [2] = "C789";