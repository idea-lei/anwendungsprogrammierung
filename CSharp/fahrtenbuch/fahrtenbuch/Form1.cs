using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fahrtenbuch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_loaddata_Click(object sender, EventArgs e)
        {
            using (AppDbContext db = new AppDbContext())
            {
                List<Verbrauch> verbList = db.Verbrauche?.ToList() ?? new List<Verbrauch>();

                dg1.DataSource = verbList;
                dg1.Update();
            } 
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (AppDbContext db = new AppDbContext()) {
                Verbrauch v1 = new Verbrauch();
                v1.km_stand = Convert.ToDouble(textBox1.Text);
                v1.km = Convert.ToDouble(textBox2.Text);
                v1.verbrauch = Convert.ToDouble(textBox3.Text);
                v1.v_km = v1.verbrauch * 100 / v1.km;
                v1.v_mpg = 235.215 / v1.v_km;

                textBox4.Text = v1.v_km.ToString();
                textBox5.Text = v1.v_mpg.ToString();

                db.Verbrauche?.Add(v1);
                db.SaveChanges();
            }
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }
    }
}
