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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.ff.Items.Add(new ListBoxItem() { Content = "shenjin" });
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            MessageBox.Show("关闭主窗口");

            Window1 wis = new Window1();
            wis.Show();

        }

        //private void Window_Closed(object sender, KeyEventArgs e)
        //{

        //}
    }
}
