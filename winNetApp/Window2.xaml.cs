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
using System.IO;

namespace winNetApp
{
    /// <summary>
    /// Window2.xaml の相互作用ロジック
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string path = "test.txt";
            string text = InputText.Text;

            //「path」に「text」を書き込み
            File.WriteAllText(path, text);
        }

        private void LaodButton_Click(object sender, RoutedEventArgs e)
        {
            string path = "test.txt";
            LoadText.Text = File.ReadAllText(path);
        }
    }
}
