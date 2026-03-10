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
            if (!double.TryParse(textBoxSquare.Text, out double squareInput) || !double.TryParse(textBoxCircle.Text, out double circleInput))
            {
                MessageBox.Show("Введи число, а не букву", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            double squareSide = Logic.GetSquareArea(squareInput);
            double circleRadius = Logic.GetCircleArea(circleInput);

            string finalPhrase = "";

            if (squareSide > circleRadius)
            {
                finalPhrase = $"Площадь квадрата больше.\nS квадрат = {squareSide} \nS круг = {circleRadius}";
            }
            else if (squareSide < circleRadius)
            {
                finalPhrase = $"Площадь круга больше.\nS квадрат = {squareSide} \nS круг = {circleRadius}";
            }
            else {
                finalPhrase = $"Площади равны! \nS {squareSide} = {circleRadius}";
            }

            labelResult.Text = finalPhrase;

            MessageBox.Show(finalPhrase, "Результат вычислений", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

