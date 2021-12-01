namespace winform_start
{
    public partial class Form1 : Form
    {
        List<PictureBox> pictureBoxes = new List<PictureBox>();
        int index = 0;
        public Form1()
        {
            InitializeComponent();
            pictureBoxes.Add(pictureBoxSun);
            pictureBoxes.Add(pictureBoxRain);
            pictureBoxes.Add(pictureBox1);

            foreach (var p in pictureBoxes)
            {
                p.Visible = false;
            }
            pictureBoxes[0].Visible = true;
            button1.Text = pictureBoxes[index].Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBoxes[index].Visible = false;
            if (index == 2) index = 0;
            else index++;

            pictureBoxes[index].Visible = true;
            button1.Text = pictureBoxes[index].Name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Funktion schreiben
        }
    }
}