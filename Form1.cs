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
                // �������� �������� �� ��������� �����
                if (decimal.TryParse(textBox1.Text, out decimal dollarRate) &&
                    decimal.TryParse(textBox2.Text, out decimal euroRate) &&
                    decimal.TryParse(textBox3.Text, out decimal rubAmount))
                {
                    // ������������ �����������
                    decimal dollarEquivalent = rubAmount / dollarRate;
                    decimal euroEquivalent = rubAmount / euroRate;

                    // ���������� ����������
                    textBox4.Text = dollarEquivalent.ToString("F2"); // ��� ����� ����� �������
                    textBox5.Text = euroEquivalent.ToString("F2");  // ��� ����� ����� �������
                }
                else
                {
                    MessageBox.Show("������� ���������� �������� ��� ������ � ����� � ������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"��������� ������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
