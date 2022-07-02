using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ass01BusinessObject;

namespace DataAccess.Repository {
    public interface IMemberRepository 
    {
        IEnumerable<MemberObject> GetMembers();
        MemberObject GetMemberByID(int MemberID);
        void InsertMember(MemberObject member);
        void UpdateMember(MemberObject member);
        void DeleteMember(int MemberID);
    }
}
