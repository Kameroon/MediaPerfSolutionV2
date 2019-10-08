using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPerf.Framework.Models.Contracts
{
    public interface IMediaPerfUser : IPerson
    {
        //IList<IMediaPerfEnvironment> Environments { get; set; }

        //string Login { get; set; }

        //IList<IUserParameter> Parameters { get; set; }

        //string Password { get; set; }

        //IList<ISqiProfile> Profiles { get; set; }

        //string WindowsAccount { get; set; }
    }

    public interface IPerson //: IEntity
    {
        string Email { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }

        //IList<IPhoneNumber> PhoneNumbers { get; set; }
    }
}
