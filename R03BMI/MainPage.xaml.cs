﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace R03BMI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            creater.Text = "JK3A29 沼下 雅治";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string height = heighit.Text;
            string weight = weighit.Text;
            string output = "";

                double h = double.Parse(height);
                double w = double.Parse(weight);
                if (h >=10){
                    h = h / 100;
                }
                if (w >= 1000){
                    w = w / 1000;
                }
                double bmi = w / (h * h);

            output = "低体重 (痩せ)";
            if(bmi >= 18.5)output = "普通体重";
            if(bmi >= 25)output = "肥満 (1度)";
            if(bmi >= 30)output = "肥満 (2度)";
            if(bmi >= 35)output = "肥満 (3度)";
            if(bmi >= 40)output = "肥満 (4度)";

            double bmi2 = Math.Round(bmi,1);

            result.Text ="BIM:"+bmi2+" "+output;

            }

        }
    }
