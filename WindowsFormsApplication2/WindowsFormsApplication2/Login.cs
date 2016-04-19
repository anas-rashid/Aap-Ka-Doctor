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

namespace WindowsFormsApplication2
{
    
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        Form parent = null;
        public Login(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        
        private void Login_Load(object sender, EventArgs e)
        {
            this.Name = "Login Portal";

        }
        public String loginNumber ()
        {
            return this.phoneNumber.Text;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            if (this.phoneNumber.Text != "") 
                this.phoneNumber.Text = phoneNumber.Text.Remove((phoneNumber.Text.Length) - 1);
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (this.phoneNumber.Text != "03001231234" && this.phoneNumber.Text.Length == 11)
            {
                SoundPlayer s = new SoundPlayer(@"..\..\Resources\New Patient.wav");
                s.Play();
                System.Threading.Thread.Sleep(3000);
            }
            else if (this.phoneNumber.Text.Length != 11)
            {
                SoundPlayer s = new SoundPlayer(@"..\..\Resources\Wrong Number.wav");
                s.Play();
                System.Threading.Thread.Sleep(3000);
                return;
            }
           
            Homepage h = new Homepage(this.phoneNumber.Text, parent);
            h.MdiParent = parent;
            h.Show();
            this.phoneNumber.Text = "";
                
        }
        private void masked_box(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }

        private void num1_Click(object sender, EventArgs e)
        {
            if (this.phoneNumber.Text.Length < 11) 
                this.phoneNumber.Text += "1";
        }

        private void num2_Click(object sender, EventArgs e)
        {
            if (this.phoneNumber.Text.Length < 11) 
                this.phoneNumber.Text += "2";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            if (this.phoneNumber.Text.Length < 11) 
                this.phoneNumber.Text += "3";
        }

        private void num4_Click(object sender, EventArgs e)
        {
            if (this.phoneNumber.Text.Length < 11) 
                this.phoneNumber.Text += "4";
        }

        private void num5_Click(object sender, EventArgs e)
        {
            if (this.phoneNumber.Text.Length < 11) 
                this.phoneNumber.Text += "5";
        }

        private void num6_Click(object sender, EventArgs e)
        {
            if (this.phoneNumber.Text.Length < 11) 
                this.phoneNumber.Text += "6";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            if (this.phoneNumber.Text.Length < 11) 
                this.phoneNumber.Text += "7";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (this.phoneNumber.Text.Length < 11) 
                this.phoneNumber.Text += "8";
        }

        private void num9_Click(object sender, EventArgs e)
        {
            if (this.phoneNumber.Text.Length < 11)
                this.phoneNumber.Text += "9";
        }

        private void num0_Click(object sender, EventArgs e)
        {
            if(this.phoneNumber.Text.Length < 11)
                this.phoneNumber.Text += "0";
        }

        public string getNumber()
        {
            return phoneNumber.Text;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }
    }
}
