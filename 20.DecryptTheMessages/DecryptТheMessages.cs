using System;
using System.Collections.Generic;

class DecryptТheMessages
{
    static string ReplaceSpecialSymbols(string word)
    {
        word = word.Replace('+', ' ').Replace('%', ',').Replace('&', '.').Replace('#', '?').Replace('$', '!');
        
        // Console.WriteLine(word);
        return word;
    }

    static string ReplaceLetters(string word)
    {
        string replaced = string.Empty;

        foreach (var ch in word)
        {
            if ((ch >= 65 && ch <= 77) || (ch >= 97 && ch <= 109))
            {
                replaced += Convert.ToString((char)(ch + 13));
            }
            else if ((ch >= 78 && ch <= 90) || (ch >= 110 && ch <= 122))
            {
                replaced += Convert.ToString((char)(ch - 13));
            }
            else
            {
                replaced += Convert.ToString((char)(ch));
            }
        }
        return replaced;
    }

    static string ReverseMessage(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static void Main()
    {
        List<string> messages = new List<string>();
        int msgCounter = 0;
        string input = string.Empty;

        bool start = true;
        do
        {
            input = Console.ReadLine();
            if (input == "START" || input == "start")
            {
                start = false;
            }
        } while (start);

        while (true)
        {
            input = Console.ReadLine();
                        
            if (input == "END" || input == "end")
            {
                break;
            }
            else if (input != string.Empty)
            {
                string encrypted = input;
                string replacedSpecial = ReplaceSpecialSymbols(encrypted);
                string replacedLetters = ReplaceLetters(replacedSpecial);

                string reversed = ReverseMessage(replacedLetters);
                messages.Add(reversed);
                msgCounter++;
            }
        }

        if (msgCounter > 0)
        {
            Console.WriteLine("Total number of messages: {0}", msgCounter);
            foreach (var msg in messages)
            {
                Console.WriteLine(msg);
            }
        }
        else
        {
            Console.WriteLine("No message received.");
        }







        //  they are communicating to each other via !!messages, which are reversed (written backwards) and then encrypted

        //  Your task is to write a program, which receives all encrypted messages in a specific communication, decrypts them and prints all decrypted messages at the console as well as the total number of messages that have been received.

        //  At the beginning of a communication, you will receive either the keyword “START” (upper case) or “start” (lower case), which indicates that you will start receiving reversed and encrypted messages. At the end of the communication, you will receive either the keyword “END” (upper case) or “end” (lower case), which indicates that the communication is over and you need to show the decrypted messages’ content and total count.

        //  Any non-empty string between the “start” and “end” keywords is considered a message. If no messages have been received between the “start” and the “end” keywords, you should print on the console: “No message received.”

        //  All messages are case-sensitive and consist of letters, digits, as well as some special characters – ‘+’, ‘%’, ‘&’, ‘#’ and ‘$’
        //  Letters from A to M are converted to letters from N to Z (A  N; B  O; … M  Z) and letters from N to Z are converted to letters from A to M (N  A; O  B; … Z  M).

        //  The converted letter should keep the case of the original letter. The special characters are converted in the following way: ‘+’ is converted to a single space (‘  ’), ‘%’ is converted to a comma (‘,’), ‘&’ is converted to a dot (‘.’), ‘#’ is converted to a question mark (‘?’) and ‘$’ is converted to an exclamation mark (‘!’).

        //  The digits (0-9) are not converted and stay the same.

        //  For example, you receive the following message – “$1+rtnffrz+greprF” and you start decrypting it. Convert the 1st character ‘$’ to ‘!’, then the 2nd character – ‘1’ stays the same, then covert the 3rd character – ‘+’ to single space ‘ ’, ‘r’  ’e’, ‘t’  ‘g’, ‘n’  ‘a’, ‘f’  ‘s’, ‘f’  ‘s’, ‘r’  ’e’ , ‘z’  ’m’, ‘+’  ‘ ’, ‘g’  ‘t’, ‘r’  ’e’ , ‘e’  ’r’ , ‘p’  ’c’ , ‘r’  ’e’ , ‘F’  ’S’.

        //  After decrypting all letters, the message is: “!1 egassem terceS” and when you reverse it, you get the original message: “Secret message 1!”


    }
}
