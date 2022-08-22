using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Fireball
{
    public static class Functions
    {
        public static Form1 form = Form.ActiveForm as Form1;
        public static System.Random random = new System.Random();

        public static int diceAmount = 0;
        public static int dmgBeforeMod = 0;
        public static int dmgAfterMod = 0;
        public static int dmgTotal = 0;

        public static void applyFoP()
        {
            Dice.head.damage = random.Next(1, 7);
            Dice.head.rerolled = true;
        }

        public static void applyEleAdept()
        {
            Dice.head.damage = 2;
        }

        public static void applyEleAffinity()
        {
            if (Int32.Parse(form.txtChaMod1.Text) < -5 || Int32.Parse(form.txtChaMod1.Text) > 10)
            {
                throw new modifierException();
            }

            dmgTotal += Int32.Parse(form.txtChaMod1.Text);
        }

        public static void applyEmpEvo()
        {
            if (Int32.Parse(form.txtIntMod.Text) < -5 || Int32.Parse(form.txtIntMod.Text) > 10)
            {
                throw new modifierException();
            }

            dmgTotal += Int32.Parse(form.txtIntMod.Text);
        }

        public static void applyPowerSurge()
        {
            if (Int32.Parse(form.txtWizardLevel.Text) < 1 || Int32.Parse(form.txtWizardLevel.Text) > 20)
            {
                throw new levelException();
            }

            dmgTotal += Int32.Parse(form.txtWizardLevel.Text) / 2;
        }

        public static void applyEmpSpell()
        {
            if (Int32.Parse(form.txtChaMod2.Text) < -5 || Int32.Parse(form.txtChaMod2.Text) > 10)
            {
                throw new modifierException();
            }

            Dice.activateButtons();
        }

        public static void applyOverchannel()
        {
            Dice.head.damage = 6;
        }

        public static void applySpellBomb()
        {
            Dice.addBonus(random.Next(1, 7));
            dmgAfterMod += Dice.bonus.damage;
        }

        public static void rerollDie(int dieNum)
        {     
            Dice.rerollSelect(dieNum);

            dmgAfterMod -= Dice.head.damage;
            dmgTotal -= Dice.head.damage;

            Dice.head.damage = random.Next(1, 7);

            if (form.chkFoP.Checked == true && Dice.head.damage == 1)
            {
                applyFoP();
            }

            if (form.chkEleAdept.Checked == true && Dice.head.damage == 1)
            {
                applyEleAdept();
            }

            dmgAfterMod += Dice.head.damage;
            dmgTotal += Dice.head.damage;

            Dice.head.rerolled = true;

            form.lblRerollsRemaining.Text = Convert.ToString(Int32.Parse(form.lblRerollsRemaining.Text) - 1);

            if (form.lblRerollsRemaining.Text == "0")
            {
                Dice.removeButtons();
            }

            form.lblDice.Text = "";
            form.lblResult.Text = "";
            Dice.print(dmgBeforeMod, dmgAfterMod, dmgTotal);

        }
        public static void rollOther()
        {
            for (int i = 0; i < diceAmount; i++)
            {
                Dice.add(random.Next(1, 7));

                dmgBeforeMod += Dice.head.damage;

                if (form.chkFoP.Checked == true && Dice.head.damage == 1)
                {
                    applyFoP();
                }

                if (form.chkEleAdept.Checked == true && Dice.head.damage == 1)
                {
                    applyEleAdept();
                }

                dmgAfterMod += Dice.head.damage;
            }

            Dice.print(dmgBeforeMod, dmgAfterMod, dmgAfterMod);
        }

        public static void rollSorcerer()
        {
            bool spellBombardment = false;

            for (int i = 0; i < diceAmount; i++)
            {
                Dice.add(random.Next(1, 7));

                dmgBeforeMod += Dice.head.damage;

                if (form.chkFoP.Checked == true && Dice.head.damage == 1)
                {
                    applyFoP();
                }

                if (form.chkEleAdept.Checked == true && Dice.head.damage == 1)
                {
                    applyEleAdept();
                }

                if (form.chkSpellBomb.Checked == true && Dice.head.damage == 6)
                {
                    if (spellBombardment != true)
                    {
                        Dice.head.rerolled = true;
                        spellBombardment = true;
                    }               
                }

                dmgAfterMod += Dice.head.damage;
            }

            if (spellBombardment == true)
            {
                applySpellBomb();
            }

            if (form.chkEleAffinity.Checked == true)
            {
                applyEleAffinity();
            }

            if (form.chkEmpSpell.Checked == true)
            {
                applyEmpSpell();
            }

            dmgTotal += dmgAfterMod;

            Dice.print(dmgBeforeMod, dmgAfterMod, dmgTotal);
        }

        public static void rollWizard()
        {
            if (form.chkOverchannel.Checked == true && Int32.Parse(form.cmbSpellLevel.Text) > 5)
            {
                throw new overchannelException();
            }

            for (int i = 0; i < diceAmount; i++)
            {
                Dice.add(random.Next(1, 7));

                dmgBeforeMod += Dice.head.damage;

                if (form.chkOverchannel.Checked == true)
                {
                    applyOverchannel();
                }
                else
                {
                    if (form.chkFoP.Checked == true && Dice.head.damage == 1)
                    {
                        applyFoP();
                    }

                    if (form.chkEleAdept.Checked == true && Dice.head.damage == 1)
                    {
                        applyEleAdept();
                    }
                }

                dmgAfterMod += Dice.head.damage;
            }

            if (form.chkEmpEvo.Checked == true)
            {
                applyEmpEvo();
            }

            if (form.chkPowerSurge.Checked == true)
            {
                applyPowerSurge();
            }

            dmgTotal += dmgAfterMod;

            Dice.print(dmgBeforeMod, dmgAfterMod, dmgTotal);
        }
    }
}