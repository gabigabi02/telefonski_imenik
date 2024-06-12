using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonskiImenik
{
    public partial class Form1 : Form
    {
        int[] broj = new int[]
{
        4898076, 6935329, 9338121, 8747950, 3487108, 3412756, 3126020,
        3351987, 4627060, 4859623, 3960873, 4145597, 2519900, 3374144,
        3018099, 5211086, 5774242, 4834495, 9793622, 2050801, 6421184,
        4936783, 6770735, 6216823, 8268708, 6230003, 5613602
};
        string[] ime = new string[]
        {
        "Adrijan", "Bojan", "Boris", "Dalibor", "Dario", "Ivan", "Jadranko",
        "Janko", "Marko", "Matej", "Mirko", "Mladen", "Nino", "Oliver",
        "Petar", "Slavko", "Stipe", "Stjepan", "Tomislav", "Toni", "Vedran",
        "Vladimir", "Zoran", "Zvonko", "Željko", "Jure", "Ivica", "Domagoj"
        };
        public Form1()
        {
            InitializeComponent();

            //this.Hide();
            //Form2 myForm2 = new Form2();
            //myForm2.StartPosition = FormStartPosition.Manual;
            //myForm2.Location = new Point(this.Bounds.Right, this.Bounds.Top);
            //myForm2.Show();
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {
         
      

            for (int i = 0; i < Math.Min(broj.Length, ime.Length); i++)
            {
                ListViewItem kontakt = new ListViewItem((i + 1).ToString());
                kontakt.SubItems.Add(broj[i].ToString());
                kontakt.SubItems.Add(ime[i]);
                listView1.Items.Add(kontakt);
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            int index = -1;
            string unos = textBox1.Text;
            index = Array.IndexOf(ime, unos);

            if (index >= 0)
            {
                int broj1 = broj[index];
                label3.Text = $"Broj korisnika '{unos}': {broj1}";
            }
            else
            {
                label3.Text = $"Korisnik '{unos}' ne postoji!";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
