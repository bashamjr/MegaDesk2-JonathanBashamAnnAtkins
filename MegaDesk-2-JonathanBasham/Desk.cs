using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_4_JonathanBasham
{
    class Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int numOfDrawers { get; set; }
        public string surfMaterial { get; set; }
       
        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;

        public struct DeskObject
        {
            public string CurrentDate;
            public string CustomerName;
            public int Width;
            public int Depth;
            public int numOfDrawers;
            public string surfMaterial;
            public int RushOrderDays;
            public int TotalQuote;     
        }

        public enum DeskMaterials
        {
            Oak,
            Laminate,
            Pine,
            Rosewood,
            Veneer
        }
    }
}
