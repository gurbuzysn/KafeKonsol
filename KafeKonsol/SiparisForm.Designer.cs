namespace KafeKonsol
{
    partial class SiparisForm
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
            label1 = new Label();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            UrunAd = new DataGridViewTextBoxColumn();
            BirimFiyat = new DataGridViewTextBoxColumn();
            Adet = new DataGridViewTextBoxColumn();
            TutarTL = new DataGridViewTextBoxColumn();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            numericUpDown2 = new NumericUpDown();
            label4 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(45, 21);
            label1.TabIndex = 0;
            label1.Text = "Ürün";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(13, 34);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(154, 29);
            comboBox1.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(197, 35);
            numericUpDown1.Margin = new Padding(4);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(154, 29);
            numericUpDown1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(373, 31);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(120, 32);
            button1.TabIndex = 3;
            button1.Text = "EKLE";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { UrunAd, BirimFiyat, Adet, TutarTL });
            dataGridView1.Location = new Point(13, 72);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(477, 402);
            dataGridView1.TabIndex = 4;
            // 
            // UrunAd
            // 
            UrunAd.HeaderText = "UrunAd";
            UrunAd.Name = "UrunAd";
            // 
            // BirimFiyat
            // 
            BirimFiyat.HeaderText = "BirimFiyat";
            BirimFiyat.Name = "BirimFiyat";
            // 
            // Adet
            // 
            Adet.HeaderText = "Adet";
            Adet.Name = "Adet";
            // 
            // TutarTL
            // 
            TutarTL.HeaderText = "TutarTL";
            TutarTL.Name = "TutarTL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(197, 9);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(42, 21);
            label2.TabIndex = 0;
            label2.Text = "Adet";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Location = new Point(717, 37);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(120, 32);
            button2.TabIndex = 3;
            button2.Text = "TAŞI";
            button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(584, 13);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 21);
            label3.TabIndex = 0;
            label3.Text = "Masa No:";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericUpDown2.Location = new Point(584, 40);
            numericUpDown2.Margin = new Padding(5, 6, 5, 6);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(124, 29);
            numericUpDown2.TabIndex = 2;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(583, 318);
            label4.Name = "label4";
            label4.Size = new Size(131, 25);
            label4.TabIndex = 5;
            label4.Text = "Ödeme Tutarı:";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.BackColor = Color.ForestGreen;
            button3.ForeColor = Color.White;
            button3.Location = new Point(681, 368);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(156, 46);
            button3.TabIndex = 3;
            button3.Text = "ÖDEME AL";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button4.BackColor = Color.Maroon;
            button4.ForeColor = Color.White;
            button4.Location = new Point(518, 368);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(155, 46);
            button4.TabIndex = 3;
            button4.Text = "SİPARİŞ İPTAL";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button5.BackColor = Color.Gold;
            button5.Location = new Point(518, 422);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(319, 52);
            button5.TabIndex = 3;
            button5.Text = "ANASAYFAYA DÖN";
            button5.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(734, 318);
            label5.Name = "label5";
            label5.Size = new Size(33, 25);
            label5.TabIndex = 5;
            label5.Text = "0tl";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.BackColor = Color.Tomato;
            label6.Font = new Font("Arial Black", 72F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(518, 75);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(319, 220);
            label6.TabIndex = 0;
            label6.Text = "00";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SiparisForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 483);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MinimumSize = new Size(866, 522);
            Name = "SiparisForm";
            Text = "SiparisForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn UrunAd;
        private DataGridViewTextBoxColumn BirimFiyat;
        private DataGridViewTextBoxColumn Adet;
        private DataGridViewTextBoxColumn TutarTL;
        private Label label2;
        private Button button2;
        private Label label3;
        private NumericUpDown numericUpDown2;
        private Label label4;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label5;
        private Label label6;
    }
}