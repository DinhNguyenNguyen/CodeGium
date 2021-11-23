using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListFood
{
    class Nudge
    {
        private Label tmpFrm;
        int xCoord = 0, yCoord = 0;
       
        public Nudge(Label theForm)
        {
            this.tmpFrm = theForm;
            xCoord = this.tmpFrm.Left;
            yCoord = this.tmpFrm.Top;
        }
        public void NudgeMe()
        {
            
           
            Task.Factory.StartNew(() =>
            {
             
                int rnd = 0;
                Random RandomClass = new Random();
                for (int i = 0; i <= 20; i++)
                {
                    rnd = RandomClass.Next(xCoord + 1, xCoord + 15);
                    tmpFrm.BeginInvoke(new Action(() =>
                    {
                        this.tmpFrm.Left = rnd + xCoord - 65;
                    }));
                    rnd = RandomClass.Next(yCoord + 1, yCoord + 15);
                    tmpFrm.BeginInvoke(new Action(() =>
                    {
                        this.tmpFrm.Top = rnd + yCoord - 25;
                    }));
                    Thread.Sleep(5);
                 
                }

                tmpFrm.BeginInvoke(new Action(() =>
                {
                    this.tmpFrm.Left = xCoord;
                    this.tmpFrm.Top = yCoord;
                }));
                

            });


        }
    }
}
