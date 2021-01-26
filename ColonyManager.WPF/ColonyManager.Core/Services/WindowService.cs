using ColonyManager.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace ColonyManager.Core.Services
{
    public class WindowService : IWindowService
    {
        public void ShowWindow(object viewModel)
        {
            var window = new Window();
            window.Content = viewModel;
            window.Show();
        }
    }
}
