using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Common;

namespace TagdigWindowsForm
{
    public partial class UjTag : Form
    {
       
        public UjTag()
        {
            InitializeComponent();
        }

        private void UjTag_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            Program.nyito.Show();
        }

        //az azonosító mező Autoincrement tulajdonságot kapott
        private void bt_ujtag_Click(object sender, EventArgs e)
        {
            Program.sql.CommandText = "INSERT INTO `ugyfel`(`nev`, `szulev`, `irszam`, `orsz`) VALUES ('" + tb_nev.Text + "','" + num_szulev.Value + "','" + tb_irszam.Text + "','" + tb_orszag.Text + "')";
            try
            {
                if (string.IsNullOrWhiteSpace(tb_nev.Text) || string.IsNullOrWhiteSpace(tb_irszam.Text) || string.IsNullOrWhiteSpace(tb_orszag.Text))
                {
                    MessageBox.Show("Üresen maradt mező(k), vagy a mező(k) csak szóközöket tartalmaz(nak). Töltsd ki a mezőt/mezőket!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    Program.sql.ExecuteNonQuery();
                    tb_nev.Text = "";
                    num_szulev.Value = 1900;
                    tb_irszam.Text = "";
                    tb_orszag.Text = "";
                    MessageBox.Show("Az új tag felvétele sikeresen megtörént", "Sikeres tagfelvétel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 

            }
            catch (MySqlException ex)
            {
                string message = Convert.ToString(ex.Message);
                MessageBox.Show(message, "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_nev.Text = "";
                num_szulev.Value = 1900;
                tb_irszam.Text = "";
                tb_orszag.Text = "";
            }
        }
    }
}
