using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace LogViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //System.Drawing.Icon ico = Properties.Resources.log_viewer;
            //this.Icon = ico;
            

            
            //grid.ItemsSource = items;
            //dataGridView1.DataSource = items;
        }


        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fDialog = new OpenFileDialog();
            fDialog.Title = "Select an XML File";
            fDialog.Filter = "XML File|*.xml";
            if (fDialog.ShowDialog() == DialogResult.OK)
            {
                string file_path = fDialog.FileName.ToString();
                openXmlFileOnTab(file_path);

            }
            //var items = deserializeLog();

            //var grid = sender as DataGrid;
        }
        private void openXmlFileOnTab(string file_path)
        {
            string file_name = Path.GetFileName(file_path);
            //Read file
            XmlSerializer deserializer = new XmlSerializer(typeof(LogMessages));
            TextReader reader = new StreamReader(file_path);
            //Create LogMessages object from xml
            object obj = deserializer.Deserialize(reader);
            LogMessages xmlData = (LogMessages)obj;
            reader.Close();
            //Create datagridview
            DataGridView datagrid = new DataGridView();
            datagrid.Dock = DockStyle.Fill;
            datagrid.DataSource = xmlData.Items;
            //Create tabpage
            TabPage filetab = new TabPage(file_name);
            //Add datagridview
            filetab.Controls.Add(datagrid);
            //Add tabpage
            tabControl1.Controls.Add(filetab);
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

