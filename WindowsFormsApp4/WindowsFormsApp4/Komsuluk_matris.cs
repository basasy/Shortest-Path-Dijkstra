using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class Komsuluk_matris
    {
        public string[] yazi = new string[82];
        public string yazi1;
        public int[,] matrix = new int[81, 81];

        public Komsuluk_matris()
        {
            FileStream fs = new FileStream("komsuuzaklik.txt", FileMode.Open, FileAccess.Read);
          
            StreamReader sw = new StreamReader(fs);
            yazi1 = sw.ReadLine();
            int i = 0;
            while (yazi1 != null)
            {
                yazi[i] = String.Copy(yazi1);
                //Console.WriteLine(yazi[i]);
                yazi1 = sw.ReadLine();

                i++;
            }
            char vırgul = ',';

            int[] uzakliklar = new int[81];
            for (int j = 0; j < 81; j++)
            {
                string[] parca = yazi[j].Split(vırgul);
              //  Console.WriteLine(parca[0]);
                for (int k = 0; k < 81; k++)
                {
                    matrix[j, k] = Convert.ToInt32(parca[k + 1]);

                }

            }
            sw.Close();
            fs.Close();
       
        }
    }
}
