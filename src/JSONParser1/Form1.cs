using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace JSONParser1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        #region UI Events
        private void cmdDeserialize_Click(object sender, EventArgs e)
        {
            //debugoutput(txtInput.Text); 
            deserialize(txtInput.Text);
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtDebugOutput.Text = string.Empty;
        }
        #endregion

        #region Debug Output

        private void debugoutput(string strDebugText)
        {
            try
            {
                //Write out whatver string that we pass in to the debug window 
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                //Update out debug text values to what it was previously plus the new string 
                txtDebugOutput.Text = txtDebugOutput.Text + strDebugText + Environment.NewLine;
                //get the lenght pf the text string
                txtDebugOutput.SelectionStart = txtDebugOutput.TextLength;
                //Scroll our caret to the end 
                txtDebugOutput.ScrollToCaret();
            }
            catch (Exception ex)
            {   //Simply write exception to diagnostics debug window 
                System.Diagnostics.Debug.Write(ex.Message.ToString() + Environment.NewLine);
            }

        }
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #region json functions

        private void deserialize(string json)
        {
            try
            {
                //var jPerson = JsonConvert.DeserializeObject<dynamic>(json);
                //var jPerson = JsonConvert.DeserializeObject<jsonPersonSimple>(json);
                //var jPerson = JsonConvert.DeserializeObject<jsonPersonComplex>(json);
                var jPerson = JsonConvert.DeserializeObject<jsonPersonArray>(json);

                debugoutput("Here's our JSON Object: " + jPerson.ToString());

                debugoutput("Here's our first name: " + jPerson.firstname);
                debugoutput("Here's the street address: " + jPerson.address.streetAddress);

                debugoutput("Attempting to print our phone numbers....");

                foreach(var num in jPerson.phoneNumbers)
                {
                    debugoutput(num.type.ToString() + " - " + num.number.ToString());
                }
            }
            catch(Exception ex)
            {
                debugoutput("We had a problem: " + ex.Message.ToString());
            }
        }
        #endregion
    }
}
