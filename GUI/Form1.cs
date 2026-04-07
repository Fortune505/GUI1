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
            if (!double.TryParse(textBoxSquare.Text, out double squareInput) || !double.TryParse(textBoxCircle.Text, out double circleInput)){
                MessageBox.Show("Введи число, а не букву", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int result = Logic.CompareAreas(squareInput, circleInput);
            double areaSquare = Logic.GetSquareArea(squareInput);
            double areaCircle = Logic.GetCircleArea(circleInput);
            string finalPhrese;

            if (result == 1) {
                finalPhrese = $"Площадь квадрата больше.\nS квадрата = {areaSquare}\nS круга = {areaCircle}";
            } else {
                finalPhrese = $"Площадь круга больше.\nS квадрата = {areaSquare}\nS круга = {areaCircle}";
            }

            labelResult.Text = finalPhrese;
            MessageBox.Show(finalPhrese, "Результат вычислений", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

