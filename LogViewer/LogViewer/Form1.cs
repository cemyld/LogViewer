using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace LogViewer
{
    public partial class Form1 : Form
    {
        string file_path;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFileDialog fDialog = new OpenFileDialog();
            fDialog.Title = "Select an XML File";
            fDialog.Filter = "XML File|*.xml";
            if (fDialog.ShowDialog() == DialogResult.OK)
            {
                file_path = fDialog.FileName.ToString();
            }
            else
            {
                Application.Exit();
            }

            var items = deserializeLog();

            var grid = sender as DataGrid;
            //grid.ItemsSource = items;
            dataGridView1.DataSource = items;
        }
        public List<LogMessage> deserializeLog()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(LogMessages));
            TextReader reader = new StreamReader(file_path);
            object obj = deserializer.Deserialize(reader);
            LogMessages xmlData = (LogMessages)obj;
            reader.Close();
            return xmlData.Items;
        }
    }
    public class LogMessage
    {
        public String Date { get; set; }
        public String Type { get; set; }
        public String Message { get; set; }
    }
    [XmlRoot("Log")]
    public class LogMessages
    {
        [XmlElement("LogMessage")]
        public List<LogMessage> Items { get; set; }
    }

}

