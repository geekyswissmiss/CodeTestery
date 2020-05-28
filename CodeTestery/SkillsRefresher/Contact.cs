using System;
using System.Collections.Generic;
using System.Text;

namespace SkillsRefresher
{
    public class Contact : IEquatable<Contact>
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }

        public Contact(string lastName, string firstName, string middleName)
        {
            this.LastName = lastName.ToUpper();
            this.FirstName = firstName.ToUpper();
            this.MiddleName = middleName.ToUpper();
        }

        public bool Equals(Contact other)
        {
            if (new ContactSameName().Equals(this, other))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class ContactSameName : EqualityComparer<Contact>
    {

        public override bool Equals(Contact b1, Contact b2)
        {
            if (b1.LastName == b2.LastName && b1.FirstName == b2.FirstName
                                && b1.MiddleName == b2.MiddleName)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode(Contact c)
        {
            string smashName = string.Concat(c.LastName, c.FirstName, c.MiddleName);
            return smashName.GetHashCode();
        }
    }
}
