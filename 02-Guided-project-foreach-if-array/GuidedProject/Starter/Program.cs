using System;

// initialize variables - graded assignments 
int examAssignments = 5;

int[] sophiaScores = { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = { 91, 91, 91, 91, 91, 91, 91 };

string[] studentNames = { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };
int[] studentScores = new int[10];

Console.WriteLine("Student\t\tGrade\n");
foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    else if (currentStudent == "Becky")
        studentScores = beckyScores;

    else if (currentStudent == "Chris")
        studentScores = chrisScores;

    else if (currentStudent == "Eric")
        studentScores = ericScores;

    else if (currentStudent == "Gregor")
        studentScores = gregorScores;

    else
        continue;

    int currentStudentSum = 0;
    decimal currentStudentScore;
    int gradedAssignments = 0;

    foreach (int score in studentScores)
    {
        if (++gradedAssignments <= examAssignments)
            currentStudentSum += score;
        else
            currentStudentSum += score / 10;
    }

    currentStudentScore = (decimal)currentStudentSum / examAssignments;

    string currentStudentLetterGrade = "";

    if (currentStudentScore >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentScore >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentScore >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentScore >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentScore >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentScore >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentScore >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentScore >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentScore >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentScore >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentScore >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentScore >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";


    Console.WriteLine($"{currentStudent}:\t\t{currentStudentScore}\t{currentStudentLetterGrade}");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();