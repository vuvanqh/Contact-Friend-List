using SQLite;
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

namespace ContactsApp
{
    /// <summary>
    /// Interaction logic for UpdateDeleteWindow.xaml
    /// </summary>
    public partial class UpdateDeleteWindow : Window
    {
        Contact contact;
        public UpdateDeleteWindow(Contact contact)
        {
            InitializeComponent();
            this.contact = contact;
            NameBox.Text = contact.Name;
            EmailBox.Text = contact.Email;
            PhoneBox.Text = contact.PhoneNumber;
        }

        private void Operation_Click(object sender, RoutedEventArgs e)
        {
            using SQLiteConnection connection = new SQLiteConnection(App.dbPath);
            if(sender == Delete)
                connection.Delete(contact);
            if (sender == Update)
            {
                contact.Name = NameBox.Text;
                contact.Email = EmailBox.Text; 
                contact.PhoneNumber = PhoneBox.Text;
                connection.Update(contact);
            }
            Close();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
