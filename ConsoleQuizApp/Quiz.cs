using System.Collections.Generic;
using System;

namespace ConsoleQuizApp
{
    public class Quiz
    {
        public List<Question> allQuestions = new List<Question>(){new Objective("Nigeria is ___", new List<string>{"country", "city", "continent"}, "A"),   new True_False("Nigeria is a country", "A"),    new CheckBox("C# has this default method",  new List<string>{"ToString()", "length()", "Length", "Convert()"}, "AC")} ;
        private int correct;
        private int wrong;
        private enum Choices
        {
            A,
            B,
            C,
            D,
            E
            
        }

        public void Play()
        {
            while (true)
            {
                Console.WriteLine("What will you like to do?\nadd   |   play    |   score   |   quit \n");
                string response = Console.ReadLine();

                if (response == "quit")
                {
                    break;
                }

                switch (response)
                {
                    case "add":
                        //adding
                        Console.WriteLine("What type of question will you like to add?\n(A) Objective   (B) True_False   (C) CheckBox");
                        string addResponse = Console.ReadLine();

                        switch (addResponse)
                        {
                            // Question questionToAdd = new Question;
                            case "A":
                                //Objective;
                                AddQuestion(CreateObjectiveQuestion());
                                break;

                            case "B":
                                //True_False;
                                AddQuestion(CreateTrueFalseQuestion());
                                break;

                            case "C":
                                //Checkbox;
                                AddQuestion(CreateCheckboxQuestion());
                                break;
                            
                            default:
                                //error
                                Console.WriteLine($"{addResponse} is an invalid entry, try again.");
                                break;
                        }

                        break;

                    case "play":
                        //playing
                        // Console.WriteLine($"playing is involked");
                        AnswerQuestion();
                        break;

                    case "score":
                        Console.WriteLine($"You got {correct} right out of {correct + wrong} questions");
                        //scoring
                        break;
                
                    default:
                        Console.WriteLine($"{response} is an invalid entry, try again.");
                        break;
                }
                // break;
                
            }
        }
        public int CountEntry()
        {
            return allQuestions.Count;
        }

        public void AddQuestion(Question question)
        {
            allQuestions.Add(question);
            // return question;
        }
    
        public Objective CreateObjectiveQuestion()
        {
            Console.WriteLine($"Enter Question: ");
            string question = Console.ReadLine();
            List<string> allOptions = ReceiveOptions();
            // Console.Write($"Enter answer: ");
            string answer = ReceiveAnswer();
            // create OBJ;
            return new Objective(question, allOptions, answer);
        }

        public CheckBox CreateCheckboxQuestion()
        {
            Console.WriteLine($"Enter Question: ");
            string question = Console.ReadLine();
            List<string> allOptions = ReceiveOptions();
            Console.Write($"Enter answers (without separating with sign nor space): ");
            string answer = Console.ReadLine();
            // create OBJ;
            return new CheckBox(question, allOptions, answer);
        }

        public True_False CreateTrueFalseQuestion()
        {
            Console.WriteLine($"Enter Question: ");
            string question = Console.ReadLine();
            Console.WriteLine("(A) True\n(B) False");
            // Console.Write($"Enter answer: ");
            string answer = ReceiveAnswer();
            // create OBJ;
            return new True_False(question, answer);
        }

        private List<string> ReceiveOptions()
        {
            List<string> allOptions = new List<string>();

            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Enter option {(Choices) i}: ");
                string option = Console.ReadLine();
                allOptions.Add(option);                
            }
            return allOptions;
        }

        private void AnswerQuestion()
        {
            int current = correct + wrong ;
            if ( current < allQuestions.Count )
            {
                var question = allQuestions[current];
                Console.WriteLine(allQuestions[current]);
                string answer = ReceiveAnswer();
                bool status = question.CheckAnswer(answer);
                if (status)
                {
                    correct++;
                    Console.WriteLine("Correct");
                }
                else
                {
                    wrong++;
                    Console.WriteLine($"Sorry, {allQuestions[current].RightAnswer} is the right answer");
                }
                // correct++;
            }
            else
            {
                Console.WriteLine("You've exhausted all questions");
                Console.WriteLine($"You got {correct} right out of {correct + wrong} questions");
            }
        }

        private string ReceiveAnswer()
        {
            Console.Write($"Enter answer: ");
            return Console.ReadLine();
        }


    }
}