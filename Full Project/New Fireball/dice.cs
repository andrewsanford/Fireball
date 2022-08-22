using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Fireball
{
    public static class Dice //linked list
    {
        public static Form1 form = Form.ActiveForm as Form1;
        public class Die
        {
            public int damage;
            public Die next;
            public bool rerolled = false;
        }

        public static Die home = null; //home node
        public static Die head = null; //head node
        public static Die bonus = null; //bonus node (spell bombardment)

        public static void add(int input)
        {
            if (head == null)
            {
                home = new Die();
                home.damage = input;
                head = home;
            }
            else
            {
                head.next = new Die();
                head = head.next;
                head.damage = input;
            }
        }

        public static void addBonus(int input)
        {
            bonus = new Die();
            bonus.damage = input;
        }

        public static void activateButtons() //empowered spell buttons
        {
            head = home;

            for (int i = 1; head != null; i++)
            {
                if (head.rerolled == false)
                {
                    form.Controls["btnReroll" + i].Enabled = true;
                    form.Controls["btnReroll" + i].Visible = true;
                }

                head = head.next;
            }

            form.lblRerolls.Visible = true;
            form.lblRerollsRemaining.Visible = true;

            if (Int32.Parse(form.txtChaMod2.Text) < 1)
            {
                form.lblRerollsRemaining.Text = "1";
            }
            else
            {
                form.lblRerollsRemaining.Text = Convert.ToString(Int32.Parse(form.txtChaMod2.Text));
            }
        }

        public static void clear()
        {
            head = home;

            while (head != null)
            {
                head = head.next;
                home = null;
                home = head;
            }

            bonus = null;

            form.lblDice.Text = "";
            form.lblResult.Text = "";  
        }

        public static void print(int dmgBeforeMod, int dmgAfterMod, int dmgTotal)
        {
            head = home;

            for (int i = 1; head != null; i++)
            {
                form.lblDice.Text += "Die " + i + ": " + head.damage;

                if (head.rerolled == true)
                {
                    form.lblDice.Text += " (rerolled)";
                }

                form.lblDice.Text += Environment.NewLine;

                head = head.next;
            }

            if (bonus != null)
            {
                form.lblDice.Text += "Bonus Die: " + bonus.damage;
            }

            form.lblResult.Text += "Damage before reassignments: " + dmgBeforeMod + Environment.NewLine;
            form.lblResult.Text += "Damage after reassignments: " + dmgAfterMod + Environment.NewLine;
            form.lblResult.Text += "Damage total (after modifiers): " + dmgTotal;
        }

        public static void removeButtons() //empowered spell buttons
        {
            for (int i = 1; i <= 14; i++)
            {
                form.Controls["btnReroll" + i].Enabled = false;
                form.Controls["btnReroll" + i].Visible = false;
            }

            form.lblRerolls.Visible = false;
            form.lblRerollsRemaining.Visible = false;
        }

        public static void rerollSelect(int dieNum)
        {
            head = home;

            for(int i = 0; i < (dieNum - 1); i++)
            {
                head = head.next;
            }

            form.Controls["btnReroll" + dieNum].Enabled = false;
            form.Controls["btnReroll" + dieNum].Visible = false;
        }

        
    }
}
