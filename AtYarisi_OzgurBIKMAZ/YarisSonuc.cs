using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarisi_OzgurBIKMAZ
{
    public partial class YarisSonuc : Form
    {
        List<string[]> listSonuclar = new List<string[]>();
        public YarisSonuc(List<string[]>listSonuclar)
        {
            InitializeComponent();
            this.listSonuclar = listSonuclar;
        }

        private void YarisSonuc_Load(object sender, EventArgs e)
        {
            if (listSonuclar.Count==6)
            {
                listAyak1.Items.AddRange(listSonuclar[0]);
                listAyak2.Items.AddRange(listSonuclar[1]);
                listAyak3.Items.AddRange(listSonuclar[2]);
                listAyak4.Items.AddRange(listSonuclar[3]);
                listAyak5.Items.AddRange(listSonuclar[4]);
                listAyak6.Items.AddRange(listSonuclar[5]);
            }
            else
            {
                MessageBox.Show("Tüm Yarışlar Oynanmadı.","Yarış Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }
    }
}
