using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace New_Fireball
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReroll1_Click(object sender, EventArgs e)
        {
            Functions.rerollDie(1);
        }

        private void btnReroll2_Click(object sender, EventArgs e)
        {
            Functions.rerollDie(2);
        }

        private void btnReroll3_Click(object sender, EventArgs e)
        {
            Functions.rerollDie(3);
        }

        private void btnReroll4_Click(object sender, EventArgs e)
        {
            Functions.rerollDie(4);
        }

        private void btnReroll5_Click(object sender, EventArgs e)
        {
            Functions.rerollDie(5);
        }

        private void btnReroll6_Click(object sender, EventArgs e)
        {
            Functions.rerollDie(6);
        }

        private void btnReroll7_Click(object sender, EventArgs e)
        {
            Functions.rerollDie(7);
        }

        private void btnReroll8_Click(object sender, EventArgs e)
        {
            Functions.rerollDie(8);
        }

        private void btnReroll9_Click(object sender, EventArgs e)
        {
            Functions.rerollDie(9);
        }

        private void btnReroll10_Click(object sender, EventArgs e)
        {
            Functions.rerollDie(10);
        }

        private void btnReroll11_Click(object sender, EventArgs e)
        {
            Functions.rerollDie(11);
        }

        private void btnReroll12_Click(object sender, EventArgs e)
        {
            Functions.rerollDie(12);
        }

        private void btnReroll13_Click(object sender, EventArgs e)
        {
            Functions.rerollDie(13);
        }

        private void btnReroll14_Click(object sender, EventArgs e)
        {
            Functions.rerollDie(14);
        }

        private void chkEleAffinity_CheckedChanged(object sender, EventArgs e)
        {
            FormFunctions.chkEleAffinity();
        }

        private void chkEmpEvo_CheckedChanged(object sender, EventArgs e)
        {
            FormFunctions.chkEmpEvo();
        }

        private void chkEmpSpell_CheckedChanged(object sender, EventArgs e)
        {
            FormFunctions.chkEmpSpell();
        }

        private void chkOverchannel_CheckedChanged(object sender, EventArgs e)
        {
            FormFunctions.chkOverchannel();
        }

        private void chkPowerSurge_CheckedChanged(object sender, EventArgs e)
        {
            FormFunctions.chkPowerSurge();
        }

        private void chkSpellBomb_CheckedChanged(object sender, EventArgs e)
        {
            FormFunctions.chkSpellBomb();
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormFunctions.cmbClass();
        }

        private void cmbSpellLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormFunctions.cmbSpellLevel();
        }

        private void txtChaMod1_TextChanged(object sender, EventArgs e)
        {
            txtChaMod2.Text = txtChaMod1.Text;
        }

        private void txtChaMod2_TextChanged(object sender, EventArgs e)
        {
            txtChaMod1.Text = txtChaMod2.Text;
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            Dice.clear();
            Dice.removeButtons();

            Functions.diceAmount = Int32.Parse(cmbSpellLevel.Text) + 8 - 3;
            Functions.dmgBeforeMod = 0;
            Functions.dmgAfterMod = 0;
            Functions.dmgTotal = 0;

            switch (cmbClass.Text)
            {
                case "Other":
                    try
                    {
                        Functions.rollOther();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Illegal Casting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;
                case "Sorcerer":
                    try
                    {
                        Functions.rollSorcerer();
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Charisma Modifier must be an integer.", "Illegal Casting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (modifierException err)
                    {
                        MessageBox.Show(err.Message, "Illegal Casting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Illegal Casting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Wizard":
                    try
                    {
                        Functions.rollWizard();
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Intelligence Modifier or Wizard Level must be an integer.", "Illegal Casting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (modifierException err)
                    {
                        MessageBox.Show(err.Message, "Illegal Casting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (levelException err)
                    {
                        MessageBox.Show(err.Message, "Illegal Casting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (overchannelException err)
                    {
                        MessageBox.Show(err.Message, "Illegal Casting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Illegal Casting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }
    }
}
