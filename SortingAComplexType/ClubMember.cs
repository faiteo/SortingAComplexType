using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAComplexType
{
    public class ClubMember : IComparable<ClubMember>
    {
        private int memberID;

        public int MemberID
        {
            get { return memberID; }
            set { memberID = value; }
        }
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }
        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        //using the default comparer
        public int CompareTo(ClubMember other)
        {
            //Sort by City
            return this.City.CompareTo(other.City);




            //Sort by MemberID
            ////the current instance is greater than the object being compared with

            //if (this.MemberID > other.MemberID)
            //{
            //    return 1;
            //}
            ////the current instance is less than the object being compared with
            //else if (this.MemberID < other.MemberID)
            //{
            //    return -1;
            //}
            ////the current instance is the same as the object being compared with
            //else
            //{
            //    return 0;
            //}
        }

        public override string ToString()
        {
            string[] lines = {
                                 "Member ID: {0}",
                                 "First Name: {1}",
                                 "Lastname: {2}",
                                 "Address: {3}",
                                 "City: {4}"
                             };
            return string.Format(string.Join(Environment.NewLine, lines), this.MemberID, this.FirstName, this.LastName, this.Address, this.City);
        }
        
 
    }
    
}
