using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            try
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(textCharFileLocation.Text);
                List<String> charStats = new List<String>();
                int i = 1;
                while (true)
                {
                    String initialString = sr.ReadLine();
                    Char[] statValueArray = initialString.ToArray();
                    String statValue = "";
                    bool pastEqual = false;
                    for (int x = 0; x < statValueArray.Length; x++)
                    {
                        if (pastEqual)
                        {
                            statValue = statValue + statValueArray[x];
                        }
                        else if (statValueArray[x].Equals('='))
                        {
                            pastEqual = true;
                        }
                        /*if (Char.IsDigit(statValueArray[x]))
                        {
                            statValue = statValue + statValueArray[x];
                        }*/
                    }
                    //String statValue = new String(initialString.Where(Char.IsDigit).ToArray());
                    if (i == 1)
                    {
                        textBoxStat1.Text = statValue;
                        i++;
                    }
                    else if (i == 2)
                    {
                        textBoxStat2.Text = statValue;
                        textBoxModifier1.Text = (DiceRolls.GetModifierText(statValue).ToString());
                        i++;
                    }
                    else if (i == 3)
                    {
                        textBoxStat3.Text = statValue;
                        textBoxModifier2.Text = (DiceRolls.GetModifierText(statValue).ToString());
                        i++;
                    }
                    else if (i == 4)
                    {
                        textBoxStat4.Text = statValue;
                        textBoxModifier3.Text = (DiceRolls.GetModifierText(statValue).ToString());
                        i++;
                    }
                    else if (i == 5)
                    {
                        textBoxStat5.Text = statValue;
                        textBoxModifier4.Text = (DiceRolls.GetModifierText(statValue).ToString());
                        i++;
                    }
                    else if (i == 6)
                    {
                        textBoxStat6.Text = statValue;
                        textBoxModifier5.Text = (DiceRolls.GetModifierText(statValue).ToString());
                        i++;
                    }
                    else if (i == 7)
                    {
                        textBoxStat7.Text = statValue;
                        textBoxModifier6.Text = (DiceRolls.GetModifierText(statValue).ToString());
                        i++;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
        private void buttonPrintBlankSheet_Click(object sender, EventArgs e)
        {
            string newFileName = "NewBlankCharaterSheet.txt";
            if (File.Exists(newFileName))
            {
                int i = 1;
                while (true)
                {
                    newFileName = "NewBlankCharaterSheet" + i + ".txt";
                    if (File.Exists(newFileName))
                    {
                        i++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            System.IO.StreamWriter sw = new System.IO.StreamWriter(newFileName, true);
            sw.WriteLine("Name=");
            sw.WriteLine("Strength=");
            sw.WriteLine("Dexterity=");
            sw.WriteLine("Constitution=");
            sw.WriteLine("Intelligence=");
            sw.WriteLine("Wisdom=");
            sw.WriteLine("Charisma=");
            sw.Close();
        }
        private void buttonGetCurrentModifiers_Click(object sender, EventArgs e)
        {
            for (int i = 1; i<=6;i++)
            {
                if (i == 1)
                {
                    textBoxModifier1.Text = (DiceRolls.GetModifierText(textBoxStat2.Text).ToString());
                }
                else if (i == 2)
                {
                    textBoxModifier2.Text = (DiceRolls.GetModifierText(textBoxStat3.Text).ToString());
                }
                else if (i == 3)
                {
                    textBoxModifier3.Text = (DiceRolls.GetModifierText(textBoxStat4.Text).ToString());
                }
                else if (i == 4)
                {
                    textBoxModifier4.Text = (DiceRolls.GetModifierText(textBoxStat5.Text).ToString());
                }
                else if (i == 5)
                {
                    textBoxModifier5.Text = (DiceRolls.GetModifierText(textBoxStat6.Text).ToString());
                }
                else if (i == 6)
                {
                    textBoxModifier6.Text = (DiceRolls.GetModifierText(textBoxStat7.Text).ToString());
                }
            }
        }
    }
}
