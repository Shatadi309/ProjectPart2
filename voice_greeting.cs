using System;
using System.Media;

namespace Project_Part2
{//start of namespace
    public class voice_greeting
    {//start of class

        public void greet()
        {//start of the greet method

            //replace the \bin\Debug\ from the path with botGreeting.wav
            string auto_path = AppDomain.CurrentDomain.BaseDirectory.Replace(@"bin\Debug\", @"\botGreeting.wav");

            //create an instance for the soundPlayer class
            SoundPlayer greetUser = new SoundPlayer(auto_path);

            //greeting 
            greetUser.Play();

        }//end of the greet method


    }//end of class
}//end of namespace