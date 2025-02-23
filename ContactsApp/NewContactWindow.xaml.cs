﻿using SQLite;
using System;
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
using System.Windows.Shapes;

namespace ContactsApp;

/// <summary>
/// Interaction logic for NewContactWindow.xaml
/// </summary>
public partial class NewContactWindow : Window
{
    public NewContactWindow()
    {
        InitializeComponent();
    }
    private void Save_Click(object sender, RoutedEventArgs e)
    {
        Contact contact = new Contact() 
        {
            Name = NameBox.Text, 
            Email = EmailBox.Text, 
            PhoneNumber=PhoneBox.Text 
        };
 
        using SQLiteConnection connection = new SQLiteConnection(App.dbPath);
        connection.Insert(contact);

        Close();
    }
}
