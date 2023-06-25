namespace DVDLogo
{
    public partial class DVDForm : Form
    {
        private int XSpeed = 5;
        private int YSpeed = 5;

        private int CornerHits = 0;

        private Random Rand = new Random();

        public DVDForm()
        {
            InitializeComponent();

            BouncingLogo.BackColor = Color.FromArgb(Rand.Next(0, 256), Rand.Next(0, 256), Rand.Next(0, 256));
            BouncingLogo.Location = new Point( // randomise location between first and third quarter of the client dimensions
                Rand.Next((int)Math.Round(ClientSize.Width * 0.25), (int)Math.Round(ClientSize.Width * 0.75)), 
                Rand.Next((int)Math.Round(ClientSize.Height * 0.25), (int)Math.Round(ClientSize.Height * 0.75))
            );

            LogoTimer.Start();
        }

        private void LogoTimer_Tick(object sender, EventArgs e)
        {
            if (
                (BouncingLogo.Left <= 0 && BouncingLogo.Top <= 0) || // top-left corner
                (BouncingLogo.Left <= 0 && BouncingLogo.Bottom >= ClientSize.Height) || // bottom-left corner
                (BouncingLogo.Right >= ClientSize.Width && BouncingLogo.Bottom >= ClientSize.Height) || // bottom-right corner
                (BouncingLogo.Right >= ClientSize.Width && BouncingLogo.Top <= 0) // top-right corner
            )
            {
                CornerHits++;
            }

            BouncingLogo.Top -= YSpeed;
            BouncingLogo.Left -= XSpeed;

            if (BouncingLogo.Top < 0 || BouncingLogo.Top >= ClientSize.Height - BouncingLogo.Height)
            {
                YSpeed = -YSpeed;
                BouncingLogo.BackColor = Color.FromArgb(Rand.Next(0, 256), Rand.Next(0, 256), Rand.Next(0, 256));
            }

            if (BouncingLogo.Left < 0 || BouncingLogo.Left >= ClientSize.Width - BouncingLogo.Width)
            {
                XSpeed = -XSpeed;
                BouncingLogo.BackColor = Color.FromArgb(Rand.Next(0, 256), Rand.Next(0, 256), Rand.Next(0, 256));
            }
        }
    }
}