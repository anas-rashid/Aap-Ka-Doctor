using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

using MetroFramework.Forms;
using MetroFramework.Controls;
using MetroFramework.Components;
using MetroFramework;
using System.Threading;

namespace WindowsFormsApplication2
{
    public partial class Homepage : MetroFramework.Forms.MetroForm
    {
        string patient = null;
        Form MDIParent = null;
        SoundPlayer s1 = new SoundPlayer(@"..\..\Resources\hAppInfo.wav");
        SoundPlayer s2 = new SoundPlayer(@"..\..\Resources\hSymInfo.wav");
        public Homepage(string patient, Form MDIParent)
        {
            //Form.CheckForIllegalCrossThreadCalls = false;
            this.patient = patient;
            this.MDIParent = MDIParent; 
            InitializeComponent();
           
            this.metroPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.metroTile1.MouseEnter += new EventHandler(sound1);
            this.metroTile2.MouseHover += new EventHandler(sound2);
            
        }
        private void sound1(object sender, EventArgs e)
        {
            this.pictureBox1.Visible = true;
            this.pictureBox2.Visible = false;
            s1.PlaySync();
            this.metroTile1.Select();
        }
        private void sound2(object sender, EventArgs e)
        {
            this.pictureBox1.Visible = false;
            this.pictureBox2.Visible = true;
            s2.PlaySync();
            this.metroTile2.Select();
        }
        private void metroTile1_Click_1(object sender, EventArgs e)
        {
           
            this.Hide();
            Appointment ap = new Appointment(patient, this, MDIParent);
            ap.MdiParent = MDIParent;
            
           // System.Threading.Thread.Sleep(6000);
            ap.Show();
          
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Symptoms s = new Symptoms(this, patient, MDIParent);
            s.MdiParent = MDIParent;
           
           // System.Threading.Thread.Sleep(6000);
            s.Show();
        }
        protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }
        private void Homepage_Load(object sender, EventArgs e)
        {
            this.Text = patient;
            this.metroTile3.MouseEnter += new EventHandler(logoutMsg);
            
        }
        private void logoutMsg(object sender, EventArgs e)
        {
            SoundPlayer s = new SoundPlayer(@"..\..\Resources\logoutMsg.wav");
            s.PlaySync();
        }
        private void form_shown(object sender, EventArgs e)
        {
            SoundPlayer ss = new SoundPlayer(@"..\..\Resources\hompage.wav");
            ss.Play();
            
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

            
        }

       

       

        
    }
}
