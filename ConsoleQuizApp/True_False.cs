using System.Collections.Generic;

namespace ConsoleQuizApp
{
    public class True_False : Question
    {
        // private int rightAnswer;
        public static List<string> Options = new List<string>{"True", "False"};
                
        public True_False(string question, string answer) : base(question, answer)
        {
            // Options = options;            
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
            return response == RightAnswer;
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