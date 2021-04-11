using System;
using System.Collections.Generic;

namespace ConsoleQuizApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("List<int>{1,2,3}");
            // List<string> list1 = new List<string>{"country", "city", "continent"};
            Objective sample1 = new Objective("Nigeria is ___", new List<string>{"country", "city", "continent"}, "A");
            True_False sample2 = new True_False("Nigeria is a country", "A");
            CheckBox sample3 = new CheckBox("C# has this default method", new List<string>{"ToString()", "length()", "Length", "Convert()"}, "AC");
            Quiz quiz1 = new Quiz();
            // Console.WriteLine(sample1);
            // Console.WriteLine(sample2);
            // Console.WriteLine(sample3);

            // Console.WriteLine(sample1.CheckAnswer("A"));
            // Console.WriteLine(sample2.CheckAnswer("A"));
            // Console.WriteLine(sample3.CheckAnswer("BA"));
            
            // Console.WriteLine(quiz1.CountEntry());
            // Console.WriteLine(quiz1.allQuestions);

            // quiz1.AddQuestion(sample1);
            // Console.WriteLine(quiz1.CountEntry());
            // quiz1.AddQuestion(quiz1.CreateObjectiveQuestion());

            // Console.WriteLine("Objective added, adding Checkbox next");

            // Console.WriteLine(quiz1.CountEntry());
            // quiz1.AddQuestion(quiz1.CreateCheckboxQuestion());

            // Console.WriteLine("Checkbox added, adding True_False next");

            // Console.WriteLine(quiz1.CountEntry());
            // quiz1.AddQuestion(quiz1.CreateTrueFalseQuestion());
            // // Console.WriteLine(sample3);
            // Console.WriteLine(quiz1.CountEntry());

            quiz1.Play();

            // Console.WriteLine(quiz1.allQuestions[2]);



            // Console.WriteLine(new List<string>{"country", "city", "continent"} == new List<string>{"country", "city", "continent"});


        }
    }
}
