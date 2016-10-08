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
    public partial class Form1 : Form
    {
        double x_in, y_in;
        double lnx_out, ex_out;
        static double cons_e = 2.718281828459045235360287471352662497757247093;
        string out_str;
        public Form1()
        {
            InitializeComponent();
        }

        



        private void button1_Click(object sender, EventArgs e)
        {
            x_in = Convert.ToDouble(textBox_X.Text);//取x
            y_in = Convert.ToDouble(textBox_Y.Text);//取y
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (radioButton_Taylor.Checked)
            {
                int i,roundln;
                int n = (int)Math.Floor(y_in);
                double temp = 1;
                double carrier, roundex = 1.0;
                double test,delta;
                string testans;
                if(n >0)
                { 
                     for (i = 0; i < n;i ++ )//先乘x的整数次幂
                     {
                         temp = temp * x_in;
                     }
                }

                lnx_out = function_lnx_taylor(x_in);//求剩余x（小数部分）的ln值
                carrier = (y_in - n) * lnx_out;//e的指数部分


                roundln = (int)Math.Floor(carrier);//e指数部分取整
                if (roundln > 0)//e的次幂计算
                {
                    for (i = 0; i < roundln; i++)
                    {
                        roundex = roundex * cons_e;
                    }
                }
                else
                    if (roundln < 0)//小于0则除e
                    {
                        for (i = 0; i < (-roundln); i++)
                        {
                            roundex = roundex / cons_e;
                        }
                    }
                    else
                    {
                        roundex = 1;
                    }

                ex_out = function_ex(carrier - roundln);//剩余部分的exp值
                ex_out = ex_out * temp * roundex;//结果

                //out_str = Console.WriteLine(ex_out.ToString("G10"));

                out_str = ex_out.ToString("G10");//取10位有效数字
                textBox_answer.Text = out_str;

                //test = Math.Pow(x_in, y_in);
                //delta = test - ex_out;
                //testans = delta.ToString();
                //textBox_test.Text = testans;
            }
            else
                if (radioButton_Simpson.Checked)
                {
                    int i, roundln;
                    int n = (int)Math.Floor(y_in);
                    double temp = 1;
                    double carrier, roundex = 1.0;
                    double test, delta;
                    string testans;
                    if (n > 0)
                    {
                        for (i = 0; i < n; i++)//先乘x的整数次幂
                        {
                            temp = temp * x_in;
                        }
                    }

                    lnx_out = function_lnx_Simpson(x_in);//求剩余x（小数部分）的ln值
                    carrier = (y_in - n) * lnx_out;//e的指数部分
                    roundln = (int)Math.Floor(carrier);//e指数部分取整
                    
                    if (roundln > 0) //e的次幂计算
                    {
                        for (i = 0; i < roundln; i++)
                        {
                            roundex = roundex * cons_e;
                        }
                    }
                    else
                        if (roundln < 0)//小于0则除e
                        {
                            for (i = 0; i < (-roundln); i++)
                            {
                                roundex = roundex / cons_e;
                            }
                        }
                        else
                        {
                            roundex = 1;
                        }

                    ex_out = function_ex(carrier - roundln);//剩余部分的exp值
                    ex_out = ex_out * temp * roundex;//结果

                    //out_str = Console.WriteLine(ex_out.ToString("G10"));

                    out_str = ex_out.ToString("G10");//取10位有效数字
                    textBox_answer.Text = out_str;

                    //test = Math.Pow(x_in, y_in);
                    //delta = test - ex_out;
                    //testans = delta.ToString();
                    //textBox_test.Text = testans;
                }
                else
                    if (radioButton_Newton.Checked)
                    {
                        int i, roundln;
                        int n = (int)Math.Floor(y_in);
                        double temp = 1;
                        double carrier, roundex = 1.0;
                        double test, delta;
                        string testans;
                        if (n > 0)
                        {
                            for (i = 0; i < n; i++)//先乘x的整数次幂
                            {
                                temp = temp * x_in;
                            }
                        }

                        lnx_out = function_lnx_Newton(x_in);//求剩余x（小数部分）的ln值
                        carrier = (y_in - n) * lnx_out;//e的指数部分
                        roundln = (int)Math.Floor(carrier);//e指数部分取整

                        if (roundln > 0) //e的次幂计算
                        {
                            for (i = 0; i < roundln; i++)
                            {
                                roundex = roundex * cons_e;
                            }
                        }
                        else
                            if (roundln < 0)//小于0则除e
                            {
                                for (i = 0; i < (-roundln); i++)
                                {
                                    roundex = roundex / cons_e;
                                }
                            }
                            else
                            {
                                roundex = 1;
                            }

                        ex_out = function_ex(carrier - roundln);//剩余部分的exp值
                        ex_out = ex_out * temp * roundex;//结果

                        //out_str = Console.WriteLine(ex_out.ToString("G10"));

                        out_str = ex_out.ToString("G10");//取10位有效数字
                        textBox_answer.Text = out_str;

                        //test = Math.Pow(x_in, y_in);
                        //delta = test - ex_out;
                        //testans = delta.ToString();
                        //textBox_test.Text = testans;
                    }








        }
    }
}
