using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAComplexType
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<ClubMember> clubMembers = GetAllClubMembers();
            
            clubMembers.Sort();
            Console.WriteLine("Sort ClubMembers by City using the default Sort method in class:");
            Console.WriteLine("======================================================================");
            foreach (ClubMember item in clubMembers)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine("-----------------");
            }


            Console.WriteLine();

            SortByLastName sortbyLastName = new SortByLastName();
            clubMembers.Sort(sortbyLastName);
            Console.WriteLine("Sort ClubMembers by LastName using IComparer interface:");
            Console.WriteLine("==========================================================");
            foreach (ClubMember item in clubMembers)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine("-----------------");
            }

            Console.WriteLine();

            //Create a Delegate constructor and pass in the sort method implementation
            Comparison<ClubMember> memberComparer = new Comparison<ClubMember>(CompareTwoMembers);
            clubMembers.Sort(memberComparer);

            Console.WriteLine("Sort ClubMembers by FirstName using Delegate implementation:");
            Console.WriteLine("=====================================================");
            foreach (ClubMember item in clubMembers)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine("-----------------");
            }

            Console.WriteLine();

            //Another way of using the delegate using a lambda expression
            clubMembers.Sort((x, y) => x.MemberID.CompareTo(y.MemberID));
            Console.WriteLine("Sort ClubMembers by ID using Delegate implementation:");
            Console.WriteLine("=====================================================");
            foreach (ClubMember item in clubMembers)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine("-----------------");
            }



            Console.ReadLine();
        }



        //Implement sort method -used by Sort delegate
        private static int CompareTwoMembers(ClubMember clubMem1, ClubMember clubMem2)
        {
            return clubMem1.FirstName.CompareTo(clubMem2.FirstName);
        }



        public static List<ClubMember> GetAllClubMembers()
        {
            List<ClubMember> clubMemberList = new List<ClubMember>()
            {
                new ClubMember{MemberID = 100, FirstName = "John", LastName = "Doe", Address = "20 Victor Avenue", City = "London"},
                new ClubMember{MemberID = 101, FirstName = "Jane", LastName = "Linux", Address = "13 Soho Avenue", City = "New York"},
                new ClubMember{MemberID = 102, FirstName = "Freddy", LastName = "Gabriel", Address = "20 Adolf Street", City = "Berlin"},
                new ClubMember{MemberID = 103, FirstName = "Mary", LastName = "Alex", Address = "100 Kingsway", City = "London"},
                new ClubMember{MemberID = 104, FirstName = "Julia", LastName = "Clement", Address = "15 Beverly Hills Avenue", City = "California"},
                new ClubMember{MemberID = 105, FirstName = "Karin", LastName = "Victor", Address = "11 Chante Avenue", City = "Paris"},
                new ClubMember{MemberID = 106, FirstName = "Thomas", LastName = "Michael", Address = "Hadsund Vej 22", City = "Arhus"},
                new ClubMember{MemberID = 107, FirstName = "Andrew", LastName = "David", Address = "Christiana Vej 100", City = "Copenhagen"}
            };
            return clubMemberList;
        }
       

    }
}
