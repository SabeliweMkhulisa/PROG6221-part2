using System;
using System.Media;

namespace assignment_two
{
    public class voice_greeting
    {//start of class



        //void method to play the sound named greet
        public void greet()
        { //star of greet method


            string auto_path = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug\", @"\progrec.wav");

            //create an instance for the soundPlayer class
            SoundPlayer greetMe = new SoundPlayer(auto_path);
            //then greet
            greetMe.Play();


        }//end of greet method



    }//end of class
}//end of namespace