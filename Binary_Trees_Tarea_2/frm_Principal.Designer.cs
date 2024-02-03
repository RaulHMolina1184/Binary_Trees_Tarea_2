namespace Binary_Trees_Tarea_2
{
    public partial class frm_Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ptb_matriz = new PictureBox();
            bnt_random = new Button();
            btn_pausa = new Button();
            btn_iniciar = new Button();
            tmr_1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)ptb_matriz).BeginInit();
            SuspendLayout();
            // 
            // ptb_matriz
            // 
            ptb_matriz.Location = new Point(31, 36);
            ptb_matriz.Name = "ptb_matriz";
            ptb_matriz.Size = new Size(400, 400);
            ptb_matriz.TabIndex = 1;
            ptb_matriz.TabStop = false;
            // 
            // bnt_random
            // 
            bnt_random.Location = new Point(535, 35);
            bnt_random.Name = "bnt_random";
            bnt_random.Size = new Size(155, 29);
            bnt_random.TabIndex = 1;
            bnt_random.Text = "Random";
            bnt_random.UseVisualStyleBackColor = true;
            bnt_random.Click += bnt_random_Click;
            // 
            // btn_pausa
            // 
            btn_pausa.Location = new Point(535, 89);
            btn_pausa.Name = "btn_pausa";
            btn_pausa.Size = new Size(155, 29);
            btn_pausa.TabIndex = 2;
            btn_pausa.Text = "Pausa";
            btn_pausa.UseVisualStyleBackColor = true;
            btn_pausa.Click += btn_pausa_Click;
            // 
            // btn_iniciar
            // 
            btn_iniciar.Location = new Point(535, 143);
            btn_iniciar.Name = "btn_iniciar";
            btn_iniciar.Size = new Size(155, 29);
            btn_iniciar.TabIndex = 3;
            btn_iniciar.Text = "Iniciar";
            btn_iniciar.UseVisualStyleBackColor = true;
            btn_iniciar.Click += btn_iniciar_Click;
            // 
            // tmr_1
            // 
            tmr_1.Tick += tmr_1_Tick;
            // 
            // frm_Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 487);
            Controls.Add(btn_iniciar);
            Controls.Add(btn_pausa);
            Controls.Add(bnt_random);
            Controls.Add(ptb_matriz);
            Name = "frm_Principal";
            Text = "El juego de la vida";
            Load += frm_Principal_Load;
            ((System.ComponentModel.ISupportInitialize)ptb_matriz).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ptb_matriz;
        private Button bnt_random;
        private Button btn_pausa;
        private Button btn_iniciar;
        private System.Windows.Forms.Timer tmr_1;
    }
}
