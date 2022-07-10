using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD

namespace DataAccess.Repository {
    internal class IMemberRepository {
=======
using Ass01BusinessObject;

namespace DataAccess.Repository {
    public interface IMemberRepository 
    {
        IEnumerable<MemberObject> GetMembers();
        MemberObject GetMemberByID(int MemberID);
        public MemberObject Login(string Email, String Password);
        public void InsertMember(MemberObject member);
        public void UpdateMember(MemberObject member);
        public void DeleteMember(int MemberID);
        public IEnumerable<MemberObject> SearchMemberByCity(string city);
        public IEnumerable<MemberObject> SearchMemberByCountry(string country);
        public IEnumerable<MemberObject> SearchMemberByEmail(string email);
        public IEnumerable<MemberObject> SearchMember(string name);

>>>>>>> origin/devs
    }
}
