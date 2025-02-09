namespace appCronometro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int seg = 0, min = 0, hrs = 0;
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            timer1.Start();

            
            
            

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            seg = min = hrs = 0;
            lblTiempo.Text = "00:00:00";
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            timer1.Stop();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seg += 1;
            if (seg == 60)
            {
                min += 1;
                seg = 0;
            }
            if (min == 60)
            {
                min = 0;
                hrs++;
            }

            lblTiempo.Text = "";
            if (hrs < 10)
                lblTiempo.Text += "0" + hrs + ":";
            else
                lblTiempo.Text += hrs + ":";

            if (min < 10)
                lblTiempo.Text += "0" + min + ":";
            else
                lblTiempo.Text += min + ":";

            if (seg < 10)
                lblTiempo.Text += "0" + seg;
            else
                lblTiempo.Text += seg;


            //lblTiempo.Text = hrs + ":" + min + ":" + seg;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
