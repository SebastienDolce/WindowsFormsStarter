using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw1pt2
{
    public partial class MainForm : Form
    {
        Size RecentSize;
        Point RecentPoint;
        public MainForm()
        {
            RecentSize = Properties.Settings.Default.LastSize;
            RecentPoint = Properties.Settings.Default.LastPosition;
            this.Size = RecentSize;
            this.Location = RecentPoint;
            InitializeComponent();
            
        }

        private void AddNames_Click(object sender, EventArgs e)
        {
            InputForm modelessDialog = new InputForm();
            modelessDialog.AcceptClicked += ModelessClick;
            modelessDialog.ShowDialog();

        }

        private void ModelessClick(object sender, EventArgs e)
        {
            InputForm inForm = (InputForm)sender;
            var listViewItem = new ListViewItem();
            listViewItem.Text = inForm.input;
            listView1.Items.Add(listViewItem);
        }
        private void ResetSettingsButt_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.LastPosition = new Point(0,0);
            Properties.Settings.Default.LastSize = new Size(500, 500);
            Properties.Settings.Default.Save();
        }

        private void SaveSize_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.LastSize = this.Size;
            Properties.Settings.Default.Save();
        }

        private void SaveLocation_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.LastPosition = this.Location;
            Properties.Settings.Default.Save();
        }
    }
}
