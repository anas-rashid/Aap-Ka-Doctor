using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;
using MetroFramework.Components;
using MetroFramework;
using System.Media;
using System.Net.Mail;

namespace WindowsFormsApplication2
{
    public partial class Appointment : MetroFramework.Forms.MetroForm
    {
        DocNumber num = null;
        string patient = null;
        Homepage Parent = null;
        Form MDIParent = null;

        public Appointment(string patient, Homepage Parent, Form MDIParent)
        {
            this.Parent = Parent;
            this.MDIParent = MDIParent;
            this.patient = patient;
            InitializeComponent();
        }
        
        private void Appointment_Load(object sender, EventArgs e)
        {
            this.doctorPhoneIcon.MouseEnter += new EventHandler(docNumInfo);
            DatePick.Format = DateTimePickerFormat.Custom;
            DatePick.CustomFormat = "dd-mm-yyyy";
            DatePick.ShowUpDown = true;
            SoundPlayer s = new SoundPlayer(@"..\..\Resources\AppointmentInfo.wav");
            s.Play();
            this.metroTile1.MouseEnter += new EventHandler(backScrMsg);
            
        }
        private void backScrMsg(object sender, EventArgs e)
        {
            SoundPlayer s = new SoundPlayer(@"..\..\Resources\backScrMsg.wav");
            s.PlaySync();
        }
        private void docNumInfo(object sender, EventArgs e)
        {
            SoundPlayer s = new SoundPlayer(@"..\..\Resources\docNoEnter.wav");
            s.PlaySync();
        }
        private void metroTile1_Click(object sender, EventArgs e)
        {
            num = new DocNumber();
            num.MdiParent = MDIParent;
            num.Show();
            num.loginBtn.Click += getNumber;
            
           
        }
       
        private void getNumber(object sender, EventArgs e)
        {
            this.docNumber.Width = 264;
            
            docNumber.Text = num.getNumber();
            
            docNumber.Visible = true;
            
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (docNumber.Text == "")
            {
                SoundPlayer s = new SoundPlayer(@"..\..\Resources\Doctors Number.wav");
                s.Play();
            } else
            if (docNumber.Text != "" && docNumber.Text.Length < 11)
            {
                SoundPlayer s = new SoundPlayer(@"..\..\Resources\Wrong Number.wav");
                s.Play();
            }
            else
            {
                if (DatePick.Value.DayOfWeek == DayOfWeek.Saturday || DatePick.Value.DayOfWeek == DayOfWeek.Sunday)
                {
                    SoundPlayer s = new SoundPlayer(@"..\..\Resources\Some Other Day.wav");
                    s.Play();
                }
                else
                {
                    SoundPlayer s = new SoundPlayer(@"..\..\Resources\Appointment Made.wav");
                    s.Play();
                    System.Threading.Thread.Sleep(5000);
                    this.Dispose();
                    //this.Close();
                    //try
                    //{
                    //    MailMessage mail = new MailMessage();
                    //    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    //    mail.From = new MailAddress("anasrasheed22@gmail.com");
                    //    mail.To.Add("danyalafzaal786@gmail.com");
                    //    mail.Subject = "New Appointment Notification";
                    //    mail.Body = "Your Appointment Has been Set with a new patient with ph# " + patient;

                    //    SmtpServer.Port = 587;
                    //    SmtpServer.Credentials = new System.Net.NetworkCredential("anasrasheed22@gmail.com", "annjanuinvaders221995");
                    //    SmtpServer.EnableSsl = true;

                    //    SmtpServer.Send(mail);

                    //}
                    //catch (Exception ex)
                    //{
                    //    MessageBox.Show(ex.ToString());
                    //}
                }
            }
            
        }

        private void metroTile1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Parent.Show();
        }

        

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
