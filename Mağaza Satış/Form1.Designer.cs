namespace Mağaza_Satış
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ürünAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.müşteriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hareketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbHareketDataSet = new Mağaza_Satış.DbHareketDataSet();
            this.hareketTableAdapter = new Mağaza_Satış.DbHareketDataSetTableAdapters.HareketTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.txtPersonel = new System.Windows.Forms.TextBox();
            this.txtMusteri = new System.Windows.Forms.TextBox();
            this.maskedTxtFiyat = new System.Windows.Forms.MaskedTextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hareketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbHareketDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ürünAdDataGridViewTextBoxColumn,
            this.müşteriDataGridViewTextBoxColumn,
            this.personelDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hareketBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1181, 264);
            this.dataGridView1.TabIndex = 0;
            // 
            // ürünAdDataGridViewTextBoxColumn
            // 
            this.ürünAdDataGridViewTextBoxColumn.DataPropertyName = "Ürün Ad";
            this.ürünAdDataGridViewTextBoxColumn.HeaderText = "Ürün Ad";
            this.ürünAdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ürünAdDataGridViewTextBoxColumn.Name = "ürünAdDataGridViewTextBoxColumn";
            // 
            // müşteriDataGridViewTextBoxColumn
            // 
            this.müşteriDataGridViewTextBoxColumn.DataPropertyName = "Müşteri";
            this.müşteriDataGridViewTextBoxColumn.HeaderText = "Müşteri";
            this.müşteriDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.müşteriDataGridViewTextBoxColumn.Name = "müşteriDataGridViewTextBoxColumn";
            // 
            // personelDataGridViewTextBoxColumn
            // 
            this.personelDataGridViewTextBoxColumn.DataPropertyName = "Personel";
            this.personelDataGridViewTextBoxColumn.HeaderText = "Personel";
            this.personelDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.personelDataGridViewTextBoxColumn.Name = "personelDataGridViewTextBoxColumn";
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            // 
            // hareketBindingSource
            // 
            this.hareketBindingSource.DataMember = "Hareket";
            this.hareketBindingSource.DataSource = this.dbHareketDataSet;
            // 
            // dbHareketDataSet
            // 
            this.dbHareketDataSet.DataSetName = "DbHareketDataSet";
            this.dbHareketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hareketTableAdapter
            // 
            this.hareketTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.maskedTxtFiyat);
            this.groupBox1.Controls.Add(this.txtMusteri);
            this.groupBox1.Controls.Add(this.txtPersonel);
            this.groupBox1.Controls.Add(this.txtUrunAd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 272);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(350, 280);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ekle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Müşteri:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Personel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fiyat:";
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(125, 37);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(205, 30);
            this.txtUrunAd.TabIndex = 1;
            // 
            // txtPersonel
            // 
            this.txtPersonel.Location = new System.Drawing.Point(125, 120);
            this.txtPersonel.Name = "txtPersonel";
            this.txtPersonel.Size = new System.Drawing.Size(205, 30);
            this.txtPersonel.TabIndex = 1;
            // 
            // txtMusteri
            // 
            this.txtMusteri.Location = new System.Drawing.Point(125, 79);
            this.txtMusteri.Name = "txtMusteri";
            this.txtMusteri.Size = new System.Drawing.Size(205, 30);
            this.txtMusteri.TabIndex = 1;
            // 
            // maskedTxtFiyat
            // 
            this.maskedTxtFiyat.Location = new System.Drawing.Point(125, 166);
            this.maskedTxtFiyat.Mask = "00000";
            this.maskedTxtFiyat.Name = "maskedTxtFiyat";
            this.maskedTxtFiyat.Size = new System.Drawing.Size(205, 30);
            this.maskedTxtFiyat.TabIndex = 2;
            this.maskedTxtFiyat.ValidatingType = typeof(int);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(125, 218);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(205, 55);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1180, 565);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hareketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbHareketDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DbHareketDataSet dbHareketDataSet;
        private System.Windows.Forms.BindingSource hareketBindingSource;
        private DbHareketDataSetTableAdapters.HareketTableAdapter hareketTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn müşteriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.MaskedTextBox maskedTxtFiyat;
        private System.Windows.Forms.TextBox txtMusteri;
        private System.Windows.Forms.TextBox txtPersonel;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

