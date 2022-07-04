﻿using System.Data;
using Ass01BusinessObject;
using Microsoft.Data.SqlClient;
namespace Ass01DataAccess {
    public class MemberDAO : BaseDAL
    {
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        private MemberDAO() { }
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

        public IEnumerable<MemberObject> GetMemberList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select MemberID, MemberName, Email, Passwords, City, Country ,roles From Users";
            var Members = new List<MemberObject>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    Members.Add(new MemberObject
                    {
                        MemberID = dataReader.GetInt32(0),
                        MemberName = dataReader.GetString(1),
                        Email = dataReader.GetString(2),
                        Password = dataReader.GetString(3),
                        City = dataReader.GetString(4),
                        Country = dataReader.GetString(5),
                        roles = dataReader.GetString(6),
                    });
                }
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return Members;
        }
        public MemberObject Login(string Email, string Password)
        {
            IEnumerable<MemberObject> members = GetMemberList();
            MemberObject member = members.SingleOrDefault(mb => mb.Email.Equals(Email) && mb.Password.Equals(Password));
            return member;
        } 
        public MemberObject GetMemberByID(int MemberID)
        {
            MemberObject Member = null;
            IDataReader dataReader = null;
            string SQLSelect = "Select MemberID,MemberName,Email,Passwords,City,Country,roles from Users where MemberID = @MemberID";
            try
            {
                var param = dataProvider.CreateParameter("@MemberID", 4, MemberID, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text,out connection, param);
                if (dataReader.Read())
                {
                    Member = new MemberObject { MemberID = dataReader.GetInt32(0), MemberName = dataReader.GetString(1), 
                        Email = dataReader.GetString(2), 
                        Password = dataReader.GetString(3), 
                        City = dataReader.GetString(4), 
                        Country = dataReader.GetString(5), 
                        roles = dataReader.GetString(6)
                    };
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }return Member;
        }

        public void AddNew(MemberObject Member) 
        {
            try
            {
                MemberObject pro = GetMemberByID(Member.MemberID);
                if (pro == null)
                {
                    string SQLInsert = "Insert into Users values (@MemberID,@MemberName,@Email,@Password,@City,@Country,@Role)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@MemberID", 4, Member.MemberID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@MemberName", 50, Member.MemberName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Email", 50, Member.Email, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Password", 50, Member.Password, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@City", 50, Member.City, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Country", 20, Member.Country, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Role", 10, Member.roles, DbType.String));
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("Member is already exist.");
                }
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);    
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Update(MemberObject Member)
        {
            try
            {
                MemberObject pro = GetMemberByID(Member.MemberID);
                if(pro != null)
                {
                    string SQLUpdate = "Update Users set  MemberName = @MemberName , Email = @Email, Passwords = @Password, City = @City, Country = @Country where MemberID = @MemberID ";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@MemberID", 4, Member.MemberID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@MemberName",50,Member.MemberName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Email",100,Member.Email, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Password",50,Member.Password, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@City",50,Member.City, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Country",50,Member.Country, DbType.String));
                    dataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The Member didn't exist");
                }
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Remove(int MemberID)
        {
            try
            {
                MemberObject memberObject = GetMemberByID(MemberID);
                if(memberObject != null)
                {
                    string SQLDelete = "Delete Users where MemberID=@MemberID";
                    var param = dataProvider.CreateParameter("@MemberID", 4, MemberID,DbType.Int32);
                    dataProvider.Delete(SQLDelete, CommandType.Text, param);
                }
                else
                {
                    throw new Exception("The Member didn't exist.");
                }
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();  
            }
        }

        public IEnumerable<MemberObject> SearchMemberByCity(string city)
        {
            IEnumerable<MemberObject> searchResult = null;
            IEnumerable<MemberObject> members = GetMemberList();
            var memberSearch = from member in members
                               where member.City.ToLower().Contains(city.ToLower())
                               select member;
            searchResult = memberSearch;

            return searchResult;
        }
        
        public IEnumerable<MemberObject> SearchMemberByCountry(string country)
        {
            IEnumerable<MemberObject> searchResult = null;
            IEnumerable<MemberObject> members = GetMemberList();
            var memberSearch = from member in members
                               where member.Country.ToLower().Contains(country.ToLower())
                               select member;
            searchResult = memberSearch;

            return searchResult;
        }

        public IEnumerable<MemberObject> SearchMember(string name)
        {
            IEnumerable<MemberObject> searchResult = null;
            IEnumerable<MemberObject> members = GetMemberList();
            var memberSearch = from member in members
                               where member.MemberName.ToLower().Contains(name.ToLower())
                               select member;
            searchResult = memberSearch;

            return searchResult;
        }

        public IEnumerable<MemberObject> SearchMemberByEmail(string email)
        {
            IEnumerable<MemberObject> searchResult = null;
            IEnumerable<MemberObject> members = GetMemberList();
            var memberSearch = from member in members
                               where member.Email.ToLower().Contains(email.ToLower())
                               select member;
            searchResult = memberSearch;

            return searchResult;
        }
    }
}