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
using Entities;

namespace GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Account> accList = new List<Account>();

        public MainWindow()
        {
            InitializeComponent();

            lbxAccounts.ItemsSource = accList;
        }

        private void BtnNewAccount_Click(object sender, RoutedEventArgs e)
        {
            NewAccountWindow window = new NewAccountWindow();
            window.Owner = this;
            if (window.ShowDialog() == false)
            {
                accList.Add(window.NewAccount);
                lbxAccounts.Items.Refresh();
            }
        }

        private void BtnDeposit_Click(object sender, RoutedEventArgs e)
        {
            DepositWindow window = new DepositWindow();
            window.Owner = this;

            window.lblID.Content = accList[lbxAccounts.SelectedIndex].Id;
            window.lblName.Content = accList[lbxAccounts.SelectedIndex].Name;
            window.lblCurBalance.Content = accList[lbxAccounts.SelectedIndex].Balance;
            window.lblNewBalance.Content = null;
            window.tbxDeposit.Text = null;

            if (window.ShowDialog() == false)
            {
                accList[lbxAccounts.SelectedIndex].Credit(int.Parse(window.tbxDeposit.Text));
                lbxAccounts.Items.Refresh();
            }
        }

        private void BtnWithdraw_Click(object sender, RoutedEventArgs e)
        {
            WithdrawWindow window = new WithdrawWindow();
            window.Owner = this;

            window.lblID.Content = accList[lbxAccounts.SelectedIndex].Id;
            window.lblName.Content = accList[lbxAccounts.SelectedIndex].Name;
            window.lblCurBalance.Content = accList[lbxAccounts.SelectedIndex].Balance;
            window.lblNewBalance.Content = null;
            window.tbxWithdrawal.Text = null;

            if (window.ShowDialog() == false)
            {
                accList[lbxAccounts.SelectedIndex].Debit(int.Parse(window.tbxWithdrawal.Text));
                lbxAccounts.Items.Refresh();
            }
        }
    }
}