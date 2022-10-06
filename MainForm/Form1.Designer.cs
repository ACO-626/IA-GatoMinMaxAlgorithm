
namespace MainForm
{
    partial class FormMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTittle2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modoDeJuegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rANDOMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UnoVsUnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.labelTurn = new System.Windows.Forms.Label();
            this.labelAdvice = new System.Windows.Forms.Label();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comienzaXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comienzaOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTitle.Location = new System.Drawing.Point(270, 153);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(237, 23);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "EJEMPLO MINMAX - E3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(130, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelTittle2
            // 
            this.labelTittle2.AutoSize = true;
            this.labelTittle2.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTittle2.Location = new System.Drawing.Point(221, 115);
            this.labelTittle2.Name = "labelTittle2";
            this.labelTittle2.Size = new System.Drawing.Size(343, 23);
            this.labelTittle2.TabIndex = 2;
            this.labelTittle2.Text = "FACULTAD DE INGENIERÍA -UNAM";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(570, 79);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 97);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modoDeJuegoToolStripMenuItem,
            this.inicioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(779, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modoDeJuegoToolStripMenuItem
            // 
            this.modoDeJuegoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iAToolStripMenuItem,
            this.rANDOMToolStripMenuItem,
            this.UnoVsUnoToolStripMenuItem});
            this.modoDeJuegoToolStripMenuItem.Name = "modoDeJuegoToolStripMenuItem";
            this.modoDeJuegoToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.modoDeJuegoToolStripMenuItem.Text = "Modo de juego";
            // 
            // iAToolStripMenuItem
            // 
            this.iAToolStripMenuItem.Name = "iAToolStripMenuItem";
            this.iAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iAToolStripMenuItem.Text = "1 VS IA";
            this.iAToolStripMenuItem.Click += new System.EventHandler(this.iAToolStripMenuItem_Click);
            // 
            // rANDOMToolStripMenuItem
            // 
            this.rANDOMToolStripMenuItem.Name = "rANDOMToolStripMenuItem";
            this.rANDOMToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rANDOMToolStripMenuItem.Text = "1 VS RANDOM";
            this.rANDOMToolStripMenuItem.Click += new System.EventHandler(this.rANDOMToolStripMenuItem_Click);
            // 
            // UnoVsUnoToolStripMenuItem
            // 
            this.UnoVsUnoToolStripMenuItem.Name = "UnoVsUnoToolStripMenuItem";
            this.UnoVsUnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.UnoVsUnoToolStripMenuItem.Text = "1 VS 1";
            this.UnoVsUnoToolStripMenuItem.Click += new System.EventHandler(this.UnoVsUnoToolStripMenuItem_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(186, 279);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(404, 373);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Montserrat", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(250, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 82);
            this.label1.TabIndex = 6;
            this.label1.Text = ".";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Montserrat", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(351, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 82);
            this.label2.TabIndex = 7;
            this.label2.Text = ".";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Montserrat", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(457, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 82);
            this.label3.TabIndex = 8;
            this.label3.Text = ".";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Montserrat", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(246, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 82);
            this.label4.TabIndex = 9;
            this.label4.Text = ".";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Montserrat", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(351, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 82);
            this.label5.TabIndex = 10;
            this.label5.Text = ".";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Montserrat", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(457, 427);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 82);
            this.label6.TabIndex = 11;
            this.label6.Text = ".";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Montserrat", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(246, 522);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 82);
            this.label7.TabIndex = 12;
            this.label7.Text = ".";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("Montserrat", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(351, 522);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 82);
            this.label8.TabIndex = 13;
            this.label8.Text = ".";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Montserrat", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(457, 522);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 82);
            this.label9.TabIndex = 14;
            this.label9.Text = ".";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DarkRed;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.Location = new System.Drawing.Point(471, 255);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(119, 45);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reiniciar";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // labelTurn
            // 
            this.labelTurn.AutoSize = true;
            this.labelTurn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelTurn.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTurn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTurn.Location = new System.Drawing.Point(180, 267);
            this.labelTurn.Name = "labelTurn";
            this.labelTurn.Size = new System.Drawing.Size(118, 33);
            this.labelTurn.TabIndex = 16;
            this.labelTurn.Text = "Turno X";
            // 
            // labelAdvice
            // 
            this.labelAdvice.AutoSize = true;
            this.labelAdvice.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelAdvice.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdvice.ForeColor = System.Drawing.Color.Red;
            this.labelAdvice.Location = new System.Drawing.Point(180, 213);
            this.labelAdvice.Name = "labelAdvice";
            this.labelAdvice.Size = new System.Drawing.Size(85, 33);
            this.labelAdvice.TabIndex = 17;
            this.labelAdvice.Text = "1 VS 1";
            this.labelAdvice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comienzaXToolStripMenuItem,
            this.comienzaOToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // comienzaXToolStripMenuItem
            // 
            this.comienzaXToolStripMenuItem.Name = "comienzaXToolStripMenuItem";
            this.comienzaXToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.comienzaXToolStripMenuItem.Text = "Comienza X";
            this.comienzaXToolStripMenuItem.Click += new System.EventHandler(this.comienzaXToolStripMenuItem_Click);
            // 
            // comienzaOToolStripMenuItem
            // 
            this.comienzaOToolStripMenuItem.Name = "comienzaOToolStripMenuItem";
            this.comienzaOToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.comienzaOToolStripMenuItem.Text = "Comienza O";
            this.comienzaOToolStripMenuItem.Click += new System.EventHandler(this.comienzaOToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(779, 638);
            this.Controls.Add(this.labelAdvice);
            this.Controls.Add(this.labelTurn);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelTittle2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Gato - Tic - Tac - Toe [MinMax Algorithm]";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTittle2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modoDeJuegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rANDOMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UnoVsUnoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label labelTurn;
        private System.Windows.Forms.Label labelAdvice;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comienzaXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comienzaOToolStripMenuItem;
    }
}

