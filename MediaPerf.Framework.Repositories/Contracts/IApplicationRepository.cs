using MediaPerf.Framework.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPerf.Framework.Repositories.Contracts
{
    public interface IApplicationRepository
    {
        //IList<ISqiApplication> GetApplications();

        //IList<ISqiEnvironment> GetEnvironments();

        IMediaPerfUser GetUser(int id);

        IList<IMediaPerfUser> GetUsers();
    }
}