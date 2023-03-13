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

            double douM;
            douM = Convert.ToDouble(txtM.Text); 
            txtKM.Text = string.Format("{0:0.##########}", douM / 10);

            double douKM;
            douKM = Convert.ToDouble(txtKM.Text);
            txtIN.Text = string.Format("{0:0.##########}", douKM / 0.000025240000);

            double douIN;
            douIN = Convert.ToDouble(txtM.Text);
            txtFT.Text = string.Format("{0:0.##########}", douIN * 12);

            double douFT;
            douFT = Convert.ToDouble(txtM.Text);
            txtYard.Text = string.Format("{0:0.##########}", douFT / 3);

        }
    }
}
