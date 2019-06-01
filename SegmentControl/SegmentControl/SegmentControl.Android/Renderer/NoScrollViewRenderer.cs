using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SegmentControl.Controls;
using SegmentControl.Droid.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(NoScrollViewBar), typeof(NoScrollViewRenderer))]

namespace SegmentControl.Droid.Renderer
{
#pragma warning disable CS0618 // Type or member is obsolete
    public class NoScrollViewRenderer : ScrollViewRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null || this.Element == null)
                return;

            if (e.OldElement != null)
                e.OldElement.PropertyChanged -= OnElementPropertyChanged;

            e.NewElement.PropertyChanged += OnElementPropertyChanged;

        }

        protected void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            this.HorizontalScrollBarEnabled = false;
            this.VerticalScrollBarEnabled = false;

        }
    }
#pragma warning restore CS0618 // Type or member is obsolete
}
