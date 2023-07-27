using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Calculator
{
   
    
    
    public partial class Calculaor : Form
    {
        bool clearAndInsert = false;
        int clicked = 0;//Determine if the user clicked on the number once after clicking the Sign
        double num1=0;
        double num2=0;
        double result;
        double temperproryNumber = 0;
       
        bool plusOperator = false;
        public Calculaor()
        {
            InitializeComponent();

        }
        
        private void Calculaor_Load(object sender, EventArgs e)
        {

            
            
            
           

        }

        private void backSpacebutto_Click(object sender, EventArgs e)
        {
           
           
          if (resultLabel.Text == "Cannot Divide By Zero")
            {
                resultLabel.Font = originalFont;
                resultLabel.Text = "0";
                plusButto.Enabled = true;
                negateButto.Enabled = true;
                squareButto.Enabled = true;
                minusButto.Enabled = true;
                multiplyButto.Enabled = true;
                divideButto.Enabled = true;
                dotButto.Enabled = true;

            }
            else
            {
                string str = resultLabel.Text;
                   if (resultLabel.Text.Length == 2 && resultLabel.Text[0] == '-')
                {
                    resultLabel.Text = "0";

                }
              else  if (str.Length > 1)
                {
                    resultLabel.Text = "";

                    for (int i = 0; i < str.Length - 1; i++)
                    {


                        resultLabel.Text += str[i];








                    }


                }

              
                else
                {
                   
                    if ((resultLabel.Text.Length == 1 || resultLabel.Text == "" ))
                    {
                        resultLabel.Text = "0";

                    }
                }



            }
        }
        private void divideButto_Click(object sender, EventArgs e)
        {
            if (clicked > 0 && plusOperator == true)
            {
                if (numLabel.Text == "")
                {
                    num1 = double.Parse(resultLabel.Text); num2 = num1;

                    resultLabel.Text = num2.ToString();
                    numLabel.Text = num1.ToString();
                    operLabel.Text = "÷";

                }


                else if (operLabel.Text != "÷")
                {
                    if (operLabel.Text == "-")
                    {
                        num1 = double.Parse(numLabel.Text);
                        num2 = double.Parse(resultLabel.Text);
                        result = num1 - num2;
                        resultLabel.Text = result.ToString();
                        operLabel.Text = "÷";

                    }
                    else if (operLabel.Text == "×")
                    {

                        num1 = double.Parse(numLabel.Text);
                        num2 = double.Parse(resultLabel.Text);
                        result = num1 * num2;
                        resultLabel.Text = result.ToString();
                        operLabel.Text = "÷";

                    }
                    else
                    {
                        num1 = double.Parse(numLabel.Text);
                        num2 = double.Parse(resultLabel.Text);
                        result = num1 + num2;
                        resultLabel.Text = result.ToString();
                        operLabel.Text = "÷";
                    }


                }
                else
                {

                    num1 = double.Parse(numLabel.Text);

                    num2 = double.Parse(resultLabel.Text);
                   
                    result = num1 / num2;
                    resultLabel.Text = result.ToString();
                    numLabel.Text = result.ToString();

                }
            }
            plusOperator = true;
            clearAndInsert = true;
            operLabel.Visible = true;
            operLabel.Text = "÷";
            numLabel.Text = resultLabel.Text;
            clicked = 0;
        }

        private void multiplyButto_Click(object sender, EventArgs e)
        {

            if (clicked > 0 && plusOperator == true)
            {
                if (numLabel.Text == "")
                {
                    num1 = double.Parse(resultLabel.Text); num2 = num1;

                    resultLabel.Text = num2.ToString();
                    numLabel.Text = num1.ToString();
                    operLabel.Text = "×";

                }


                else if (operLabel.Text != "×")
                {
                    if (operLabel.Text == "+")
                    {
                        num1 = double.Parse(numLabel.Text);
                        num2 = double.Parse(resultLabel.Text);
                        result = num1 + num2;
                        resultLabel.Text = result.ToString();
                        operLabel.Text = "×";

                    }
                    else if (operLabel.Text == "-")
                    {

                        num1 = double.Parse(numLabel.Text);
                        num2 = double.Parse(resultLabel.Text);
                        result = num1 - num2;
                        resultLabel.Text = result.ToString();
                        operLabel.Text = "×";

                    }
                    else
                    {
                        num1 = double.Parse(numLabel.Text);
                        num2 = double.Parse(resultLabel.Text);
                        result = num1 / num2;
                        resultLabel.Text = result.ToString();
                        operLabel.Text = "×";
                    }


                }
                else
                {

                    num1 = double.Parse(numLabel.Text);

                    num2 = double.Parse(resultLabel.Text);
                    
                    result = num1 * num2;
                    resultLabel.Text = result.ToString();
                    numLabel.Text = result.ToString();

                }
            }

            plusOperator = true;
            clearAndInsert = true;
            operLabel.Visible = true;
            operLabel.Text = "×";
            numLabel.Text = resultLabel.Text;
            clicked = 0;
        }

        private void minusButto_Click(object sender, EventArgs e)
        {
            if (clicked > 0 && plusOperator == true)
            {
                if (numLabel.Text == "") 
                {
                    num1 = double.Parse(resultLabel.Text); num2 = num1;

                    resultLabel.Text = num2.ToString();
                    numLabel.Text=num1.ToString();
                    operLabel.Text="-";
                
                }


                else if (operLabel.Text != "-")
                {
                    if (operLabel.Text == "+")
                    {
                        num1 = double.Parse(numLabel.Text);
                        num2 = double.Parse(resultLabel.Text);
                        result = num1 + num2;
                        resultLabel.Text = result.ToString();
                        operLabel.Text = "-";

                    }
                    else if (operLabel.Text == "×")
                    {

                        num1 = double.Parse(numLabel.Text);
                        num2 = double.Parse(resultLabel.Text);
                        result = num1 * num2;
                        resultLabel.Text = result.ToString();
                        operLabel.Text = "-";

                    }
                    else
                    {
                        num1 = double.Parse(numLabel.Text);
                        num2 = double.Parse(resultLabel.Text);
                        result = num1 / num2;
                        resultLabel.Text = result.ToString();
                        operLabel.Text = "-";
                    }


                }
                else
                {

                    num1 = double.Parse(numLabel.Text);

                    num2 = double.Parse(resultLabel.Text);
                    
                    result = num1 - num2;
                    resultLabel.Text = result.ToString();
                    numLabel.Text = result.ToString();

                }
            }

            plusOperator = true;
            clearAndInsert = true;
            operLabel.Visible = true;
            operLabel.Text="-";
            numLabel.Text = resultLabel.Text;
            clicked = 0;
        }
        Font originalFont;
        
        private void equalButto_Click(object sender, EventArgs e)
        {
        
            bool foundEqual = false;
            for (int i = 0; i < numLabel.Text.Length; i++)
            {
                if (numLabel.Text[i] == '=')
                {
                    foundEqual = true;
                    if (operLabel.Text == "+")
                    {
                        int plusSignIndex = numLabel.Text.IndexOf("+") + 1;
                        int equalSignIndex = numLabel.Text.IndexOf("=");
                        string secondNumber = numLabel.Text.Substring(plusSignIndex, equalSignIndex - plusSignIndex);
                        num2 = double.Parse(secondNumber);

                        num1 = double.Parse(resultLabel.Text);
                        result = num1 + num2;
                        resultLabel.Text = result.ToString();
                        numLabel.Text = num1.ToString() + "+" + num2.ToString() + "=";
                        break;
                    }
                    else if (operLabel.Text == "-")
                    {




                        num1 = double.Parse(resultLabel.Text);

                        result = num1 - temperproryNumber;
                        resultLabel.Text = result.ToString();
                        numLabel.Text = num1.ToString() + "-" + num2.ToString() + "=";
                        break;
                    }
                    else if (operLabel.Text == "×")
                    {
                        int plusSignIndex = numLabel.Text.IndexOf("×") + 1;
                        int equalSignIndex = numLabel.Text.IndexOf("=");
                        string secondNumber = numLabel.Text.Substring(plusSignIndex, equalSignIndex - plusSignIndex);
                        num2 = double.Parse(secondNumber);

                        num1 = double.Parse(resultLabel.Text);
                        result = num1 * num2;
                        resultLabel.Text = result.ToString();
                        numLabel.Text = num1.ToString() + "×" + num2.ToString() + "=";
                        break;
                    }
                    else if (operLabel.Text == "÷")
                    {
                        int plusSignIndex = numLabel.Text.IndexOf("÷") + 1;
                        int equalSignIndex = numLabel.Text.IndexOf("=");
                        string secondNumber = numLabel.Text.Substring(plusSignIndex, equalSignIndex - plusSignIndex);
                        num2 = double.Parse(secondNumber);

                        num1 = double.Parse(resultLabel.Text);
                        result = num1 * num2;
                        resultLabel.Text = result.ToString();
                        numLabel.Text = num1.ToString() + "÷" + num2.ToString() + "=";
                        break;
                    }
                    else
                    {
                        num1 = double.Parse(resultLabel.Text);
                        numLabel.Text = num1 + "=";
                        resultLabel.Text = num1.ToString();
                    }
                }

            }


            clicked = 0;
            clearAndInsert = true;

         
            if (resultLabel.Text == "Cannot Divide By Zero")
            {
                resultLabel.Font = originalFont;
                resultLabel.Text = "0";
                plusButto.Enabled = true;
                negateButto.Enabled = true;
                squareButto.Enabled = true;
                minusButto.Enabled = true;
                multiplyButto.Enabled = true;
                divideButto.Enabled = true;
                dotButto.Enabled = true;

            }
            else
            {
                if (operLabel.Text == "+" && operLabel.Visible == true)

                {
                    num1 = double.Parse(numLabel.Text);
                    num2 = double.Parse(resultLabel.Text);
                    result = num1 + num2;
                    numLabel.Text = num1.ToString() + "+" + num2.ToString() + "=";
                    operLabel.Visible = false;
                    resultLabel.Text = result.ToString();

                }
                else if (operLabel.Text == "-" && operLabel.Visible == true)

                {
                    num1 = double.Parse(numLabel.Text);
                    num2 = double.Parse(resultLabel.Text);
                    temperproryNumber = num2;
                    result = num1 - num2;
                    numLabel.Text = num1.ToString() + "-" + num2.ToString() + "=";
                    operLabel.Visible = false;
                    resultLabel.Text = result.ToString();

                }
                else if (operLabel.Text == "×" && operLabel.Visible == true)

                {
                    num1 = double.Parse(numLabel.Text);
                    num2 = double.Parse(resultLabel.Text);
                    result = num1 * num2;
                    numLabel.Text = num1.ToString() + "×" + num2.ToString() + "=";
                    operLabel.Visible = false;
                    resultLabel.Text = result.ToString();

                }
                else if (operLabel.Text == "÷" && operLabel.Visible == true)

                {

                    num1 = double.Parse(numLabel.Text);
                    num2 = double.Parse(resultLabel.Text);
                    if (num2 == 0)
                    {
                        originalFont = resultLabel.Font;
                        resultLabel.Font = new Font("Arial", 17, FontStyle.Bold);
                        resultLabel.Text = "Cannot Divide By Zero";
                        plusButto.Enabled = false;
                        negateButto.Enabled = false;
                        squareButto.Enabled = false;
                        minusButto.Enabled = false;
                        multiplyButto.Enabled = false;
                        divideButto.Enabled = false;
                        dotButto.Enabled = false;

                    }
                    else if (operLabel.Text == "÷")
                    {
                        result = num1 / num2;
                        numLabel.Text = num1.ToString() + "÷" + num2.ToString() + "=";
                        operLabel.Visible = false;
                        resultLabel.Text = result.ToString();
                    }
                    else
                    {
                        num1 = double.Parse(resultLabel.Text);
                        numLabel.Text = num1 + "=";
                        resultLabel.Text = num1.ToString();
                    }
                }

                else if (foundEqual == false)
                {
                    num1 = double.Parse(resultLabel.Text);
                    numLabel.Text = num1 + "=";
                    resultLabel.Text = num1.ToString();
                }
            }
        }
        private void plusButto_Click(object sender, EventArgs e)
        {
            if (clicked > 0 && plusOperator == true)
            {
                if (numLabel.Text == "")
                {
                    num1 = double.Parse(resultLabel.Text); num2 = num1;

                    resultLabel.Text = num2.ToString();
                    numLabel.Text = num1.ToString();
                    operLabel.Text = "+";

                }


                else if (operLabel.Text != "+")
                {
                    if (operLabel.Text == "-")
                    {
                        num1 = double.Parse(numLabel.Text);
                        num2 = double.Parse(resultLabel.Text);
                        result = num1 - num2;
                        resultLabel.Text = result.ToString();
                        operLabel.Text = "+";

                    }
                    else if (operLabel.Text == "×")
                    {

                        num1 = double.Parse(numLabel.Text);
                        num2 = double.Parse(resultLabel.Text);
                        result = num1 * num2;
                        resultLabel.Text = result.ToString();
                        operLabel.Text = "+";

                    }
                    else
                    {
                        num1 = double.Parse(numLabel.Text);
                        num2 = double.Parse(resultLabel.Text);
                        result = num1 / num2;
                        resultLabel.Text = result.ToString();
                        operLabel.Text = "+";
                    }


                }
                else
                {

                    num1 = double.Parse(numLabel.Text);

                    num2 = double.Parse(resultLabel.Text);
                    if (operLabel.Text != "+")
                    {


                    }
                    result = num1 + num2;
                    resultLabel.Text = result.ToString();
                    numLabel.Text = result.ToString();

                }
            }

             plusOperator = true;
            
            operLabel.Visible = true;
            operLabel.Text = "+";
            num1=double.Parse(resultLabel.Text);
            resultLabel.Text = num1.ToString();
            numLabel.Text=num1.ToString();
            clicked = 0;
            clearAndInsert = true;
          
                
            
        }

        private void oneButto_Click(object sender, EventArgs e)
        {
          
            clicked++;//increasing the clicks as if it is one click it goes to be the the same number or in clearing state

            clearAndInsert = false;
            // This part is when user clicks the number on clearing state and in the presence of one zero only
            if (resultLabel.Text == "0" &&resultLabel.Text.Length==1)
            {
               
                
                resultLabel.Text = "1";
                for (int i = 0; i < numLabel.Text.Length; i++)
                {
                    if (numLabel.Text[i] == '=')
                    {
                        operLabel.Visible = false;
                        numLabel.Text = "";
                        break;

                    }

                }


                clicked = 2; //make the click equal 2 as to append the number and continue
            }
            else if (resultLabel.Text == "0.")
            {
                resultLabel.Text += "1";

            }
            else  
          
            {

                if (clicked >= 2)//if it is 2 or more continue appending that means the user didnt click once after the operator sign

                {
                    resultLabel.Text += "1"; 
                }


                else
                {
                    resultLabel.Text = "1"; //user clicks once after the  operator sign
                    for (int i = 0; i < numLabel.Text.Length; i++)
                    {
                        if (numLabel.Text[i] == '=')
                        {
                            operLabel.Visible = false;
                            numLabel.Text = "";
                            break;

                        }

                    }


                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            aboutUsForm aboutUsF=new aboutUsForm();
            aboutUsF.ShowDialog();
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {

            clicked++;//increasing the clicks as if it is one click it goes to be the the same number or in clearing state


            // This part is when user clicks the number on clearing state and in the presence of one zero only
            if (resultLabel.Text == "0"||clearAndInsert==true)
            {
                clearAndInsert=false;

                resultLabel.Text = "0";
                   for(int i = 0;i < numLabel.Text.Length; i++) 
            {
                if (numLabel.Text[i] == '=') 
                {
                operLabel.Visible = false;
                    numLabel.Text = "";
                    break;
                
                }
            
            }


            }
            else if (resultLabel.Text == "0.")
            {
                resultLabel.Text += "0";

            }
            else

            {

                    resultLabel.Text += "0";


            }
        }

        private void twoButto_Click(object sender, EventArgs e)
        {
            clicked++;//increasing the clicks as if it is one click it goes to be the the same number or in clearing state
            clearAndInsert = false;
            // This part is when user clicks the number on clearing state and in the presence of one zero only
            if (resultLabel.Text == "0" && resultLabel.Text.Length == 1)
            {
                
                resultLabel.Text = "2";
                clicked = 2; //make the click equal 2 as to append the number and continue
                for (int i = 0; i < numLabel.Text.Length; i++)
                {
                    if (numLabel.Text[i] == '=')
                    {
                        operLabel.Visible = false;
                        numLabel.Text = "";
                        break;

                    }

                }

            }
           else if (resultLabel.Text == "0.")
            {
                resultLabel.Text += "2";

            }
            else

            {

                if (clicked >= 2)//if it is 2 or more continue appending that means the user didnt click once after the operator sign

                {
                    resultLabel.Text += "2";
                }


                else
                {
                   
                    resultLabel.Text = "2"; //user clicks once after the  operator sign

                    for (int i = 0; i < numLabel.Text.Length; i++)
                    {
                        if (numLabel.Text[i] == '=')
                        {
                            operLabel.Visible = false;
                            numLabel.Text = "";
                            break;

                        }

                    }

                }
            }
        }

        private void threeButto_Click(object sender, EventArgs e)
        {
            clicked++;//increasing the clicks as if it is one click it goes to be the the same number or in clearing state
            clearAndInsert = false;
            // This part is when user clicks the number on clearing state and in the presence of one zero only
            if (resultLabel.Text == "0" && resultLabel.Text.Length == 1)
            {
                resultLabel.Text = "3";
                clicked = 2; //make the click equal 2 as to append the number and continue
                for (int i = 0; i < numLabel.Text.Length; i++)
                {
                    if (numLabel.Text[i] == '=')
                    {
                        operLabel.Visible = false;
                        numLabel.Text = "";
                        break;

                    }

                }

            }
            else if (resultLabel.Text == "0.")
            {
                resultLabel.Text += "3";

            }
            else

            {

                if (clicked >= 2)//if it is 2 or more continue appending that means the user didnt click once after the operator sign

                {
                    resultLabel.Text += "3";
                }


                
                
                  //  if (resultLabel.Text.EndsWith(".")) { resultLabel.Text += "3"; }
                  
                    
                   else
                    {
                        
                    resultLabel.Text = "3"; //user clicks once after the  operator sign

                    for (int i = 0; i < numLabel.Text.Length; i++)
                    {
                        if (numLabel.Text[i] == '=')
                        {
                            operLabel.Visible = false;
                            numLabel.Text = "";
                            break;

                        }

                    }


                }



            }
        }

            private void fourButto_Click(object sender, EventArgs e)
        {
            clicked++;//increasing the clicks as if it is one click it goes to be the the same number or in clearing state
            clearAndInsert = false;
            // This part is when user clicks the number on clearing state and in the presence of one zero only
            if (resultLabel.Text == "0" && resultLabel.Text.Length == 1)
            {
                resultLabel.Text = "4";
                clicked = 2; //make the click equal 2 as to append the number and continue
                for (int i = 0; i < numLabel.Text.Length; i++)
                {
                    if (numLabel.Text[i] == '=')
                    {
                        operLabel.Visible = false;
                        numLabel.Text = "";
                        break;

                    }

                }

            }
            else if (resultLabel.Text == "0.")
            {
                resultLabel.Text += "4";

            }
            else

            {

                if (clicked >= 2)//if it is 2 or more continue appending that means the user didnt click once after the operator sign

                {
                    resultLabel.Text += "4";
                }


                else
                {
                    resultLabel.Text = "4"; //user clicks once after the  operator sign

                    for (int i = 0; i < numLabel.Text.Length; i++)
                    {
                        if (numLabel.Text[i] == '=')
                        {
                            operLabel.Visible = false;
                            numLabel.Text = "";
                            break;

                        }

                    }

                }
            }

        }

        private void fiveButto_Click(object sender, EventArgs e)
        {
            clicked++;//increasing the clicks as if it is one click it goes to be the the same number or in clearing state
            clearAndInsert = false;
            // This part is when user clicks the number on clearing state and in the presence of one zero only
            if (resultLabel.Text == "0" && resultLabel.Text.Length == 1)
            {
                resultLabel.Text = "5";
                clicked = 2; //make the click equal 2 as to append the number and continue
                for (int i = 0; i < numLabel.Text.Length; i++)
                {
                    if (numLabel.Text[i] == '=')
                    {
                        operLabel.Visible = false;
                        numLabel.Text = "";
                        break;

                    }

                }

            }
            else if (resultLabel.Text == "0.")
            {
                resultLabel.Text += "5";

            }
            else

            {

                if (clicked >= 2)//if it is 2 or more continue appending that means the user didnt click once after the operator sign

                {
                    resultLabel.Text += "5";
                }


                else
                {
                    resultLabel.Text = "5"; //user clicks once after the  operator sign

                    for (int i = 0; i < numLabel.Text.Length; i++)
                    {
                        if (numLabel.Text[i] == '=')
                        {
                            operLabel.Visible = false;
                            numLabel.Text = "";
                            break;

                        }

                    }

                }
            }
        }

        private void sixButto_Click(object sender, EventArgs e)
        {
            clicked++;//increasing the clicks as if it is one click it goes to be the the same number or in clearing state
            clearAndInsert = false;
            // This part is when user clicks the number on clearing state and in the presence of one zero only
            if (resultLabel.Text == "0" && resultLabel.Text.Length == 1)
            {
                resultLabel.Text = "6";
                clicked = 2; //make the click equal 2 as to append the number and continue
                for (int i = 0; i < numLabel.Text.Length; i++)
                {
                    if (numLabel.Text[i] == '=')
                    {
                        operLabel.Visible = false;
                        numLabel.Text = "";
                        break;

                    }

                }

            }
            else if (resultLabel.Text == "0.")
            {
                resultLabel.Text += "6";

            }
            else

            {

                if (clicked >= 2)//if it is 2 or more continue appending that means the user didnt click once after the operator sign

                {
                    resultLabel.Text += "6";
                }


                else
                {
                    resultLabel.Text = "6"; //user clicks once after the  operator sign
                    for (int i = 0; i < numLabel.Text.Length; i++)
                    {
                        if (numLabel.Text[i] == '=')
                        {
                            operLabel.Visible = false;
                            numLabel.Text = "";
                            break;

                        }

                    }


                }
            }
        }

        private void sevenButto_Click(object sender, EventArgs e)
        {
            clicked++;//increasing the clicks as if it is one click it goes to be the the same number or in clearing state
            clearAndInsert = false;
            // This part is when user clicks the number on clearing state and in the presence of one zero only
            if (resultLabel.Text == "0" && resultLabel.Text.Length == 1)
            {
                resultLabel.Text = "7";
                clicked = 2; //make the click equal 2 as to append the number and continue
                for (int i = 0; i < numLabel.Text.Length; i++)
                {
                    if (numLabel.Text[i] == '=')
                    {
                        operLabel.Visible = false;
                        numLabel.Text = "";
                        break;

                    }

                }

            }
            else if (resultLabel.Text == "0.")
            {
                resultLabel.Text += "7";

            }
            else

            {

                if (clicked >= 2)//if it is 2 or more continue appending that means the user didnt click once after the operator sign

                {
                    resultLabel.Text += "7";
                }


                else
                {
                    resultLabel.Text = "7"; //user clicks once after the  operator sign


                }
            }
        }

        private void eightButto_Click(object sender, EventArgs e)
        {
            clicked++;//increasing the clicks as if it is one click it goes to be the the same number or in clearing state
            clearAndInsert = false;
            // This part is when user clicks the number on clearing state and in the presence of one zero only
            if (resultLabel.Text == "0" && resultLabel.Text.Length == 1)
            {
                resultLabel.Text = "8";
                clicked = 2; //make the click equal 2 as to append the number and continue
                for (int i = 0; i < numLabel.Text.Length; i++)
                {
                    if (numLabel.Text[i] == '=')
                    {
                        operLabel.Visible = false;
                        numLabel.Text = "";
                        break;

                    }

                }

            }
            else if (resultLabel.Text == "0.")
            {
                resultLabel.Text += "8";

            }
            else

            {

                if (clicked >= 2)//if it is 2 or more continue appending that means the user didnt click once after the operator sign

                {
                    resultLabel.Text += "8";
                }


                else
                {
                    resultLabel.Text = "8"; //user clicks once after the  operator sign

                    for (int i = 0; i < numLabel.Text.Length; i++)
                    {
                        if (numLabel.Text[i] == '=')
                        {
                            operLabel.Visible = false;
                            numLabel.Text = "";
                            break;

                        }

                    }

                }
            }

        }

        private void nineButto_Click(object sender, EventArgs e)
        {
            clicked++;//increasing the clicks as if it is one click it goes to be the the same number or in clearing state
            clearAndInsert = false;
            // This part is when user clicks the number on clearing state and in the presence of one zero only
            if (resultLabel.Text == "0" && resultLabel.Text.Length == 1)
            {
                resultLabel.Text = "9";
                clicked = 2; //make the click equal 2 as to append the number and continue
                for (int i = 0; i < numLabel.Text.Length; i++)
                {
                    if (numLabel.Text[i] == '=')
                    {
                        operLabel.Visible = false;
                        numLabel.Text = "";
                        break;

                    }

                }

            }
            else if (resultLabel.Text == "0.")
            {
                resultLabel.Text += "9";

            }
            else

            {

                if (clicked >= 2)//if it is 2 or more continue appending that means the user didnt click once after the operator sign

                {
                    resultLabel.Text += "9";
                }


                else
                {
                    resultLabel.Text = "9"; //user clicks once after the  operator sign
                    for (int i = 0; i < numLabel.Text.Length; i++)
                    {
                        if (numLabel.Text[i] == '=')
                        {
                            operLabel.Visible = false;
                            numLabel.Text = "";
                            break;

                        }

                    }


                }
            }

        }

        private void dotButto_Click(object sender, EventArgs e)
        {
            
            bool dotCount = false;
            decimal n1;
            n1 = decimal.Parse(resultLabel.Text);
           for(int i = 0; i < resultLabel.Text.Length; i++) 
            {
                if (resultLabel.Text[i] == '.') 
                {
                    dotCount = true;
                    break;
                }
                for (int j = 0; j < numLabel.Text.Length; j++)
                {

                    if (numLabel.Text[j]=='=')
                    {

                        num1 = 0;
                        resultLabel.Text = num1.ToString() + '.';
                        result = double.Parse(resultLabel.Text);
             

                    }

                }
            }
            if (dotCount == true) 
            {
               
                return;
            
            }
            else 
            {
                
               
                
                    resultLabel.Text = n1.ToString() + ".";
                    result = double.Parse(resultLabel.Text);
                
            }
            
        }

        private void clearButto_Click(object sender, EventArgs e)
        {
            
            //Clearing all thing to the first state
            if (resultLabel.Text == "Cannot Divide By Zero")
            {
                resultLabel.Font = originalFont;
                resultLabel.Text = "0";
                numLabel.Text = "";
                operLabel.Text = "";
                plusButto.Enabled = true;
                negateButto.Enabled = true;
                squareButto.Enabled = true;
                minusButto.Enabled = true;
                multiplyButto.Enabled = true;
                divideButto.Enabled = true;
                dotButto.Enabled = true;
            }
            else
            {
                resultLabel.Text = "0";
                numLabel.Text = "";
                operLabel.Text = "";
                
            }
            clicked = 0;
        }

        private void operLabel_Click(object sender, EventArgs e)
        {

        }

        private void negateButto_Click(object sender, EventArgs e)
        {
           



            result = double.Parse(resultLabel.Text);
                result = -result;
                resultLabel.Text = result.ToString();
            
            
        }

        private void squareButto_Click(object sender, EventArgs e)
        {
            num1=double.Parse(resultLabel.Text);
            result = Math.Pow(num1, 2);
            numLabel.Text = "sqr(" + num1 + ")";
            resultLabel.Text=result.ToString();
        }
    }
}
