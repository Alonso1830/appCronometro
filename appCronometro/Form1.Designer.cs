namespace appCronometro
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnIniciar = new Button();
            btnDetener = new Button();
            btnReiniciar = new Button();
            lblTiempo = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.Lime;
            btnIniciar.BackgroundImage = Properties.Resources.play;
            btnIniciar.BackgroundImageLayout = ImageLayout.Stretch;
            btnIniciar.Location = new Point(61, 131);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(52, 39);
            btnIniciar.TabIndex = 0;
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnDetener
            // 
            btnDetener.BackColor = SystemColors.ButtonFace;
            btnDetener.BackgroundImage = Properties.Resources.pausa;
            btnDetener.BackgroundImageLayout = ImageLayout.Stretch;
            btnDetener.Location = new Point(177, 131);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(51, 39);
            btnDetener.TabIndex = 1;
            btnDetener.UseVisualStyleBackColor = false;
            btnDetener.Click += btnDetener_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.BackColor = Color.FromArgb(192, 192, 0);
            btnReiniciar.BackgroundImage = Properties.Resources.reset;
            btnReiniciar.BackgroundImageLayout = ImageLayout.Stretch;
            btnReiniciar.Location = new Point(282, 131);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(51, 39);
            btnReiniciar.TabIndex = 2;
            btnReiniciar.UseVisualStyleBackColor = false;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Font = new Font("Arial Black", 50.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTiempo.ForeColor = Color.Red;
            lblTiempo.Location = new Point(24, 9);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(354, 95);
            lblTiempo.TabIndex = 3;
            lblTiempo.Text = "00:00:00";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(403, 200);
            Controls.Add(lblTiempo);
            Controls.Add(btnReiniciar);
            Controls.Add(btnDetener);
            Controls.Add(btnIniciar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Cronometro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciar;
        private Button btnDetener;
        private Button btnReiniciar;
        private Label lblTiempo;
        private System.Windows.Forms.Timer timer1;
    }
}
