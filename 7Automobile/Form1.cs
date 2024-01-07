using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7Automobile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttn_AccSpe_Click(object sender, EventArgs e)
        {
            Automobile auto = new Automobile();
            string s = txt_AccSpe.Text;
            auto.Accesa(s);

            txt_AccSpe.Text = auto.Stato;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Automobile auto = new Automobile();
            auto.Stato = "Spenta";
            txt_AccSpe.Text = auto.Stato;
        }
    }
    public class Automobile
    {
        public string stato;

        public string Stato
        { get { return stato; } set {  stato = value; } }

        public void Accesa(string s)
        {
            if (s == "Spenta")
            {
                Stato = "Accesa";
                
            }
            else
            {
                Stato = "Spenta";
              
            }
        }
    }
}
