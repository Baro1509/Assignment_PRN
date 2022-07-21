using BusinessObject.EntityModels;
using DataAccess.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eStore
{
    public class MembersController : Controller
    {
        readonly IMemberRepository memberRepository = new MemberRepository();
        public MembersController()
        {
            memberRepository = new MemberRepository();
        }
        // GET: MembersController
        public ActionResult Index()
        {
            ViewBag.loginMemberId = HttpContext.Session.GetInt32("LoginMemberId");
            return View();
        }

        // GET: MembersController
        public ActionResult IndexAdmin()
        {
            ViewBag.loginMemberId = HttpContext.Session.GetInt32("LoginMemberId");
            return View();
        }

        // GET: MembersController/Profile/5
        public ActionResult Profile(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var member = memberRepository.Get(id);
            if (member == null)
            {
                return NotFound();
            }
            return View(member);
        }

        // GET: MembersController/Login
        public ActionResult Login(string message)
        {
            ViewData["Message"] = message;
            return View("Login");
        }

        // POST: MembersController/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Member member)
        {
            string message = "";
            try
            {
                Member? loginMember = memberRepository.Check(member.Email, member.Passwords);
                if (loginMember != null && loginMember.RoleId == 1) //admin
                {
                    HttpContext.Session.SetInt32("LoginMemberId", loginMember.MemberId);
                    HttpContext.Session.SetInt32("LoginMemberRoleId", loginMember.RoleId);
                    return RedirectToAction(nameof(IndexAdmin));
                }
                if (loginMember != null && loginMember.RoleId == 2) //member
                {
                    HttpContext.Session.SetInt32("LoginMemberId", loginMember.MemberId);
                    HttpContext.Session.SetInt32("LoginMemberRoleId", loginMember.RoleId);
                    return RedirectToAction(nameof(Index));
                }
                message = "Incorrect email or password";
                return Login(message);
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return RedirectToAction(nameof(Login));
            }
        }

        // GET: MembersController/Register
        public ActionResult Register(string message)
        {
            ViewData["message"] = message;
            return View();
        }

        // POST: MembersController/Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Member member)
        {
            string message = "";
            try
            {
                Member? loginMember = memberRepository.Check(member.Email);
                if (loginMember != null) //duplicated email
                {
                    message = "This email is already taken!";
                    return Register(message);
                }
                else
                {
                    memberRepository.Add(member);
                    message = "Register successfully! Please login to continue shopping!";
                }
                return Login(message);
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return RedirectToAction(nameof(Login));
            }
        }

        // GET: MembersController/Logout
        public ActionResult Logout()
        {
            HttpContext.Session.Remove("LoginMemberId");
            HttpContext.Session.Remove("LoginMemberRoleId");
            return RedirectToAction(nameof(Login));
        }

        // GET: MembersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MembersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Profile));
            }
            catch
            {
                return View();
            }
        }

        // GET: MembersController/Edit/5
        public ActionResult Edit(int id)
        {
            int? memberId = HttpContext.Session.GetInt32("LoginMemberId");
            int? roleId = HttpContext.Session.GetInt32("LoginMemberRoleId");
            if (memberId != null && roleId != null && memberId == id && roleId == 2) //only login member can edit their profile
            {
                Member member = memberRepository.Get(id);
                if (member == null)
                {
                    return NotFound();
                }
                return View(member);
            }
            if (roleId != null && roleId == 2)
            {
                return RedirectToAction(nameof(Index));
            }
            if (roleId != null && roleId == 1)
            {
                return RedirectToAction(nameof(IndexAdmin));
            }
            return RedirectToAction(nameof(Login));
        }

        // POST: MembersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Member member)
        {
            Console.WriteLine("Edit");
            if (id == member.MemberId)
            {
                int? memberId = HttpContext.Session.GetInt32("LoginMemberId");
                int? roleId = HttpContext.Session.GetInt32("LoginMemberRoleId");
                if (memberId != null && roleId != null && memberId == id && roleId == 2) //only login member can edit their profile
                {
                    try
                    {
                        memberRepository.Update(member);
                        return RedirectToAction(nameof(Profile), new { id = id });
                    }
                    catch (Exception ex)
                    {
                        ViewBag.Message = ex.Message;
                        return View();
                    }
                }
                if (roleId != null && roleId == 2)
                {
                    return RedirectToAction(nameof(Index));
                }
                if (roleId != null && roleId == 1)
                {
                    return RedirectToAction(nameof(IndexAdmin));
                }
                return Login("You must login to edit profile");
            }
            return NotFound();
        }

        // GET: MembersController/List
        public ActionResult List()
        {
            int? roleId = HttpContext.Session.GetInt32("LoginMemberRoleId");
            if (roleId != null && roleId == 1)
            {
                var members = memberRepository.GetAll();
                return View(members);
            }
            if (roleId != null && roleId == 2)
            {
                return RedirectToAction(nameof(Index));
            }
            return Login("You must be admin to view member list");
        }

        // GET: MembersController/Delete/5
        public ActionResult Delete(int id, string message)
        {
            ViewData["Message"] = message;
            if (id == null)
            {
                return NotFound();
            }
            var member = memberRepository.Get(id);
            if (member == null)
            {
                return NotFound();
            }
            return View(member);
        }

        // POST: MembersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                int? memberId = HttpContext.Session.GetInt32("LoginMemberId");
                if (memberId != null && memberId == id)
                {
                    string message = "You cannot delete yourself!";
                    return Delete(id, message);
                }
                int? roleId = HttpContext.Session.GetInt32("LoginMemberRoleId");
                if (roleId == null || roleId != 1)
                {
                    return Login("You must be admin to delete member!");
                }
                memberRepository.Delete(id);
                return RedirectToAction(nameof(List));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }
    }
}
