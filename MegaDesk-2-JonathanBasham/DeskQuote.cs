using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_4_JonathanBasham
{
    class DeskQuote
    {
        #region Object member variables
        // A desk quote object description
        private string CustomerName;
        private DateTime QuoteDate;
        private Desk Desk = new Desk();
        private int RushDays;
        private int QuoteAmount;
        #endregion

        #region local variables
        // Used in class in multiple areas
        private int SurfaceArea = 0;
        #endregion

        #region Constants
        // Constants (future source is some data source)
        private const int PRICE_BASE = 200;
        private const int SIZE_THRESHOLD = 1000;  // inches squared
        private const int PRICE_PER_DRAWER = 50;
        private const int PRICE_PER_SURFACEAREA = 1; // per square inch greater than desktop threshold
        private const int RUSH1 = 3;  // rush days option 1
        private const int RUSH2 = 5;  // rush days option 2
        private const int RUSH3 = 7;  // rush days option 3
        private const int RUSH_THRESHOLD = 2000; // inches squared - see problem specs for rush order costs
        #endregion

        public DeskQuote(int width, int depth, int drawers, string material, int rushDays)
        {
            // Constructor when object is built - set attribute values
            Desk.Width = width;
            Desk.Depth = depth;
            Desk.numOfDrawers = drawers;
            Desk.surfMaterial = material;
            RushDays = rushDays;

            // calculate Surface Area member variable for use in multiple functions
            SurfaceArea = Desk.Width * Desk.Depth;


        }
        
        public int CalculateQuoteTotal()
        {         
            return PRICE_BASE + SurfaceAreaCost() + DrawerCost() + SurfaceMaterialCost() + GetRushOrder();
        }

        private int SurfaceAreaCost()
        {
            // Determine if additional cost is warranted with desk areas greater than the desktop size threshold
            if (SurfaceArea > SIZE_THRESHOLD)
            {
                return (SurfaceArea - SIZE_THRESHOLD) * PRICE_PER_SURFACEAREA;
            }
            else
            {
                return 0;
            }
        }

        private int DrawerCost()
        {
            return Desk.numOfDrawers * PRICE_PER_DRAWER;
        }

        private int SurfaceMaterialCost()
        {
            int materialCost = 0;
            switch (Desk.surfMaterial)
            {
                 case "Laminate":
                     materialCost = 100;
                     break;
                 case "Oak":
                     materialCost = 200;
                     break;
                 case "Pine":
                     materialCost = 50;
                     break;
                 case "Veneer":
                     materialCost = 125;
                     break;
                 case "Rosewood":
                     materialCost = 300;
                     break;
                 default:
                     materialCost = -1; // error flag
                     break;
             }
            return materialCost;
        }

        private int GetRushOrder()
        {
            int rushCost = 0;
            string path = @"C:\Users\Jonathan.Basham\source\repos\MegaDesk-2-JonathanBasham\MegaDesk-2-JonathanBasham\bin\Debug\rushOrderPrices.txt";
            try
            {
                int x = 0;
                int y = 0;
                int[,] fileItems = new int[3, 3];
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    fileItems[x, y] = int.Parse(line);
                    if (y < 2) { y++; }
                    else { y = 0; x++; }
                }

                if (RushDays == RUSH1)
                {
                    if (SurfaceArea < SIZE_THRESHOLD)
                    {
                        rushCost = fileItems[0, 0];
                    }
                    else if (SurfaceArea <= RUSH_THRESHOLD)
                    {
                        rushCost = fileItems[1, 0];
                    }
                    else
                    {
                        rushCost = fileItems[2, 0];
                    }
                }
                if (RushDays == RUSH2)
                {
                    if (SurfaceArea < SIZE_THRESHOLD)
                    {
                        rushCost = fileItems[0, 1];
                    }
                    else if (SurfaceArea <= RUSH_THRESHOLD)
                    {
                        rushCost = fileItems[1, 1];
                    }
                    else
                    {
                        rushCost = fileItems[2, 1];
                    }
                }
                if (RushDays == RUSH3)
                {
                    if (SurfaceArea < SIZE_THRESHOLD)
                    {
                        rushCost = fileItems[0, 2];
                    }
                    else if (SurfaceArea <= RUSH_THRESHOLD)
                    {
                        rushCost = fileItems[1, 2];
                    }
                    else
                    {
                        rushCost = fileItems[2, 2];
                    }
                }

            }
            catch (Exception ex) { }
            return rushCost; 
        }

        private int RushOrderCost()
        {
            // *** Magic numbers used for costs in this version
            int rushCost = 0;
            if (RushDays == RUSH1)
            {
                if (SurfaceArea < SIZE_THRESHOLD)
                {
                    rushCost = 60;
                }
                else if (SurfaceArea <= RUSH_THRESHOLD)
                {
                    rushCost = 70;
                }
                else
                {
                    rushCost = 80;
                }
            }
            if (RushDays == RUSH2)
            {
                if (SurfaceArea < SIZE_THRESHOLD)
                {
                    rushCost = 40;
                }
                else if (SurfaceArea <= RUSH_THRESHOLD)
                {
                    rushCost = 50;
                }
                else
                {
                    rushCost = 60;
                }
            }
            if (RushDays == RUSH3)
            {
                if (SurfaceArea < SIZE_THRESHOLD)
                {
                    rushCost = 30;
                }
                else if (SurfaceArea <= RUSH_THRESHOLD)
                {
                    rushCost = 30;
                }
                else
                {
                    rushCost = 40;
                }
            }
            return rushCost;
        }
    }
}
