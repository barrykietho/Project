using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project01
{
    public partial class Form3 : Form
    {
        private string[] arrNguyenLieu;
        ArrayList arrayListAmount = new ArrayList();
        public Form3()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void bt_chuyen_doi_Click(object sender, EventArgs e)
        {
            SlipString(tb_cong_thuc.Text.Trim());
            for(int i = 0; i < arrNguyenLieu.Length; i++)
            {
                Label label = new Label();
                label.Width = 150;
                label.Height = 30;
                label.Text = arrNguyenLieu[i].Trim();
                nguyenLieuInput.Controls.Add(label);

                Label label1 = new Label();
                label1.Width = 80;
                label1.Height = 30;
                label1.Text = arrayListAmount[i].ToString();
                nguyenLieuConvert.Controls.Add(label1);
            }
        }
        private void SlipString(String nglieu)
        {
            arrNguyenLieu = nglieu.Split(',');
            foreach (string nguyenlieu in arrNguyenLieu)
            {
                tachSo(nguyenlieu);
            }
        }
        private void tachSo(string stringHaveNum)
        {
            string b = string.Empty;
            double value = 0.0;
            double result;
            for(int i = 0; i < stringHaveNum.Length; i++)
            {
                if (Char.IsDigit(stringHaveNum[i]))
                    b += stringHaveNum[i];
            }
            if (b.Length > 0)
            {
                value = double.Parse(b);
            }
            result = double.Parse(tb_so_ng.Text) * value / double.Parse(tb_so_ng_ct.Text);
            arrayListAmount.Add(result);
               
        }
    }
}
