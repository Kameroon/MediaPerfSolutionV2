using System;
using System.Runtime.Serialization;


namespace MediaPerf.Framework.Repositories.Exceptions
{
    /// <summary>
    ///     Exception levée lors de la sauvegarde de données depuis le dépôt
    /// </summary>
    /// <seealso cref="RepositoryException" />
    [Serializable]
    public class SaveRepositoryException : RepositoryException
    {
        #region Fields

        private const string MESSAGE = "Impossible de sauvegarder l'entité [{0}].";

        #endregion

        #region Constructors

        public SaveRepositoryException(Type entityType) : base(string.Format(MESSAGE, entityType))
        {
        }

        public SaveRepositoryException(string message) : base(message)
        {
        }

        public SaveRepositoryException(Type entityType, Exception inner)
            : base(string.Format(MESSAGE, entityType), inner)
        {
        }

        public SaveRepositoryException(string message, Exception inner) : base(message, inner)
        {
        }

        protected SaveRepositoryException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        #endregion
    }
}