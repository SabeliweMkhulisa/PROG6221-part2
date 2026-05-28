namespace assignment_two
{//start of namespace

    public class user_memory
    {//start of class

        //store the username
        private string stored_name = string.Empty;
        //store the favourite topic or interest
        private string stored_interest = string.Empty;

        public user_memory()
        {//start of constructor
        }//end of constructor

        //method to store the username
        public void store_name(string name)

        {//start of method
            stored_name = name;
        }//end of method

        //method to store a user interest or topic
        public void store_interest(string interest)
        {//start of method
            stored_interest = interest;
        }//end of method

        //method to recall everything the bot remembers about the user
        public string recall_all(string username)
        {//start of method

            string recall = string.Empty;

            if (stored_name != string.Empty)
            {//start of if
                recall += "I remember your name is " + stored_name + ". ";
            }//end of if

            if (stored_interest != string.Empty)
            {//start of if
                recall += "I also remember that you are interested in " + stored_interest + ". ";
                recall += "As someone interested in " + stored_interest + ", you might want to review your account security settings regularly.";
            }//end of if

            if (recall == string.Empty)
            {//start of if
                return "I don't have any specific details stored about you yet, " + username + ". Tell me something about yourself and I'll remember it!";
            }//end of if

            return recall;

        }//end of method

        //method to get a short summary for the memory bar
        public string get_summary()
        {//start of method

            string summary = string.Empty;

            if (stored_name != string.Empty)
            {//start of if
                summary += "Name: " + stored_name + "  ";
            }//end of if

            if (stored_interest != string.Empty)
            {//start of if
                summary += "| Interest: " + stored_interest;
            }//end of if

            if (summary == string.Empty)
            {//start of if
                return "No details stored yet.";
            }//end of if

            return summary;

        }//end of method

    }//end of class

}//end of namespace