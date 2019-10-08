using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPerf.Framework.Models.Contracts
{
    /// <summary>
    ///     Usine de fabrication du modèle de l'application.
    /// </summary>
    public interface IApplicationModelFactory
    {
        ///// <summary>
        /////     Crée une application.
        ///// </summary>
        ///// <returns></returns>
        //ISqiApplication CreateApplication();

        ///// <summary>
        /////     Crée une application.
        ///// </summary>
        ///// <param name="id">Identifiant de l'application.</param>
        ///// <param name="label">Libellé de l'application.</param>
        ///// <param name="isEnable">Activé si <c>true</c>.</param>
        ///// <returns></returns>
        //ISqiApplication CreateApplication(int id, string label, bool isEnable);

        ///// <summary>
        /////     Crée un environnement.
        ///// </summary>
        ///// <returns></returns>
        //ISqiEnvironment CreateEnvironment();

        ///// <summary>
        /////     Crée un environnement.
        ///// </summary>
        ///// <param name="id">Identifiant de l'environnement.</param>
        ///// <param name="label">Libellé de l'environnement.</param>
        ///// <returns></returns>
        //ISqiEnvironment CreateEnvironment(int id, string label);

        ///// <summary>
        /////     Crée un statut d'environnement.
        ///// </summary>
        ///// <returns></returns>
        //IEnvironmentStatus CreateEnvironmentStatus();

        ///// <summary>
        /////     Crée un statut d'environnement.
        ///// </summary>
        ///// <param name="id">Identifiant de l'environnement.</param>
        ///// <param name="label">Libellé de l'environnement.</param>
        ///// <returns></returns>
        //IEnvironmentStatus CreateEnvironmentStatus(int id, string label);

        /// <summary>
        ///     Crée un utilisateur.
        /// </summary>
        /// <returns></returns>
        IMediaPerfUser CreateUser();

        /// <summary>
        ///     Crée un utilisateur.
        /// </summary>
        /// <param name="id">Identifiant de l'utilisateur.</param>
        /// <param name="lastName">Nom de famille de l'utilisateur.</param>
        /// <param name="firstName">Prénom de l'utilisateur.</param>
        /// <param name="email">Adresse électronique de l'utilisateur.</param>
        /// <param name="login">Login de l'utilisateur.</param>
        /// <param name="password">Mode de passe de l'utilisateur.</param>
        /// <param name="windowsAccount">Compte Windows de l'utilisateur.</param>
        /// <returns></returns>
        IMediaPerfUser CreateUser(int id, string lastName, string firstName, string email, string login, string password,
            string windowsAccount);
    }
}