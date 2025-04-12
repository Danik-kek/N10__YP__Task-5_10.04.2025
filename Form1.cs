namespace N10__YP__Task_5_10._04._2025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем значения из текстовых полей
                if (decimal.TryParse(textBox1.Text, out decimal dollarRate) &&
                    decimal.TryParse(textBox2.Text, out decimal euroRate) &&
                    decimal.TryParse(textBox3.Text, out decimal rubAmount))
                {
                    // Рассчитываем эквиваленты
                    decimal dollarEquivalent = rubAmount / dollarRate;
                    decimal euroEquivalent = rubAmount / euroRate;

                    // Отображаем результаты
                    textBox4.Text = dollarEquivalent.ToString("F2"); // Два знака после запятой
                    textBox5.Text = euroEquivalent.ToString("F2");  // Два знака после запятой
                }
                else
                {
                    MessageBox.Show("Введите корректные значения для курсов и суммы в рублях.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
