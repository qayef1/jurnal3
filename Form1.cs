namespace Modul3_103022400070
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Set default values
            comboBoxDari.SelectedIndex = 0;
            comboBoxKe.SelectedIndex = 1;
        }

        private void buttonKonversi_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi input
                if (string.IsNullOrWhiteSpace(textBoxNilaiAwal.Text))
                {
                    MessageBox.Show("Mohon masukkan nilai awal!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (comboBoxDari.SelectedIndex == -1 || comboBoxKe.SelectedIndex == -1)
                {
                    MessageBox.Show("Mohon pilih satuan dari dan ke!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Parse input
                if (!double.TryParse(textBoxNilaiAwal.Text, out double nilaiAwal))
                {
                    MessageBox.Show("Nilai awal harus berupa angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string satuanDari = comboBoxDari.SelectedItem?.ToString() ?? "";
                string satuanKe = comboBoxKe.SelectedItem?.ToString() ?? "";

                // Konversi suhu
                double hasil = KonversiSuhu(nilaiAwal, satuanDari, satuanKe);

                // Tampilkan hasil
                textBoxHasil.Text = hasil.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double KonversiSuhu(double nilai, string dari, string ke)
        {
            // Jika satuan sama, langsung return
            if (dari == ke)
                return nilai;

            // Konversi ke Celcius terlebih dahulu sebagai base
            double celcius = dari switch
            {
                "Celcius" => nilai,
                "Fahrenheit" => (nilai - 32) * 5 / 9,
                "Kelvin" => nilai - 273.15,
                "Reamur" => nilai * 5 / 4,
                _ => nilai
            };

            // Konversi dari Celcius ke satuan tujuan
            return ke switch
            {
                "Celcius" => celcius,
                "Fahrenheit" => (celcius * 9 / 5) + 32,
                "Kelvin" => celcius + 273.15,
                "Reamur" => celcius * 4 / 5,
                _ => celcius
            };
        }
    }
}
