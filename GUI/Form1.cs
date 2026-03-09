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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.SavedSquare = textBoxSquare.Text;
            Properties.Settings.Default.SavedCircle = textBoxCircle.Text;

            Properties.Settings.Default.Save();
        }

        private void buttonCompare_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxSquare.Text, out double a) || !double.TryParse(textBoxCircle.Text, out double r))
            {
                MessageBox.Show("Введи число, а не букву", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            double SKv = Logic.GetSKv(a);
            double SKr = Logic.GetSKr(r);

            string itogovaFraza = "";

            if (SKv > SKr)
            {
                itogovaFraza = $"Площадь квадрата больше.\nS квадрат = {SKv} \nS круг = {SKr}";
            }
            else if (SKv < SKr)
            {
                itogovaFraza = $"Площадь круга больше.\nS квадрат = {SKv} \nS круг = {SKr}";
            }
            else {
                itogovaFraza = $"Площади равны! \nS {SKv} = {SKr}";
            }

            labelResult.Text = itogovaFraza;

            MessageBox.Show(itogovaFraza, "Результат вычислений", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

