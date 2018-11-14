using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sweepstakes
{
    class UI
    {
        
        string userReply;

        public void EnterContestantInfo(Contestant contestant)
        {
            UserInputFirstName(contestant);
            UserInputLastName(contestant);
            UserInputEmailAddress(contestant);
            ConfirmToEnterSweepstakes();
        }
        public void UserInputFirstName(Contestant contestant)
        {
            Console.WriteLine("Please enter your first name:");
            contestant.FirstName = Console.ReadLine();
        }
        public void UserInputLastName(Contestant contestant)
        {
            Console.WriteLine("Please enter you last name: ");
            contestant.LastName = Console.ReadLine();
        }
        public void UserInputEmailAddress(Contestant contestant)
        {
            Console.WriteLine("Please enter your email address: ");
            contestant.EmailAddress = Console.ReadLine();
        }

        private void ConfirmToEnterSweepstakes()
        {
            Console.WriteLine("All contestants will be notified when the winner is selected.");
            Console.WriteLine("Winner will be notified by email.");
            Console.WriteLine("Would you like to enter our sweepstakes? Yes or No?");
            userReply = Console.ReadLine();
            VerifyUserInput(userReply);
            Console.WriteLine("You have successfully registered for this sweepstakes! Good Luck!");
            Console.ReadLine();
        }

        private void VerifyUserInput(string userInput)
        {
            if (userInput.ToLower() == "yes")
            {
                userInput = userReply;
                return;
            }
            else if  (userInput.ToLower() == "no")
            {
                userInput = userReply;
                return;
            }
            else
            {
                Console.WriteLine("Please enter a valid response.");
                ConfirmToEnterSweepstakes();
            }
        }
    }
}
