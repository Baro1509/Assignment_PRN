using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class Member
    {
        [Key]
        public string email { get; set; }
       
        public string password { get; set; }
       
        public string role { get; set; }
    }

    public class MemberDbContext : DbContext
    {
        public MemberDbContext() { }
        public  DbSet<Member> Members { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfiguration configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("LoginDemoDB"));
        }
    }

    public sealed class MemberManage
    {
        private static MemberManage instance = null;
        private static readonly object instanceLock = new object();
        private MemberManage() { }
        public static MemberManage Instance
        {
            get {
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
                using MemberDbContext context = new MemberDbContext();
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
                using MemberDbContext context = new MemberDbContext();
                var mem = context.Members.Where(m => m.email.Equals(member.email) && m.password.Equals(member.password)).FirstOrDefault();
                if (mem != null)
                {
                    return true;
                }
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return false;

        }
    }

    
}
