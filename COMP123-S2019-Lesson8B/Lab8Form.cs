using System;
using System.Windows.Forms;

namespace COMP123_S2019_Lesson8B
{
    public partial class Lab8Form : Form
    {
        //Class Properties
        public string UserName { get; set; }
        public float UserAge { get; set; }

        /// <summary>
        /// This is the event handler for the Lab08Form Load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lab8Form_Load(object sender, EventArgs e)
        {
            ClearForm();
        }

        /// <summary>  
        /// this is the Constructor for Lab08Form
        /// /// </summary>
        public Lab8Form()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// This is the event handler for the submit button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            UserName = NameLabel.Text;
            UserAge = float.Parse(AgeTextBox.Text);

            OutputLabel.Text = NameTextBox.Text + " " + AgeTextBox.Text;
            ClearForm();

            // NameTextBox.Text = string.Empty; //option B
        }

        /// <summary>
        /// This method clears the text box
        /// </summary>
        private void ClearForm()
        {
            NameTextBox.Clear();
            AgeTextBox.Clear();
            SubmitButton.Enabled = false;
        }

        /// <summary>
        /// This is the event handler for the AgeTextBox TextChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {

            //Exception handler to test the input to see if it can be parsed
            try
            {
                float.Parse(AgeTextBox.Text);
                SubmitButton.Enabled = true;
            }
            catch
            {
                SubmitButton.Enabled = false;
            }
        }

        /// <summary>
        /// This is the event handler for the NameTextBox TextChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            SubmitButton.Enabled = (NameTextBox.Text.Length < 2) ? false : true;
        }
    }
}
