using BusinessObject.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository {
    public class MemberRepository : IMemberRepository
    {
        public void DeleteMember(int id) => MemberDAO.Instance.Delete(id);

        public Member GetMemberById(int id)
        {
            Ass02Context context = new Ass02Context();
            var mem = context.Members.FirstOrDefault(x => x.MemberId == id);
            return mem;
        }

        public IEnumerable<Member> GetMembers()
        {
            return MemberDAO.Instance.GetMembers();
        }

        public void InsertMember(Member member)
        {
            MemberDAO.Instance.Insert(member);  
        }

        public void UpdateMember(Member member)
        {
            MemberDAO.Instance.Update(member);
        }
    }
}
