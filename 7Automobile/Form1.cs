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
            auto.AccSpe(s);
            txt_AccSpe.Text = auto.Stato;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Automobile auto = new Automobile();
            auto.Stato = "Spenta";
            auto.Velocita = 0;
            auto.Marcia = 0;
            txt_AccSpe.Text = auto.Stato;
            txt_Accelera.Text = auto.Velocita.ToString();
            txt_Marcia.Text = auto.Marcia.ToString();
        }

        
        private void bttn_Accelera_Click(object sender, EventArgs e)
        {
            Automobile auto = new Automobile();
            auto.Stato = txt_AccSpe.Text;
            int s = int.Parse(txt_Accelera.Text);
            auto.MovimentoPos(s);
            txt_Accelera.Text = (auto.Velocita).ToString();
        }

        private void bttn_Decelera_Click(object sender, EventArgs e)
        {
            Automobile auto = new Automobile();
            auto.Stato = txt_AccSpe.Text;
            int s = int.Parse(txt_Accelera.Text);
            auto.MovimentoNeg(s);
            txt_Accelera.Text = (auto.Velocita).ToString();
        }

        private void bttn_Amarcia_Click(object sender, EventArgs e)
        {
            Automobile auto = new Automobile();
            auto.Stato = txt_AccSpe.Text;
            int n = int.Parse(txt_Marcia.Text);
            auto.Aumenta(n);
            txt_Marcia.Text = (auto.Marcia).ToString();
        }

        private void bttn_Smarcia_Click(object sender, EventArgs e)
        {
            Automobile auto = new Automobile();
            auto.Stato = txt_AccSpe.Text;
            int n = int.Parse(txt_Marcia.Text);
            auto.Scala(n);
            txt_Marcia.Text = (auto.Marcia).ToString();
        }
    }
    public class Automobile
    {
        public string stato;
        public int velocita;
        public int marcia;


        public string Stato
        { get { return stato; } set {  stato = value; } }
        public int Velocita
        { get { return velocita; } set { velocita = value; } }
        public int Marcia
        { get { return marcia; } set { marcia = value; } }

        public void AccSpe(string s)
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
        public void MovimentoPos(int s)
        {
            if(Stato=="Accesa")
            {
                if (s < 200)
                {
                 Velocita = s + 10;
                }
                else
                {
                }
            }
            else
            {

            }
            
        }
        public void MovimentoNeg(int s)
        {
            if (Stato == "Accesa")
            {
                if (s > 0)
                {
                    Velocita = s - 10;
                }
                else { }
            }
            else
            {

            }
        }
        public void Aumenta(int n)
        {
            if (Stato == "Accesa")
            {
                if (n > 0 && n<6)
                {
                    Marcia = n+1;
                }
                else { }
            }
            else
            {

            }
        }
        public void Scala(int n)
        {
            if (Stato == "Accesa")
            {
                if (n > 0 && n < 7)
                {
                    Marcia = n-1;
                }
                else { }
            }
            else
            {

            }
        }
    }
}
