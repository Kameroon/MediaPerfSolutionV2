using MediaPerf.Framework.Application.MVVM.ViewModels.Controls;
using MediaPerf.Framework.Application.Resources;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPerf.Framework.Application.MVVM.ViewModels
{
    public class MainViewModelBase //: ViewModelBase
    {
        #region Fields

        public const string DOCUMENTS_GROUP_NAME = "DocumentsGroup";

        #endregion

        #region Properties

        public virtual string AboutLabel { get; } = ApplicationLabels.MenuApplicationAboutLabel;

        public virtual int ActiveDocumentIndex { get; set; }

        public virtual string ApplicationLabel { get; } = ApplicationLabels.MenuApplicationLabel;

        public virtual string DocumentsGroupName { get; } = DOCUMENTS_GROUP_NAME;

        public virtual string ExitLabel { get; } = ApplicationLabels.MenuApplicationExitLabel;

        public virtual string GeneralLabel { get; } = ApplicationLabels.MenuCategoryGeneralLabel;

        public virtual HeaderViewModel HeaderViewModel { get; protected set; }

        public virtual bool IsPopupVisible { get; protected set; }

        public virtual string MainMenuLabel { get; } = ApplicationLabels.MainMenuLabel;

        public virtual ObservableCollection<object> Panels { get; } = new ObservableCollection<object>();

        public virtual PopupViewModel PopupViewModel { get; protected set; }

        public virtual string StatusBarLabel { get; } = ApplicationLabels.StatusBarLabel;

        //private ISessionService SessionService { get; } = InstanceLocator.Current.GetInstance<ISessionService>();

        #endregion

        #region Methods

        public void Exit()
        {
            Environment.Exit(0);
        }

        public void HidePopup()
        {
            PopupViewModel = null;
            IsPopupVisible = false;
        }

        public void SetFocusOnSelectedPanel() => ActiveDocumentIndex = Panels.Count - 1;

        public void ShowPopup(string message, Action validateAction)
        {
            //PopupViewModel = PopupViewModel.Create(this, message, validateAction);
            IsPopupVisible = true;
        }

        public void ShowPopup(string message, Action validateAction, Action invalidateAction,
            Action cancelAction = null)
        {
            //PopupViewModel = PopupViewModel.Create(this, message, validateAction, invalidateAction, cancelAction);
            IsPopupVisible = true;
        }

        protected virtual void Initialize()
        {
            //var currentUser = SessionService.GetCurrentUser();
            //HeaderViewModel = HeaderViewModel.Create(currentUser);
        }

        #endregion
    }
}
