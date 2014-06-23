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
        private int mActiveTab = -1;

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


        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                for (int i = 0; i < tabControl1.TabCount; ++i)
                {
                    Rectangle r = tabControl1.GetTabRect(i);
                    if (r.Contains(e.Location) /* && it is the header that was clicked*/)
                    {
                        // update active tab
                        mActiveTab = i;

                        // Change slected index, get the page, create contextual menu
                        ContextMenu cm = new ContextMenu();
                        // Add several items to menu
                        MenuItem closeitem = new MenuItem("Close", new EventHandler(CloseItem_Click));
                        //closeitem.Click += new EventHandler(CloseItem_Click);
                        
                        cm.MenuItems.Add(closeitem);

                        cm.Show(this, e.Location);
                        break;
                    }
                }
            }
            base.OnMouseUp(e);
        }

        private void CloseItem_Click(object sender, EventArgs e)
        {
            if (mActiveTab != -1)
            {
                this.tabControl1.TabPages.RemoveAt(mActiveTab);
            }
        }

        private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.ShowNewFolderButton = false;
            folderBrowserDialog1.Description =
            "Select a Source Folder for XML Files";
            //folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Personal;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string destpath = folderBrowserDialog1.SelectedPath;
                foreach (string filedir in Directory.GetFiles(destpath, "*.xml", SearchOption.AllDirectories))
                {
                    openXmlFileOnTab(filedir);
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



