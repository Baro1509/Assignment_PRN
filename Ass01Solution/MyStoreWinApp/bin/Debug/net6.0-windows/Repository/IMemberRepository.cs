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
        public MemberObject Login(string MemberName, String Password);
        public void InsertMember(MemberObject member);
        public void UpdateMember(MemberObject member);
        public void DeleteMember(int MemberID);
        public IEnumerable<MemberObject> SearchMember(int id);
        public IEnumerable<MemberObject> SearchMember(string name);

    }
}
