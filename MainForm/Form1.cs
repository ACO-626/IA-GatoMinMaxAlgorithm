using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MainForm
{
    public partial class FormMain : Form
    {
        #region Variables
        string simbol = "X";
        string simbolNXT = "O";

        

        byte val = 0;

        byte row1 = 0;
        byte row2 = 0;
        byte row3 = 0;
        byte column1 = 0;
        byte column2 = 0;
        byte column3 = 0;
        byte diag1 = 0;
        byte diag2 = 0;

        byte turno=1;

        int[,] matrix = new int[3, 3];
        //bool[] matrixBool = new bool[9];
        byte[] matrixConceptual = new byte[9];
        //Tiene cuatro niveles de profundidad máximo 8 posibles tiros, 9 casillas
        byte[,,] arbol = new byte[4, 8, 9];
        #endregion

        #region PredicciónArbol
        private void prediceArbol(byte casilla, byte signoOfMin)
        {
            int estimado = estimaMatrices(turno, 4);
            byte[,] arbol = new byte[estimado,9];

            //Heredo a todos los hijos el estado actual
            for(int i = 0; i<estimado;i++)
            {
                for(int j = 0;j<9;j++)
                {
                    arbol[i, j] = matrixConceptual[j];
                }
                
            }

        }
        #endregion

        #region Estimación de Matrices
        private int estimaMatrices(int turno,int pasos)
        {
            int numMat = 0;
            if (turno<6)
            {
                

                for (int i = 0; i < pasos; i++)
                {
                    numMat += factorial(10 - turno) / factorial(9 - turno - i);
                }

                return numMat;
            }else
            {
                numMat = 64;
                return numMat;
            }
            
        }
        #endregion

        #region CalculoFactorial
        private int factorial(int n)
        {
            if (n == 1 || n == 0)
            {
                return 1;
            }              
            return n * factorial(n - 1);
        }
        #endregion



        #region Banderas
        bool manoMano = true;
        bool manoRandom = false;
        bool manoIA = false;

        bool turnoX = true;
        bool tiroPC = false;
        bool winer = false;

        #endregion

        #region Inicializar
        public FormMain()
        {
            InitializeComponent();
            reset();
        }
        #endregion

        #region StripMenu
        private void iAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manoMano = false;
            manoRandom = false;
            manoIA = true;

            labelAdvice.Text = "1 VS IA";
        }

        private void rANDOMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manoMano = false;
            manoIA = false;
            manoRandom = true;

            labelAdvice.Text = "1 VS RANDOM";
        }

        private void UnoVsUnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manoIA = false;
            manoRandom = false;
            manoMano = true;

            labelAdvice.Text = "1 VS 1";
        }
        #endregion

        #region Reset
        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            turno = 1;
            turnoX = true;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = 0;
                }
            }
            
            for (int i = 0; i < 9; i++)
            {

                matrixConceptual[i] = 0;

            }

            label1.Text = " ";
            label2.Text = " ";
            label3.Text = " ";
            label4.Text = " ";
            label5.Text = " ";
            label6.Text = " ";
            label7.Text = " ";
            label8.Text = " ";
            label9.Text = " ";
            labelTurn.Text = "Turno X";
             row1 = 0;
             row2 = 0;
             row3 = 0;
             column1 = 0;
             column2 = 0;
             column3 = 0;
             diag1 = 0;
             diag2 = 0;
             winer = false;
             enableGame(true);
            
        }
        #endregion

        #region FuncionRellenar
        private void rellenar(int casilla, bool turnoX)
        {
            
            if (turnoX)
            {
                simbol = "X";
                simbolNXT = "O";
                val = 1;
            }
            else
            {
                simbol = "O";
                simbolNXT = "X";
                val = 4;
            }
            switch (casilla)
            {
                case 1:
                    label1.Text = simbol;

                    // *  -  - //
                    // -  -  - //
                    // -  -  - //

                    row1 += val;
                    column1 += val;
                    diag1 += val;

                    break;
                case 2:
                    label2.Text = simbol;

                    // -  *  - //
                    // -  -  - //
                    // -  -  - //
                    row1 += val;
                    column2 += val;

                    break;
                case 3:
                    label3.Text = simbol;

                    // -  -  * //
                    // -  -  - //
                    // -  -  - //

                    row1 += val;
                    column3 += val;
                    diag2 += val;
                    break;
                case 4:
                    label4.Text = simbol;

                    // -  -  - //
                    // *  -  - //
                    // -  -  - //

                    row2 += val;
                    column1 += val;
                    
                    break;
                case 5:
                    label5.Text = simbol;

                    // -  -  - //
                    // -  *  - //
                    // -  -  - //

                    row2 += val;
                    column2 += val;
                    diag2 += val;
                    diag1 += val;
                    break;
                case 6:

                    label6.Text = simbol;

                    // -  -  - //
                    // -  -  * //
                    // -  -  - //

                    row2 += val;
                    column3 += val;
                    
                    break;
                case 7:
                    label7.Text = simbol;

                    // -  -  - //
                    // -  -  - //
                    // *  -  - //

                    row3 += val;
                    column1 += val;
                    diag2 += val;
                    break;
                case 8:
                    label8.Text = simbol;

                    // -  -  - //
                    // -  -  - //
                    // -  *  - //

                    row3 += val;
                    column2 += val;
                    
                    break;
                case 9:
                    label9.Text = simbol;

                    // -  -  - //
                    // -  -  - //
                    // -  -  * //

                    row3 += val;
                    column3 += val;
                    diag1 += val;
                    break;
                default:

                    break;
            }            
            whoWin();
            turno++;
            //labelProve2.Text = turno.ToString();
            //labelProve.Text = estimaMatrices(turno, 4).ToString();

            //Para tener matriz conceptual
            if(turnoX)
            {
                matrixConceptual[casilla - 1] = 1;
            }else
            {
                matrixConceptual[casilla - 1] = 4;
            }
            
            //matrixBool[casilla-1] = true;

            this.turnoX = !turnoX;
            if (manoRandom &&  tiroPC==false && !winer)
            {
                Random random = new Random();
                int azar = random.Next(9);
                while(matrixConceptual[azar] != 0)
                {
                    azar = random.Next(9);
                }
                tiroPC = true;
                rellenar(azar+1, this.turnoX);
                tiroPC = false;
            }
            
        }
        #endregion

        #region EventosToqueCasilla
        private void label1_Click(object sender, EventArgs e)
        {
            rellenar(1, turnoX);
            

        }

        private void label2_Click(object sender, EventArgs e)
        {
            rellenar(2, turnoX);
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            rellenar(3, turnoX);
           
        }

        private void label4_Click(object sender, EventArgs e)
        {
            rellenar(4, turnoX);
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            rellenar(5, turnoX);
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            rellenar(6, turnoX);
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
            rellenar(7, turnoX);
           
        }

        private void label8_Click(object sender, EventArgs e)
        {
            rellenar(8, turnoX);
            
        }

        private void label9_Click(object sender, EventArgs e)
        {
            rellenar(9, turnoX);
            
        }
        #endregion

        #region FuncionQuienGana

        private void whoWin()
        {
            
            if(row1 == 3 || row2 == 3 || row3 == 3 || column1 == 3 || column2 == 3 || column3 == 3 || diag1 == 3 || diag2 == 3)
            {
                labelTurn.Text = "El ganador es X";
                enableGame(false);
                winer = true;
            }else if(row1 == 12 || row2 == 12 || row3 == 12 || column1 == 12 || column2 == 12 || column3 == 12 || diag1 == 12 || diag2 == 12)
            {
                labelTurn.Text = "El ganador es O";
                enableGame(false);
                winer = true;
            }
            else if(!manoRandom)
            {
                this.labelTurn.Text = "Turno " + simbolNXT;
            }

        }
        #endregion

        #region DisableFuncion

        private void enableGame(bool state)
        {
            label1.Enabled = state;
            label2.Enabled = state;
            label3.Enabled = state;
            label4.Enabled = state;
            label5.Enabled = state;
            label6.Enabled = state;
            label7.Enabled = state;
            label8.Enabled = state;
            label9.Enabled = state;
        }
        #endregion

        #region Cambio de inicio
        private void comienzaXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reset();
             simbol = "X";
             simbolNXT = "O";
             labelTurn.Text = "Turno X";
        }

        private void comienzaOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reset();
            simbol = "O";
            simbolNXT = "X";
            turnoX = false;
            labelTurn.Text = "Turno O";
        }
        #endregion

        #region Contacto
        private void gitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://github.com/ACO-626/IA-GatoMinMaxAlgorithm");
        }

        private void repositoriosACOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://github.com/ACO-626");
        }

        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Email: ocampoalejandro.oc@gmail.com \n By ACO", "Contacto desarrollador");
        }
        #endregion
    }
}