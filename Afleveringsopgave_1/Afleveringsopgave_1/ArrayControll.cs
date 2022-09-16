using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Afleveringsopgave_1
{
    internal class ArrayControll
    {
        public String[] bruger = new string[] { }; // Sætter et array der er tomt

        public int arraycounter { get; set; }   // Sætter Array Counter

        public string? username { get; set; }   // Sætter username = Textbox

        public void adduser()
        {
            arraycounter = bruger.Length+1; // Array counter sættes til antallet af poster i Arrayet +1
            Array.Resize(ref bruger, arraycounter); // Resizer arrayet med Arraycounters værdi
            debug(Convert.ToString($"arraycounter er nu {arraycounter} \n\r"));// Mit private debugvindue
            //bruger[arraycounter] = username.ToString(); // Fylder den nye plads i arrayet med username

            /*
             * Når jeg forsøger at tilføje et nyt navn til mit array for jeg array out of range
             * Jeg forsøger at lave det hele lidt mere smart så arrayet ikke er fixed, men at der er metoder til at 
             * resize arrayet op og ned
             * 
             * Jeg har forsøgt mig med mange ting, men under alle omstændigheder, ender jeg altid ud i at mit
             * array ikke resizes, det forbliver altid på 1, JEg har tænkt over om det evt er fordi at hver gang 
             * jeg trykker på knappen, så laver jeg faktisk et nyt array, og derved bliver det nye array
             * aldrig større end 1
             * Men hvor skal jeg så declerere mit array, har også forsøgt at ligge declerationen i onload
             * af formen, men stadig uden held
             * 
             * Håber du kan se hvad jeg vil, og ikke mindst hvad jeg gør galt
             */

            debug(Convert.ToString($"Dit array er nu {arraycounter} stort \n\r")); // Mit private debugvindue
        }

        void deluser()
        {

        }

        void generateUserlist()
        {

        }

        public void debug(string debugtext)
        {
            var textbox = Form.ActiveForm as Form1;
            if (textbox != null)
            {
                textbox.textBoxDebug.Text = debugtext+"\n\r";
            }
        }
    }
}
