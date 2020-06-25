using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaForca
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            Jogo gaming = new Jogo();
            int tentativas = 5;
            List<Label> Labels = new List<Label>();
            addAllLabels(Labels);
        }


        public void addAllLabels(List<Label> labels){
            labels.Add(label1); labels.Add(label2); labels.Add(label3); labels.Add(label4);
            labels.Add(label5); labels.Add(label6); labels.Add(label7); labels.Add(label8);
            labels.Add(label9); labels.Add(label10); labels.Add(label11); labels.Add(label12);
            labels.Add(label13); labels.Add(label14); labels.Add(label15); labels.Add(label16);
            labels.Add(label17); labels.Add(label18); labels.Add(label19); labels.Add(label20);
            labels.Add(label21); labels.Add(label22); labels.Add(label23); labels.Add(label24);
            labels.Add(label25); labels.Add(label26); labels.Add(label27); labels.Add(label28);
            labels.Add(label29); labels.Add(label30); labels.Add(label31); labels.Add(label32);
            labels.Add(label33); labels.Add(label34); labels.Add(label35); labels.Add(label36);
            labels.Add(label37); labels.Add(label38); labels.Add(label39); labels.Add(label40);
            labels.Add(label41); labels.Add(label42); labels.Add(label43); labels.Add(label44);
            labels.Add(label45); labels.Add(label46);
        }

        private void A_Click(object sender, EventArgs e)
        {
            A.Visible = false;
        }
        private void B_Click(object sender, EventArgs e)
        {

        }

        private void C_Click(object sender, EventArgs e)
        {

        }

        private void D_Click(object sender, EventArgs e)
        {

        }

        private void E_Click(object sender, EventArgs e)
        {

        }

        private void F_Click(object sender, EventArgs e)
        {

        }

        private void G_Click(object sender, EventArgs e)
        {

        }

        private void H_Click(object sender, EventArgs e)
        {

        }

        private void I_Click(object sender, EventArgs e)
        {

        }

        private void J_Click(object sender, EventArgs e)
        {

        }

        private void K_Click(object sender, EventArgs e)
        {

        }

        private void L_Click(object sender, EventArgs e)
        {

        }

        private void M_Click(object sender, EventArgs e)
        {

        }

        private void N_Click(object sender, EventArgs e)
        {

        }

        private void O_Click(object sender, EventArgs e)
        {

        }

        private void P_Click(object sender, EventArgs e)
        {

        }

        private void Q_Click(object sender, EventArgs e)
        {

        }

        private void R_Click(object sender, EventArgs e)
        {

        }

        private void S_Click(object sender, EventArgs e)
        {

        }

        private void T_Click(object sender, EventArgs e)
        {

        }

        private void U_Click(object sender, EventArgs e)
        {

        }

        private void V_Click(object sender, EventArgs e)
        {

        }

        private void W_Click(object sender, EventArgs e)
        {

        }

        private void X_Click(object sender, EventArgs e)
        {

        }

        private void Y_Click(object sender, EventArgs e)
        {

        }

        private void Z_Click(object sender, EventArgs e)
        {

        }
    }
}
