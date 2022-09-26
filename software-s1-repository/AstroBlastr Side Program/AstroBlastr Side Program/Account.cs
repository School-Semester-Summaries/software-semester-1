using System;
using System.Collections.Generic;
using System.Text;

namespace AstroBlastr_Side_Program
{
    class Account
    {
        // Fields
        private string firstName;
        private string lastName;
        private string password;

        // Properties
        public string FirstName { get { return firstName; } }
        public string LastName { get { return lastName; } }
        public string Password { get { return password; } }

        // Constructors
        public Account(string firstName, string lastName, string password)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.password = password;
        }
    }
}
