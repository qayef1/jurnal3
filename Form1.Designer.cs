namespace Modul3_103022400070
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelSatuanAwal = new Label();
            comboBoxDari = new ComboBox();
            labelNilaiAwal = new Label();
            textBoxNilaiAwal = new TextBox();
            buttonKonversi = new Button();
            labelSatuanAkhir = new Label();
            comboBoxKe = new ComboBox();
            labelNilaiAkhir = new Label();
            textBoxHasil = new TextBox();
            SuspendLayout();
            // 
            // labelSatuanAwal
            // 
            labelSatuanAwal.AutoSize = true;
            labelSatuanAwal.Location = new Point(30, 30);
            labelSatuanAwal.Name = "labelSatuanAwal";
            labelSatuanAwal.Size = new Size(94, 20);
            labelSatuanAwal.TabIndex = 0;
            labelSatuanAwal.Text = "Satuan Awal";
            // 
            // comboBoxDari
            // 
            comboBoxDari.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDari.FormattingEnabled = true;
            comboBoxDari.Items.AddRange(new object[] { "Celcius", "Fahrenheit", "Kelvin", "Reamur" });
            comboBoxDari.Location = new Point(30, 60);
            comboBoxDari.Name = "comboBoxDari";
            comboBoxDari.Size = new Size(150, 28);
            comboBoxDari.TabIndex = 1;
            // 
            // labelNilaiAwal
            // 
            labelNilaiAwal.AutoSize = true;
            labelNilaiAwal.Location = new Point(250, 30);
            labelNilaiAwal.Name = "labelNilaiAwal";
            labelNilaiAwal.Size = new Size(76, 20);
            labelNilaiAwal.TabIndex = 2;
            labelNilaiAwal.Text = "Nilai Awal";
            // 
            // textBoxNilaiAwal
            // 
            textBoxNilaiAwal.Location = new Point(250, 60);
            textBoxNilaiAwal.Name = "textBoxNilaiAwal";
            textBoxNilaiAwal.Size = new Size(150, 27);
            textBoxNilaiAwal.TabIndex = 3;
            // 
            // buttonKonversi
            // 
            buttonKonversi.Location = new Point(250, 110);
            buttonKonversi.Name = "buttonKonversi";
            buttonKonversi.Size = new Size(150, 35);
            buttonKonversi.TabIndex = 4;
            buttonKonversi.Text = "Convert";
            buttonKonversi.UseVisualStyleBackColor = true;
            buttonKonversi.Click += buttonKonversi_Click;
            // 
            // labelSatuanAkhir
            // 
            labelSatuanAkhir.AutoSize = true;
            labelSatuanAkhir.Location = new Point(30, 180);
            labelSatuanAkhir.Name = "labelSatuanAkhir";
            labelSatuanAkhir.Size = new Size(97, 20);
            labelSatuanAkhir.TabIndex = 5;
            labelSatuanAkhir.Text = "Satuan Akhir";
            // 
            // comboBoxKe
            // 
            comboBoxKe.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxKe.FormattingEnabled = true;
            comboBoxKe.Items.AddRange(new object[] { "Celcius", "Fahrenheit", "Kelvin", "Reamur" });
            comboBoxKe.Location = new Point(30, 210);
            comboBoxKe.Name = "comboBoxKe";
            comboBoxKe.Size = new Size(150, 28);
            comboBoxKe.TabIndex = 6;
            // 
            // labelNilaiAkhir
            // 
            labelNilaiAkhir.AutoSize = true;
            labelNilaiAkhir.Location = new Point(250, 180);
            labelNilaiAkhir.Name = "labelNilaiAkhir";
            labelNilaiAkhir.Size = new Size(79, 20);
            labelNilaiAkhir.TabIndex = 7;
            labelNilaiAkhir.Text = "Nilai Akhir";
            // 
            // textBoxHasil
            // 
            textBoxHasil.Location = new Point(250, 210);
            textBoxHasil.Name = "textBoxHasil";
            textBoxHasil.ReadOnly = true;
            textBoxHasil.Size = new Size(150, 27);
            textBoxHasil.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 300);
            Controls.Add(textBoxHasil);
            Controls.Add(labelNilaiAkhir);
            Controls.Add(comboBoxKe);
            Controls.Add(labelSatuanAkhir);
            Controls.Add(buttonKonversi);
            Controls.Add(textBoxNilaiAwal);
            Controls.Add(labelNilaiAwal);
            Controls.Add(comboBoxDari);
            Controls.Add(labelSatuanAwal);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSatuanAwal;
        private ComboBox comboBoxDari;
        private Label labelNilaiAwal;
        private TextBox textBoxNilaiAwal;
        private Button buttonKonversi;
        private Label labelSatuanAkhir;
        private ComboBox comboBoxKe;
        private Label labelNilaiAkhir;
        private TextBox textBoxHasil;
    }
}
