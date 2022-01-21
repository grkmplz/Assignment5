using System;
using System.Collections.Generic;

namespace assignment5_trial_trial2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Hogetdatetimee = DateTime.UtcNow.ToString("yyyy-MM-dd");
            string dosyaadiinikoy = Hogetdatetimee + ".txt";

            string yoluciz = @"C:\Users\gorke\Desktop\";
            string kombinet = System.IO.Path.Combine(yoluciz, dosyaadiinikoy);

            List<string> allvalwewant = new List<string>();
            Console.WriteLine("Please write the text : ");
            string valueue;

          
            bool cingalo = true;                                     // 2.Yçntem ve hocanın istediği yöntem
            do
            {
                valueue = Console.ReadLine();
                if (valueue == "start")
                {
                    do
                    {
                        valueue = Console.ReadLine();
                        if (valueue != "stop")
                        {
                            allvalwewant.Add(valueue);
                        }
                    } while (valueue != "stop");

                    using (System.IO.StreamWriter dosca = new System.IO.StreamWriter(kombinet))
                    {
                        dosca.WriteLine("Captains's log \nStardate " + Hogetdatetimee + "\n");
                        foreach (var allwewant in allvalwewant)
                        {
                            dosca.WriteLine(allwewant);
                        }
                        dosca.WriteLine("\n" + "Jean-Luc Picard");
                    }

                    if (valueue == "stop")
                    {
                        cingalo = false;
                    }
                }

            } while (cingalo != false);


        }
    }
}
