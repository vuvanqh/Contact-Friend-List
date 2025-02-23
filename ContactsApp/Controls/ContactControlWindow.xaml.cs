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

namespace ContactsApp.Controls
{
    /// <summary>
    /// Interaction logic for ContactControlWindow.xaml
    /// </summary>
    public partial class ContactControlWindow : UserControl
    {
        public Contact Contact
        {
            get { return (Contact)GetValue(ContactProperty); }
            set { SetValue(ContactProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Contact.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ContactProperty =
            DependencyProperty.Register("Contact", typeof(Contact), typeof(ContactControlWindow), new PropertyMetadata(new Contact(),SetText));

        private static void SetText(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ContactControlWindow window = (ContactControlWindow)d;
            if (window!=null)
            {
                window.NameBlock.Text = (e.NewValue as Contact)?.Name;
                window.EmailBlock.Text = (e.NewValue as Contact)?.Email;
                window.PhoneBlock.Text = (e.NewValue as Contact)?.PhoneNumber;
            }
        }

        public ContactControlWindow()
        {
            InitializeComponent();
        }
    }
}
