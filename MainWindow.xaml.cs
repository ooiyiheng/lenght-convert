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

namespace lenght_convert
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void txtCM_KeyUp(object sender, KeyEventArgs e)
        {
            double douCM; //宣告一個double變數，變數名稱叫douCM
            douCM = Convert.ToDouble(txtCM.Text); //從txtCM輸入文字框取得輸入的文字，並且轉換成double的資料型態
            txtM.Text = string.Format("{0:0.##########}", douCM / 100); 
            //將douCM的數值除以100，也就是從公分轉換成公尺


            txtKM.Text = string.Format("{0:0.##########}", douCM / 10000);

            txtIN.Text = string.Format("{0:0.##########}", douCM / 2.54);

            txtFT.Text = string.Format("{0:0.##########}", douCM / 30.45);

            txtYard.Text = string.Format("{0:0.##########}", douCM / 91.44);

        }
    }
}
