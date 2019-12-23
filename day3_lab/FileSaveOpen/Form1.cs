using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOL;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FileSaveOpen
{
    public partial class Form1 : Form
    {

        string FileName;
        List<Customer> CustList = new List<Customer>(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void OnFileOpen(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
               string FileName = ofd.FileName;
                FileStream fs = new FileStream(FileName, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                CustList = bf.Deserialize(fs) as List<Customer>;
                fs.Close();
                this.dgvList.DataSource = CustList;
            }

            MessageBox.Show("File is Opened", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OnFileSaveAs(object sender, EventArgs e)
        {
            SaveFileDialog ofd = new SaveFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileName = ofd.FileName;
                FileStream fs = new FileStream(FileName, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, CustList);
                fs.Close();
            }

            MessageBox.Show("File Saved Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void OnFileExit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void OnBtnExit(object sender, EventArgs e)
        {
            MessageBox.Show("Are you Sure?", "CDAC ACTS" ,MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            this.Close();
        }

        private void OnBtnRegister(object sender, EventArgs e)
        {
            CustList.Add(new Customer { FirstName = tbFirstName.Text, LastName = tbLastName.Text, ContactNumber = tbContact.Text, BirthDate = dtpDOB.Value });
            dgvList.DataSource = null;      //solving problem for data refresh on grid view
            dgvList.DataSource = CustList;
            MessageBox.Show("Data Added Successfully!!","Heads Up", MessageBoxButtons.OK);
        }
    }
}
