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
    public partial class TagModositas : Form
    {
        public TagModositas()
        {
            InitializeComponent();
        }

        private void TagModositas_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            Program.nyito.Show();
        }

        string beazonosit;
        string azon;
        bool siker = false;
        int azono;


   
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
                            string azonosito;
                            while (olvas.Read())
                            {
                                azonosito = (olvas["azon"].ToString());
                                tb_nev.Text = (olvas["nev"].ToString());
                                num_szulev.Text = (olvas["szulev"].ToString());
                                tb_irszam.Text = (olvas["irszam"].ToString());
                                tb_orszag.Text = (olvas["orsz"].ToString());
                            }
                            olvas.Close();
                        }
                        siker = true;
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
                            tb_nev.Text = (olvas["nev"].ToString());
                            num_szulev.Text = (olvas["szulev"].ToString());
                            tb_irszam.Text = (olvas["irszam"].ToString());
                            tb_orszag.Text = (olvas["orsz"].ToString());
                        }
                        olvas.Close();
                    }
                    siker = true;
                }
                else
                {
                    MessageBox.Show("Nem választottál ki kritériumot, válassz egyet a legördülő menüből!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    comb_kriterium.Focus();
                    siker = false;
                }

                if (siker == true)
                {
                    beazonosit = tb_nev.Text;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;

                    tb_nev.Visible = true;
                    num_szulev.Visible = true;
                    tb_irszam.Visible = true;
                    tb_orszag.Visible = true;
                    bt_aktualizal.Visible = true;
                    bt_megsem.Visible = true;

                    if (cb_nev.Checked == false)
                    {
                        tb_nev.ReadOnly = true;
                    }
                    if (cb_szulev.Checked == false)
                    {
                        num_szulev.ReadOnly = true;
                    }
                    if (cb_irszam.Checked == false)
                    {
                        tb_irszam.ReadOnly = true;
                    }
                    if (cb_orszag.Checked == false)
                    {
                        tb_orszag.ReadOnly = true;
                    }

                }

            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message);
                Environment.Exit(0);
                throw;
            }
        }

        private void bt_aktualizal_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_nev.ReadOnly == false)
                {
                    Program.sql.CommandText = "UPDATE `ugyfel` SET `nev` = '" + tb_nev.Text + "' WHERE `nev` LIKE '" + beazonosit + "'";
                    Program.sql.ExecuteNonQuery();
                }
                if (num_szulev.ReadOnly == false)
                {
                    Program.sql.CommandText = "UPDATE `ugyfel` SET `szulev`  = '" + Convert.ToInt32(num_szulev.Value) + "'  WHERE `nev` LIKE '" + beazonosit + "'";
                    Program.sql.ExecuteNonQuery();
                }
                if (tb_irszam.ReadOnly == false)
                {
                    int irszam;
                    bool success = Int32.TryParse(tb_irszam.Text, out irszam);
                    if (success)
                    {
                        Program.sql.CommandText = "UPDATE `ugyfel` SET `irszam` = '" + Convert.ToInt32(tb_irszam.Text) + "' WHERE `nev` LIKE '" + beazonosit + "'";
                        Program.sql.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Nem számot adtál meg", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tb_irszam.Clear();
                        tb_irszam.Focus();
                    }
                }
                if (tb_orszag.ReadOnly == false)
                {
                    Program.sql.CommandText = "UPDATE `ugyfel` SET `orsz` = '" + tb_orszag + "' WHERE `nev` LIKE '" + beazonosit + "'";
                    Program.sql.ExecuteNonQuery();
                }
                /*using (MySqlDataReader olvas = Program.sql.ExecuteReader())
                {
                    while (olvas.Read())
                    {
                        
                    }
                    olvas.Close();
                }*/


                MessageBox.Show("A módosítás sikeresen megtörént", "Sikeres módosítás", MessageBoxButtons.OK, MessageBoxIcon.Information);



                azon = "";
                azono = 0;
                tb_adat.Text = "";
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;

                tb_nev.Visible = false;
                num_szulev.Visible = false;
                tb_irszam.Visible = false;
                tb_orszag.Visible = false;
                bt_aktualizal.Visible = false;
                bt_megsem.Visible = false;

                cb_nev.Checked = false;
                cb_szulev.Checked = false;
                cb_irszam.Checked = false;
                cb_orszag.Checked = false;

                tb_nev.ReadOnly = false;
                num_szulev.ReadOnly = false;
                tb_irszam.ReadOnly = false;
                tb_orszag.ReadOnly = false;

                comb_kriterium.SelectedIndex = -1;


            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message);
                Environment.Exit(0);
                throw;
            }

            

        }

        private void bt_megsem_Click(object sender, EventArgs e)
        {
            azon = "";
            azono = 0;
            tb_adat.Text = "";
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;

            tb_nev.Visible = false;
            num_szulev.Visible = false;
            tb_irszam.Visible = false;
            tb_orszag.Visible = false;
            bt_aktualizal.Visible = false;
            bt_megsem.Visible = false;

            cb_nev.Checked = false;
            cb_szulev.Checked = false;
            cb_irszam.Checked = false;
            cb_orszag.Checked = false;

            tb_nev.ReadOnly = false;
            num_szulev.ReadOnly = false;
            tb_irszam.ReadOnly = false;
            tb_orszag.ReadOnly = false;

            comb_kriterium.SelectedIndex = -1;

        }
    }
}