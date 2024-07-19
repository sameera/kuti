﻿using Kuti.Windows.Common.VirtualDesktops;
using System.Windows.Controls;

namespace Kuti.Windows.Settings.Pages
{
    /// <summary>
    /// Interaction logic for PinnedAppsPage.xaml
    /// </summary>
    public partial class PinnedAppsPage : Page
    {
        public PinnedAppsPage()
        {
            InitializeComponent();

            Loaded += (_, _) => {
                var viewModel = new PinnedAppsViewModel(App.GetRequiredService<IDesktopsManager>());
                viewModel.RefreshModel();
                DataContext = viewModel;
            };
        }
    }
}
