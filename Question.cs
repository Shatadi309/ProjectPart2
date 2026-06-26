namespace Project_Part2
{//start of namespace
    public class Question
    {//start of class

        //getters and setters to user's answers and store them
        public string QuestionText { get; set; }

        public string[] Options { get; set; }

        public string CorrectAnswer { get; set; }

        public string CorrectFeedback { get; set; }

        public string IncorrectFeedback { get; set; }

        public bool IsTrueFalse { get; set; }

    }//end of class
}//end of namespace