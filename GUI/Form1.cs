namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxSquare.Text = Properties.Settings.Default.SavedSquare;

            textBoxCircle.Text = Properties.Settings.Default.SavedCircle;
        }
    }
}
