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
        double function_lnx_taylor(double x)  //使用Taylor展开的方式求lnx
        {
            double fx = 0, acum = 1, judge = 10;
            double dx = 0, dy = 0;
            int i, j, sgn, deviation = 0;

            if (x >= 2)  //x必须在2以内方收敛，故需不断除e直至小于2，最后在加上
            {
                for (; ; )
                {
                    x = x / cons_e;
                    deviation++;
                    if (x < 2)
                        break;
                }
            }

            for (i = 1; ; i++)
            {
                acum = 1;
                if (i % 2 == 0) //判断Taylor展开各项正负号
                {
                    sgn = -1;
                }
                else
                {
                    sgn = 1;
                }

                for (j = 0; j < i; j++) //累计各项(x-1)的次数
                {
                    acum = acum * (x - 1);
                }
                dx = acum * sgn / i;//本项
                dy = acum * (x - 1) * (-sgn) / (i + 1);//后一项
                judge = (dx + dy) * 100000000000;//前后项之和满足误差限小数点后14位
                if (judge < 0.001)
                    if (judge > -0.0001)
                        break;
                fx = fx + dx;
            }
            fx = fx + deviation;
            return fx;
        }




        public double function_ex(double x)  //使用Taylor展开方式求e^x，此处代入的x大于0小于1
        {
            double fx = 1, dx = 0, acum = 1, judge = 2;
            int i, j, pow = 1;

            for (i = 1; ; i++)
            {
                acum = 1;
                pow = 1;

                for (j = 0; j < i; j++) //进行泰勒展开
                {
                    acum = acum * x;//累计x的次数
                    pow = pow * (j + 1);//求阶乘
                }
                dx = acum / pow;
                judge = dx * 1000000000000;//在误差限度内
                if (judge < 0.001)
                    break;
                fx = fx + dx;


            }


            return fx;
        }


    }
}
