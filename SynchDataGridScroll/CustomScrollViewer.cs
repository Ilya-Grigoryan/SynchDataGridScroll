using System;
using System.Windows.Controls;

namespace SynchDataGridScroll
{
    public class CustomScrollViewer : ScrollViewer
    {
        private CustomDataGrid _customDataGrid;
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            _customDataGrid = VisualTreeHelperEx.FindParent<CustomDataGrid>(this);
        }

        protected override void OnScrollChanged(ScrollChangedEventArgs e)
        {
            base.OnScrollChanged(e);

            if (Math.Abs(e.VerticalChange) > 0.001 && (Math.Abs(_customDataGrid.VerticalScrollValue - e.VerticalOffset) > 0.001))
            {
                _customDataGrid.VerticalScrollValue = e.VerticalOffset;
            }
        }
    }
}
