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
/// Interaction logic for SwitchWindow.xaml
/// </summary>
public partial class SwitchWindow : Window
{
    public SwitchWindow()
    {
        InitializeComponent();
    }
    private void Operation_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("ok");
        Close();
    }
}