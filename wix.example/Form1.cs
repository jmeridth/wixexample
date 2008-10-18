using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using wix.example.exception;
using wix.example.service;

namespace wix.example
{
    public partial class Form1 : Form
    {
        private AgeCalculator ageCalculator;

        public Form1()
        {
            InitializeComponent();
            dtpBirthday.MaxDate = DateTime.Now;
        }

        private void btnCalculateAge_Click(object sender, EventArgs e)
        {
            ageCalculator = new AgeCalculator(dtpBirthday.Value);
            lblAge.Visible = true;
            try
            {
                lblAge.Text = ageCalculator.RenderAge() + " y.o.";    
            }
            catch(InvalidBirthdayException ibe)
            {
                lblAge.Text = "Date invalid"; 
            }
            
        }
    }
}
