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

namespace SortedListApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SortedList sortedList;
        string data = "";

        public MainWindow()
        {
            InitializeComponent();
            sortedList = new SortedList();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            if ((keyTxt.Text == "") || (valTxt.Text == ""))
            {
                MessageBox.Show("กรุณาใส่ข้อมูล");
            }
            else 
            {
                sortedList.Add(int.Parse(keyTxt.Text), valTxt.Text);
                ICollection collection = sortedList.Keys;

                data = "";

                foreach(int key in collection)
                {
                    data = data + "Key : " + key.ToString() + " = " + sortedList[key].ToString() + "\n";
                }

                MessageBox.Show(data);

                keyTxt.Text = "";
                valTxt.Text = "";
            }

        }
    }
}
