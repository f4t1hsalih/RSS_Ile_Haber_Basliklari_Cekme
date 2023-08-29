using System.Xml;

namespace RSS_Ile_Haber_Basliklari_Cekme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHurriyet_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader xmlread = new XmlTextReader("http://www.hurriyet.com.tr/rss/anasayfa");
            while (xmlread.Read())
            {
                if (xmlread.Name == "title")
                {
                    listBox1.Items.Add(xmlread.ReadString());
                }
            }
        }

        private void btnMilliyet_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader xmlread = new XmlTextReader("http://www.milatgazetesi.com/rss.php");
            while (xmlread.Read())
            {
                if (xmlread.Name == "title")
                {
                    listBox1.Items.Add(xmlread.ReadString());
                }
            }
        }
    }
}