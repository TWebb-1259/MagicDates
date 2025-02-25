namespace MagicDates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MagicButton_Click(object sender, EventArgs e)
        {
            int month,
                day, 
                year;

            int.TryParse(MonthTextBox.Text, out month);
            int.TryParse(DayTextBox.Text, out day);
            int.TryParse(YearTextBox.Text, out year);
                        

            if(month > 0 && month < 12)
            {
                if(day > 0 && day < 32)
                {
                    if(year >= 0 && year <= 99)
                    {
                        int sum;

                        sum = month * day;

                        if(sum == year)
                        {
                            MessageDisplay.Text = "The date is magic!";
                        }
                        else
                        {
                            MessageDisplay.Text = "The date is NOT magic!";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Invalid year");
                    }
                }
                else
                {
                    MessageBox.Show("Error: Invalid day");
                }
            }
            else
            {
                MessageBox.Show("Error: Invalid month");
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
