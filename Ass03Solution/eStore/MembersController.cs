﻿using BusinessObject.EntityModels;
using DataAccess.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eStore
{
    public class MembersController : Controller
    {
        readonly IMemberRepository memberRepository = new MemberRepository();
        public MembersController() => memberRepository = new MemberRepository();
        // GET: MembersController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MembersController
        public ActionResult IndexAdmin()
        {
            return View();
        }

        // GET: MembersController/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
            Console.WriteLine("Login Member checked!");
            string message = "";
            try
            {
                Member loginMember = memberRepository.Check(member.Email, member.Passwords);
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
                return RedirectToAction(nameof(Details));
            }
            catch
            {
                return View();
            }
        }

        // GET: MembersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MembersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Details));
            }
            catch
            {
                return View();
            }
        }

        // GET: MembersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MembersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
