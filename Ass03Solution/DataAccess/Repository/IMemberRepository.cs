using BusinessObject.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataAccess.Repository;

public interface IMemberRepository
{
    public Member Check(string email, string passwords);
    public Member Get(int memberId);
    public void Update(Member member);

    public IEnumerable<Member> GetAll();

}
