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
using System.IO;

namespace HarcsosokAppBne
{
    public partial class Form_Harcosok : Form
    {
        static MySqlConnection conn = null;
        static MySqlCommand sql = null;
        public Form_Harcosok()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "cs_harcosok";
            sb.CharacterSet = "utf8";

            conn = new MySqlConnection(sb.ToString());
            try
            {
                conn.Open();
                sql = conn.CreateCommand();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
                      

            //comboBox_user-be töltődjön be az összes harcos neve

            Hasznalolista_update();

            Harcoslista_update();
            

        }

        private void button_create_Click(object sender, EventArgs e)
        {
            if (adatlap_valid())
            {
                sql.CommandText = "INSERT INTO `harcosok`(`id`, `nev`)" +
                    " VALUES" +
                    " (NULL,' " + textBox_nev.Text.Trim() + "');";
                try
                {
                    if (sql.ExecuteNonQuery() == 1)
                    {
                        textBox_nev.Text = "";
                        MessageBox.Show("Az adatok rögzítése sikerült!");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message); // alapért hibaüzenet 
                    return;
                }


            }
        }

        private void Hasznalolista_update()
        {
            comboBox_user.SelectedIndex = -1;
            comboBox_user.Items.Clear();
            sql.CommandText = "SELECT `id`,`nev`,`letrehozas` FROM `harcosok` WHERE 1";

            using (MySqlDataReader dr = sql.ExecuteReader())
            {
                while (dr.Read())
                {
                    int id = dr.GetInt32("id");
                    string nev = dr.GetString("nev");
                    DateTime letrehozas = dr.GetDateTime("letrehozas");
                    comboBox_user.Items.Add(new Harcosok(id, nev, letrehozas));
                }
            }          
        }

        private void Harcoslista_update()
        {
            listBox_harcos.SelectedIndex = -1;
            listBox_harcos.Items.Clear();
            sql.CommandText = "SELECT `id`,`nev`,`letrehozas` FROM `harcosok` WHERE 1";

            using (MySqlDataReader dr = sql.ExecuteReader())
            {
                while (dr.Read())
                {
                    int id = dr.GetInt32("id");
                    string nev = dr.GetString("nev");
                    DateTime letrehozas = dr.GetDateTime("letrehozas");

                    listBox_harcos.Items.Add(new Harcosok(id, nev, letrehozas));

                }

            }

        }

        private void Kepesseglista_update()
        {
            listBox_kepesseg.SelectedIndex = -1;
            listBox_kepesseg.Items.Clear();
           sql.CommandText = "SELECT `id`, `nev`, `leiras`, `harcos_id` FROM `kepessegek` WHERE 1";

            using (MySqlDataReader dr = sql.ExecuteReader())
            {
                while (dr.Read())
                {
                    int kepesseg_id = dr.GetInt32("id");
                    string kepesseg_nev = dr.GetString("nev");
                    string kepesseg_leiras = dr.GetString("leiras");
                    int harcos_id = dr.GetInt32("harcos_id");

                    listBox_kepesseg.Items.Add(new Kepessegek(kepesseg_id, kepesseg_nev, kepesseg_leiras, harcos_id));
                }
            }

        }

        private void label_nev_Click(object sender, EventArgs e) // véletlenül nyomtam meg de nem törlöm,
            //mert akkor összeomlik a program.... 
        {

        }

        private bool adatlap_valid()
        {
            if (String.IsNullOrWhiteSpace(textBox_nev.Text) || textBox_nev.Text.Trim().Length < 3)
            {
                MessageBox.Show("A Név mező kitöltése kötelező!");
                return false;
            }
            sql.CommandText = "SELECT COUNT(*) FROM `harcosok` WHERE nev =" + textBox_nev.Text.Trim();
            //long ellenorzesDb = (long)sql.ExecuteScalar();
            //if (ellenorzesDb > 0)
            //{
            //    MessageBox.Show("Ilyen névvel már szerepelt harcos!");
            //    return false;
            //}
           
            return true;
        }

        private void comboBox_user_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_user.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztva harcos!");
                return;
            }

           Harcosok kival = (Harcosok)comboBox_user.SelectedItem;
           //textBox_nev.Text = kival.Nev;
          // int harcos_id = kival.Id;
           numericUpDown_harcosid.Value = ((Harcosok)comboBox_user.SelectedItem).Id;

        }

        private void button_addkepesseg_Click(object sender, EventArgs e)
        {
            if (comboBox_user.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztva harcos!");
                return;
            }

            if (String.IsNullOrWhiteSpace(textBox_kepesseg_nev_add.Text) || textBox_kepesseg_nev_add.Text.Trim().Length < 2)
            {
                MessageBox.Show("A képesség nevének kitöltése kötelező!");
                return;
            }
            if (String.IsNullOrWhiteSpace(textBox_kepesseg_nev_add.Text) || textBox_kepesseg_nev_add.Text.Trim().Length < 2)
            {
                MessageBox.Show("A leírás mező kitöltése kötelező!");
                return;
            }
            
            string nev = textBox_kepesseg_nev_add.Text.Trim();
            string leiras = textBox_kepesseg_leiras_add.Text.Trim();
           int harcos_id = ((Harcosok)comboBox_user.SelectedItem).Id;
        

            sql.CommandText = "INSERT INTO `kepessegek`(`id`, `nev`, `leiras`,`harcos_id`)" +
              " VALUES" +
              " (NULL, " + nev + "," +leiras + " ," + " , " + harcos_id + "); ";
           // sql.ExecuteNonQuery();

            try
                {
                    if (sql.ExecuteNonQuery() == 1)
                    {
                        textBox_nev.Text = "";
                        MessageBox.Show("Az adatok rögzítése sikerült!");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message); // alapért hibaüzenet 
                    return;
                }

          //  listBox_kepesseg.Items.Add(new Kepessegek(id, nev, leiras, harcos_id));
            Kepesseglista_update();
        }

        private void listBox_harcos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_harcos.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztva harcos!");
                return;
            }
           // listBox_kepesseg.Items.Add(new Kepessegek(nev));
           // Harcosok kivalaszt = (Harcosok)listBox_harcos.SelectedItem;
            //listBox_kepesseg.Text = ((Kepessegek)listBox_kepesseg.SelectedItem).Nev;
            //textBox_nev.Text = kivalaszt.Nev;
            //int harcos_id = kivalaszt.Id;
            Kepesseglista_update();
        }

        private void listBox_kepesseg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_kepesseg.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztva képesség!");
                return;
            }
            textBox_kepeseg_leiras_kiir.Text = ((Kepessegek)listBox_kepesseg.SelectedItem).Leiras;
            // Kepessegek kivalaszt = ((Kepessegek)listBox_kepesseg.SelectedItem;
            //textBox_kepeseg_leiras_kiir = Kepessegek.kepesseg_kiir();

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (listBox_kepesseg.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztva képesség");
                return;
            }
            sql.CommandText = "DELETE from `kepessegek` WHERE id = " + ((Kepessegek)listBox_kepesseg.SelectedItem).Id;
            if (sql.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Sikerült törölni az képességet!");
            }
            else
            {
                MessageBox.Show("Sikertelen volt a törlés!");
                return;
            }
            Kepesseglista_update();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (listBox_kepesseg.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztva képesség");
                return;
            }

            sql.CommandText = " UPDATE `kepessegek` SET  `leiras`= " + textBox_kepeseg_leiras_kiir.Text + 
                "WHERE `id = " + ((Kepessegek)listBox_kepesseg.SelectedItem).Id; 

         // sql.CommandText "UPDATE `kepessegek` SET `leiras`= " + textBox_kepeseg_leiras_kiir.Text +
          //    "WHERE id = " + ((Kepessegek)listBox_kepesseg.SelectedItem).Id;
          //   "`id`=[value-1]," +
          //   "`nev`=[value-2]," +

            //     "`harcos_id`=[value-4] WHERE 1";

            if (sql.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Sikerült módosítani a képességet!");
            }
            else
            {
                MessageBox.Show("Sikertelen volt a módosítás!");
                return;
            }
        }
    }
}
