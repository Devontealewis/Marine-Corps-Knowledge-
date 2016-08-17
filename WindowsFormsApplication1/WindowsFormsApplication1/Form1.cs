﻿using System;
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
        String WpnName;
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
            this.dataGridView1.Rows.Add("M4");
            MK19pictureBox.Visible = false;
            M2pictureBox.Visible = false;
            M240pictureBox.Visible = false;
            SawpictureBox.Visible = false;
            M16pictureBox.Visible = false;
            M4pictureBox.Visible = false;
            label5.Visible = false; 

            
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            {
                if (WpnName == "Mk19")
                {
                    MK19pictureBox.Visible = true;
                    M2pictureBox.Visible = false;
                    M240pictureBox.Visible = false;
                    SawpictureBox.Visible = false;
                    M16pictureBox.Visible = false;
                    M4pictureBox.Visible = false;
                    label5.Visible = false;

                    txtboxmaxrange.Text = "2,212m";
                    txtboxeffrange.Text = "1,500m";
                    txtboxfirerate.Text = "40 rounds/min sustained 60 rounds/min rapid";
                    txtboxweight.Text = "77.6 lbs";
                }
                if (WpnName == "M2 50 cal") 
                {
                    MK19pictureBox.Visible = false;
                    M2pictureBox.Visible = true;
                    M240pictureBox.Visible = false;
                    SawpictureBox.Visible = false;
                    M16pictureBox.Visible = false;
                    M4pictureBox.Visible = false;
                    label5.Visible = false;

                    txtboxmaxrange.Text = "2,000m";
                    txtboxeffrange.Text = "1,830m area, 1,500m point";
                    txtboxfirerate.Text = "450-575 rounds per minute";
                    txtboxweight.Text = "84 lbs";
                
                }

                if (WpnName == "M240")
                {
                    MK19pictureBox.Visible = false;
                    M2pictureBox.Visible = false;
                    M240pictureBox.Visible = true;
                    SawpictureBox.Visible = false;
                    M16pictureBox.Visible = false;
                    M4pictureBox.Visible = false;
                    label5.Visible = false;

                    txtboxmaxrange.Text = "3,725m";
                    txtboxeffrange.Text = "800m bipod, 1,100m tripod";
                    txtboxfirerate.Text = "750-950 rounds per minute";
                    txtboxweight.Text = "27.6 lbs";
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];

            WpnName = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
        }

    

    }
}
