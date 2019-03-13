using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    public partial class MainPage : ContentPage
    {
        public static double grade = 0;
        public static double final = 0;
        public static int unit = 0;
        public static int cp = 0;
        
       


        public MainPage()
        {
            InitializeComponent();

            

            




        }
        public void checkp()
        {
            if(0 != unit)
            {

                txteq.Text += " + ";


            }
            else
            {
                
            }
          


        }
        public void check()
        {
            if (eqC > 0)
            {
                grade = 0;
                final = 0;
                unit = 0;
                txteq.Text = "";
                txteq1.Text = "0.0";
                eqC = 0;
                cp = 0;
            }
        }

        

        private void clrClicked(object sender, EventArgs e)
        {
            grade = 0;
            final = 0;
            unit = 0;
            txteq.Text = "";
            txteq1.Text = "0.0";
            cp = 0;

        }
      

        private void a_Clicked(object sender, EventArgs e)
        {
            
            check();
            checkp();
            txteq.Text += "(A)";
            grade = grade + 12;
            unit++;

        }

        private void bb_Clicked(object sender, EventArgs e)
        {
            
            check();
            checkp();
            txteq.Text += "(B+)";
            grade = grade + 10.5;
            unit++;

        }

        private void b_Clicked(object sender, EventArgs e)
        {
            check();
            checkp();
            txteq.Text += "(B)";
            grade = grade + 9;
            unit++;
            cp++;
        }

        private void cc_Clicked(object sender, EventArgs e)
        {
            check();
            checkp();
            txteq.Text += "(C+)";
            grade = grade + 7.5;
            unit++;
            cp++;
            
        }

        private void c_Clicked(object sender, EventArgs e)
        {
            check();
            checkp();
            txteq.Text += "(C)";
            grade = grade + 6;
            unit++;
            cp++;
           

        }

        private void d_Clicked(object sender, EventArgs e)
        {
            check();
            checkp();
            txteq.Text += "(D)";
            grade = grade + 3;
            unit++;
            cp++;
            

        }

        private void f_Clicked(object sender, EventArgs e)
        {
            check();
            checkp();
            txteq.Text += "(F/FD)";
            grade = grade + 0;
            unit++;
            cp++;
           
        }

        private void eq_Clicked(object sender, EventArgs e)
        {
            unit = unit * 3;
            final = grade / unit;
            txteq1.Text = grade.ToString() + "/" + unit.ToString() + "=" + final.ToString();
            grade = 0;
            final = 0;
            unit = 0;
           
            eqC++;
        }
        int eqC = 0;
       
    }
    
}
