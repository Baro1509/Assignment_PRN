using BusinessObject.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository {
    public interface IMemberRepository {
        IEnumerable<Member> GetMembers();
        Member GetMemberById(int id);
        void UpdateMember(Member member);
        void DeleteMember(int id);
        void InsertMember(Member member);
        Member GetMember(Member member);
    }
}
