using MediaPerf.Framework.Application.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPerf.Framework.Application.MVVM.ViewModels.Controls
{
    /*
    public class PopupViewModel
    {
        #region Fields

        #endregion

        #region Properties

        #endregion

        #region Constructor
        public PopupViewModel()
        {

        }
        #endregion

        #region Methods

        #endregion
    }
    */

    //[POCOViewModel]
    public class PopupViewModel //: ViewModelBase
    {
        #region Properties

        public Action CancelAction { get; set; }

        public virtual string CancelLabel { get; set; } = ApplicationLabels.CancelLabel;

        public Action InvalidateAction { get; set; }

        public virtual string InvalidateLabel { get; set; } = ApplicationLabels.NoLabel;

        public virtual string Message { get; set; }

        public Action ValidateAction { get; set; }

        public virtual string ValidateLabel { get; set; }

        private MainViewModelBase MainViewModel { get; }

        #endregion

        #region Constructors

        public PopupViewModel()
        {
        }

        protected PopupViewModel(MainViewModelBase mainViewModel, string message, Action validateAction)
        {
            MainViewModel = mainViewModel ?? throw new ArgumentNullException(nameof(mainViewModel));
            Message = message;
            ValidateAction = validateAction;
            ValidateLabel = ApplicationLabels.OkLabel;
        }

        protected PopupViewModel(MainViewModelBase mainViewModel, string message, Action validateAction,
            Action invalidateAction, Action cancelAction = null)
        {
            MainViewModel = mainViewModel ?? throw new ArgumentNullException(nameof(mainViewModel));
            Message = message;
            ValidateAction = validateAction;
            ValidateLabel = ApplicationLabels.YesLabel;
            InvalidateAction = invalidateAction;
            CancelAction = cancelAction;
        }

        #endregion

        #region Methods

        /*
        public static PopupViewModel Create(MainViewModelBase mainViewModel, string message, Action validateAction)
        {
            return ViewModelSource.Create(() => new PopupViewModel(mainViewModel, message, validateAction));
        }

        public static PopupViewModel Create(MainViewModelBase mainViewModel, string message, Action validateAction,
            Action invalidateAction, Action cancelAction = null)
        {
            return ViewModelSource.Create(() =>
                new PopupViewModel(mainViewModel, message, validateAction, invalidateAction, cancelAction));
        }
        */

        public bool CanCancel() => CancelAction != null;

        public void Cancel()
        {
            MainViewModel.HidePopup();
            CancelAction.Invoke();
        }

        public bool CanInvalidate() => InvalidateAction != null;

        public void Invalidate()
        {
            MainViewModel.HidePopup();
            InvalidateAction.Invoke();
        }

        public void Validate()
        {
            MainViewModel.HidePopup();
            ValidateAction?.Invoke();
        }

        #endregion
    }
}

