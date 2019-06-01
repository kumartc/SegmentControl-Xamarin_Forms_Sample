using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Foundation;
using SegmentControl.iOS.Renderer;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(NoScrollViewRenderer), typeof(NoScrollViewRenderer))]
namespace SegmentControl.iOS.Renderer
{
    public class NoScrollViewRenderer : ScrollViewRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null || this.Element == null)
            {
                return;
            }

            if (e.OldElement != null)
            {
                e.OldElement.PropertyChanged -= OnElementPropertyChanged;
            }

            e.NewElement.PropertyChanged += OnElementPropertyChanged;
        }

        private void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            this.ShowsHorizontalScrollIndicator = false;
        }
    }
}