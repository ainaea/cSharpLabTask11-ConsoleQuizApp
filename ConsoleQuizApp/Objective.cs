using System.Collections.Generic;

namespace ConsoleQuizApp
{
    public class Objective : Question
    {
        // private int rightAnswer;
        public List<string> Options { get; private set; }
                
        public Objective(string question, List<string> options, string answer) : base(question, answer)
        {
            Options = options;            
            // RightAnswer = answer;
        }

        // public int RightAnswer
        // {
        //     get { return rightAnswer; }
        //     private set {
        //         if (value >= 0 && value < Options.Count)
        //         {
        //             rightAnswer = value;
        //         }
        //         else
        //         {
        //             throw new System.ArgumentOutOfRangeException();
        //         }
        //     }
        // }
        public override bool CheckAnswer(string response)
        {   
            // int index = (int) Choices.B;
            return response == RightAnswer;
            // return Options[index] == RightAnswer
        }

        public override string ToString()
        {
            int i = 0;
            string stringedOptions = "";
            foreach (var str in Options)
            {
                stringedOptions += $"({(Choices) i++}) {str}\n" ;
            }
            return $"{Questn}\nChoose one option from:\n{stringedOptions}";
        }

    }
}