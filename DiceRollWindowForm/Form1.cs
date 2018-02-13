using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRollWindowForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxModifier.Text = "1";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            string buttonClicked = "None Selected";
            int dieNum = 0;
            if (radioButtonD4.Checked)
            {
                buttonClicked = "D4";
                dieNum = 4;
            }
            else if (radioButtonD6.Checked)
            {
                buttonClicked = "D6";
                dieNum = 6;
            }
            else if (radioButtonD8.Checked)
            {
                buttonClicked = "D8";
                dieNum = 8;
            }
            else if (radioButtonD10.Checked)
            {
                buttonClicked = "D10";
                dieNum = 10;
            }
            else if (radioButtonD12.Checked)
            {
                buttonClicked = "D12";
                dieNum = 12;
            }
            else if (radioButtonD20.Checked)
            {
                buttonClicked = "D20";
                dieNum = 20;
            }
            else if (radioButtonD100.Checked)
            {
                buttonClicked = "D100";
                dieNum = 100;
            }

            int outcome = 0;
            int totalOutcome = 0;
            String Name = maskedTextBoxName.Text.ToString();
            String result = "";
            String addedResult = "";
            try
            {
                int multiplyer = int.Parse(textBoxModifier.Text);
                for(int i = 0;i<multiplyer;i++){
                    outcome =  rand.Next(1, dieNum);
                    totalOutcome = outcome + totalOutcome;
                    if (multiplyer == 1)
                    {
                        addedResult = totalOutcome.ToString();
                    }
                    else if (multiplyer > 1)
                    {
                        if (i < multiplyer)
                        {
                            addedResult = addedResult + outcome.ToString();
                            if (i != multiplyer-1)
                            {
                                addedResult = addedResult + "+";
                            }
                            if (i == multiplyer - 1)
                            {
                                addedResult = addedResult + "=" + totalOutcome.ToString();
                            }
                        }
                    }
                }
                if (Name != "")
                {
                    result = "Player " + Name + " has made a " + buttonClicked + " of:" + addedResult;
                }
                else
                {
                    result = "This " + buttonClicked + " roll result is :" + addedResult;
                }
                textBoxResult.AppendText(result + "\n");
                System.IO.StreamWriter sw = new System.IO.StreamWriter("DiceRollResultOuput.txt",true);
                sw.WriteLine(result);
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonCharacterFileChoice_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt";
            ofd.ShowDialog();
            if (ofd.FileName.Length != 0)
            {
                textCharFileLocation.Text = ofd.FileName;
            }
        }

        private void buttonPrintStats_Click(object sender, EventArgs e)
        {
            System.IO.StreamReader sr = new System.IO.StreamReader(textCharFileLocation.Text);
            List<String> charStats = new List<String>();
            for (int i = 0; )
            {

            }
            charStats[0] = sr.ReadLine();
        }
    }
}
