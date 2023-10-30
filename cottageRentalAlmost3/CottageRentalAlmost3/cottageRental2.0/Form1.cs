namespace cottageRental2._0
{
    public partial class CottageRental : Form
    {

        const decimal PROPERTYCOST1 = 150m;
        const decimal PROPERTYCOST2 = 250m;
        const decimal PROPERTYCOST3 = 165m;
        const decimal PROPERTYCOST4 = 350m;
        const decimal PROPERTYCOST5 = 220m;
        const decimal PROPERTYCOST6 = 300m;
        const decimal SERVICEFEE = 50m;
        const decimal CLEANINGFEE = 20m;
        const decimal PROPERTYTAX = 0.07m;

        const string property1 = "$150 / per night";
        const string property2 = "$250 / per night";
        const string property3 = "$165 / per night";
        const string property4 = "$350 / per night";
        const string property5 = "$220 / per night";
        const string property6 = "$300 / per night";

        string msgcap = "Cottage Rental";

       





        public CottageRental()
        {
            InitializeComponent();
        }

        private void getinfo()
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            propertyname.Text = "Beachhouse property";
            propertyprice.Text = "$150 / per night";
            Amenities1.Text = "Free Wifi";
            Amenities2.Text = "A/C";
            Amenities3.Text = "Pet friendly";
            Amenities4.Text = "TV";
            Amenities5.Text = "Heater";
            Amenities6.Text = "Washer / Dryer";
            numbedrooms.Text = "1 Bedroom | 1 Bathroom |  Kitchen | Lawn/ Garden" ;
            travelers1.Minimum = 1;
            travelers1.Maximum = 2;
            

            pictureBox8.Image = Properties.Resources.property_01_1;
            pictureBox9.Image = Properties.Resources.property_01_2;
            pictureBox10.Image = Properties.Resources.property_01_3;
            pictureBox11.Image = Properties.Resources.internet;
            pictureBox12.Image = Properties.Resources.air_conditioner; 
            pictureBox13.Image = Properties.Resources.petfriendly;
            pictureBox14.Image = Properties.Resources.tevlevision;
            pictureBox15.Image = Properties.Resources.heater;
            pictureBox16.Image = Properties.Resources.washerdryer;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            propertyname.Text = "Harrison Creek Cottage";
            propertyprice.Text = "$250 / per night";
            numbedrooms.Text = "3 Bedrooms |    3 Baths |    Kitchen |    Garden view";
            Amenities1.Text = "Wifi";
            Amenities2.Text = " TV ";
            Amenities3.Text = "Free parking";
            Amenities4.Text = "Beach access";
            Amenities5.Text = "Hot Tub";
            Amenities6.Text = "Pet Friendly";
            travelers1.Minimum = 1;
            travelers1.Maximum = 6;

            pictureBox11.Image = Properties.Resources.internet;
            pictureBox12.Image = Properties.Resources.tevlevision;
            pictureBox13.Image = Properties.Resources.freeparking;
            pictureBox14.Image = Properties.Resources.beachaccess;
            pictureBox15.Image = Properties.Resources.hottub;
            pictureBox16.Image = Properties.Resources.petfriendly;



            pictureBox8.Image = Properties.Resources.property_2_2;
            pictureBox9.Image = Properties.Resources.property_2_3;
            pictureBox10.Image = Properties.Resources.property_2_4;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            propertyprice.Text = "$165 / per night";
            propertyname.Text = "Mountain Treehouse";
            numbedrooms.Text = "2 Bedrooms |    2 Baths |   Kitchen ";
            Amenities1.Text = "Internet";
            Amenities2.Text = "TV";
            Amenities3.Text = "Washer";
            Amenities4.Text = "A/C";
            Amenities5.Text = "Fire Place";
            Amenities6.Text = "No Smoking";
            travelers1.Minimum = 1;
            travelers1.Maximum = 2;

            pictureBox11.Image = Properties.Resources.internet;
            pictureBox12.Image = Properties.Resources.tevlevision;
            pictureBox13.Image = Properties.Resources.washerdryer;
            pictureBox14.Image = Properties.Resources.air_conditioner;
            pictureBox15.Image = Properties.Resources.fireplace;
            pictureBox16.Image = Properties.Resources.nosmoking;


            pictureBox8.Image = Properties.Resources.property31;
            pictureBox9.Image = Properties.Resources.property32;
            pictureBox10.Image = Properties.Resources.property33;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            propertyprice.Text = "$350 / per night";
            propertyname.Text = "Tuscan Getaway";
            numbedrooms.Text = "1 Bedroom |  1 Bath |  Kitchen |  Vinyaerd Views";
            Amenities1.Text = "Internet";
            Amenities2.Text = "TV";
            Amenities3.Text = "A/C";
            Amenities4.Text = "Outdoor Dinning";
            Amenities5.Text = "Free Parking";
            Amenities6.Text = "No Pets Allowed";
            travelers1.Minimum = 1;
            travelers1.Maximum = 2;
            pictureBox11.Image = Properties.Resources.internet;
            pictureBox12.Image = Properties.Resources.tevlevision;
            pictureBox13.Image = Properties.Resources.air_conditioner;
            pictureBox14.Image = Properties.Resources.outdoordinning;
            pictureBox15.Image = Properties.Resources.freeparking;
            pictureBox16.Image = Properties.Resources.nopetsallowed;


            pictureBox8.Image = Properties.Resources.property41;
            pictureBox9.Image = Properties.Resources.property42;
            pictureBox10.Image = Properties.Resources.property43;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            propertyprice.Text = "$220 / per night";
            propertyname.Text = "Luxury cottage by the sea";
            numbedrooms.Text = "2 Bedroom |   1 Bath |   Kitchen |   Sea Views";
            Amenities1.Text = "Free Wifi";
            Amenities2.Text = "TV";
            Amenities3.Text = "A/C";
            Amenities4.Text = "Outdoor Space";
            Amenities5.Text = "Dining";
            Amenities6.Text = "Pets Allowed";
            travelers1.Minimum = 1;
            travelers1.Maximum = 4;
            pictureBox11.Image = Properties.Resources.internet;
            pictureBox12.Image = Properties.Resources.tevlevision;
            pictureBox13.Image = Properties.Resources.air_conditioner;
            pictureBox14.Image = Properties.Resources.beachaccess;
            pictureBox15.Image = Properties.Resources.outdoordinning;
            pictureBox16.Image = Properties.Resources.petfriendly;


            pictureBox8.Image = Properties.Resources.property51;
            pictureBox9.Image = Properties.Resources.property52;
            pictureBox10.Image = Properties.Resources.property_5_updated_3;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            propertyprice.Text = "$300 / per night";
            propertyname.Text = "Adirondack Lake Hilltop Lodge";
            numbedrooms.Text = "4 Bedroom |   4 Bath |   Kitchen |   Deck/Patio";
            Amenities1.Text = "Internet";
            Amenities2.Text = "TV";
            Amenities3.Text = "A/C";
            Amenities4.Text = "Hot Tub";
            Amenities5.Text = "Fire Place";
            Amenities6.Text = "Washer/ Dryer";
            travelers1.Minimum = 1;
            travelers1.Maximum = 6;

            pictureBox11.Image = Properties.Resources.internet;
            pictureBox12.Image = Properties.Resources.tevlevision;
            pictureBox13.Image = Properties.Resources.air_conditioner;
            pictureBox14.Image = Properties.Resources.hottub;
            pictureBox15.Image = Properties.Resources.fireplace;
            pictureBox16.Image = Properties.Resources.washerdryer;


            pictureBox8.Image = Properties.Resources.Property_6_updated_1;
            pictureBox9.Image = Properties.Resources.Property_6_updated_2;
            pictureBox10.Image = Properties.Resources.Property_6_updated_3;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }



        private void buttoncheckdate1_Click(object sender, EventArgs e)
        {
            DateTime StartDate = dateTimePicker11.Value;
            DateTime EndDate = dateTimePicker12.Value;

            if (StartDate >= EndDate)
            {
                MessageBox.Show(" Start date must be before the end date ");
                return;

            }
            else
            {
                booknow1.Visible = true;
                Resetdate1.Visible = true;
                dateTimePicker11.Enabled = false;
                dateTimePicker12.Enabled = false;

            }

            int NumDays = 0;
            NumDays = (EndDate - StartDate).Days;
            if (propertyprice.Text == property1)
            {
               
                decimal price = 0;
                price = PROPERTYCOST1 * NumDays;
                priceoutput1.Text = price.ToString("c2");

            }
            else if (propertyprice.Text == property2)
            {
                decimal price2 = 0;
                price2 = PROPERTYCOST2 * NumDays;
                priceoutput1.Text = price2.ToString("c2");
            }
            else if (propertyprice.Text == property3)
            {
                decimal price3 = 0;
                price3 = PROPERTYCOST3 * NumDays;
                priceoutput1.Text = price3.ToString("c2");
            }
            else if (propertyprice.Text == property4)
            {
                decimal price4 = 0;
                price4 = PROPERTYCOST4 * NumDays;
                priceoutput1.Text = price4.ToString("c2");
            }
            else if (propertyprice.Text == property5)
            {
                decimal price4 = 0;
                price4 = PROPERTYCOST5 * NumDays;
                priceoutput1.Text = price4.ToString("c2");
            }
            else if (propertyprice.Text == property6)
            {
                decimal price6 = 0;
                price6 = PROPERTYCOST6 * NumDays;
                priceoutput1.Text = price6.ToString("c2");
            }



        }

        private void Resetdate1_Click(object sender, EventArgs e)
        {
            dateTimePicker11.Enabled = true;
            dateTimePicker12.Enabled = true;
            booknow1.Visible = false;
            Resetdate1.Visible = false;
            priceoutput1.Text = "";
        }

        private void booknow1_Click(object sender, EventArgs e)
        {


            if (propertyprice.Text == property1)
            {

                DateTime StartDate = dateTimePicker11.Value;
                DateTime EndDate = dateTimePicker12.Value;
                int NumDays = 0;
                decimal price = 0;

                NumDays = (EndDate - StartDate).Days;
                price = PROPERTYCOST1 * NumDays;
                priceoutput1.Text = price.ToString("c2");
                tabControl1.SelectedIndex = 3;
                labeldisplayprice.Text = "Price per night x  day";
                outputservice.Text = "$50";
                outputcleaning.Text = "$20";
                decimal taxes = PROPERTYCOST1 * PROPERTYTAX;
                outputtax.Text = taxes.ToString("c2");
                outputdays.Text = price.ToString("c2");

                //decimal taxes = PROPERTYCOST1 * PROPERTYTAX;
                decimal truetotal = price + SERVICEFEE + CLEANINGFEE + taxes;
                outputtotal.Text = truetotal.ToString("c2");


            }
            else if (propertyprice.Text == property2)
            {

                DateTime StartDate = dateTimePicker11.Value;
                DateTime EndDate = dateTimePicker12.Value;
                int NumDays = 0;
                decimal price2 = 0;

                NumDays = (EndDate - StartDate).Days;
                price2 = PROPERTYCOST2 * NumDays;
                priceoutput1.Text = price2.ToString("c2");
                tabControl1.SelectedIndex = 3;
                labeldisplayprice.Text = "Price per night x  day";
                outputservice.Text = "$50";
                outputcleaning.Text = "$20";
                decimal taxes2 = PROPERTYCOST2 * PROPERTYTAX;
                outputtax.Text = taxes2.ToString("c2");
                outputdays.Text = price2.ToString("c2");

                //decimal taxes2 = PROPERTYCOST2 * PROPERTYTAX;
                decimal truetotal2 = price2 + SERVICEFEE + CLEANINGFEE + taxes2;
                outputtotal.Text = truetotal2.ToString("c2");


            }
            else if (propertyprice.Text == property3)
            {
                DateTime StartDate = dateTimePicker11.Value;
                DateTime EndDate = dateTimePicker12.Value;
                int NumDays = 0;
                decimal price = 0;

                NumDays = (EndDate - StartDate).Days;
                price = PROPERTYCOST3 * NumDays;
                priceoutput1.Text = price.ToString("c2");
                tabControl1.SelectedIndex = 3;
                labeldisplayprice.Text = "Price per night x  day";
                outputservice.Text = "$50";
                outputcleaning.Text = "$20";
                decimal taxes3 = PROPERTYCOST3 * PROPERTYTAX;
                outputtax.Text = taxes3.ToString("c2");
                outputdays.Text = price.ToString("c2");

                //decimal taxes = PROPERTYCOST3 * PROPERTYTAX;
                decimal truetotal = price + SERVICEFEE + CLEANINGFEE + taxes3;
                outputtotal.Text = truetotal.ToString("c2");

            }
            else if (propertyprice.Text == property4)
            {

                DateTime StartDate = dateTimePicker11.Value;
                DateTime EndDate = dateTimePicker12.Value;
                int NumDays = 0;
                decimal price = 0;

                NumDays = (EndDate - StartDate).Days;
                price = PROPERTYCOST4 * NumDays;
                priceoutput1.Text = price.ToString("c2");
                tabControl1.SelectedIndex = 3;
                outputservice.Text = "$50";
                outputcleaning.Text = "$20";
                decimal taxes = PROPERTYCOST4 * PROPERTYTAX;
                outputtax.Text = taxes.ToString("c2");
                outputdays.Text = price.ToString("c2");

                //decimal taxes = PROPERTYCOST4 * PROPERTYTAX;
                decimal truetotal = price + SERVICEFEE + CLEANINGFEE + taxes;
                outputtotal.Text = truetotal.ToString("c2");

            }
            else if (propertyprice.Text == property5)
            {
                DateTime StartDate = dateTimePicker11.Value;
                DateTime EndDate = dateTimePicker12.Value;
                int NumDays = 0;
                decimal price = 0;

                NumDays = (EndDate - StartDate).Days;
                price = PROPERTYCOST5 * NumDays;
                priceoutput1.Text = price.ToString("c2");
                tabControl1.SelectedIndex = 3;
                //labeldisplayprice.Text = "Price per night x  day";
                outputservice.Text = "$50";
                outputcleaning.Text = "$20";
                decimal taxes = PROPERTYCOST5 * PROPERTYTAX;
                outputtax.Text = taxes.ToString("c2");
                outputdays.Text = price.ToString("c2");

                //decimal taxes = PROPERTYCOST5 * PROPERTYTAX;
                decimal truetotal = price + SERVICEFEE + CLEANINGFEE + taxes;
                outputtotal.Text = truetotal.ToString("c2");
            }
            else if (propertyprice.Text == property6)
            {
                DateTime StartDate = dateTimePicker11.Value;
                DateTime EndDate = dateTimePicker12.Value;
                int NumDays = 0;
                decimal price = 0;

                NumDays = (EndDate - StartDate).Days;
                price = PROPERTYCOST6 * NumDays;
                priceoutput1.Text = price.ToString("c2");
                tabControl1.SelectedIndex = 3;
                labeldisplayprice.Text = "Price per night x  day";
                outputservice.Text = "$50";
                outputcleaning.Text = "$20";
                decimal taxes = PROPERTYCOST6 * PROPERTYTAX;
                outputtax.Text = taxes.ToString("c2");
                outputdays.Text = price.ToString("c2");

                //decimal taxes = PROPERTYCOST6 * PROPERTYTAX;
                decimal truetotal = price + SERVICEFEE + CLEANINGFEE + taxes;
                outputtotal.Text = truetotal.ToString("c2");
            }






        }

        private void labeldisplayprice_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            //tabControl1.SelectedIndex = 1;
            dateTimePicker11.Enabled = true;
            dateTimePicker12.Enabled = true;
            booknow1.Visible = false;
            Resetdate1.Visible = false;
            priceoutput1.Text = "";

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void buttongoback2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            //tabControl1.SelectedIndex = 1;
            dateTimePicker11.Enabled = true;
            dateTimePicker12.Enabled = true;
            booknow1.Visible = false;
            Resetdate1.Visible = false;
            priceoutput1.Text = "";

        }

        private void buttonconfirm_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;


        }

        private void button8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
           

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == string.Empty)
            {
                MessageBox.Show("Please make sure all textbox are filled", msgcap, MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            else if (maskedTextBox2.Text == string.Empty)
            {
                MessageBox.Show("Please make sure all textbox are filled", msgcap, MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            else if (maskedTextBox3.Text == string.Empty)
            {
                MessageBox.Show("Please make sure all textbox are filled", msgcap, MessageBoxButtons.OK, MessageBoxIcon.Error); return;

            }
            else if (maskedTextBox4.Text == string.Empty)
            {
                MessageBox.Show("Please make sure all textbox are filled", msgcap, MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            else if (maskedTextBox5.Text == string.Empty)
            {
                MessageBox.Show("Please make sure all textbox are filled", msgcap, MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }

            if (radioButton1.Checked || radioButton2.Checked)
            {

            }

            else
            {
                MessageBox.Show("Please choose debit or credit", msgcap, MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }

            

            DateTime StartDate = dateTimePicker11.Value;
            DateTime EndDate = dateTimePicker12.Value.Date;
            int NumDays = 0;
            decimal traveleres = travelers1.Value;
            NumDays = (EndDate - StartDate).Days;
            

            DialogResult Processpayment; 
            Processpayment = MessageBox.Show("Are you sure you want to process your Payment information", msgcap, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Processpayment == DialogResult.Yes)

            {
                DialogResult confirmation;
                confirmation =  MessageBox.Show("Congratulations" + " " + FirstName.Text + " you will be staying with us for " + NumDays + " Day(s). " + "\n\n" + " You will be traveling with " + traveleres + " traveler(s). " +
                   "\n\n" + " Your check in date is " + StartDate.ToString("d") + " and " + " check out date is " + EndDate.ToString("d") + ".",msgcap,MessageBoxButtons.OK,MessageBoxIcon.Information);

                DialogResult doyouwanttorentagain;
                doyouwanttorentagain = MessageBox.Show(" Do you want to book another property ? ", msgcap, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

                if (doyouwanttorentagain == DialogResult.Yes)
                {
                    tabControl1.SelectedIndex = 1;
                    dateTimePicker11.Enabled = true;
                    dateTimePicker12.Enabled = true;
                    booknow1.Visible = false;
                    Resetdate1.Visible = false;
                    priceoutput1.Text = "";

                }

                else
                {

                    this.Close();
                }


            }

            else 
            { }

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {   
        
        }
    }
}