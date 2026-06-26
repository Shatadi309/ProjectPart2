using System.Collections.Generic;

namespace Project_Part2
{//start of namespace
    public class QuizManager
    {//start of class


        //list to hold all quiz questions
        private List<Question> quiz_questions = new List<Question>();

        //track current question index
        private int current_index = 0;

        //track the user's score
        private int score = 0;

        //constructor
        public QuizManager()
        {//start of constructor
            load_questions();
        }//end of constructor


        //method to load all 10 questions
        private void load_questions()
        {//start of load_questions

            //Question 1 - Multiple Choice - Phishing
            quiz_questions.Add(new Question
            {
                QuestionText = "What should you do if you receive an email asking for your password?",
                Options = new string[]
                {
                    "A) Reply with your password",
                    "B) Delete the email",
                    "C) Report the email as phishing",
                    "D) Ignore it"
                },
                CorrectAnswer = "C",
                CorrectFeedback = "Correct! Reporting phishing emails helps protect you and others from scams.",
                IncorrectFeedback = "Incorrect. You should report the email as phishing. Never reply with your password.",
                IsTrueFalse = false
            });

            //Question 2 - True or False - Passwords
            quiz_questions.Add(new Question
            {
                QuestionText = "True or False: Using the same password for multiple accounts is safe as long as it is strong.",
                Options = new string[]
                {
                    "A) True",
                    "B) False"
                },
                CorrectAnswer = "B",
                CorrectFeedback = "Correct! Reusing passwords is dangerous. If one account is breached, all accounts are at risk.",
                IncorrectFeedback = "Incorrect. Reusing passwords is unsafe. Always use a unique password for each account.",
                IsTrueFalse = true
            });

            //Question 3 - Multiple Choice - Safe Browsing
            quiz_questions.Add(new Question
            {
                QuestionText = "Which of the following is a sign of a phishing website?",
                Options = new string[]
                {
                    "A) The URL starts with https://",
                    "B) The site has a padlock icon",
                    "C) The URL is slightly misspelled e.g. amaz0n.com",
                    "D) The website loads quickly"
                },
                CorrectAnswer = "C",
                CorrectFeedback = "Correct! Attackers use lookalike domains with misspellings to trick users.",
                IncorrectFeedback = "Incorrect. A misspelled URL is the key warning sign. Always check the URL carefully.",
                IsTrueFalse = false
            });

            //Question 4 - True or False - Multi-Factor Authentication
            quiz_questions.Add(new Question
            {
                QuestionText = "True or False: Multi-factor authentication (MFA) makes your account significantly more secure.",
                Options = new string[]
                {
                    "A) True",
                    "B) False"
                },
                CorrectAnswer = "A",
                CorrectFeedback = "Correct! MFA adds an extra layer of security, making it much harder for attackers to access your account.",
                IncorrectFeedback = "Incorrect. MFA is very effective. Always enable it where possible.",
                IsTrueFalse = true
            });

            //Question 5 - Multiple Choice - Social Engineering
            quiz_questions.Add(new Question
            {
                QuestionText = "A caller claims to be from IT support and asks for your login details to fix an urgent issue. What do you do?",
                Options = new string[]
                {
                    "A) Give them your credentials since it is urgent",
                    "B) Hang up and call IT through the official number",
                    "C) Email them your password instead",
                    "D) Give only your username"
                },
                CorrectAnswer = "B",
                CorrectFeedback = "Correct! This is social engineering. Always verify by calling the official IT number.",
                IncorrectFeedback = "Incorrect. Never give credentials over the phone. Verify through official channels.",
                IsTrueFalse = false
            });

            //Question 6 - Multiple Choice - Password Safety
            quiz_questions.Add(new Question
            {
                QuestionText = "Which of the following is the strongest password?",
                Options = new string[]
                {
                    "A) password123",
                    "B) MyDog2015",
                    "C) T9mR2kLpvXq",
                    "D) qwerty"
                },
                CorrectAnswer = "C",
                CorrectFeedback = "Correct! A strong password is long, random and mixes letters, numbers and symbols.",
                IncorrectFeedback = "Incorrect. The strongest password is random, long and avoids personal details.",
                IsTrueFalse = false
            });

            //Question 7 - True or False - Safe Browsing
            quiz_questions.Add(new Question
            {
                QuestionText = "True or False: It is safe to click links in emails from unknown senders as long as you do not download files.",
                Options = new string[]
                {
                    "A) True",
                    "B) False"
                },
                CorrectAnswer = "B",
                CorrectFeedback = "Correct! Clicking a link alone can expose your device to threats. Never click suspicious links.",
                IncorrectFeedback = "Incorrect. Even clicking a link without downloading can compromise your device.",
                IsTrueFalse = true
            });

            //Question 8 - Multiple Choice - Safe Browsing
            quiz_questions.Add(new Question
            {
                QuestionText = "What does HTTPS in a website URL indicate?",
                Options = new string[]
                {
                    "A) The website is completely safe and legitimate",
                    "B) The website is government-owned",
                    "C) Data between your browser and the site is encrypted",
                    "D) The website has no malware"
                },
                CorrectAnswer = "C",
                CorrectFeedback = "Correct! HTTPS encrypts data in transit but does not guarantee the site is trustworthy.",
                IncorrectFeedback = "Incorrect. HTTPS only means data is encrypted, not that the site is safe or legitimate.",
                IsTrueFalse = false
            });

            //Question 9 - True or False - VPN and Public Wi-Fi
            quiz_questions.Add(new Question
            {
                QuestionText = "True or False: Using public Wi-Fi without a VPN puts your data at risk from attackers on the same network.",
                Options = new string[]
                {
                    "A) True",
                    "B) False"
                },
                CorrectAnswer = "A",
                CorrectFeedback = "Correct! Always use a VPN on public Wi-Fi to protect your data from interception.",
                IncorrectFeedback = "Incorrect. Public Wi-Fi is unsafe without a VPN as attackers can intercept your data.",
                IsTrueFalse = true
            });

            //Question 10 - Multiple Choice - Social Engineering
            quiz_questions.Add(new Question
            {
                QuestionText = "A pop-up appears saying your computer is infected and to call a number immediately. What do you do?",
                Options = new string[]
                {
                    "A) Call the number right away",
                    "B) Enter your credit card details to fix it",
                    "C) Close the pop-up and run a legitimate antivirus scan",
                    "D) Restart your computer then call the number"
                },
                CorrectAnswer = "C",
                CorrectFeedback = "Correct! This is a tech support scam. Close it and run a trusted antivirus scan.",
                IncorrectFeedback = "Incorrect. This is a social engineering scam. Close the pop-up and scan with a trusted antivirus.",
                IsTrueFalse = false
            });

        }//end of load_questions


        //method to get the current question
        public Question get_current_question()
        {//start
            if (current_index < quiz_questions.Count)
                return quiz_questions[current_index];
            return null;
        }//end


        //method to check the answer and return true or false
        public bool check_answer(string selected_option)
        {//start
            Question current = get_current_question();
            if (current == null) return false;

            //get the letter A, B, C or D from the selected option
            string selected_letter = selected_option.Substring(0, 1).ToUpper();

            bool is_correct = selected_letter == current.CorrectAnswer.ToUpper();

            //increment score if correct
            if (is_correct)
                score++;

            return is_correct;
        }//end


        //method to move to next question
        public void next_question()
        {//start
            current_index++;
        }//end


        //method to check if quiz is finished
        public bool is_finished()
        {//start
            return current_index >= quiz_questions.Count;
        }//end


        //method to get the current score
        public int get_score()
        {//start
            return score;
        }//end


        //method to get the total number of questions
        public int get_total()
        {//start
            return quiz_questions.Count;
        }//end


        //method to get the question number (1-based)
        public int get_question_number()
        {//start
            return current_index + 1;
        }//end


        //method to reset the quiz
        public void reset()
        {//start
            current_index = 0;
            score = 0;
        }//end


        //method to get final feedback based on score
        public string get_final_feedback(int final_score, int total)
        {//start
            if (final_score == total)
                return "Outstanding! You are a Cybersecurity Expert! Keep protecting yourself online!";
            else if (final_score >= 8)
                return "Great job! You have strong cybersecurity awareness. Keep it up!";
            else if (final_score >= 6)
                return "Good effort! You are on the right track. Review the topics you missed to stay safer online.";
            else if (final_score >= 4)
                return "Keep learning to stay safe from attackers. Review phishing, passwords and safe browsing topics.";
            else
                return "Keep learning to stay safe from attackers. Your online safety depends on understanding these concepts!";
        }//end



    }//end of class
}//end of namspace