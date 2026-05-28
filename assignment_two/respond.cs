using System.Collections;

namespace assignment_two
{//start of namespace

    public class respond
    {//start of class

        public respond(ArrayList reply, ArrayList ignore)
        {//start of constructor
            //load answers into the reply list
            answers(reply);
            //load ignore words
            words(ignore);
        }//end of constructor
//



        public void answers(ArrayList add_answers)
        {//start of method

            //greeting responses
            add_answers.Add("greeting Hello! How can I help you stay safe online today?");
            add_answers.Add("greeting I'm doing great! Ready to answer all your cybersecurity questions.");
            add_answers.Add("greeting Hi there! Ask me anything about staying safe online.");

            //purpose responses
            add_answers.Add("purpose My purpose is to educate you on how to stay safe online and guide your cybersecurity questions.");
            add_answers.Add("purpose I help users understand online safety and digital protection.");
            add_answers.Add("purpose I assist with cybersecurity awareness and safety guidance.");

            //password responses
            add_answers.Add("password Use at least 12 characters with uppercase, lowercase, numbers and symbols. Never reuse passwords.");
            add_answers.Add("password A strong password should be long and unpredictable. Try using a passphrase instead of a single word.");
            add_answers.Add("password Consider using a password manager like Bitwarden or LastPass to manage your credentials safely.");

            //phishing responses
            add_answers.Add("phishing Phishing is a scam where attackers pretend to be trusted sources to steal your information.");
            add_answers.Add("phishing Watch out for unexpected emails asking you to click links or provide personal details.");
            add_answers.Add("phishing Legitimate companies will never ask for your passwords via email. Always verify the sender.");

            //scam responses
            add_answers.Add("scam Be cautious of emails or messages asking for personal information — scammers often create urgency.");
            add_answers.Add("scam Scammers disguise themselves as trusted organisations. Always verify before responding.");
            add_answers.Add("scam If something feels too good to be true, it probably is. Report suspicious messages to authorities.");

            //privacy responses
            add_answers.Add("privacy Review your privacy settings on all social media and online accounts regularly.");
            add_answers.Add("privacy Avoid sharing sensitive personal details publicly online.");
            add_answers.Add("privacy Use encrypted messaging apps to keep your private conversations secure.");

            //malware responses
            add_answers.Add("malware Malware includes viruses, ransomware, spyware, and trojans. Install reputable antivirus software.");
            add_answers.Add("malware Never open email attachments from unknown senders — they may contain malware.");
            add_answers.Add("malware Keep your operating system and software updated to protect against malware vulnerabilities.");

            //vpn responses
            add_answers.Add("vpn A VPN encrypts your internet connection and protects you on public Wi-Fi networks.");
            add_answers.Add("vpn Never access banking or sensitive accounts on public Wi-Fi without a VPN.");
            add_answers.Add("vpn A VPN also hides your IP address, improving your privacy and online anonymity.");

            //2fa responses
            add_answers.Add("2fa Two-factor authentication adds a second layer of security beyond your password.");
            add_answers.Add("2fa Use an authenticator app like Google Authenticator or Authy for stronger 2FA.");
            add_answers.Add("2fa Enable 2FA on all important accounts — especially email, banking, and social media.");

            //firewall responses
            add_answers.Add("firewall A firewall controls network traffic based on security rules to block unwanted access.");
            add_answers.Add("firewall Always keep your firewall enabled — it acts as a barrier between your device and threats.");
            add_answers.Add("firewall Both hardware and software firewalls help protect your network from malicious traffic.");

            //browsing responses
            add_answers.Add("browsing Always look for HTTPS and the padlock icon before entering any personal information.");
            add_answers.Add("browsing Avoid downloading files from untrusted websites — they may contain hidden malware.");
            add_answers.Add("browsing Keep your browser and extensions updated to stay protected from the latest threats.");

            //social engineering responses
            add_answers.Add("social Attackers use social engineering to manipulate people into revealing confidential information.");
            add_answers.Add("social Always verify the identity of anyone asking for sensitive information before responding.");
            add_answers.Add("social Be wary of unsolicited calls or messages claiming to be from IT support or your bank.");

            //hacked responses
            add_answers.Add("hacked Immediately change your password and log out of all devices if you think you were hacked.");
            add_answers.Add("hacked Contact the platform's support team and enable two-factor authentication right away.");
            add_answers.Add("hacked Check your account activity for any unauthorised changes or suspicious logins.");

            //fraud responses
            add_answers.Add("fraud Contact your bank immediately if you suspect fraudulent activity on your account.");
            add_answers.Add("fraud Report suspicious financial activity to your bank and the relevant authorities.");
            add_answers.Add("fraud Monitor your accounts regularly for unusual transactions or unauthorised access.");

            //cybersecurity general
            add_answers.Add("cybersecurity Cybersecurity is about protecting systems, networks and data from digital attacks and threats.");
            add_answers.Add("cybersecurity Good cybersecurity habits include strong passwords, updates, and awareness of phishing scams.");
            add_answers.Add("cybersecurity Everyone is a potential target online — practising basic cybersecurity can protect you.");

            // DETECTION RESPONSES

            //worried
            add_answers.Add("worried It is completely understandable to feel worried. Scammers can be very convincing. Let me share some tips to help you stay safe. Always avoid clicking unexpected links, verify senders, and use strong passwords.");
            add_answers.Add("worried Don't panic — most cybersecurity issues can be resolved quickly. Let's work through it together step by step.");
            add_answers.Add("worried I understand your concern. You are not alone in feeling this way. Let me help make sure your information is safe.");

            //scared
            add_answers.Add("scared It's okay to feel scared — cybersecurity threats can seem overwhelming. I'm here to help guide you through it.");
            add_answers.Add("scared Fear is a natural reaction. Let's take this one step at a time so you feel more confident online.");

            //frustrated
            add_answers.Add("frustrated I understand you are frustrated. Let's work through the issue step by step together.");
            add_answers.Add("frustrated It is okay to feel frustrated when things aren't working as expected. I'm here to help.");
            add_answers.Add("frustrated Take a breath — we will sort this out together. Tell me more about the issue.");

            //confused
            add_answers.Add("confused That is completely okay — confusion is normal with cybersecurity topics. Let me explain it clearly for you.");
            add_answers.Add("confused No worries at all. Let me break it down step by step so it makes more sense.");
            add_answers.Add("confused I will help you understand it better. Feel free to ask as many questions as you need.");

            //happy
            add_answers.Add("happy That is great to hear! I am glad things are going well for you.");
            add_answers.Add("happy Awesome! Positivity is always a good thing. Let me know if you need any cybersecurity help today.");
            add_answers.Add("happy I am happy for you! Let's keep that positive energy going while staying safe online.");

            //sad
            add_answers.Add("sad I am sorry you are feeling this way. I am here for you — let me know what I can help with.");
            add_answers.Add("sad That sounds tough. Take things one step at a time and remember I am here to help.");
            add_answers.Add("sad I hope things improve for you soon. You can always talk to me anytime.");

            //angry
            add_answers.Add("angry I understand you are angry. Let us try to solve the issue together calmly.");
            add_answers.Add("angry It is okay to feel angry, but I am here to help you fix the problem.");
            add_answers.Add("angry Take your time. I am not going anywhere — we will sort this out together.");

        }//end of method


        private void words(ArrayList ignoring)
        {//start of method
         //ignoring questions
            ignoring.Add("a");
            ignoring.Add("about");
            ignoring.Add("above");
            ignoring.Add("across");
            ignoring.Add("after");
            ignoring.Add("afterwards");
            ignoring.Add("again");
            ignoring.Add("against");
            ignoring.Add("all");
            ignoring.Add("almost");
            ignoring.Add("alone");
            ignoring.Add("along");
            ignoring.Add("already");
            ignoring.Add("also");
            ignoring.Add("although");
            ignoring.Add("always");
            ignoring.Add("am");
            ignoring.Add("among");
            ignoring.Add("amongst");
            ignoring.Add("amount");
            ignoring.Add("an");
            ignoring.Add("and");
            ignoring.Add("another");
            ignoring.Add("any");
            ignoring.Add("anyhow");
            ignoring.Add("anyone");
            ignoring.Add("anything");
            ignoring.Add("anyway");
            ignoring.Add("anywhere");
            ignoring.Add("are");
            ignoring.Add("around");
            ignoring.Add("as");
            ignoring.Add("at");
            ignoring.Add("back");
            ignoring.Add("be");
            ignoring.Add("became");
            ignoring.Add("because");
            ignoring.Add("become");
            ignoring.Add("becomes");
            ignoring.Add("becoming");
            ignoring.Add("been");
            ignoring.Add("before");
            ignoring.Add("beforehand");
            ignoring.Add("behind");
            ignoring.Add("being");
            ignoring.Add("below");
            ignoring.Add("beside");
            ignoring.Add("besides");
            ignoring.Add("between");
            ignoring.Add("beyond");
            ignoring.Add("both");
            ignoring.Add("but");
            ignoring.Add("by");
            ignoring.Add("can");
            ignoring.Add("cannot");
            ignoring.Add("could");
            ignoring.Add("did");
            ignoring.Add("do");
            ignoring.Add("does");
            ignoring.Add("doing");
            ignoring.Add("done");
            ignoring.Add("down");
            ignoring.Add("during");
            ignoring.Add("each");
            ignoring.Add("either");
            ignoring.Add("else");
            ignoring.Add("elsewhere");
            ignoring.Add("enough");
            ignoring.Add("etc");
            ignoring.Add("even");
            ignoring.Add("ever");
            ignoring.Add("every");
            ignoring.Add("everyone");
            ignoring.Add("everything");
            ignoring.Add("everywhere");
            ignoring.Add("except");
            ignoring.Add("few");
            ignoring.Add("first");
            ignoring.Add("for");
            ignoring.Add("former");
            ignoring.Add("formerly");
            ignoring.Add("from");
            ignoring.Add("further");
            ignoring.Add("had");
            ignoring.Add("has");
            ignoring.Add("have");
            ignoring.Add("having");
            ignoring.Add("he");
            ignoring.Add("hence");
            ignoring.Add("her");
            ignoring.Add("here");
            ignoring.Add("hereafter");
            ignoring.Add("hereby");
            ignoring.Add("herein");
            ignoring.Add("hereupon");
            ignoring.Add("hers");
            ignoring.Add("herself");
            ignoring.Add("him");
            ignoring.Add("himself");
            ignoring.Add("his");
            ignoring.Add("how");
            ignoring.Add("however");
            ignoring.Add("i");
            ignoring.Add("if");
            ignoring.Add("in");
            ignoring.Add("indeed");
            ignoring.Add("inside");
            ignoring.Add("instead");
            ignoring.Add("into");
            ignoring.Add("is");
            ignoring.Add("it");
            ignoring.Add("its");
            ignoring.Add("itself");
            ignoring.Add("last");
            ignoring.Add("later");
            ignoring.Add("latter");
            ignoring.Add("latterly");
            ignoring.Add("least");
            ignoring.Add("less");
            ignoring.Add("lot");
            ignoring.Add("many");
            ignoring.Add("may");
            ignoring.Add("me");
            ignoring.Add("meanwhile");
            ignoring.Add("might");
            ignoring.Add("more");
            ignoring.Add("moreover");
            ignoring.Add("most");
            ignoring.Add("mostly");
            ignoring.Add("much");
            ignoring.Add("must");
            ignoring.Add("my");
            ignoring.Add("myself");
            ignoring.Add("name");
            ignoring.Add("namely");
            ignoring.Add("neither");
            ignoring.Add("never");
            ignoring.Add("nevertheless");
            ignoring.Add("next");
            ignoring.Add("no");
            ignoring.Add("nobody");
            ignoring.Add("none");
            ignoring.Add("noone");
            ignoring.Add("nor");
            ignoring.Add("not");
            ignoring.Add("nothing");
            ignoring.Add("now");
            ignoring.Add("nowhere");
            ignoring.Add("of");
            ignoring.Add("off");
            ignoring.Add("often");
            ignoring.Add("on");
            ignoring.Add("once");
            ignoring.Add("one");
            ignoring.Add("only");
            ignoring.Add("or");
            ignoring.Add("other");
            ignoring.Add("others");
            ignoring.Add("otherwise");
            ignoring.Add("ought");
            ignoring.Add("our");
            ignoring.Add("ours");
            ignoring.Add("ourselves");
            ignoring.Add("out");
            ignoring.Add("outside");
            ignoring.Add("over");
            ignoring.Add("own");
            ignoring.Add("part");
            ignoring.Add("per");
            ignoring.Add("perhaps");
            ignoring.Add("please");
            ignoring.Add("put");
            ignoring.Add("rather");
            ignoring.Add("re");
            ignoring.Add("same");
            ignoring.Add("see");
            ignoring.Add("seem");
            ignoring.Add("seemed");
            ignoring.Add("seeming");
            ignoring.Add("seems");
            ignoring.Add("several");
            ignoring.Add("she");
            ignoring.Add("should");
            ignoring.Add("show");
            ignoring.Add("side");
            ignoring.Add("since");
            ignoring.Add("so");
            ignoring.Add("some");
            ignoring.Add("somehow");
            ignoring.Add("someone");
            ignoring.Add("something");
            ignoring.Add("sometime");
            ignoring.Add("sometimes");
            ignoring.Add("somewhere");
            ignoring.Add("still");
            ignoring.Add("such");
            ignoring.Add("take");
            ignoring.Add("than");
            ignoring.Add("that");
            ignoring.Add("the");
            ignoring.Add("their");
            ignoring.Add("theirs");
            ignoring.Add("them");
            ignoring.Add("themselves");
            ignoring.Add("then");
            ignoring.Add("thence");
            ignoring.Add("there");
            ignoring.Add("thereafter");
            ignoring.Add("thereby");
            ignoring.Add("therefore");
            ignoring.Add("therein");
            ignoring.Add("thereupon");
            ignoring.Add("these");
            ignoring.Add("they");
            ignoring.Add("this");
            ignoring.Add("those");
            ignoring.Add("though");
            ignoring.Add("through");
            ignoring.Add("throughout");
            ignoring.Add("thru");
            ignoring.Add("thus");
            ignoring.Add("to");
            ignoring.Add("together");
            ignoring.Add("too");
            ignoring.Add("toward");
            ignoring.Add("towards");
            ignoring.Add("under");
            ignoring.Add("unless");
            ignoring.Add("until");
            ignoring.Add("up");
            ignoring.Add("upon");
            ignoring.Add("us");
            ignoring.Add("used");
            ignoring.Add("very");
            ignoring.Add("via");
            ignoring.Add("was");
            ignoring.Add("we");
            ignoring.Add("well");
            ignoring.Add("were");
            ignoring.Add("what");
            ignoring.Add("whatever");
            ignoring.Add("when");
            ignoring.Add("whence");
            ignoring.Add("whenever");
            ignoring.Add("where");
            ignoring.Add("whereafter");
            ignoring.Add("whereas");
            ignoring.Add("whereby");
            ignoring.Add("wherein");
            ignoring.Add("whereupon");
            ignoring.Add("wherever");
            ignoring.Add("whether");
            ignoring.Add("which");
            ignoring.Add("while");
            ignoring.Add("whither");
            ignoring.Add("who");
            ignoring.Add("whoever");
            ignoring.Add("whole");
            ignoring.Add("whom");
            ignoring.Add("whose");
            ignoring.Add("why");
            ignoring.Add("will");
            ignoring.Add("with");
            ignoring.Add("within");
            ignoring.Add("without");
            ignoring.Add("would");
            ignoring.Add("yes");
            ignoring.Add("yet");
            ignoring.Add("hey");
            ignoring.Add("you");
            ignoring.Add("your");
            ignoring.Add("yours");
            ignoring.Add("yourself");
            ignoring.Add("yourselves");

        }//end of method

    }//end of class

}//end of namespace
