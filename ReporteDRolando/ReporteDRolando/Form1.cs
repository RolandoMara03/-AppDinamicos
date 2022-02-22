using ReporteDRolando.Data;
using ReporteDRolando.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReporteDRolando
{
    public partial class Form1 : Form
    {
        Conexion con;
        int cont = 3;
        MenuP mnp;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por preferirnos");
            Application.Exit();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            con = new Conexion(txtUsuario.Text,txtContraseña.Text);
            Cursor.Current = Cursors.WaitCursor;

            if (txtUsuario.Text.Equals("") || txtContraseña.Text.Equals(""))
            {
                MessageBox.Show("No pueden haber campos vacios", "Alerta");
                Cursor.Current = Cursors.Default;
                return;
            }
            if (this.con.connect.State == ConnectionState.Open)
            {
             
                MessageBox.Show("Su conexion fue realizada con exito!!", "Conexion");
                mnp = new MenuP(con, txtUsuario.Text);

                mnp.Show();
                this.Hide();
            }
            else
            {
                Cursor.Current = Cursors.Default;
                --cont;
                MessageBox.Show("Error:usuario o contrasenia incorrecta ", cont + " Intentos restantes");
                if (cont == 0)
                {
                    cont = 3;
                    btnIngresar.Enabled = false;
                    btnSalir.Enabled = false;
                    Thread.Sleep(3000);
                    btnIngresar.Enabled = true;
                    btnSalir.Enabled = true;

                }


            }

        }

        private void BtnIngresar_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
}
