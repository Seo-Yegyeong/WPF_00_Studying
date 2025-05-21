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

namespace WPF_00_Studying
{
    /// <summary>
    /// Interaction logic for P1_GridLogin.xaml
    /// </summary>
    public partial class P1_GridLogin : Page
    {
        public P1_GridLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            // Check if the username and password are correct
            if (TextBox_Id.Text == "" || TextBox_Password.Text == "")
            {               
                MessageBox.Show("아이디와 비밀번호 모두 입력해주세요!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                MessageBox.Show($"로그인 시도: {TextBox_Id.Text} / {TextBox_Password.Text}");
            }
        }
    }
}
