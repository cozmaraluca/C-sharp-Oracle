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
using System.Globalization;
using System.Security.Cryptography;

namespace tpbd
{
    public partial class Form2 : Form
    {
        String q1,q2,q3,q4;
        OracleConnection conn;
        //OracleParameter cas_p, cass_p, impozit_p, parola;
        OracleCommand c1,c2,c3,c4;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private byte[] _keys;

        public string Encrypt(string Value)
        {
            try
            {
                byte[] data = UTF8Encoding.UTF8.GetBytes(Value);
                string Encrypted = string.Empty;

                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(Value));

                    using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                    {
                        ICryptoTransform transform = tripDes.CreateEncryptor();
                        byte[] results = transform.TransformFinalBlock(data, 0, data.Length);

                        Encrypted = Convert.ToBase64String(results, 0, results.Length);
                    }

                    this._keys = keys;
                }

                return Encrypted;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public string Decrypt(string Value, byte[] keys)
        {
            try
            {
                byte[] data = Convert.FromBase64String(Value);
                string Decrypted = string.Empty;

                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                    {
                        ICryptoTransform transform = tripDes.CreateDecryptor();
                        byte[] results = transform.TransformFinalBlock(data, 0, data.Length);

                        Decrypted = UTF8Encoding.UTF8.GetString(results);
                    }
                }

                return Decrypted;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                q2 = "update procente set impozit_p= '" + textBox2.Text.ToString() + "',cas_p= '" + textBox3.Text.ToString() + "',cass_p= '" + textBox4.Text.ToString() +  "'";
                c2 = new OracleCommand(q2, conn);
                c2.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Actualizare realizata cu succes");
                this.pROCENTETableAdapter.Fill(this.dataSet1.PROCENTE);

            }
            catch (Exception ex)
            {
                label2.Text = "error " + ex.ToString();
            }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            try
            {
                conn = new OracleConnection("DATA SOURCE=localhost:1521/XE;PASSWORD=student;USER ID=STUDENT");
                conn.Open();
                label2.Text = conn.DataSource;
                conn.Close();
            }
            catch (Exception ex)
            {
                label2.Text = ex.ToString() + " error";
            }
            // TODO: This line of code loads data into the 'dataSet1.PROCENTE' table. You can move, or remove it, as needed.
            this.pROCENTETableAdapter.Fill(this.dataSet1.PROCENTE);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            


            try
            {
                conn.Open();
                q1 = "Select * from procente";
                c1 = new OracleCommand(q1, conn);
                OracleDataReader dr = c1.ExecuteReader();
                

                if (dr.Read())
                {
                    
                    if (Encrypt(textBox1.Text).Equals(dr["parola"].ToString()))
                    {
                        textBox1.Visible = false;
                        label1.Visible = false;
                        button1.Visible = false;
                        button2.Visible = false;

                        textBox2.Visible = true;
                        textBox3.Visible = true;
                        textBox4.Visible = true;
                        textBox5.Visible = true;
                        label3.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;
                        button3.Visible = true;
                        dataGridView1.Visible = true;


                        try
                        {

                                textBox2.Text = (dr["impozit_p"].ToString());
                                textBox3.Text = (dr["cas_p"].ToString());
                                textBox4.Text = (dr["cass_p"].ToString());
                                textBox5.Text = (Decrypt(Encrypt("student"),_keys));




                        }
                        catch (Exception ex)
                        {
                            label2.Text = "error " + ex.ToString();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Parola incorecta");
                    }

                }
                conn.Close();
            }
            catch (Exception ex)
            {
                label2.Text = "error " + ex.ToString();
            }
        }
    }
}
