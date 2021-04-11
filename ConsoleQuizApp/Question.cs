using System.Collections.Generic;

namespace ConsoleQuizApp
{
    public abstract class Question
    {   
        private string question;
        private string rightAnswer;

        public enum Choices
        {
            A,
            B,
            C,
            D,
            E
            
        }

       // protected static List<int> response2 = new List<int>{12,10};

        public Question(string questn, string ans)
        {
            Questn = questn;
            RightAnswer = ans;
        }
        public string Questn
        {
            get { return question; }
            private set { question = value; }
        }

        public string RightAnswer
        {
            get { return rightAnswer; }
            private set { rightAnswer = value; }
        }
        
        public abstract bool CheckAnswer(string response);
        // public abstract bool CheckAnswer();

    }
}