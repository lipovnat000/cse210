using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradeString = Console.ReadLine();

        int grade = int.Parse(gradeString);

        if (grade >= 90){
            if (grade % 10 < 3) {
                Console.WriteLine("Your grade is an A-");
            } else {
                Console.WriteLine("Your grade is an A");
            }
        } else if (grade >= 80){
            if (grade % 10 > 7) {
                Console.WriteLine("Your grade is a B+");
            } else if (grade % 10 < 3) {
                Console.WriteLine("Your grade is a B-");
            } else {
                Console.WriteLine("Your grade is a B");
            }
        } else if (grade >= 70){
            if (grade % 10 > 7) {
                Console.WriteLine("Your grade is a C+");
            } else if (grade % 10 < 3) {
                Console.WriteLine("Your grade is a C-");
            } else {
                Console.WriteLine("Your grade is a C");
            }
        } else if (grade >= 60){
            if (grade % 10 > 7) {
                Console.WriteLine("Your grade is a D+");
            } else if (grade % 10 < 3) {
                Console.WriteLine("Your grade is a D-");
            } else {
                Console.WriteLine("Your grade is a D");
            }
        } else {
            Console.WriteLine("Your grade is an F");
        }
    }
}