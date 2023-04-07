// Program 2
// CIS 199-03
// Due by: 3/11/22
// Written by: S2210

// This program calculates the cost of a hotel stay based on user inputed
// data for the number of guests, number of nights, and hotel star rating.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public partial class HotelForm : Form
    {
        public HotelForm()
        {
            InitializeComponent();
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            int numGuests;                      // number of guests on reservation
            int numNights;                      // number of nights of reservation
            const int MIN_GUESTS = 1;           // minimum number of guests allowed per room
            const int MAX_GUESTS = 7;           // maximum number of guests allowed per room
            const int MIN_NIGHTS = 1;           // minimum number of night reservation required
            const int NIGHTS_THRESHOLD1 = 7;    // threshold to reduce per night cost
            const int NIGHTS_THRESHOLD2 = 31;   // threshold to reduce per night cost
            const double GUEST_FEE1 = 100;      // guest fee for 1 guest per room
            const double GUEST_FEE2 = 150;      // guest fee for 2 guests per room
            const double GUEST_FEE3 = 250;      // guest fee for 3 guests per room
            const double GUEST_FEE4 = 400;      // guest fee for 4-7 guests per room
            const double NIGHT_FEE1 = 100;      // night fee for stays of 1-6 nights
            const double NIGHT_FEE2 = 75;       // night fee for stays of 7-30 nights
            const double NIGHT_FEE3 = 25;       // night fee for stays of 31+ nights
            const double STAR_FACTOR1 = 1.0;    // multiple for hotel star rating of 1
            const double STAR_FACTOR2 = 1.5;    // multiple for hotel star rating of 2
            const double STAR_FACTOR3 = 2.5;    // multiple for hotel star rating of 3
            const double STAR_FACTOR4 = 3.0;    // multiple for hotel star rating of 4
            const double STAR_FACTOR5 = 4.0;    // multiple for hotel star rating of 5
            double guestFee;                    // fee related to number of guests
            double nightFee;                    // fee related to number of night stay
            double starFactor;                  // fee multiple related to hotel star rating
            double totalCost;                   // total cost of stay

            // validate user input for number of guests
            if (int.TryParse(guestsTxt.Text, out numGuests) && numGuests >= MIN_GUESTS && numGuests <= MAX_GUESTS)
            {
                // validate user input for number of nights
                if (int.TryParse(nightsTxt.Text, out numNights) && numNights >= MIN_NIGHTS)
                {
                    // validate user input for number of hotel star rating
                    if (starsCombo.SelectedIndex >= 0)
                    {
                        // determine the value of the star factor
                        if (int.Parse(starsCombo.Text) == 1)
                            starFactor = STAR_FACTOR1;
                        else if (int.Parse(starsCombo.Text) == 2)
                            starFactor = STAR_FACTOR2;
                        else if (int.Parse(starsCombo.Text) == 3)
                            starFactor = STAR_FACTOR3;
                        else if (int.Parse(starsCombo.Text) == 4)
                            starFactor = STAR_FACTOR4;
                        else
                            starFactor = STAR_FACTOR5;

                        // determine the guest fee
                        if (numGuests == MIN_GUESTS)
                            guestFee = GUEST_FEE1;
                        else if (numGuests == 2)
                            guestFee = GUEST_FEE2;
                        else if (numGuests == 3)
                            guestFee = GUEST_FEE3;
                        else
                            guestFee = GUEST_FEE4;

                        // determine the night fee
                        if (numNights < NIGHTS_THRESHOLD1)
                            nightFee = NIGHT_FEE1;
                        else if (numNights < NIGHTS_THRESHOLD2)
                            nightFee = NIGHT_FEE2;
                        else
                            nightFee = NIGHT_FEE3;

                        // calculate the total cost and display the results
                        totalCost = (guestFee + (numNights * nightFee)) * starFactor;
                        costOutputLbl.Text = $"{totalCost:C}";
                    }
                    // reponse for invalid star rating selection
                    else
                        MessageBox.Show($"Invalid input. Select the number of hotel stars.");
                }
                // reponse for invalid number of nights input
                else
                    MessageBox.Show($"Invalid input. Enter the number of nights: {MIN_NIGHTS}+.");
            }
            // reponse for invalid number of guests input
            else
                MessageBox.Show($"Invalid input. Enter the number of guests from {MIN_GUESTS}-{MAX_GUESTS}.");
        }
    }
}
