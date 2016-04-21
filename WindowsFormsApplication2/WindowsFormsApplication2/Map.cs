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
        private void Map_Shown(object sender, EventArgs e)
        {
            
            SoundPlayer s = new SoundPlayer(@"..\..\Resources\map.wav");
            s.PlaySync();
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
        private void Map_Load(object sender, EventArgs e)
        {
            
            this.metroTile3.MouseEnter += new EventHandler(logoutMsg);
            this.metroTile4.MouseEnter += new EventHandler(backScrMsg);
            this.metroTile1.MouseEnter += new EventHandler(Map_Shown);
            
        }
        private void logoutMsg(object sender, EventArgs e)
        {
            this.metroTile3.Select();
            SoundPlayer s = new SoundPlayer(@"..\..\Resources\logoutMsg.wav");
            s.PlaySync();
        }
        private void backScrMsg(object sender, EventArgs e)
        {
            this.metroTile4.Select();
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
