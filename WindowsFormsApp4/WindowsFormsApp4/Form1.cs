using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class TML : Form
    {
        public string[] sehirler = new string[81];
        public List<int> choose_city = new List<int>();
        public string[] dosyadan_oku(string [] sehirler)
        {
           
      
            FileStream fs = new FileStream("sehirler form.txt", FileMode.Open, FileAccess.Read);        
            StreamReader sw = new StreamReader(fs);
            string yazi = sw.ReadLine();
            int i = 0;
            while (yazi != null)
            {
                sehirler[i] = String.Copy(yazi);
                yazi = sw.ReadLine();
                //Console.WriteLine(sehirler[i]);
                i++;
                
            }
            //Satır satır okuma işlemini gerçekleştirdik ve ekrana yazdırdık
            //Son satır okunduktan sonra okuma işlemini bitirdik
            return sehirler;
            sw.Close();
            fs.Close();
        }
    public TML()
        {
            InitializeComponent();
            sehirler = dosyadan_oku(sehirler);
            
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int b = 0;
            for(int i=0;i<sehirler.Length;i++)
            {
                if(comboBox2.Text.Equals(sehirler[i]))
                {
                    b = i;
                    break;
                }
            }
            choose_city.Add(b);
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int b = 0;
            for (int i = 0; i < sehirler.Length; i++)
            {
                if (comboBox1.Text.Equals(sehirler[i]))
                {
                    b = i;
                    break;
                }
            }
           // Console.WriteLine(b);
            choose_city.Add(b);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.Items.AddRange(sehirler);
            comboBox1.Items.AddRange(sehirler);
            comboBox3.Items.AddRange(sehirler);
            comboBox4.Items.AddRange(sehirler);
            comboBox5.Items.AddRange(sehirler);
            comboBox6.Items.AddRange(sehirler);
            comboBox7.Items.AddRange(sehirler);
            comboBox8.Items.AddRange(sehirler);
            comboBox9.Items.AddRange(sehirler);
            comboBox10.Items.AddRange(sehirler);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int b = 0;
            for (int i = 0; i < sehirler.Length; i++)
            {
                if (comboBox3.Text.Equals(sehirler[i]))
                {
                    b = i;
                    break;
                }
            }
           // Console.WriteLine(b);
            choose_city.Add(b);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int b = 0;
            for (int i = 0; i < sehirler.Length; i++)
            {
                if (comboBox4.Text.Equals(sehirler[i]))
                {
                    b = i;
                    break;
                }
            }
           // Console.WriteLine(b);
            choose_city.Add(b);
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            int b = 0;
            for (int i = 0; i < sehirler.Length; i++)
            {
                if (comboBox5.Text.Equals(sehirler[i]))
                {
                    b = i;
                    break;
                }
            }
           // Console.WriteLine(b);
            choose_city.Add(b);
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            int b = 0;
            for (int i = 0; i < sehirler.Length; i++)
            {
                if (comboBox6.Text.Equals(sehirler[i]))
                {
                    b = i;
                    break;
                }
            }
           // Console.WriteLine(b);
            choose_city.Add(b);
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            int b = 0;
            for (int i = 0; i < sehirler.Length; i++)
            {
                if (comboBox7.Text.Equals(sehirler[i]))
                {
                    b = i;
                    break;
                }
            }
           // Console.WriteLine(b);
            choose_city.Add(b);
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            int b = 0;
            for (int i = 0; i < sehirler.Length; i++)
            {
                if (comboBox8.Text.Equals(sehirler[i]))
                {
                    b = i;
                    break;
                }
            }
           // Console.WriteLine(b);
            choose_city.Add(b);
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            int b = 0;
            for (int i = 0; i < sehirler.Length; i++)
            {
                if (comboBox9.Text.Equals(sehirler[i]))
                {
                    b = i;
                    break;
                }
            }
            //Console.WriteLine(b);
            choose_city.Add(b);
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            int b = 0;
            for (int i = 0; i < sehirler.Length; i++)
            {
                if (comboBox10.Text.Equals(sehirler[i]))
                {
                    b = i;
                    break;
                }
            }
            //Console.WriteLine(b);
            choose_city.Add(b);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TML_MAPS form2 = new TML_MAPS();
            choose_city.Insert(0, 40);
            choose_city.Add(40);
            /*for(int i=0;i<choose_city.Count;i++)
            {
                Console.WriteLine(choose_city[i]);
            }*/
            form2.choose_city = choose_city;
            form2.sehirler = sehirler;
            form2.Show();
           
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            choose_city.Clear();
            comboBox10.Items.Clear();
            comboBox10.Items.AddRange(sehirler);
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(sehirler);
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(sehirler);
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(sehirler);
            comboBox4.Items.Clear();
            comboBox4.Items.AddRange(sehirler);
            comboBox5.Items.Clear();
            comboBox5.Items.AddRange(sehirler);
            comboBox6.Items.Clear();
            comboBox6.Items.AddRange(sehirler);
            comboBox7.Items.Clear();
            comboBox7.Items.AddRange(sehirler);
            comboBox8.Items.Clear();
            comboBox8.Items.AddRange(sehirler);
            comboBox9.Items.Clear();
            comboBox9.Items.AddRange(sehirler);
        }
    }
}
