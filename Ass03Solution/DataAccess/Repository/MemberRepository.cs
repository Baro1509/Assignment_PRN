using BusinessObject.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository;

public class MemberRepository : IMemberRepository
{
    public Member Check(string email, string passwords) => MemberDAO.Instance.Check(email, passwords);

    public Member Get(int memberId) => MemberDAO.Instance.Get(memberId);

    public IEnumerable<Member> GetAll() => MemberDAO.Instance.GetAll();

    public void Update(Member member) => MemberDAO.Instance.Update(member);
}
