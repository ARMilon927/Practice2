﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorAppPractice2
{
    public partial class CalculatorUi : Form
    {
        public CalculatorUi()
        {
            InitializeComponent();
        }
        Calculator aCalculator = new Calculator();
        private void AddButton_Click(object sender, EventArgs e)
        {
            aCalculator.firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            aCalculator.secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            resultTextBox.Text = aCalculator.Add().ToString();
        }
        private void SubtractButton_Click(object sender, EventArgs e)
        {
            aCalculator.firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            aCalculator.secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            resultTextBox.Text = aCalculator.Subtract().ToString();
        }
        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            aCalculator.firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            aCalculator.secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            resultTextBox.Text = aCalculator.Multiply().ToString();
        }
        private void DivideButton_Click(object sender, EventArgs e)
        {
            aCalculator.firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            aCalculator.secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            resultTextBox.Text = aCalculator.Divide().ToString();
        }
    }
}
