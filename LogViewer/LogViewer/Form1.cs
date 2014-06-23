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
            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
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
            //Create bindingsource
            BindingSource bn = new BindingSource();
            bn.DataSource = xmlData.Items;
            //Create columns
            DataGridViewTextBoxColumn datecolumn = new DataGridViewTextBoxColumn();
            datecolumn.Name = "Date";
            datecolumn.DataPropertyName = "Date";
            datecolumn.ReadOnly = true;
            datecolumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DataGridViewTextBoxColumn typecolumn = new DataGridViewTextBoxColumn();
            typecolumn.Name = "Type";
            typecolumn.DataPropertyName = "Type";
            typecolumn.ReadOnly = true;
            typecolumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DataGridViewTextBoxColumn messagecolumn = new DataGridViewTextBoxColumn();
            messagecolumn.Name = "Message";
            messagecolumn.DataPropertyName = "Message";
            messagecolumn.ReadOnly = true;
            messagecolumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //Create datagridview
            DataGridView datagrid = new DataGridView();
            datagrid.AutoGenerateColumns = false;
            //Add columns
            datagrid.Columns.Add(datecolumn);
            datagrid.Columns.Add(typecolumn);
            datagrid.Columns.Add(messagecolumn);
            //Set datagridview properties
            datagrid.DataSource = bn;
            datagrid.Dock = DockStyle.Fill;
            //datagrid.AutoSizeColumnsMode= DataGridViewAutoSizeColumnsMode.Fill;
            //
            //Create tabpage
            TabPage filetab = new TabPage(file_name);
            //Add datagridview
            filetab.Controls.Add(datagrid);
            //Add tabpage
            tabControl1.Controls.Add(filetab);
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            //This code will render a "x" mark at the end of the Tab caption. 
            e.Graphics.DrawString("x", e.Font, Brushes.Black, e.Bounds.Right - 15, e.Bounds.Top + 4);
            e.Graphics.DrawString(this.tabControl1.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 12, e.Bounds.Top + 4);
            e.DrawFocusRectangle();
        }

        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            //Looping through the controls.
            for (int i = 0; i < this.tabControl1.TabPages.Count; i++)
            {
                Rectangle r = tabControl1.GetTabRect(i);
                //Getting the position of the "x" mark.
                Rectangle closeButton = new Rectangle(r.Right - 15, r.Top + 4, 9, 7);
                if (closeButton.Contains(e.Location))
                {
                    if (MessageBox.Show("Would you like to Close this Tab?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.tabControl1.TabPages.RemoveAt(i);
                        break;
                    }
                }
            }
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

