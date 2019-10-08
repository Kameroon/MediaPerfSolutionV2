using MediaPerf.Framework.Models.Contracts;
using System;
using System.Collections.Generic;

namespace MediaPerf.Framework.Models.Implementations
{
    public class MediaPerfUser : IPerson
    {
        #region Properties
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //IList<IMediaPerfEnvironment> Environments { get; set; }

        string Login { get; set; }

        //IList<IUserParameter> Parameters { get; set; }

        string Password { get; set; }

        IList<IMediaPerfUser> Profiles { get; set; }

        string WindowsAccount { get; set; }
        #endregion

        #region Constructor
        public MediaPerfUser()
        {

        }

        public MediaPerfUser(int id, string lastName, string firstName, string email, string login, string password,
            string windowsAccount) //: base(id, lastName, firstName)
        {
            LastName = lastName;
            FirstName = firstName;
            Email = email;
            Login = login;
            Password = password;
            WindowsAccount = windowsAccount;
        }
        #endregion
    }
}