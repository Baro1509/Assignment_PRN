using BusinessObject.EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.ComponentModel.DataAnnotations;

namespace DataAccess
{
    public class MemberDAO
    {
        [Key]
        public string Email { get; set; }

        public string Passwords { get; set; }

        public string Role { get; set; }
    }

    public sealed class MemberManage
    {
        private static MemberManage instance = null;
        private static readonly object instanceLock = new object();
        private MemberManage() { }
        public static MemberManage Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberManage();
                    }
                    return instance;
                }
            }
        }
        public List<Member> GetMembers()
        {
            List<Member> members;
            try
            {
                using Ass02Context context = new Ass02Context();
                members = context.Members.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return members;
        }

        public Boolean checkLogin(Member member)
        {
            try
            {
                using Ass02Context context = new Ass02Context();
                var mem = context.Members.Where(m => m.Email.Equals(member.Email) && m.Passwords.Equals(member.Passwords)).FirstOrDefault();
                if (mem != null)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return false;

        }
    }
}
