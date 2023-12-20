using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
namespace Auto_Combo_Master_Flex1zy
{
    class Combo
    {
        public  void ComboStart()
        {
            //SETUP
            Click click = new Click();
            Point p = new Point();
            p.X = 100;
            p.Y = 100;  


            //combo
            click.leftClick(p); //click x100 y100 with leftclick
            Thread.Sleep(630); //sleep for game
            click.leftClick(p); //another click
            SendKeys.SendWait("Q");// send q key

        }
    }
}
