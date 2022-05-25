namespace FunkcjaKwadratowa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                double a, b, c, ans1, ans2, ans3;
                a = double.Parse(tb_a.Text);
                b = double.Parse(tb_b.Text);
                c = double.Parse(tb_c.Text);
                ans1 = (-1 * b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
                ans2 = (-1 * b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
                ans3 = (Math.Pow(b, 2) - 4 * a * c);
                lb_answer1.Text = ans1.ToString("n2");
                lb_answer2.Text = ans2.ToString("n2");
                lb_answer3.Text = ans3.ToString("n2");
                if (ans3 > 0)
                {


                    this.richTextBox1.Text = "\nDelta jest większa od 0:\n"
                    + "x1 = (-b - √Δ) / 2a ≈ " + Math.Round(ans1) + "\nx2 = (-b + √Δ) / 2a ≈ " + Math.Round(ans2);
                }
                else if (ans3 < 0)
                {

                    richTextBox1.Text = "\nDelta jest mniejsza od 0: Brak Rozwiązań dla x1 i x2\n";

                }
                else if (ans3 == 0)
                {
                    double x0;
                    x0 = -b / (2 * a);
                    richTextBox1.Text = "\nDelta Jest Równa 0:\n"
                    + "xₒ = x1 = x2 = -b / 2a ≈ " + Math.Round(ans1);
                }

            }
        }
    }
}