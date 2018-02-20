using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRollWindowForm
{
    class DiceRolls
    {
        public static void RollInitiative(int numberofPeople)
        {
            Random rand = new Random();
            int[] initiativeRolls = new int[numberofPeople];
            for (int i = 0; i < initiativeRolls.Length; i++)
            {
                initiativeRolls[i] = rand.Next(1, 20);
            }
        }
        public static String GetModifierText(string stat)
        {
            while (true)
            {
                try
                {
                    int statNum = Convert.ToInt32(stat);
                    int modifier = (int)Math.Floor((decimal)(statNum - 10) / 2);
                    return modifier.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return "N/A";
                }
            }

        }
        public static int GetModifierInt(string stat)
        {
            while (true)
            {
                try
                {
                    int statNum = Convert.ToInt32(stat);
                    int modifier = (int)Math.Floor((decimal)(statNum - 10) / 2);
                    return modifier;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }
    }
}
