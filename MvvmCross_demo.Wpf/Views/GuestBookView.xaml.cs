﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MvvmCross.Platforms.Wpf.Presenters.Attributes;
using MvvmCross.Platforms.Wpf.Views;

namespace MvvmCross_demo.Wpf.Views
{

    [MvxContentPresentation]
    /// <summary>
    /// Interaction logic for GuestBookView.xaml
    /// </summary>
    public partial class GuestBookView : MvxWpfView
    {
        public GuestBookView()
        {
            InitializeComponent();
        }
    }
}
