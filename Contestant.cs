using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant
    {
        private string firstName;
        private string lastName;
        private string emailAddress;
        private int registrationNumber;
        UI userInterface = new UI();

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name must have a value");
                if (value.Any(c => char.IsDigit(c)))
                    throw new ArgumentException("Name cannot contain numbers");
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name must have a value");
                if (value.Any(c => char.IsDigit(c)))
                    throw new ArgumentException("Name cannot contain numbers");
                lastName = value;
            }
        }
        public string EmailAddress
        {
            get
            {
                return emailAddress;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name must have a value");
                emailAddress = value;
            }
        }

        private int SetRegistrationNumber()
        {
            Random randomNumber = new Random();
            registrationNumber = randomNumber.Next(1000, 2000);
            return registrationNumber;
        }
    }
}
