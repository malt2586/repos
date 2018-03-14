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

namespace GUI
{
    /// <summary>
    /// Interaction logic for DepositWindow.xaml
    /// </summary>
    public partial class DepositWindow : Window
    {
        public DepositWindow()
        {
            InitializeComponent();
        }

        private void TbxDeposit_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (int.TryParse(tbxDeposit.Text, out int result))
            {
                lblNewBalance.Content = (int)lblCurBalance.Content + result;
            }
            else
            {
                lblNewBalance.Content = lblCurBalance.Content;
            }
        }

        private void BtnDeposit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
