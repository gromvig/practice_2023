using static System.Math;
namespace practice_2023
{
    public partial class Form1 : Form
    {
       Dots[] mas = new Dots[3];
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("1");
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("3");

            comboBox2.Items.Add("1");
            comboBox2.Items.Add("2");
            comboBox2.Items.Add("3");

            comboBox3.Items.Add("1");
            comboBox3.Items.Add("2");
            comboBox3.Items.Add("3");
            label22.Text = Convert.ToString(1);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            label22.Text = Convert.ToString(i + 2);
            int z = int.Parse(textBox1.Text);
            int r = int.Parse(textBox3.Text);
            double angle = PI * double.Parse(textBox2.Text);
            Dots dot = new Dots(z, r, angle);
            mas[i] = dot;
            i++;
            int x0 = int.Parse(textBox4.Text);
            int y0 = int.Parse(textBox5.Text);
            int z0 = int.Parse(textBox6.Text);
            int m = int.Parse(textBox7.Text);
            int n = int.Parse(textBox8.Text);
            int p = int.Parse(textBox9.Text);
            if (i == 3)
            {
                label17.Text = Convert.ToString(dot.triangle_square(mas[0].decDot, mas[1].decDot, mas[2].decDot));
                switch (comboBox3.SelectedIndex)
                {
                    case 0:
                        label18.Text = Convert.ToString(dot.straight_distance(mas[0].decDot, x0, y0, z0, m, n, p));
                        break;
                    case 1:
                        label18.Text = Convert.ToString(dot.straight_distance(mas[1].decDot, x0, y0, z0, m, n, p));
                        break;
                    case 2:
                        label18.Text = Convert.ToString(dot.straight_distance(mas[2].decDot, x0, y0, z0, m, n, p));
                        break;
                }
                if (comboBox1.Text == comboBox2.Text)
                {
                    label21.Text = "0";
                }
                else if ((comboBox1.Text == "1" || comboBox2.Text == "1") && (comboBox1.Text == "2" || comboBox2.Text == "2"))
                {
                    label21.Text = Convert.ToString(dot.Dots_distance(mas[0].decDot, mas[1].decDot));
                }
                else if ((comboBox1.Text == "2" || comboBox2.Text == "2") && (comboBox1.Text == "3" || comboBox2.Text == "3"))
                {
                    label21.Text = Convert.ToString(dot.Dots_distance(mas[1].decDot, mas[2].decDot));
                }
                else if ((comboBox1.Text == "1" || comboBox2.Text == "1") && (comboBox1.Text == "3" || comboBox2.Text == "3"))
                {
                    label21.Text = Convert.ToString(dot.Dots_distance(mas[0].decDot, mas[2].decDot));
                }
            }
        }
    }
}