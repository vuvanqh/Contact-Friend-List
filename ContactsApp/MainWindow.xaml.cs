using SQLite;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ContactsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Contact> contacts = new List<Contact>();

        public MainWindow()
        {
            InitializeComponent();
            ReadDatabase();
        }

        private void NewContact_Click(object sender, RoutedEventArgs e)
        {
            NewContactWindow newContactWindow = new NewContactWindow();
            newContactWindow.ShowDialog(); //show & wait for it to be closed

            ReadDatabase();
        }

        void ReadDatabase()
        {
            using SQLiteConnection connection = new SQLiteConnection(App.dbPath);
            connection.CreateTable<Contact>();
            contacts = connection.Table<Contact>().OrderBy(c => c.Name).ToList();

            ContactList.ItemsSource = contacts;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e) //filtering
        {
            var searchBox = sender as TextBox;
            var filteredList = contacts.Where(c => c.Name.ToLower().Contains(searchBox.Text.ToLower())).ToList();
            ContactList.ItemsSource = filteredList;
        }

        private void ContactList_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            Contact? contact = ContactList.SelectedItem as Contact;
            if(contact != null)
            {
                UpdateDeleteWindow window = new UpdateDeleteWindow(contact);

                window.ShowDialog();
            }
            ReadDatabase();
        }

        private void Change_ButtonUp(object sender, MouseButtonEventArgs e)
        {
            SwitchWindow window = new SwitchWindow();
            window.ShowDialog();
        }
    }
}