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

        private void txtM_KeyUp_1(object sender, KeyEventArgs e)
        {
            double douM;
            douM = Convert.ToDouble(txtM.Text);

            txtCM.Text = string.Format("{0:0.##########}", douM * 100);
            txtKM.Text = string.Format("{0:0.##########}", douM * 0.001);
            txtIN.Text = string.Format("{0:0.##########}", douM * 39.37);
            txtFT.Text = string.Format("{0:0.##########}", douM * 3.28);
            txtYard.Text = string.Format("{0:0.##########}", douM * 1.09);
        }

        private void txtKM_KeyUp(object sender, KeyEventArgs e)
        {
            double douKM;
            douKM = Convert.ToDouble(txtKM.Text);

            txtCM.Text = string.Format("{0:0.##########}", douKM * 100);
            txtM.Text = string.Format("{0:0.##########}", douKM * 1000);
            txtIN.Text = string.Format("{0:0.##########}", douKM * 39370.1);
            txtFT.Text = string.Format("{0:0.##########}", douKM * 3280.84);
            txtYard.Text = string.Format("{0:0.##########}", douKM * 1093.61);
        }

        private void txtIN_KeyUp(object sender, KeyEventArgs e)
        {
            double douIn;
            douIn = Convert.ToDouble(txtIN.Text);

            txtCM.Text = string.Format("{0:0.##########}", douIn * 2.54);
            txtM.Text = string.Format("{0:0.##########}", douIn * 0.0254);
            txtKM.Text = string.Format("{0:0.##########}", douIn * 0.0000254);
            txtFT.Text = string.Format("{0:0.##########}", douIn * 0.0833);
            txtYard.Text = string.Format("{0:0.##########}", douIn * 0.0278);
        }

        private void txtFT_TextChanged(object sender, TextChangedEventArgs e)
        {
            double douFt;
            douFt = Convert.ToDouble(txtFT.Text);

            txtCM.Text = string.Format("{0:0.##########}", douFt * 30.48);
            txtM.Text = string.Format("{0:0.##########}", douFt * 0.3048);
            txtKM.Text = string.Format("{0:0.##########}", douFt * 0.0003048);
            txtIN.Text = string.Format("{0:0.##########}", douFt * 12);
            txtYard.Text = string.Format("{0:0.##########}", douFt * 0.3333);
        }

        private void txtYard_KeyUp(object sender, KeyEventArgs e)
        {
            double douYard;
            douYard = Convert.ToDouble(txtYard.Text);

            txtCM.Text = string.Format("{0:0.##########}", douYard * 91.44);
            txtM.Text = string.Format("{0:0.##########}", douYard * 0.9144);
            txtKM.Text = string.Format("{0:0.##########}", douYard * 0.0009144);
            txtIN.Text = string.Format("{0:0.##########}", douYard * 36);
            txtFT.Text = string.Format("{0:0.##########}", douYard * 3);
        }

        private void ButtonAllClear_Click(object sender, RoutedEventArgs e)
        {
            txtCM.Text = "0";
            txtM.Text = "0";
            txtKM.Text = "0";
            txtIN.Text = "0";
            txtFT.Text = "0";
            txtYard.Text = "0";
        }
    }
}
