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
        double function_lnx_Simpson(double x)
        {
            double Rf = 0;
            double a, b, h, length, derivative;
            double result = 0;
            double now = 0,nowhlf=0;
            int i,n = 1;
            bool rev = false;
            if (x >= 1)//根据x大小判断积分上下限
            {
                a = 1;
                b = x;
                rev = false;
            }
            else 
            {
                a = x;
                b = 1;
                rev = true;
            }
            length = b-a;
            h = length;
            for (; ; )
            {
                h = h / 2;
                n = n * 2;
                if(rev == false) //求四阶导数最大值
                {
                    derivative = 1;
                }
                else
                {
                    derivative = 24/(a * a * a * a * a);
                }


                Rf = length * h * h * h * h * derivative / 2880;//误差项
                if (Rf * 100000000000 < 0.0001)//判断误差项
                    break;
            }

            now = a + h;
            nowhlf = a + h / 2;
            for (i = 1; i < n; i++) //积分
            {
                result = result + h/3 * (1 / now);
                now = now + h;

            }

            for (i = 0; i < n; i++)
            {
                result = result + 2 * h / 3 * (1 / nowhlf);
                nowhlf = nowhlf + h;
            }

                result = result + (1 / a + 1 / b) * h / 6;//累加
                if (rev == false)
                    return result; 
                else
                    return -result;
            


        }


    }
}
