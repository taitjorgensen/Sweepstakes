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


        public void EnterContestantInfo(Contestant contestant)
        {
            UserInputFirstName(contestant);
            UserInputLastName(contestant);
            UserInputEmailAddress(contestant);
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


    }
}
