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
        Jogo Gaming = new Jogo();
        public bool comecoJogo = true;
        public string currentWord;
        public List<Label> Labels = new List<Label>();

        public Game()
        {
            InitializeComponent();
            Inicio();
        }

        public void Inicio()
        {
            displayForca(Gaming.Tentativas);
            if (currentWord == null && comecoJogo == true)
            {
                comecoJogo = false;
                addAllLabels(Labels);
                Gaming.addPalavra("testdois");
                Gaming.addPalavra("test");
                currentWord = Gaming.novaPalavra();
                Gaming.addLabel(currentWord.Length, Labels);
                Gaming.Tentativas = 6;
                displayForca(Gaming.Tentativas);
            }
            else if (Gaming.Tentativas == 0)
            {
                this.Close();
            }
            else if(Gaming.checkWord(currentWord) == true)
            {
                currentWord = Gaming.novaPalavra();
                Gaming.removeAllLabes();
                Gaming.addLabel(currentWord.Length, Labels);
                Gaming.Tentativas = 6;
            }
            if(currentWord == "")
            {
                this.Close();
            }


            foreach (Label l in Gaming.Labels)
            {
                l.Visible = true;
            }
        }

        private void A_Click(object sender, EventArgs e)
        {
            Gaming.btClick(A, currentWord);
            if (Gaming.checkWord(currentWord) == true)
            {
                resetBtns();
            }
            Inicio();
            
        }
        private void B_Click(object sender, EventArgs e)
        {
            Gaming.btClick(B, currentWord);
            if (Gaming.checkWord(currentWord) == true)
            {
                resetBtns();
            }
            Inicio();
        }

        private void C_Click(object sender, EventArgs e)
        {
            Gaming.btClick(C, currentWord);
            if (Gaming.checkWord(currentWord) == true)
            {
                resetBtns();
            }
            Inicio();
        }

        private void D_Click(object sender, EventArgs e)
        {
            Gaming.btClick(D, currentWord);
            if (Gaming.checkWord(currentWord) == true)
            {
                resetBtns();
            }
            Inicio();
        }

        private void E_Click(object sender, EventArgs e)
        {
            Gaming.btClick(E, currentWord);
            if (Gaming.checkWord(currentWord) == true)
            {
                resetBtns();
            }
            Inicio();
        }

        private void F_Click(object sender, EventArgs e)
        {
            Gaming.btClick(F, currentWord);
            if (Gaming.checkWord(currentWord) == true)
            {
                resetBtns();
            }
            Inicio();
        }

        private void G_Click(object sender, EventArgs e)
        {
            Gaming.btClick(G, currentWord);
            if (Gaming.checkWord(currentWord) == true)
            {
                resetBtns();
            }
            Inicio();
        }

        private void H_Click(object sender, EventArgs e)
        {
            Gaming.btClick(H, currentWord);
            if (Gaming.checkWord(currentWord) == true)
            {
                resetBtns();
            }
            Inicio();
        }

        private void I_Click(object sender, EventArgs e)
        {
            Gaming.btClick(I, currentWord);
            if (Gaming.checkWord(currentWord) == true)
            {
                resetBtns();
            }
            Inicio();
        }

        private void J_Click(object sender, EventArgs e)
        {
            Gaming.btClick(J, currentWord);
            if (Gaming.checkWord(currentWord) == true)
            {
                resetBtns();
            }
            Inicio();
        }

        private void K_Click(object sender, EventArgs e)
        {
            Gaming.btClick(K, currentWord);
            if (Gaming.checkWord(currentWord) == true)
            {
                resetBtns();
            }
            Inicio();
        }

        private void L_Click(object sender, EventArgs e)
        {
            Gaming.btClick(L, currentWord);
            if (Gaming.checkWord(currentWord) == true)
            {
                resetBtns();
            }
            Inicio();
        }

        private void M_Click(object sender, EventArgs e)
        {
            Gaming.btClick(M, currentWord);
            if (Gaming.checkWord(currentWord) == true)
            {
                resetBtns();
            }
            Inicio();
        }

        private void N_Click(object sender, EventArgs e)
        {
            Gaming.btClick(N, currentWord);
            if (Gaming.checkWord(currentWord) == true)
            {
                resetBtns();
            }
            Inicio();
        }

        private void O_Click(object sender, EventArgs e)
        {
            Gaming.btClick(O, currentWord);
            if (Gaming.checkWord(currentWord) == true)
            {
                resetBtns();
            }
            Inicio();
        }

        private void P_Click(object sender, EventArgs e)
        {
            Gaming.btClick(P, currentWord);
            if (Gaming.checkWord(currentWord) == true)
            {
                resetBtns();
            }
            Inicio();
        }

        private void Q_Click(object sender, EventArgs e)
        {
            Gaming.btClick(Q, currentWord);
            if (Gaming.checkWord(currentWord) == true)
            {
                resetBtns();
            }
            Inicio();
        }

        private void R_Click(object sender, EventArgs e)
        {
            Gaming.btClick(R, currentWord);
            if (Gaming.checkWord(currentWord) == true)
            {
                resetBtns();
            }
            Inicio();
        }

        private void S_Click(object sender, EventArgs e)
        {
            Gaming.btClick(S, currentWord);
            if (Gaming.checkWord(currentWord) == true)
            {
                resetBtns();
            }
            Inicio();
        }

        private void T_Click(object sender, EventArgs e)
        {
            Gaming.btClick(T, currentWord);
            if (Gaming.checkWord(currentWord) == true)
            {
                resetBtns();
            }
            Inicio();
        }

        private void U_Click(object sender, EventArgs e)
        {
            Gaming.btClick(U, currentWord);
            if (Gaming.checkWord(currentWord) == true)
            {
                resetBtns();
            }
            Inicio();
        }

        private void V_Click(object sender, EventArgs e)
        {
            Gaming.btClick(V, currentWord);
            if (Gaming.checkWord(currentWord) == true)
            {
                resetBtns();
            }
            Inicio();
        }

        private void W_Click(object sender, EventArgs e)
        {
            Gaming.btClick(W, currentWord);
            if (Gaming.checkWord(currentWord) == true)
            {
                resetBtns();
            }
            Inicio();
        }

        private void X_Click(object sender, EventArgs e)
        {
            Gaming.btClick(X, currentWord);
            if (Gaming.checkWord(currentWord) == true)
            {
                resetBtns();
            }
            Inicio();
        }

        private void Y_Click(object sender, EventArgs e)
        {
            Gaming.btClick(Y, currentWord);
            if (Gaming.checkWord(currentWord) == true)
            {
                resetBtns();
            }
            Inicio();
        }

        private void Z_Click(object sender, EventArgs e)
        {
            Gaming.btClick(Z, currentWord);
            if (Gaming.checkWord(currentWord) == true)
            {
                resetBtns();
            }
            Inicio();
        }

        public void addAllLabels(List<Label> labels)
        {
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

        public void resetBtns()
        {
            A.Visible = true; B.Visible = true; C.Visible = true; D.Visible = true;
            E.Visible = true; F.Visible = true; G.Visible = true; H.Visible = true;
            I.Visible = true; J.Visible = true; K.Visible = true; L.Visible = true;
            M.Visible = true; N.Visible = true; O.Visible = true; P.Visible = true;
            Q.Visible = true; R.Visible = true; S.Visible = true; T.Visible = true;
            U.Visible = true; V.Visible = true; W.Visible = true; X.Visible = true;
            Y.Visible = true; Z.Visible = true;
        }

        public void displayForca(int i)
        {
            int stage = 6 - i;
            if(stage == 0)
            {
                stage0.Visible = true;
                stage1.Visible = false;
                stage2.Visible = false;
                stage3.Visible = false;
                stage4.Visible = false;
                stage5.Visible = false;
                stage6.Visible = false;
            }
            else if (stage == 1)
            {
                stage0.Visible = false;
                stage1.Visible = true;
                stage2.Visible = false;
                stage3.Visible = false;
                stage4.Visible = false;
                stage5.Visible = false;
                stage6.Visible = false;
            }
            else if (stage == 2)
            {
                stage0.Visible = false;
                stage1.Visible = false;
                stage2.Visible = true;
                stage3.Visible = false;
                stage4.Visible = false;
                stage5.Visible = false;
                stage6.Visible = false;
            }
            else if (stage == 3)
            {
                stage0.Visible = false;
                stage1.Visible = false;
                stage2.Visible = false;
                stage3.Visible = true;
                stage4.Visible = false;
                stage5.Visible = false;
                stage6.Visible = false;
            }
            else if (stage == 4)
            {
                stage0.Visible = false;
                stage1.Visible = false;
                stage2.Visible = false;
                stage3.Visible = false;
                stage4.Visible = true;
                stage5.Visible = false;
                stage6.Visible = false;
            }
            else if (stage == 5)
            {
                stage0.Visible = false;
                stage1.Visible = false;
                stage2.Visible = false;
                stage3.Visible = false;
                stage4.Visible = false;
                stage5.Visible = true;
                stage6.Visible = false;
            }
            else if (stage == 6)
            {
                stage0.Visible = false;
                stage1.Visible = false;
                stage2.Visible = false;
                stage3.Visible = false;
                stage4.Visible = false;
                stage5.Visible = false;
                stage6.Visible = true;
            }
        }
    }
}
