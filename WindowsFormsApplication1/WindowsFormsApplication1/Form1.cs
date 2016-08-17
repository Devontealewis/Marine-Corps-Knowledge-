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
        String WpnName = "Mk19";
        
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];

            WpnName = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
        }

    

        private void btnSelect_Click(object sender, EventArgs e)
        {
            
                if (WpnName == "Mk19")
                {
                    MK19pictureBox.Visible = true;
                    M2pictureBox.Visible = false;
                    M240pictureBox.Visible = false;
                    SawpictureBox.Visible = false;
                    M16pictureBox.Visible = false;
                    M4pictureBox.Visible = false;
                    label5.Visible = true;
                    label5.Text = WpnName;

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
                    label5.Visible = true;
                    label5.Text = WpnName;

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
                    label5.Visible = true;
                    label5.Text = WpnName;

                    txtboxmaxrange.Text = "3,725m";
                    txtboxeffrange.Text = "800m bipod, 1,100m tripod";
                    txtboxfirerate.Text = "750-950 rounds per minute";
                    txtboxweight.Text = "27.6 lbs";
                }
                if(WpnName == "Saw"){
                MK19pictureBox.Visible = false;
                M2pictureBox.Visible = false;
                M240pictureBox.Visible = false;
                SawpictureBox.Visible = true;
                M16pictureBox.Visible = false;
                M4pictureBox.Visible = false;
                label5.Visible = true;
                label5.Text = WpnName;

                txtboxmaxrange.Text = "3,600m";
                txtboxeffrange.Text = "700m without barrel, 800m w/th barrel";
                txtboxfirerate.Text = "450-575 rounds per minute";
                txtboxweight.Text = "17 lbs unloaded, 22 lbs loaded";
                
            }

            if (WpnName == "M16")
            {
                MK19pictureBox.Visible = false;
                M2pictureBox.Visible = false;
                M240pictureBox.Visible = false;
                SawpictureBox.Visible = false;
                M16pictureBox.Visible = true;
                M4pictureBox.Visible = false;
                label5.Visible = true;
                label5.Text = WpnName;

                txtboxmaxrange.Text = "3,600m";
                txtboxeffrange.Text = "800m area, 550m point";
                txtboxfirerate.Text = "12-15 susbtained rounds/min, 45 -60 rounds/min semi";
                txtboxweight.Text = "7 lbs, 8 ounces";
            }


            if (WpnName == "M4")
            {
                MK19pictureBox.Visible = false;
                M2pictureBox.Visible = false;
                M240pictureBox.Visible = false;
                SawpictureBox.Visible = false;
                M16pictureBox.Visible = false;
                M4pictureBox.Visible = true;
                label5.Visible = true;
                label5.Text = WpnName;

                txtboxmaxrange.Text = "3,600m";
                txtboxeffrange.Text = "500m point";
                txtboxfirerate.Text = "???";
                txtboxweight.Text = "7.5 lbs";
            }
        }



    }
}
