using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace _20703802_ErdemGozlu_BST206
{

    public partial class MainWindow : Window
    {
        public class User
        {
            public string MARKA { get; set; }

            public string MODEL { get; set; }

            public int FIYAT { get; set; }

        }

        ObservableCollection<User> li = new ObservableCollection<User>();

        public MainWindow()
        {
            InitializeComponent();

            List<User> items = new List<User>();
            li.Add(new User() { MARKA = "AUIDI", MODEL = "Q5", FIYAT = 755478 });
            li.Add(new User() { MARKA = "ALFA ROMEO", MODEL = "GIULIETTA", FIYAT = 856531 });
            li.Add(new User() { MARKA = "BMW", MODEL = "320I", FIYAT = 756800 });
            li.Add(new User() { MARKA = "MERCEDES", MODEL = "E250", FIYAT = 925589 });
            li.Add(new User() { MARKA = "FORD", MODEL = "FOCUS", FIYAT = 457325 });
            li.Add(new User() { MARKA = "FIAT", MODEL = "EGEA", FIYAT = 353987 });
            li.Add(new User() { MARKA = "NISSAN", MODEL = "QOASHQAI", FIYAT = 420698 });
            li.Add(new User() { MARKA = "VOLKSWAGEN", MODEL = "TROC", FIYAT = 784330 });
            li.Add(new User() { MARKA = "OPEL", MODEL = "INSIGNIA", FIYAT = 633487 });
            lvUsers.ItemsSource = li;
        }

        


        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            li.Add(new User() { MARKA = textBox1.Text, MODEL = textBox2.Text, FIYAT = Convert.ToInt32(textBox3.Text) });
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (lvUsers.SelectedIndex >= 0)
            {
                User user = lvUsers.SelectedItem as User;
                li.Remove(user);
            }
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            User yeniUser = new User();
            yeniUser.MARKA = textBox1.Text;
            yeniUser.MODEL = textBox2.Text;
            yeniUser.FIYAT = Convert.ToInt32(textBox3.Text);

            User eskiUser = lvUsers.SelectedItem as User;
            li.Remove(eskiUser);
            li.Add(yeniUser);
        }
    }
}

