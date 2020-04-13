namespace tpbd
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pROCENTEBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new tpbd.DataSet1();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.pROCENTEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pROCENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROCENTETableAdapter = new tpbd.DataSet1TableAdapters.PROCENTETableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iMPOZITPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cASPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cASSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAROLADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROCENTEBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pROCENTEBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROCENTEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROCENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROCENTEBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introduceti parola";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(158, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // pROCENTEBindingSource2
            // 
            this.pROCENTEBindingSource2.DataMember = "PROCENTE";
            this.pROCENTEBindingSource2.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(364, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(387, 224);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 28);
            this.button3.TabIndex = 7;
            this.button3.Text = "Modifica";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(364, 80);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(155, 20);
            this.textBox3.TabIndex = 8;
            this.textBox3.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(364, 129);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(155, 20);
            this.textBox4.TabIndex = 9;
            this.textBox4.Visible = false;
            // 
            // pROCENTEBindingSource1
            // 
            this.pROCENTEBindingSource1.DataMember = "PROCENTE";
            this.pROCENTEBindingSource1.DataSource = this.dataSet1;
            // 
            // pROCENTEBindingSource
            // 
            this.pROCENTEBindingSource.DataMember = "PROCENTE";
            this.pROCENTEBindingSource.DataSource = this.dataSet1;
            // 
            // pROCENTETableAdapter
            // 
            this.pROCENTETableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Impozit";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "CAS";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(415, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "CASS";
            this.label5.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iMPOZITPDataGridViewTextBoxColumn,
            this.cASPDataGridViewTextBoxColumn,
            this.cASSPDataGridViewTextBoxColumn,
            this.pAROLADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pROCENTEBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(62, 314);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 64);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.Visible = false;
            // 
            // iMPOZITPDataGridViewTextBoxColumn
            // 
            this.iMPOZITPDataGridViewTextBoxColumn.DataPropertyName = "IMPOZIT_P";
            this.iMPOZITPDataGridViewTextBoxColumn.HeaderText = "IMPOZIT_P";
            this.iMPOZITPDataGridViewTextBoxColumn.Name = "iMPOZITPDataGridViewTextBoxColumn";
            // 
            // cASPDataGridViewTextBoxColumn
            // 
            this.cASPDataGridViewTextBoxColumn.DataPropertyName = "CAS_P";
            this.cASPDataGridViewTextBoxColumn.HeaderText = "CAS_P";
            this.cASPDataGridViewTextBoxColumn.Name = "cASPDataGridViewTextBoxColumn";
            // 
            // cASSPDataGridViewTextBoxColumn
            // 
            this.cASSPDataGridViewTextBoxColumn.DataPropertyName = "CASS_P";
            this.cASSPDataGridViewTextBoxColumn.HeaderText = "CASS_P";
            this.cASSPDataGridViewTextBoxColumn.Name = "cASSPDataGridViewTextBoxColumn";
            // 
            // pAROLADataGridViewTextBoxColumn
            // 
            this.pAROLADataGridViewTextBoxColumn.DataPropertyName = "PAROLA";
            this.pAROLADataGridViewTextBoxColumn.HeaderText = "PAROLA";
            this.pAROLADataGridViewTextBoxColumn.Name = "pAROLADataGridViewTextBoxColumn";
            // 
            // pROCENTEBindingSource3
            // 
            this.pROCENTEBindingSource3.DataMember = "PROCENTE";
            this.pROCENTEBindingSource3.DataSource = this.dataSet1;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(364, 179);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(155, 20);
            this.textBox5.TabIndex = 15;
            this.textBox5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Parola";
            this.label6.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 390);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pROCENTEBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROCENTEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROCENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROCENTEBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource pROCENTEBindingSource;
        private DataSet1TableAdapters.PROCENTETableAdapter pROCENTETableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource pROCENTEBindingSource1;
        private System.Windows.Forms.BindingSource pROCENTEBindingSource2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMPOZITPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cASPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cASSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAROLADataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pROCENTEBindingSource3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        //private DataSet1TableAdapters.PROCENTTableAdapter pROCENTTableAdapter;
    }
}