using System;
using System.Windows;
using System.Windows.Controls;

namespace SynchDataGridScroll
{
    public class CustomDataGrid : DataGrid
    {
        public double VerticalScrollValue
        {
            get { return (double)GetValue(VerticalScrollValueProperty); }
            set { SetValue(VerticalScrollValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for VerticalScrollValue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty VerticalScrollValueProperty =
            DependencyProperty.Register("VerticalScrollValue", typeof(double), typeof(CustomDataGrid), new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, OnVerticalScrollValueChanged));

        private static void OnVerticalScrollValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            CustomDataGrid dg = d as CustomDataGrid;
            if (dg == null || dg.ScrollViewer == null) return;
            dg.ScrollViewer.ScrollToVerticalOffset(dg.VerticalScrollValue);
        }
        public ScrollViewer ScrollViewer
        {
            get { return (ScrollViewer)GetValue(ScrollViewerProperty); }
            set { SetValue(ScrollViewerProperty, value); }
        }
        // Using a DependencyProperty as the backing store for ScrollViewer.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ScrollViewerProperty =
            DependencyProperty.Register("ScrollViewer", typeof(ScrollViewer), typeof(CustomDataGrid), new PropertyMetadata(null));

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            ScrollViewer = VisualTreeHelperEx.FindChild<ScrollViewer>(this);
        }
    }
}
