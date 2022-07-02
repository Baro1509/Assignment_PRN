using BusinessObject.EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.ComponentModel.DataAnnotations;

namespace DataAccess
{
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
        public MemberDAO() { }
        public List<Member> GetMembers()
        {
            List<Member> members;
            try
            {
                Ass02Context context = new Ass02Context();
                members = context.Members.ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return members;
        }
        public void Insert(Member member)
        {
            try
            {
                Ass02Context ctx = new Ass02Context();
                ctx.Members.Add(member);
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Member member)
        {
            try
            {
                Ass02Context ctx = new Ass02Context();
                ctx.Entry<Member>(member).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                ctx.SaveChanges();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Delete(Member member)
        {
            try
            {
                Ass02Context ctx = new Ass02Context();
                var mem = ctx.Members.FirstOrDefault(x => x.MemberId == member.MemberId);
                ctx.Members.Remove(mem);
                ctx.SaveChanges();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public string checkLogin(Member member)
        {
            string role = "";
            try
            {
                Ass02Context ctx = new Ass02Context();
                var mem = ctx.Members.Where(m => m.Email.Equals(member.Email) && m.Passwords.Equals(member.Passwords)).FirstOrDefault();
                if (mem != null)
                {
                    role = mem.RoleId.ToString();
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            return role;
        }
    }
}
