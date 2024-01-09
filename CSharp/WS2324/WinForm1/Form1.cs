namespace WinForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox_Verbrauch.Text = "Hallo";
            double verbrauch = 0;
            double.TryParse(textBox_Verbrauch.Text, out verbrauch);
            double reichweite = 0;
            reichweite = verbrauch * 1.234566;
            textBox_Reichweite.Text = reichweite.ToString();
            MessageBox.Show("Hallo");

            // 1. Convert
            var output = Convert.ToDouble(textBox_Verbrauch.Text);

            // 2. double.parse
            try
            {
                var output2 = double.Parse(textBox_Verbrauch.Text);
            }
            catch
            {

            }

            // 3. double.TryParse
            if(double.TryParse(textBox_Verbrauch.Text, out double output3))
            {
            }
        }
    }
}
