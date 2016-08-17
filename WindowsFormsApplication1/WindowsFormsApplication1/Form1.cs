using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Add("Mk19");
            this.dataGridView1.Rows.Add("M2 50 cal"); 
            this.dataGridView1.Rows.Add("M240");
            this.dataGridView1.Rows.Add("Saw");
            this.dataGridView1.Rows.Add("M16");
            MK19pictureBox.Visible = false;
            M2pictureBox.Visible = false;
            M240pictureBox.Visible = false;
            SawpictureBox.Visible = false;
            M16pictureBox.Visible = false; 


            
        }

    

    }
}
