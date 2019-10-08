using MediaPerf.Framework.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPerf.Framework.Models.Implementations
{
    public class ApplicationModelFactory : IApplicationModelFactory
    {
        #region Methods

        //public ISqiApplication CreateApplication() => new SqiApplication();

        //public ISqiApplication CreateApplication(int id, string label, bool isEnable) =>
        //    new SqiApplication(label, isEnable);

        //public ISqiEnvironment CreateEnvironment() => new SqiEnvironment();

        //public ISqiEnvironment CreateEnvironment(int id, string label) => new SqiEnvironment(label);

        //public IEnvironmentStatus CreateEnvironmentStatus() => new EnvironmentStatus();

        //public IEnvironmentStatus CreateEnvironmentStatus(int id, string label) => new EnvironmentStatus(id, label);


        public IMediaPerfUser CreateUser()
        {
            return new MediaPerfUser();
        }

        public IMediaPerfUser CreateUser(int id, string lastName, string firstName,
            string email, string login, string password, string windowsAccount)
        {
            return new MediaPerfUser(id, lastName, firstName, email, login, password, windowsAccount);
        }
        #endregion
    }
}