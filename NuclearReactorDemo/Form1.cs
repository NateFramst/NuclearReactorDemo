using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.Media;

namespace NuclearReactorDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void reactorStateLabel2_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //change colour of reactors
            //  Thread.Sleep(3000);
            SoundPlayer alertPlayer = new SoundPlayer(Properties.Resources.alert);
            alertPlayer.Play();
            reactorStateLabel1.BackColor = Color.Red;
            reactorStateLabel2.BackColor = Color.Red;
            outputLabel.Text = "MELTDOWN IMMINENT";
            outputLabel.BackColor = Color.White;
            
            Refresh();
            Thread.Sleep(1050);
            reactorStateLabel1.BackColor = Color.White;
            reactorStateLabel2.BackColor = Color.White;
            outputLabel.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(1050);
            reactorStateLabel1.BackColor = Color.Red;
            reactorStateLabel2.BackColor = Color.Red;
            outputLabel.BackColor = Color.White;
            Refresh();
            Thread.Sleep(1050);
            reactorStateLabel1.BackColor = Color.White;
            reactorStateLabel2.BackColor = Color.White;
            outputLabel.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(1050);
            reactorStateLabel1.BackColor = Color.Red;
            reactorStateLabel2.BackColor = Color.Red;
            outputLabel.BackColor = Color.White;
            Refresh();
            

        }
    }
}