using System.Xml;

namespace RSS_Ile_Haber_Basliklari_Cekme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadRssTitles(string rssUrl)
        {
            listBox1.Items.Clear();

            try
            {
                using (XmlTextReader xmlread = new XmlTextReader(rssUrl))
                {
                    while (xmlread.Read())
                    {
                        if (xmlread.Name == "title")
                        {
                            listBox1.Items.Add(xmlread.ReadString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata Oluþtu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHurriyet_Click(object sender, EventArgs e)
        {
            LoadRssTitles("http://www.hurriyet.com.tr/rss/anasayfa");
        }

        private void btnMilliyet_Click(object sender, EventArgs e)
        {
            LoadRssTitles("http://www.milatgazetesi.com/rss.php");
        }

        private void btnNtv_Click(object sender, EventArgs e)
        {
            LoadRssTitles("https://www.ntv.com.tr/gundem.rss");
        }

        private void btnSabah_Click(object sender, EventArgs e)
        {
            LoadRssTitles("https://www.sabah.com.tr/rss/gundem.xml");
        }
    }
}