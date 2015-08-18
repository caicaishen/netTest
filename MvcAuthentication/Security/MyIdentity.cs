using MvcAuthentication.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace MvcAuthentication.Security
{
    #region MyIdentity
    public class MyIdentity : IIdentity
    {
        private int _userID;
        private string _userName;
        private string _phone;
        private string _pwd;

        public string UserName
        {
            get { return _userName; }
        }

        public string Phone
        {
            get { return _phone; }
        }

        public int UserID
        {
            get { return _userID; }

        }

        public string Pwd
        {
            get { return _pwd; }
        }

        private bool CanPass()
        {
            AccountContext acContext=new AccountContext();

         var cuser=   acContext.Users.Where(m => m.Name == _userName & m.Password == _pwd).FirstOrDefault();
            if (cuser!=null)
            {
                this._userID = cuser.UserID;
                return true;
            }
            //这里朋友们可以根据自己的需要改为从数据库中验证用户名和密码， 
            //这里为了方便我直接指定的字符串 
            //if (_userName == "516365717@qq.com")
            //{
            //    return true;
            //}
            else
            {
                return false;
            }
        } 
        public MyIdentity(string UserName,string Pwd)
        {
            this._userName =UserName;
           // this._userID = 2;
            //this._phone = "6623428346283";
            this._pwd = Pwd;

        }

        public MyIdentity(int UserID)
        {
            this._userName = "ssdd";
            this._userID = UserID;
            this._phone = "6623428346283";
        }

        public string AuthenticationType
        {

            get { return "Form"; }

        }

        /// <summary>  

        /// 是否验证  

        /// </summary>  

        public bool IsAuthenticated
        {

          //  get { return true; }
            get
            {
                return CanPass();
            }

        }

        /// <summary>  

        /// 返回用户  

        /// </summary>  

        public string Name
        {

            get { return _userName; }

        }



    } 
    #endregion



    public class MyPrincipal : IPrincipal
    {
        private IIdentity _identity;

        private ArrayList _permissionList=new ArrayList();
 
        public ArrayList PermissionList
        {
            get { return _permissionList; }
        }

        public IIdentity Identity
        {
            get { return _identity; }
            set { _identity = value; }

        }

        /// <summary>  

        /// 当前用户是否指定角色（采用权限值方式，此处返回false）  

        /// </summary>  

        /// <param name="role"></param>  

        /// <returns></returns>  
        public bool IsInRole(string role)
        {

            return false;
        }

        public MyPrincipal(string UserName,string Pwd)
        {
            _identity = new MyIdentity(UserName,Pwd);
            _permissionList.Add(1);
            _permissionList.Add(2);
            _permissionList.Add(3);
            _permissionList.Add(4);
            _permissionList.Add(5);
            //_permissionList.Add(6);
            //_permissionList.Add(7);
            //_permissionList.Add(8);


        }

        public MyPrincipal(int UserID)
        {
            _identity = new MyIdentity(UserID);
            //以下权限根据UserName获取数据库用户拥有的权限值，此次省略 
            _permissionList.Add(1);
            _permissionList.Add(2);
            _permissionList.Add(3);
            _permissionList.Add(4);
            _permissionList.Add(5);

        }

        public bool IsPermissionID(int permissionid)
        {
            return _permissionList.Contains(permissionid);

        }


        IIdentity IPrincipal.Identity
        {
            get { return _identity; }
        }
    }
}