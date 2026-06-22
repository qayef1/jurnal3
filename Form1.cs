namespace Modul3_103022400070
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Tidak set default values agar bisa validasi ComboBox kosong
        }

        private void buttonKonversi_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi 1: Cek apakah kedua ComboBox sudah dipilih
                if (comboBoxDari.SelectedIndex == -1 || comboBoxKe.SelectedIndex == -1)
                {
                    MessageBox.Show("Pilih satuan terlebih dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validasi 2: Cek apakah TextField Nilai Awal kosong atau bukan angka valid
                if (string.IsNullOrWhiteSpace(textBoxNilaiAwal.Text))
                {
                    MessageBox.Show("Masukkan angka yang valid", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validasi 3: Parse input - cek apakah input adalah angka
                if (!double.TryParse(textBoxNilaiAwal.Text, out double nilaiAwal))
                {
                    MessageBox.Show("Masukkan angka yang valid", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
