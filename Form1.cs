using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Data.OleDb;
using CrystalDecisions.CrystalReports.Engine;


namespace tpbd
{
    public partial class Form1 : Form
    {
        OracleConnection conn;
        OracleCommand cmd,c1,c2,c3,c4,c5;
        OracleParameter salar_baza, spor, premii_brute, nume, prenume, functie, retineri;
        String str,q1,q2,q3,q4,q5;
        OracleDataAdapter da;
        OleDbConnection cn;
        OleDbDataAdapter d1;
        DataSet s1;
        string strSQL;

        private void statPlataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox29.Visible = true;
            button7.Visible = true;
            dataGridView3.Visible = true;
            crystalReportViewer1.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                cn = new OleDbConnection("Provider=OraOLEDB.Oracle;Password=student;User ID=student;Data Source=localhost");
                strSQL = "select * from angajati where nume=" + "'" + textBox29.Text + "'"; ;
                d1 = new OleDbDataAdapter(strSQL, cn);
                s1 = new DataSet();
                d1.Fill(s1, "angajati");

               // conn = new OracleConnection("DATA SOURCE = localhost:1521 / xe; PASSWORD = student; PERSIST SECURITY INFO = True; USER ID = student");
               // strSQL = "SELECT * FROM angajati where id>" +textBox29.Text;
               // da = new OracleDataAdapter(strSQL, conn);
               // s1 = new DataSet();
              //  da.Fill(s1, "angajati");

                dataGridView3.DataSource = s1.Tables["angajati"];
                // CrystalReport1 raport = new CrystalReport1();
                // crystalReportViewer1.DisplayGroupTree = false;
                //  raport.SetDataSource(s1.Tables["angajati"]);
                //  crystalReportViewer1.ReportSource = raport;

               

                ReportDocument rap = new ReportDocument();
                rap.Load(System.Web.HttpContext.Current.Server.MapPath("~/CrystalReport1.rpt"));
                rap.SetDataSource(s1.Tables["angajati"]);
                crystalReportViewer1.ReportSource = rap;

            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message.ToString());
                label8.Text = ex.ToString();
            }
        }

        DataSet ds;
        

        private void button6_Click(object sender, EventArgs e)
        {       
            try
            {
                conn.Open();
                q5 = "Delete from angajati where nume= +'" + textBox20.Text.ToString() + "'";
                c5 = new OracleCommand(q5, conn);
                c5.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Inregistrare stearsa");

                conn.Close();
                this.aNGAJATITableAdapter.Fill(this.dataSet1.ANGAJATI);
            }
            catch (Exception ex)
            {
                label8.Text = "error " + ex.ToString();
            }
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mODIFPROCENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox20.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("Numele angajatului poate contine doar litere!");
            }
            try
            {
                conn.Open();
                q4 = "Select * from angajati where prenume= +'" + textBox20.Text.ToString() + "'";
                c4 = new OracleCommand(q4, conn);
                OracleDataReader dr = c4.ExecuteReader();

                if (dr.Read())
                {
                    textBox21.Text = "Nume: " + (dr["nume"].ToString()) + " Prenume: " + (dr["prenume"].ToString()) + " Functie: " + (dr["functie"].ToString()) + " Salar de baza: " + (dr["salar_baza"].ToString()) + " Spor: " + (dr["spor"].ToString()) + " Premii brute: " + (dr["premii_brute"].ToString()) + " Total brut: " + (dr["total_brut"].ToString()) + " Brut impozabil: " + (dr["brut_impozabil"].ToString()) + " Impozit: " + (dr["impozit"].ToString()) + " CAS: " + (dr["cas"].ToString()) + " CASS: " + (dr["cass"].ToString()) + " Retineri: " + (dr["retineri"].ToString()) + " Virat card: " + (dr["virat_card"].ToString());

                }
                else
                {
                    MessageBox.Show("Nu s-a gasit angajatul");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                label8.Text = "error " + ex.ToString();
            }
        }
       


        private void button1_Click(object sender, EventArgs e)
        {
            
                try
            {
                conn.Open();
                nume = new OracleParameter();
                prenume = new OracleParameter();
                functie = new OracleParameter();
                salar_baza = new OracleParameter();
                spor = new OracleParameter();
                premii_brute = new OracleParameter();
                retineri = new OracleParameter();

                nume.Value = textBox1.Text;
                prenume.Value = textBox2.Text;
                functie.Value = textBox3.Text;
                salar_baza.Value = textBox4.Text;
                spor.Value = textBox5.Text;
                premii_brute.Value = textBox6.Text;
                retineri.Value = textBox7.Text;

                str = "insert into angajati values(0,:2,:3,:4,:5,:6,:7,0,0,0,0,0,:13,0)";
                cmd = new OracleCommand(str, conn);
                cmd.Parameters.Add(nume);
                cmd.Parameters.Add(prenume);
                cmd.Parameters.Add(functie);
                cmd.Parameters.Add(salar_baza);
                cmd.Parameters.Add(spor);
                cmd.Parameters.Add(premii_brute);
                cmd.Parameters.Add(retineri);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Ati adaugat un nou angajat");
                this.aNGAJATITableAdapter.Fill(this.dataSet1.ANGAJATI);
                if (!System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "^[a-zA-Z ]"))
                    MessageBox.Show("Numele angajatului poate contine doar litere!");
                if (!System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "^[a-zA-Z ]"))
                    MessageBox.Show("Prenumele angajatului poate contine doar litere!");
                if (!System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "^[a-zA-Z ]"))
                    MessageBox.Show("Functia angajatului poate contine doar litere!");
                if (System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, "[^0-9]"))
                    MessageBox.Show("Campul salar de baza poate contine doar cifre!");
                if (System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, "[^0-9]"))
                    MessageBox.Show("Campul spor poate contine doar cifre!");
                if (System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, "[^0-9]"))
                    MessageBox.Show("Campul premii brute poate contine doar cifre!");
                if (System.Text.RegularExpressions.Regex.IsMatch(textBox6.Text, "[^0-9]"))
                    MessageBox.Show("Campul retineri poate contine doar cifre!");
            }
            catch (Exception ex)
            {
                label8.Text = "error " + ex.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dataGridView2.CurrentRow.Cells[1].Value.ToString()) || string.IsNullOrWhiteSpace(dataGridView2.CurrentRow.Cells[2].Value.ToString()) || string.IsNullOrWhiteSpace(dataGridView2.CurrentRow.Cells[3].Value.ToString()) || string.IsNullOrWhiteSpace(dataGridView2.CurrentRow.Cells[4].Value.ToString()) || string.IsNullOrWhiteSpace(dataGridView2.CurrentRow.Cells[5].Value.ToString()) || string.IsNullOrWhiteSpace(dataGridView2.CurrentRow.Cells[6].Value.ToString()) || string.IsNullOrWhiteSpace(dataGridView2.CurrentRow.Cells[12].Value.ToString()))
            {
                MessageBox.Show("Nu ati completat toate campurile");
            }
            else
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(dataGridView2.CurrentRow.Cells[1].Value.ToString(), "^[a-zA-Z ]") || !System.Text.RegularExpressions.Regex.IsMatch(dataGridView2.CurrentRow.Cells[2].Value.ToString(), "^[a-zA-Z ]") || !System.Text.RegularExpressions.Regex.IsMatch(dataGridView2.CurrentRow.Cells[3].Value.ToString(), "^[a-zA-Z ]") || System.Text.RegularExpressions.Regex.IsMatch(dataGridView2.CurrentRow.Cells[4].Value.ToString(), "[^0-9]") || System.Text.RegularExpressions.Regex.IsMatch(dataGridView2.CurrentRow.Cells[5].Value.ToString(), "[^0-9]") || System.Text.RegularExpressions.Regex.IsMatch(dataGridView2.CurrentRow.Cells[6].Value.ToString(), "[^0-9]") || System.Text.RegularExpressions.Regex.IsMatch(dataGridView2.CurrentRow.Cells[12].Value.ToString(), "[^0-9]"))
                {

                    MessageBox.Show("Datele introduse nu sunt corecte");
                }
                else
                {
                    try
                    {
                        conn.Open();
                        q3 = "update angajati set nume= '" + dataGridView2.CurrentRow.Cells[1].Value.ToString() + "',prenume= '" + dataGridView2.CurrentRow.Cells[2].Value.ToString() + "',functie= '" + dataGridView2.CurrentRow.Cells[3].Value.ToString() + "',salar_baza= '" + int.Parse(dataGridView2.CurrentRow.Cells[4].Value.ToString()) + "',spor= '" + int.Parse(dataGridView2.CurrentRow.Cells[5].Value.ToString()) + "',premii_brute= '" + int.Parse(dataGridView2.CurrentRow.Cells[6].Value.ToString()) + "',retineri= '" + int.Parse(dataGridView2.CurrentRow.Cells[12].Value.ToString()) + "' where nr_crt= '" + int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString()) + "'";
                        c3 = new OracleCommand(q3, conn);
                        c3.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Actualizare realizata cu succes");
                        this.aNGAJATITableAdapter.Fill(this.dataSet1.ANGAJATI);
                    }
                    catch (Exception ex)
                    {
                        label8.Text = "error " + ex.ToString();
                    }
                }
            }
        }

        private void stergereAngajatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox20.Visible = true;
            textBox21.Visible = true;
            label17.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            textBox27.Visible = false;
            textBox28.Visible = false;


        }

        private void ajutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PictureBox pb1 = new PictureBox();
            textBox27.Visible = false;

            textBox8.Visible = true;
            textBox8.Text = "1.INTRODUCERE DATE ~ Pentru a introduce, sterge sau edita datele angajatilor, click pe Introducere Date.";
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "D:/tpbd/introducere.png";
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

            textBox9.Visible = true;
            textBox9.Text = "2.ACTUALIZARE ~ Vor aparea patru alte optiuni. Prima este ACTUALIZARE. La click pe aceasta optiune se vor putea actualiza datele. De asemenea la click pe Adaugare angajati sau stergere se adauga, respectiv sterg date.";
            pictureBox2.Visible = true;
            pictureBox2.ImageLocation = "D:/tpbd/add.png";
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;

            textBox10.Visible = true;
            textBox10.Text = "3.TIPARIRE ~ Sub optiunea tiparire vor aparea doua alte optiuni: Stat de plata si fluturasi. La click pe una dintre aceste optiuni se va crea un raport fie sub forma de stat de plata sau fluturas pentru angajatul introdus. ";
            pictureBox3.Visible = true;
            pictureBox3.ImageLocation = "D:/tpbd/stat.png";
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;

            textBox11.Visible = true;
            textBox11.Text = "4.MODIFICARE PROCENTE ~ La alegerea acestei optiuni se va deschide o noua fereastra. In casuta text introduceti parola si apasati Ok. Cancel va inchide noua fereastra. Daca parola este corecta vor aparea valorile impozitului, CAS-ului si CASS-ului. Puteti sterge valoarea pe care doriti sa o modificati si sa introduceti noua valoare(1). Faceti click pe butnul Modifica(2) si observati schimbarea si in tabel(3). ";
            pictureBox4.Visible = true;
            pictureBox4.ImageLocation = "D:/tpbd/parola.png";
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.Visible = true;
            pictureBox5.ImageLocation = "D:/tpbd/modif.png";
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;

            textBox22.Visible = true;
            textBox22.Text = "5.IESIRE ~ Aceasta optiune va inchide aplicatia. ";

            textBox23.Visible = true;
            textBox23.Text = "6.CUM ACTUALIZAM DATELE ~  Dupa alegerea optiunii Actualizare Date veti introduce numele angajatului cautat(1) si se face click pe butonul Cauta(2) - vor aparea casute cu datele angajatului. Se sterge valoarea corespunzatoare casutei pe care doriti sa o editati si se introduce noua valoare(3) dupa care faceti click pe butonul Actualizare(4).";
            pictureBox6.Visible = true;
            pictureBox6.ImageLocation = "D:/tpbd/actualizare.png";
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;


            textBox24.Visible = true;
            textBox24.Text = "7.ACTUALIZARE MAI MULTI ANGAJATI ~ In tabel se face click pe celula de modificat si se introduce noua valoare. Apoi, pentru a sugera ca editarea s-a incheiat faceti click pe orice alta celula si va aparea un buton sub tabel. Dati click pe butonul aparut, Actualizare din tabel, iar datele vor fi actualizate . ";
            pictureBox7.Visible = true;
            pictureBox7.ImageLocation = "D:/tpbd/tabel.png";
            pictureBox7.SizeMode = PictureBoxSizeMode.AutoSize;

            textBox25.Visible = true;
            textBox25.Text = "8.ADAUGARE ANGAJATI ~ Vor aparea casute editabile. Introduceti datele noului angajat si dati click pe butonul Adauga. Veti putea observa ca angajatul adaugat va aparea in tabelul de jos alaturi de ceilalti angajati. ";
            pictureBox8.Visible = true;
            pictureBox8.ImageLocation = "D:/tpbd/adaugare.png";
            pictureBox8.SizeMode = PictureBoxSizeMode.AutoSize;

            textBox26.Visible = true;
            textBox26.Text = "9.STERGERE ANGAJATI ~ Introduceti in casuta text numele angajatului cautat si dati click pe butonul Cauta. Vor aparea datele angajatului mai jos si un buton Sterge la apasarea caruia se va sterge inregistrarea corespunzatoare angajatului. ";
            pictureBox9.Visible = true;
            pictureBox9.ImageLocation = "D:/tpbd/sterge.png";
            pictureBox9.SizeMode = PictureBoxSizeMode.AutoSize;

        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            button4.Visible = true;
            
        }

        private void actualizareDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox12.Visible = true;
            label9.Visible = true;
            button2.Visible = true;
            dataGridView2.Visible = true;

            textBox27.Visible = false;
            textBox28.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox13.Text)|| string.IsNullOrWhiteSpace(textBox14.Text)|| string.IsNullOrWhiteSpace(textBox15.Text)|| string.IsNullOrWhiteSpace(textBox16.Text)||string.IsNullOrWhiteSpace(textBox17.Text)|| string.IsNullOrWhiteSpace(textBox18.Text)|| string.IsNullOrWhiteSpace(textBox19.Text))
            {
                MessageBox.Show("Nu ati completat toate campurile");
            }
            else
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(textBox13.Text, "^[a-zA-Z ]") || !System.Text.RegularExpressions.Regex.IsMatch(textBox14.Text, "^[a-zA-Z ]") || !System.Text.RegularExpressions.Regex.IsMatch(textBox15.Text, "^[a-zA-Z ]") || System.Text.RegularExpressions.Regex.IsMatch(textBox16.Text, "[^0-9]") || System.Text.RegularExpressions.Regex.IsMatch(textBox17.Text, "[^0-9]") || System.Text.RegularExpressions.Regex.IsMatch(textBox18.Text, "[^0-9]") || System.Text.RegularExpressions.Regex.IsMatch(textBox19.Text, "[^0-9]"))
                {

                    MessageBox.Show("Datele introduse nu sunt corecte");
                }
                else
                {
                    try
                    {
                        conn.Open();
                        q2 = "update angajati set nume= '" + textBox13.Text.ToString() + "',prenume= '" + textBox14.Text.ToString() + "',functie= '" + textBox15.Text.ToString() + "',salar_baza= '" + textBox16.Text.ToString() + "',spor= '" + textBox17.Text.ToString() + "',premii_brute= '" + textBox18.Text.ToString() + "',retineri= '" + textBox19.Text.ToString() + "' where nume= '" + textBox12.Text.ToString() + "'";
                        c2 = new OracleCommand(q2, conn);
                        c2.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Actualizare realizata cu succes");
                        this.aNGAJATITableAdapter.Fill(this.dataSet1.ANGAJATI);
                    }
                    catch (Exception ex)
                    {
                        label8.Text = "error " + ex.ToString();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;

            textBox13.Visible = true;
            textBox14.Visible = true;
            textBox15.Visible = true;
            textBox16.Visible = true;
            textBox17.Visible = true;
            textBox18.Visible = true;
            textBox19.Visible = true;

            button3.Visible = true;
            if (string.IsNullOrWhiteSpace(textBox12.Text))
            {
                MessageBox.Show("Nu ati completat numele angajatului cautat");
            }
            else
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(textBox12.Text, "^[a-zA-Z ]"))
                { MessageBox.Show("Numele angajatului poate contine doar litere!"); }
                else
                {

                    try
                    {
                        conn.Open();
                        q1 = "Select * from angajati where nume= +'" + textBox12.Text.ToString() + "'";
                        c1 = new OracleCommand(q1, conn);
                        OracleDataReader dr = c1.ExecuteReader();
                        // c1.ExecuteNonQuery();
                        if (dr.Read())
                        {
                            textBox13.Text = (dr["nume"].ToString());
                            textBox14.Text = (dr["prenume"].ToString());
                            textBox15.Text = (dr["functie"].ToString());
                            textBox16.Text = (dr["salar_baza"].ToString());
                            textBox17.Text = (dr["spor"].ToString());
                            textBox18.Text = (dr["premii_brute"].ToString());
                            textBox19.Text = (dr["retineri"].ToString());


                        }
                        else
                        {
                            MessageBox.Show("Nu s-a gasit angajatul");
                        }
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        label8.Text = "error " + ex.ToString();
                    }

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox27.Visible = true;
            textBox27.Text = "Click mai sus pe Ajutor pentru mai multe detalii despre operarea aplicatiei.\n Click pe Iesire pentru a inchide aplicatia.";

            textBox28.Visible = true;
            textBox28.Text = "Cozma Raluca-Andreea";
            try
            {
                conn = new OracleConnection("DATA SOURCE=localhost:1521/XE;PASSWORD=student;USER ID=STUDENT");
                conn.Open();
                label8.Text = conn.DataSource;
                //label2.Text = conn.ServerVersion;
                conn.Close();
            }
            catch (Exception ex)
            {
                label8.Text = ex.ToString() + " error";
            }
            // TODO: This line of code loads data into the 'dataSet1.ANGAJATI' table. You can move, or remove it, as needed.
            this.aNGAJATITableAdapter.Fill(this.dataSet1.ANGAJATI);
        }



        public Form1()
        {
            InitializeComponent();
        }

        private void adaugareAngajatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;

            button1.Visible = true;

            dataGridView1.Visible = true;

            textBox5.Text = "0";
            textBox7.Text = "0";

            textBox27.Visible = false;
            textBox28.Visible = false;



        }
    }
}
