using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace BCS {
    static class Program {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main(string[] args) {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frm_Main());
            Data d = new Data(args[0]);
            Write(d);
            Console.WriteLine("Press return to exit");
            Console.ReadLine();
        }

        private static void Write(Data d) {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Ey_Para:");
            Console.WriteLine("Iris Center    : x={0}", d.LimbusDecentration.X);
            Console.WriteLine("Iris Center    : y={0}", d.LimbusDecentration.Y);
            Console.WriteLine("Iris Diameter  : {0}", d.IrisDiameter);
            Console.WriteLine("Pupil  Center  : x={0}", d.PupilDecentration.X);
            Console.WriteLine("Pupil  Center  : y={0}", d.PupilDecentration.Y);
            Console.WriteLine("Pupil  Diameter: {0}", d.PupilDiameter);
            Console.WriteLine(d.Flat.Radius);
            Console.WriteLine(d.Steep.Radius);
        }
    }
}
