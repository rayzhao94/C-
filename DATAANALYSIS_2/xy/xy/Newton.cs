using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;

namespace x_y
{
    partial class Form1
    {
        double function_lnx_Newton(double x)
        {
            double delta = 1;
            double step = x,step_former ;
            int deviation = 0;

            if (x > cons_e)  //x>e时则除e，为使其在区间（1，e）内
            {
                for (; ; )
                {
                    x = x / cons_e;
                    deviation++;
                    if (x <= cons_e)
                        break;
                }
            }
            else
                if (x < 1)//x<1时乘e，为使其在区间（1，e）内
                {

                    for (; ; )
                    {
                        x = x * cons_e;
                        deviation --;
                        if (x  > 1)
                            break;
                    }
                }

            step_former = x;
            for (; ; )
            {
                step = step_former - 1 + x / function_ex(step_former);//带入牛顿迭代公式
                //step = step_former - 1 + step_former / Math.Exp(step_former);
                delta = Math.Abs(step - step_former);//前后项差在给定范围内
                if (delta * 10000000000 < 0.001)
                {
                    
                    break;
                }
                step_former = step;
            }
            return step + deviation ;

        }


    }
}
