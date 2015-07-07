// Copyright (c) Microsoft Corporation. All rights reserved.
//
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ExampleGallery
{
    public sealed partial class CustomControlExample : UserControl
    {
        public CustomControlExample()
        {
            this.InitializeComponent();

            if (ThumbnailGenerator.IsDrawingThumbnail)
            {
                Content = new GlowTextCustomControl()
                {
                    Text = "Glow",
                    GlowAmount = 30,
                    GlowColor = Colors.Yellow,
                    TextColor = Colors.White,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center
                };
            }
        }

        private void UserControl_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (e.NewSize.Width > e.NewSize.Height)
                demoPanel.Orientation = Orientation.Horizontal;
            else
                demoPanel.Orientation = Orientation.Vertical;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (ThumbnailGenerator.IsDrawingThumbnail)
                return;

            Pulse.Begin();
        }
    }
}