﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ass01BusinessObject;
using Ass01DataAccess;

namespace DataAccess.Repository {
    public class MemberRepository : IMemberRepository 
    {
        public MemberObject GetMemberByID(int MemberID) => MemberDAO.Instance.GetMemberByID(MemberID);
        public IEnumerable<MemberObject> GetMembers() => MemberDAO.Instance.GetMemberList();
        public void InsertMember(MemberObject member) => MemberDAO.Instance.AddNew(member);
        public void UpdateMember(MemberObject member) => MemberDAO.Instance.Update(member);
        public void DeleteMember(int MemberID) => MemberDAO.Instance.Remove(MemberID);
    }
}
