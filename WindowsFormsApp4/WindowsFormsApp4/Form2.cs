using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class TML_MAPS : Form
    {
        public List<int> choose_city = new List<int>();
        public string[] yazi = new string[82];
        public string yazi1;
        public int[,] matrix = new int[81, 2];
        public string[] sehirler = new string[81];
   
        public void koordinat_matris()
        {
            FileStream fs = new FileStream("PİXELLER.TXT", FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            yazi1 = sw.ReadLine();
            int i = 0;
            while (yazi1 != null)
            {
                yazi[i] = String.Copy(yazi1);
                yazi1 = sw.ReadLine();

                i++;
            }
            char vırgul = ';';

            for (int j = 0; j < 81; j++)
            {
                string[] parca = yazi[j].Split(vırgul);
                for (int k = 0; k <= 1; k++)
                {
                    matrix[j, k] = Convert.ToInt32(parca[k]);
                   // Console.WriteLine(matrix[j, k]);


                }
               

            }
            sw.Close();
            fs.Close();
            
        }

        public TML_MAPS()
        {
            
            
            InitializeComponent();
            

        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {


            Paint += Form2_Paint;


        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            d d = new d();
            Komsuluk_matris matris = new Komsuluk_matris();
            koordinat_matris();
            

            int mesafe =0 ;
            for (int i = 0; i < choose_city.Count - 1; i++)
            {
                string box = "";
                d.dijkstra(matris.matrix, choose_city[i], choose_city[i + 1]);
                //Console.WriteLine(choose_city.Count);
                Graphics cizim = e.Graphics;
                // Console.WriteLine(d.shortest_dist[0]);
               
               
                //Console.WriteLine("Toplam yol->" + distance);
                for (int h = 0; h < d.shortest_dist.Count; h++)
                {
                    //Console.Write(d.shortest_dist[h] + " = ");
                    mesafe += d.shortest_dist[h];
                    box = Convert.ToString(d.shortest_dist[h]) + " =>";



                    for (int k = 0; k < d.path_matrix[h].Count-1; k++)
                    {
                        
                       // Console.Write(sehirler[d.path_matrix[h][k]]);
                        box += sehirler[d.path_matrix[h][k]] + " <-";
                       // Console.Write(d.path_matrix[h][k] + "-> ");
                       // Console.Write(matrix[d.path_matrix[h][k], 0] + ":" + matrix[d.path_matrix[h][k], 1] +" ");
                        
                        
                        if (h==d.shortest_dist.Count-1)
                        {
                            
                            cizim.DrawLine(Pens.Red, matrix[d.path_matrix[h][k], 0], matrix[d.path_matrix[h][k], 1], matrix[d.path_matrix[h][k+1], 0], matrix[d.path_matrix[h][k+1], 1]);
                            
   
                        }
                        else
                        {
                            
                            cizim.DrawLine(Pens.Black, matrix[d.path_matrix[h][k], 0], matrix[d.path_matrix[h][k], 1], matrix[d.path_matrix[h][k + 1], 0], matrix[d.path_matrix[h][k + 1], 1]);
                        }
                       
                    }
                    listBox1.Items.Add(box);
                   
                    string mesafe_s = "TOPLAM MESAFE = " + Convert.ToString(mesafe); ; 
                    listBox1.Items.Add(mesafe_s);
                    Console.WriteLine();
                    Console.WriteLine(h);
                    


                }
                
                //cizim.DrawLine(Pens.Red,997, 410, 0, 0);

            }
            
            






        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
 
}
