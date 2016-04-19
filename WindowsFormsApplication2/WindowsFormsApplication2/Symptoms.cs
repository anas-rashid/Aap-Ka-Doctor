using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication2
{
    public partial class Symptoms : MetroFramework.Forms.MetroForm
    {
        List<int> tileSelected = new List<int>(); 
        
        Homepage Parent = null;
        Form MDIParent = null;
        bool bt1 = false, bt2 = false, bt3 = false, bt4 = false, bt5 = false, bt6 = false, bt7 = false, bt8 = false;

        public Symptoms(Homepage Parent, string patient, Form MDIParent)
        {
            InitializeComponent();
            this.Text = patient;
            this.Parent = Parent;
            this.MDIParent = MDIParent;
        }

        private void Symptoms_Load(object sender, EventArgs e)
        {
            SoundPlayer s11 = new SoundPlayer(@"..\..\Resources\SympotmsInfo.wav");
            s11.Play();
            this.metroTile10.MouseEnter += new EventHandler(backScrMsg);
        }
        private void backScrMsg(object sender, EventArgs e)
        {
            SoundPlayer s = new SoundPlayer(@"..\..\Resources\backScrMsg.wav");
            s.PlaySync();
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            if(tileSelected.Count!=0 )
            {
                if(tileSelected.Remove(8) == true && tileSelected.Count == 0)
                {
                    SoundPlayer s = new SoundPlayer(@"..\..\Resources\docNotAvail.wav");
                    s.Play();
                    tileSelected.Add(8);

                }
                else 
                {
                    this.Hide();
                    Map m = new Map(this);
                    m.MdiParent = MDIParent;
                    m.Show();
                    tileSelected.Add(8);
                   
                    
                }
                
            }
            else
            {
                SoundPlayer s = new SoundPlayer(@"..\..\Resources\noDoc.wav");
                s.Play();
            }

        }

        private void metroTile7_Click(object sender, EventArgs e)
        { 
            if(bt7 == false)
            {
                tileSelected.Add(7);
                bt7 = true;
                this.metroTile7.Style = MetroFramework.MetroColorStyle.Green;
                this.metroTile7.TileImage = new Bitmap(@"..\..\Resources\HCI icons\7.png");
            }
            else
            {
                bt7 = false;
                tileSelected.Remove(7);
                this.metroTile7.Style = MetroFramework.MetroColorStyle.Black;
                this.metroTile7.TileImage = new Bitmap(@"..\..\Resources\HCI \7.png");
            }
            
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (bt1 == false)
            {
                tileSelected.Add(1);
                bt1 = true;
                this.metroTile1.Style = MetroFramework.MetroColorStyle.Green;
                this.metroTile1.TileImage = new Bitmap(@"..\..\Resources\HCI icons\1.png");
            }
            else
            {
                tileSelected.Remove(1);
                bt1 = false;
                this.metroTile1.Style = MetroFramework.MetroColorStyle.Black;
                this.metroTile1.TileImage = new Bitmap(@"..\..\Resources\HCI\1.png");
            }
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            if (bt2 == false)
            {
                tileSelected.Add(2);
                bt2 = true;
                this.metroTile2.Style = MetroFramework.MetroColorStyle.Green;
                this.metroTile2.TileImage = new Bitmap(@"..\..\Resources\HCI icons\2.png");
            }
            else
            {
                tileSelected.Remove(2);
                bt2 = false;
                this.metroTile2.Style = MetroFramework.MetroColorStyle.Black;
                this.metroTile2.TileImage = new Bitmap(@"..\..\Resources\HCI\2.png");
            }
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            if (bt3 == false)
            {
                tileSelected.Add(3);
                bt3 = true;
                this.metroTile3.Style = MetroFramework.MetroColorStyle.Green;
                this.metroTile3.TileImage = new Bitmap(@"..\..\Resources\HCI icons\3.png");
            }
            else
            {
                tileSelected.Remove(3);
                bt3 = false;
                this.metroTile3.Style = MetroFramework.MetroColorStyle.Black;
                this.metroTile3.TileImage = new Bitmap(@"..\..\Resources\HCI\3.png");
            }
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            if (bt4 == false)
            {
                tileSelected.Add(4);
                bt4 = true;
                this.metroTile4.Style = MetroFramework.MetroColorStyle.Green;
                this.metroTile4.TileImage = new Bitmap(@"..\..\Resources\HCI icons\4.png");
            }
            else
            {
                tileSelected.Remove(4);
                bt4 = false;
                this.metroTile4.Style = MetroFramework.MetroColorStyle.Black;
                this.metroTile4.TileImage = new Bitmap(@"..\..\Resources\HCI\4.png");
            }
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            if (bt5 == false)
            {
                tileSelected.Add(5);
                bt5 = true;
                this.metroTile5.Style = MetroFramework.MetroColorStyle.Green;
                this.metroTile5.TileImage = new Bitmap(@"..\..\Resources\HCI icons\5.png");
            }
            else
            {
                tileSelected.Remove(5);
                bt5 = false;
                this.metroTile5.Style = MetroFramework.MetroColorStyle.Black;
                this.metroTile5.TileImage = new Bitmap(@"..\..\Resources\HCI\5.png");
            }
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            if (bt6 == false)
            {
                tileSelected.Add(6);
                bt6 = true;
                this.metroTile6.Style = MetroFramework.MetroColorStyle.Green;
                this.metroTile6.TileImage = new Bitmap(@"..\..\Resources\HCI icons\6.png");
            }
            else
            {
                tileSelected.Remove(6);
                bt6 = false;
                this.metroTile6.Style = MetroFramework.MetroColorStyle.Black;
                this.metroTile6.TileImage = new Bitmap(@"..\..\Resources\HCI\6.png");
            }
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            if (bt8 == false)
            {
                tileSelected.Add(8);
                bt8 = true;
                this.metroTile8.Style = MetroFramework.MetroColorStyle.Red;
                this.metroTile8.TileImage = new Bitmap(@"..\..\Resources\HCI icons\8.png");
            }
            else
            {
                tileSelected.Remove(8);
                bt8 = false;
                this.metroTile8.Style = MetroFramework.MetroColorStyle.Black;
                this.metroTile8.TileImage = new Bitmap(@"..\..\Resources\HCI\8.png");
            }
        }

        private void metroTile10_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Parent.Show();
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
    }
}
