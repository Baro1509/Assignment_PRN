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
        public string Insert(Member member)
        {
            string message="";
            try
            {
                Ass02Context ctx = new Ass02Context();
                var mem = ctx.Members.Where(e =>e.Email.Equals(member.Email) || e.MemberId == member.MemberId ).FirstOrDefault();
                if (mem != null)
                {
                    message = "Email or Id cannot duplicate!!";
                }
                else
                {
                    ctx.Members.Add(member);
                    ctx.SaveChanges();
                    message = "Create successfully!!";
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return message;
            

            
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
        public void Delete(int id)
        {
            try
            {
                Ass02Context ctx = new Ass02Context();
                var mem = ctx.Members.FirstOrDefault(x => x.MemberId == id);
                ctx.Members.Remove(mem);
                ctx.SaveChanges();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public string checkLogin(Member member)
        {
            string mem = "";
            try
            {
                Ass02Context ctx = new Ass02Context();
                mem = ctx.Members.Where(m => m.Email.Equals(member.Email) && m.Passwords.Equals(member.Passwords)).Select(r => r.RoleId).FirstOrDefault().ToString();

            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            return mem;
        }
        public Member GetMember(Member mem)
        {
            Member member = null;
            try
            {
                Ass02Context ctx = new Ass02Context();
                member = ctx.Members.Where(m => m.Email.Equals(mem.Email) && m.Passwords.Equals(mem.Passwords)).FirstOrDefault();
            } catch(Exception ex) { throw new Exception(ex.Message); }
            return member;
        }
    }
}
