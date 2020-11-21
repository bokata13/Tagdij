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
using System.Globalization;

namespace TagdigWindowsForm
{
    public partial class UjBefizetes : Form
    {
        public UjBefizetes()
        {
            InitializeComponent();
        }

        private void UjBefizetes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            Program.nyito.Show();
        }

        string azon;
        int azono;
        int azonosito;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comb_kriterium.SelectedIndex == 1)
                {

                    bool success = Int32.TryParse(tb_adat.Text, out azono);
                    if (success)
                    {
                        Program.sql.CommandText = "SELECT * FROM `ugyfel` WHERE `azon` LIKE '" + azono + "'";
                        using (MySqlDataReader olvas = Program.sql.ExecuteReader())
                        {
                            while (olvas.Read())
                            {
                                tb_adat.Text = (olvas["azon"].ToString());
                                tb_adat2.Text = (olvas["nev"].ToString());

                            }
                            olvas.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nem számot adtál meg", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tb_adat.Clear();
                        tb_adat.Focus();
                    }
                }
                else if (comb_kriterium.SelectedIndex == 0)
                {
                    azon = tb_adat.Text;
                    Program.sql.CommandText = "SELECT * FROM `ugyfel` WHERE `nev` LIKE '" + azon + "'";
                    using (MySqlDataReader olvas = Program.sql.ExecuteReader())
                    {
                        while (olvas.Read())
                        {
                            tb_adat2.Text = (olvas["azon"].ToString());
                            tb_adat.Text = (olvas["nev"].ToString());
                        }
                        olvas.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Nem választottál ki kritériumot, válassz egyet a legördülő menüből!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    comb_kriterium.Focus();
                }


            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message);
                Environment.Exit(0);
                throw;
            }
        }
        private void bt_rogzit_Click(object sender, EventArgs e)
        {
            try 
            {
                if (Int32.TryParse(tb_adat.Text, out azono))
                {
                    azonosito = azono;
                }
                else 
                {
                    azonosito = Convert.ToInt32(tb_adat2.Text);
                }


                int osszeg;
                if (Int32.TryParse(tb_osszeg.Text, out osszeg))
                {
                    osszeg = Convert.ToInt32(tb_osszeg.Text);
                    string date = (DateTime.Now.ToString("yyyy-MM-dd HH':'mm':'ss"));
                    Program.sql.CommandText = "INSERT INTO `befiz`(`azon`, `datum`, `osszeg`) VALUES ('" + azonosito + "','" + date + "','" + osszeg + "')";
                    Program.sql.ExecuteNonQuery();
                    MessageBox.Show("Befizetés sikeresen rögzítve", "Befizetés sikeres", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_adat.Text = "";
                    tb_adat2.Text = "";
                    comb_kriterium.SelectedIndex = -1;
                    azon = "";
                    azono = 0;
                    azonosito = 0;
                    tb_osszeg.Text = "";
                    osszeg = 0;
      
                }
                else 
                {
                    MessageBox.Show("Nem számot adtál meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_osszeg.Clear();
                    tb_osszeg.Focus();
                }
                

                
            }
            catch(MySqlException myex)
            {
                MessageBox.Show(myex.Message);
                Environment.Exit(0);
                throw;
            }
        }

        private void bt_megse_Click(object sender, EventArgs e)
        {
            tb_adat.Text = "";
            tb_adat2.Text = "";
            comb_kriterium.SelectedIndex = -1;
            azon = "";
            azono = 0;
            azonosito = 0;
            tb_osszeg.Text = "";
        }


    }
}
