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
        public Form1()
        {
            InitializeComponent();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        
        public void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] integers = new int[]
    {
        4898076, 6935329, 9338121, 8747950, 3487108, 3412756, 3126020,
        3351987, 4627060, 4859623, 3960873, 4145597, 2519900, 3374144,
        3018099, 5211086, 5774242, 4834495, 9793622, 2050801, 6421184,
        4936783, 6770735, 6216823, 8268708, 6230003, 5613602
    };

            string[] names = new string[]
            {
        "Adrijan", "Bojan", "Boris", "Dalibor", "Dario", "Ivan", "Jadranko",
        "Janko", "Marko", "Matej", "Mirko", "Mladen", "Nino", "Oliver",
        "Petar", "Slavko", "Stipe", "Stjepan", "Tomislav", "Toni", "Vedran",
        "Vladimir", "Zoran", "Zvonko", "Željko", "Jure", "Ivica", "Domagoj"
            };

            for (int i = 0; i < Math.Min(integers.Length, names.Length); i++)
            {
                ListViewItem item = new ListViewItem((i + 1).ToString());
                item.SubItems.Add(integers[i].ToString());
                item.SubItems.Add(names[i]);
                listView1.Items.Add(item);
            }
        }
    }
}
