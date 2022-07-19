using BusinessObject.EntityModels;
namespace DataAccess;

public class MemberDAO
{
    private static MemberDAO instance = null;
    private static readonly object instanceLock = new object();
    public static MemberDAO Instance
    {
        get
        {
            lock (instanceLock)
            {
                if (instance == null)
                {
                    instance = new MemberDAO();
                }
                return instance;
            }
        }
    }
    public Member Check(string email, string passwords)
    {
        Member loginMember = null;
        try
        {
            using var context = new Ass02Context();
            loginMember = context.Members.Where(x => x.Email == email && x.Passwords == passwords).FirstOrDefault();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return loginMember;
    }

    public Member Get(int memberId)
    {
        Member member = null;
        try
        {
            using var context = new Ass02Context();
            member = context.Members.Where(x => x.MemberId == memberId).FirstOrDefault();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return member;
    }

    public void Update(Member member)
    {
        if (member != null)
        {
            try
            {
                Member _member = Get(member.MemberId);
                if (_member != null)
                {
                    _member = member;
                    using var context = new Ass02Context();
                    context.Members.Update(member);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Member does not exist!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }

    public IEnumerable<Member> GetAll()
    {
        var members = new List<Member>();
        try
        {
            using var context = new Ass02Context();
            members = context.Members.ToList();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return members;
    }
}
