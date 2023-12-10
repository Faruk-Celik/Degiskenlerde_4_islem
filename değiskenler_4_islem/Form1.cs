namespace değiskenler_4_islem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam, carpım, bölüm, fark;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            toplam = sayi1 + sayi2;
            carpım = sayi1 * sayi2;
            fark = sayi1 - sayi2;
            bölüm = sayi1 / sayi2;
            MessageBox.Show("toplam:" + toplam + "\n" + "fark" + fark + "\n" + "carpım:" + carpım + "\n" + "bölüm:" + bölüm + "\n");


        }
    }
}