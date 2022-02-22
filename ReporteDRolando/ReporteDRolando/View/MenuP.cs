using ReporteDRolando.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReporteDRolando.View
{
    public partial class MenuP : Form
    {
        Conexion con;      
        public MenuP(Conexion con,String User)
        {
            InitializeComponent();
            this.con = con;
            this.txtUser.Text = User;

        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por preferirnos");
            Application.Exit();
        }
    }
}
