using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //using void with parameters
        //public void myMethod(String names)
        //{
        //    listBox1.Items.Add("My Name Is :" + " " + names);

        //}


        //using return type with parameters
        //public int number(int n1, int n2, int n3)
        //{
        //    int sum = n1 + n2+n3;
        //    return sum;
        

        //}


        //using square
        //public int square(int num)
        //{
        //    int sq = num * num;
        //    return sq;
        //}


        //using maxValue with parameters
       public int maxValue(int n1, int n2, int n3)
        {
            if(n1> n2 && n1 > n3)
            {
                return n1;
            }else if(n2> n1 && n2 > n3)
            {
                return n2;
            }
            else if (n3 > n1 && n3 > n2)
            {
                return n3;
            }
            return 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //using void with parameters
            //myMethod("Ali");
            //myMethod("Mohamed");
            //myMethod("Asha");

            //using return type with parameters
            //int n1 =int.Parse( txtn1.Text);
            //int n2 = int.Parse(txtn2.Text);
            //int n3 = int.Parse(txtn3.Text);
            //listBox1.Items.Add(number(n1, n2, n3));


            //using square
            //int n1 = int.Parse(txtn1.Text);
            //listBox1.Items.Add(square(n1));


            //Using maxValue
            int n1 = int.Parse(txtn1.Text);
            int n2 = int.Parse(txtn2.Text);
            int n3 = int.Parse(txtn3.Text);
            listBox1.Items.Add(maxValue(n1, n2, n3));
            txtn1.Text = "";
            txtn2.Text = "";
            txtn3.Text = "";
        }

    }
}
