using System.Windows;
using System.Windows.Controls;

namespace MediaPerf.Framework.Application.MVVM.Views.Components
{
    public class FieldGrid : Grid
    {
        #region Fields

        public static readonly DependencyProperty ControlLengthProperty = DependencyProperty.Register(
            "ControlLength", typeof(GridLength), typeof(FieldGrid), new PropertyMetadata(default(GridLength)));

        #endregion

        #region Properties

        public GridLength ControlLength
        {
            get => (GridLength)GetValue(ControlLengthProperty);
            set => SetValue(ControlLengthProperty, value);
        }

        #endregion

        #region Constructors

        public FieldGrid() => ControlLength = new GridLength(2, GridUnitType.Star);

        #endregion
    }
}
