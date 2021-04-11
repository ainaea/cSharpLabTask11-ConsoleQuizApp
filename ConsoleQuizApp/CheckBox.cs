using System.Collections.Generic;

namespace ConsoleQuizApp
{
    public class CheckBox : Question
    {
        // private List<int> rightAnswer;
        public List<string> Options { get; private set; }
                
        public CheckBox(string question, List<string> options, string answer) : base(question, answer)
        {
            Options = options;            
            // RightAnswer = answer;
        }

        // public  List<int> RightAnswer
        // {
        //     get { return rightAnswer; }
        //     private set {
        //         if (value is List<int>)
        //         {
        //             rightAnswer = value;
        //         }
        //         else
        //         {
        //             throw new System.ArgumentOutOfRangeException();
        //         }
        //     }
        // }
        public override bool CheckAnswer( string response)
        {
            if (response.Length == RightAnswer.Length)
            {
                foreach (char each in RightAnswer)
                {
                    // System.Console.WriteLine(response.Contains(each)); AC vs BA
                    if (!response.Contains(each))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
            // return response.Length == RightAnswer.Length;
        }

        public override string ToString()
        {
            int i = 0;
            string stringedOptions = "";
            foreach (var str in Options)
            {
                stringedOptions += $"({(Choices) i++}) {str}\n" ;
            }
            return $"{Questn}\nChoose all correct options from:\n{stringedOptions}";
        }
    }
}