using System;
using System.Collections;
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

namespace ArrayListApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arrayList;
        public MainWindow()
        {
            InitializeComponent();
            arrayList = new ArrayList();
        }

        private void btonAdd_Click(object sender, RoutedEventArgs e)
        {
            arrayList.Add(txtInput.Text);
            txtInput.Text = "";
        }

        private void btonRemove_Click(object sender, RoutedEventArgs e)
        {
            arrayList.Remove(txtInput.Text);
            txtInput.Text = "";
        }

        private void btonShow_Click(object sender, RoutedEventArgs e)
        {
            foreach(string data in arrayList)
            {
                MessageBox.Show(data.ToString());
            }
                MessageBox.Show("Total Index : " + arrayList.Count.ToString());
        }
    }
}
