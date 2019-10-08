using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPerf.Framework.Application.MVVM.ViewModels.Controls
{
    public class HeaderViewModel
    {

        #region Fields

        #endregion

        #region Properties

        public virtual string CurrentUserFullName { get; protected set; }

        #endregion

        #region Constructor
        public HeaderViewModel()
        {
            //if (IsInDesignMode)
            //{
            //    // ReSharper disable once VirtualMemberCallInConstructor
            //    CurrentUserFullName = "John Snow";
            //}
        }

        /*
        protected HeaderViewModel(ISqiUser currentUser)
        {
            InitializeCurrentUserFullName(currentUser);
        }
        */
        #endregion

        #region Methods
/*
        public static HeaderViewModel Create(ISqiUser currentUser)
        {
            return ViewModelSource.Create(() => new HeaderViewModel(currentUser));
        }

        private void InitializeCurrentUserFullName(ISqiUser currentUser)
        {
            CurrentUserFullName = $"{currentUser.FirstName} {currentUser.LastName}";
        }
        */
        #endregion
    }
}
