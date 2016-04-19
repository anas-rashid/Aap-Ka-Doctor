using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Map : MetroFramework.Forms.MetroForm
    {
        MetroFramework.Forms.MetroForm parent = null;
        public Map(MetroFramework.Forms.MetroForm parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void Map_Load(object sender, EventArgs e)
        {
            SoundPlayer s = new SoundPlayer(@"..\..\Resources\map.wav");
            s.Play();
            this.metroTile3.MouseEnter += new EventHandler(logoutMsg);
            this.metroTile4.MouseEnter += new EventHandler(backScrMsg);
            
        }
        private void logoutMsg(object sender, EventArgs e)
        {
            SoundPlayer s = new SoundPlayer(@"..\..\Resources\logoutMsg.wav");
            s.PlaySync();
        }
        private void backScrMsg(object sender, EventArgs e)
        {
            SoundPlayer s = new SoundPlayer(@"..\..\Resources\backScrMsg.wav");
            s.PlaySync();
        }
        private void metroTile3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            this.Dispose();
            parent.Show();
        }


    }
}
