using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
    File: CalculatorApp
    Author: Ben Heeley
    CreationDate: 22nd Nov 2018
    Version 1.0 
*/

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int a;
        int b;
        double c;
        double d;

        int answer;
        double answerD;

        bool dataAdd = false;
        bool cleanPress = false;

        int Operation;
        string addition;
        string subtraction;
        string multiply;
        string divide;

        //Adds a 1
        private void button1_Click(object sender, EventArgs e)
        {
            if (cleanPress == true) { Clean(); cleanPress = false; }
            labelViewWindow.Text += (1);
        }
        //Adds a 2
        private void button2_Click(object sender, EventArgs e)
        {
            if (cleanPress == true) { Clean(); cleanPress = false; }
            labelViewWindow.Text += (2);
        }
        //Adds a 3
        private void button3_Click(object sender, EventArgs e)
        {
            if (cleanPress == true) { Clean(); cleanPress = false; }
            labelViewWindow.Text += (3);
        }
        //Adds a 4
        private void button4_Click(object sender, EventArgs e)
        {
            if (cleanPress == true) { Clean(); cleanPress = false; }
            labelViewWindow.Text += (4);
        }
        //Adds a 5
        private void button5_Click(object sender, EventArgs e)
        {
            if (cleanPress == true) { Clean(); cleanPress = false; }
            labelViewWindow.Text += (5);
        }
        //Adds a 6
        private void button6_Click(object sender, EventArgs e)
        {
            if (cleanPress == true) { Clean(); cleanPress = false; }
            labelViewWindow.Text += (6);
        }
        //Adds a 7
        private void button7_Click(object sender, EventArgs e)
        {
            if (cleanPress == true) { Clean(); cleanPress = false; }
            labelViewWindow.Text += (7);
        }
        //Adds a 8
        private void button8_Click(object sender, EventArgs e)
        {
            if (cleanPress == true) { Clean(); cleanPress = false; }
            labelViewWindow.Text += (8);
        }
        //Adds a 9
        private void button9_Click(object sender, EventArgs e)
        {
            if (cleanPress == true) { Clean(); cleanPress = false; }
            labelViewWindow.Text += (9);
        }
        //Adds a 0
        private void button0_Click(object sender, EventArgs e)
        {
            if (cleanPress == true) { Clean(); cleanPress = false; }
            labelViewWindow.Text += (0);
        }

        //Clears the Calculator
        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clean();
        }

        //Adds a Decimal
        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            labelViewWindow.Text += ".";
        }

        //Totals up the numbers and provides an answer to the query
        private void EqualButton_Click(object sender, EventArgs e)
        {

            if (dataAdd==true)
            {
                

                try
                {
                    b = Convert.ToInt32(labelViewWindow.Text);
                }
                catch
                {
                    d = Convert.ToDouble(labelViewWindow.Text);
                }

                switch (Operation)
                {
                    case 1:
                        answer = BasicMath.Arithmetic.Add(a, b);
                        labelViewWindow.Text = Convert.ToString(answer);
                        break;
                    case 2:
                        answer = BasicMath.Arithmetic.Sub(a, b);
                        labelViewWindow.Text = Convert.ToString(answer);
                        break;
                    case 3:
                        answerD = BasicMath.Arithmetic.Div(a, b);
                        labelViewWindow.Text = Convert.ToString(answer);
                        break;
                    case 4:
                        answer = BasicMath.Arithmetic.Mult(a, b);
                        labelViewWindow.Text = Convert.ToString(answer);
                        break;
                    default:
                        break;
                    case 5:
                        d = Convert.ToDouble(b);
                        answerD = BasicMath.Doubles.Add(c, d);
                        labelViewWindow.Text = Convert.ToString(answerD);
                        break;
                    case 6:
                        d = Convert.ToDouble(b);
                        answerD = BasicMath.Doubles.Sub(c, d);
                        labelViewWindow.Text = Convert.ToString(answerD);
                        break;
                    case 7:
                        d = Convert.ToDouble(b);
                        answerD = BasicMath.Doubles.Div(c, d);
                        labelViewWindow.Text = Convert.ToString(answerD);
                        break;
                    case 8:
                        d = Convert.ToDouble(b);
                        answerD = BasicMath.Doubles.Mult(c, d);
                        labelViewWindow.Text = Convert.ToString(answerD);
                        break;
                }
                dataAdd = false;
                cleanPress = true;
            }
            
        }

        //Slots the number currently in the screen and prepares to add the Next int
        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToInt32(labelViewWindow.Text);
                Operation = 1;
                dataAdd = true;
                Clean();
            }
            catch
            {
                c = Convert.ToDouble(labelViewWindow.Text);
                Operation = 5;
                dataAdd = true;
                Clean();
            }
        }

        //Cleans the screen
        void Clean()
        {
            labelViewWindow.Text = "";
        }

        //Slots the number currently in the screen and prepares to Subtract the Next int
        private void SubtractButton_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToInt32(labelViewWindow.Text);
                Operation = 2;
                dataAdd = true;
                Clean();
            }
            catch
            {
                c = Convert.ToDouble(labelViewWindow.Text);
                Operation = 6;
                dataAdd = true;
                Clean();
            }
        }
        //Slots the number currently in the screen and prepares to Divide the Next int
        private void DivideButton_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToInt32(labelViewWindow.Text);
                Operation = 3;
                dataAdd = true;
                Clean();
            }
            catch
            {
                c = Convert.ToDouble(labelViewWindow.Text);
                Operation = 7;
                dataAdd = true;
                Clean();
            }
        }
        //Slots the number currently in the screen and prepares to multiply the Next int
        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToInt32(labelViewWindow.Text);
                Operation = 4;
                dataAdd = true;
                Clean();
            }
            catch
            {
                c = Convert.ToDouble(labelViewWindow.Text);
                Operation = 8;
                dataAdd = true;
                Clean();
            }
        }
        //Squares the current screen value
        private void SqrButton_Click(object sender, EventArgs e)
        {
            try
            {
                answerD = MathAlgebraic.Class1.Square(Convert.ToDouble(labelViewWindow.Text));
                labelViewWindow.Text = Convert.ToString(answerD);
                answerD = 0;
                cleanPress = true;
            }
            catch
            {
                labelViewWindow.Text = "INVALID";
                cleanPress = true;
            }
        }
        //Cubes the current screen value
        private void CubeButton_Click(object sender, EventArgs e)
        {
            try
            {
                answerD = MathAlgebraic.Class1.Cube(Convert.ToDouble(labelViewWindow.Text));
                labelViewWindow.Text = Convert.ToString(answerD);
                answerD = 0;
                cleanPress = true;
            }
            catch
            {
                labelViewWindow.Text = "INVALID";
                cleanPress = true;
            }
        }
        //Turns a Negative into a positive or a positive into a negative
        private void InverseButton_Click(object sender, EventArgs e)
        {
            try
            {
                answerD = MathAlgebraic.Class1.Inverse(Convert.ToDouble(labelViewWindow.Text));
                labelViewWindow.Text = Convert.ToString(answerD);
                answerD = 0;
            }
            catch
            {
                labelViewWindow.Text = "INVALID";
                cleanPress = true;
            }
        }
        //Provides the Sine equation for the degress given
        private void SineButton_Click(object sender, EventArgs e)
        {
            try
            {
                answerD = MathTrigonometric.Class1.Sin(Convert.ToDouble(labelViewWindow.Text));
                labelViewWindow.Text = Convert.ToString(answerD);
                answerD = 0;
                cleanPress = true;
            }
            catch
            {
                labelViewWindow.Text = "INVALID";
                cleanPress = true;
            }
        }
        //Provides the CoSine equation for the degress given
        private void CosineButton_Click(object sender, EventArgs e)
        {
            try
            {
                answerD = MathTrigonometric.Class1.Cos(Convert.ToDouble(labelViewWindow.Text));
                labelViewWindow.Text = Convert.ToString(answerD);
                answerD = 0;
                cleanPress = true;
            }
            catch
            {
                labelViewWindow.Text = "INVALID";
                cleanPress = true;
            }
        }
        //Provides the Tangent equation for the degress given
        private void TangentButton_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(labelViewWindow.Text) == 90)
            {
                labelViewWindow.Text = "INVALID";
            }
            try
            {
                answerD = MathTrigonometric.Class1.Tan(Convert.ToDouble(labelViewWindow.Text));
                labelViewWindow.Text = Convert.ToString(answerD);
                answerD = 0;
                cleanPress = true;
            }
            catch
            {
                labelViewWindow.Text = "INVALID";
                cleanPress = true;
            }
        }
    }
}
