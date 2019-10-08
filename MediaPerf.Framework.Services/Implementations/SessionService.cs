using MediaPerf.Framework.Models.Contracts;
using MediaPerf.Framework.Repositories.Contracts;
using MediaPerf.Framework.Repositories.Exceptions;
using MediaPerf.Framework.Services.Contracts;
using MediaPerf.Framework.Services.Exceptions;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPerf.Framework.Services.Implementations
{
    public class SessionService : ISessionService
    {
        #region Fields

        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        #endregion

        #region Properties

        private IApplicationRepository AppplicationRepository { get; } =
            InstanceLocator.Current.GetInstance<IApplicationRepository>();

        private IMediaPerfUser CurrentUser { get; set; }

        #endregion

        #region Methods

        public IMediaPerfUser GetCurrentUser()
        {
            if (CurrentUser == null)
            {
                LoadCurrentUser();
            }

            return CurrentUser;
        }

        public string GetUserParameter(string key)
        {
            var currentUser = GetCurrentUser();
            //var parameter = currentUser.Parameters.SingleOrDefault(p => p.Key.Equals(key));

            //if (parameter == null)
            //{
            //    _logger.Debug($"Paramètre [{key}] introuvable pour l'utilisateur [#{currentUser.Id}].");

            //    return null;
            //}

            //_logger.Debug($"Paramètre [{key}] de l'utilisateur [#{currentUser.Id}] : [{parameter.Value}].");

            //return parameter.Value;
            return null;
        }

        private void LoadCurrentUser()
        {
            var id = 2;

            try
            {
                CurrentUser = AppplicationRepository.GetUser(id);
            }
            catch (LoadRepositoryException exception)
            {
                _logger.Error(exception);

                throw new ServiceException($"Impossible de récupérer l'utilisateur en cours [#{id}]", exception);
            }
        }

        #endregion
    }
}