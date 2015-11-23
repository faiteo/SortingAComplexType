using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAComplexType
{
    public class SortByLastName : IComparer<ClubMember>
    {
        //Sort implementing IComparer interface
        public int Compare(ClubMember member1, ClubMember member2)
        {
            return member1.LastName.CompareTo(member2.LastName);
        }
    }
}
