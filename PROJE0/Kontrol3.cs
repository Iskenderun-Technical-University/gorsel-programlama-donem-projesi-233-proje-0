using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJE0
{
    public partial class Kontrol3 : UserControl
    {
        public Kontrol3()
        {
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Siparişiniz Alınmıştır Bizi Tercih Ettiğiniz İçin Teşekkür Ederiz");
            
        }
    }
}
