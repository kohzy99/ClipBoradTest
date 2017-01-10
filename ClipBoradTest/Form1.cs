using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipBoradTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // クリップボードに文字列データがあるか確認
            if (Clipboard.ContainsText())
            {
                //文字列データを取得する
                textBox1.Clear();
                textBox1.Text = Clipboard.GetText();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //クリップボードのデータを取得する
            //クリップボードにデータが無いときはnullを返す
            IDataObject data = Clipboard.GetDataObject();

            if (data != null)
            {
                textBox1.Clear();
                //関連付けられているすべての形式を列挙する
                foreach (string fmt in data.GetFormats(false))
                {
                    textBox1.AppendText(fmt + "\r\n");

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.AppendText("DataFormats.Bitmap = " + DataFormats.Bitmap + "\r\n");
            textBox1.AppendText("DataFormats.CommaSeparatedValue = " + DataFormats.CommaSeparatedValue + "\r\n");
            textBox1.AppendText("DataFormats.Dib = " + DataFormats.Dib + "\r\n");
            textBox1.AppendText("DataFormats.Dif = " + DataFormats.Dif + "\r\n");
            textBox1.AppendText("DataFormats.EnhancedMetafile = " + DataFormats.EnhancedMetafile + "\r\n");
            textBox1.AppendText("DataFormats.FileDrop = " + DataFormats.FileDrop + "\r\n");
            textBox1.AppendText("DataFormats.Html = " + DataFormats.Html + "\r\n");
            textBox1.AppendText("DataFormats.Locale = " + DataFormats.Locale + "\r\n");
            textBox1.AppendText("DataFormats.MetafilePict = " + DataFormats.MetafilePict + "\r\n");
            textBox1.AppendText("DataFormats.OemText = " + DataFormats.OemText + "\r\n");
            textBox1.AppendText("DataFormats.Palette = " + DataFormats.Palette + "\r\n");
            textBox1.AppendText("DataFormats.PenData = " + DataFormats.PenData + "\r\n");
            textBox1.AppendText("DataFormats.Riff = " + DataFormats.Riff + "\r\n");
            textBox1.AppendText("DataFormats.Rtf = " + DataFormats.Rtf + "\r\n");
            textBox1.AppendText("DataFormats.Serializable = " + DataFormats.Serializable + "\r\n");
            textBox1.AppendText("DataFormats.StringFormat = " + DataFormats.StringFormat + "\r\n");
            textBox1.AppendText("DataFormats.SymbolicLink = " + DataFormats.SymbolicLink + "\r\n");
            textBox1.AppendText("DataFormats.Text = " + DataFormats.Text + "\r\n");
            textBox1.AppendText("DataFormats.Tiff = " + DataFormats.Tiff + "\r\n");
            textBox1.AppendText("DataFormats.UnicodeText = " + DataFormats.UnicodeText + "\r\n");
            textBox1.AppendText("DataFormats.WaveAudio = " + DataFormats.WaveAudio + "\r\n");

        }
    }
}
