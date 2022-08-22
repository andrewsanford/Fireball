using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Fireball
{
    public static class FormFunctions
    {
        public static Form1 form = Form.ActiveForm as Form1;

        public static void chkEleAffinity()
        {
            if (form.chkEleAffinity.Checked == true)
            {
                form.txtChaMod1.Enabled = true;
            }
            else
            {
                form.txtChaMod1.Enabled = false;
            }

            if (form.chkEleAffinity.Checked == true)
            {
                form.chkSpellBomb.Enabled = false;
                form.chkSpellBomb.Checked = false;
            }
            else
            {
                form.chkSpellBomb.Enabled = true;
            }
        }

        public static void chkEmpEvo()
        {
            if (form.chkEmpEvo.Checked == true)
            {
                form.txtIntMod.Enabled = true;
            }
            else
            {
                form.txtIntMod.Enabled = false;
            }

            if (form.chkEmpEvo.Checked == true || form.chkOverchannel.Checked == true)
            {
                form.chkPowerSurge.Checked = false;
                form.chkPowerSurge.Enabled = false;
            }
            else
            {
                form.chkPowerSurge.Enabled = true;
            }
        }

        public static void chkEmpSpell()
        {
            if (form.chkEmpSpell.Checked == true)
            {
                form.txtChaMod2.Enabled = true;
            }
            else
            {
                form.txtChaMod2.Enabled = false;
            }
        }

        public static void chkOverchannel()
        {
            if (form.chkOverchannel.Checked == true || form.chkEmpEvo.Checked == true)
            {
                form.chkPowerSurge.Checked = false;
                form.chkPowerSurge.Enabled = false;
            }
            else
            {
                form.chkPowerSurge.Enabled = true;
            }
        }

        public static void chkPowerSurge()
        {
            if (form.chkPowerSurge.Checked == true)
            {
                form.txtWizardLevel.Enabled = true;
            }
            else
            {
                form.txtWizardLevel.Enabled = false;
            }
        }

        public static void chkSpellBomb()
        {
            if (form.chkSpellBomb.Checked == true)
            {
                form.chkEleAffinity.Enabled = false;
                form.chkEleAffinity.Checked = false;
            }
            else
            {
                form.chkEleAffinity.Enabled = true;
            }
        }

        public static void cmbClass()
        {
            switch (form.cmbClass.Text)
            {
                case "Wizard":
                    form.lblEleAffinity.Visible = false;
                    form.chkEleAffinity.Visible = false;
                    form.chkEleAffinity.Checked = false;
                    form.lblChaMod1.Visible = false;
                    form.txtChaMod1.Visible = false;
                    form.lblOverchannel.Visible = true;
                    form.chkOverchannel.Visible = true;
                    form.lblSpellBomb.Visible = false;
                    form.chkSpellBomb.Visible = false;
                    form.chkSpellBomb.Checked = false;
                    form.lblEmpEvo.Visible = true;
                    form.chkEmpEvo.Visible = true;
                    form.lblIntMod.Visible = true;
                    form.txtIntMod.Visible = true;
                    form.lblEmpSpell.Visible = false;
                    form.chkEmpSpell.Visible = false;
                    form.chkEmpSpell.Checked = false;
                    form.lblChaMod2.Visible = false;
                    form.txtChaMod2.Visible = false;
                    form.lblPowerSurge.Visible = true;
                    form.chkPowerSurge.Visible = true;
                    form.lblWizardLevel.Visible = true;
                    form.txtWizardLevel.Visible = true;
                    break;

                case "Sorcerer":
                    form.lblEleAffinity.Visible = true;
                    form.chkEleAffinity.Visible = true;
                    form.lblChaMod1.Visible = true;
                    form.txtChaMod1.Visible = true;
                    form.lblOverchannel.Visible = false;
                    form.chkOverchannel.Visible = false;
                    form.chkOverchannel.Checked = false;
                    form.lblSpellBomb.Visible = true;
                    form.chkSpellBomb.Visible = true;
                    form.lblEmpEvo.Visible = false;
                    form.chkEmpEvo.Visible = false;
                    form.chkEmpEvo.Checked = false;
                    form.lblIntMod.Visible = false;
                    form.txtIntMod.Visible = false;
                    form.lblEmpSpell.Visible = true;
                    form.chkEmpSpell.Visible = true;
                    form.lblChaMod2.Visible = true;
                    form.txtChaMod2.Visible = true;
                    form.lblPowerSurge.Visible = false;
                    form.chkPowerSurge.Visible = false;
                    form.chkPowerSurge.Checked = false;
                    form.lblWizardLevel.Visible = false;
                    form.txtWizardLevel.Visible = false;
                    break;

                case "Other":
                    form.lblEleAffinity.Visible = false;
                    form.chkEleAffinity.Visible = false;
                    form.chkEleAffinity.Checked = false;
                    form.lblChaMod1.Visible = false;
                    form.txtChaMod1.Visible = false;
                    form.lblOverchannel.Visible = false;
                    form.chkOverchannel.Visible = false;
                    form.chkOverchannel.Checked = false;
                    form.lblSpellBomb.Visible = false;
                    form.chkSpellBomb.Visible = false;
                    form.chkSpellBomb.Checked = false;
                    form.lblEmpEvo.Visible = false;
                    form.chkEmpEvo.Visible = false;
                    form.chkEmpEvo.Checked = false;
                    form.lblIntMod.Visible = false;
                    form.txtIntMod.Visible = false;
                    form.lblEmpSpell.Visible = false;
                    form.chkEmpSpell.Visible = false;
                    form.chkEmpSpell.Checked = false;
                    form.lblChaMod2.Visible = false;
                    form.txtChaMod2.Visible = false;
                    form.lblPowerSurge.Visible = false;
                    form.chkPowerSurge.Visible = false;
                    form.chkPowerSurge.Checked = false;
                    form.lblWizardLevel.Visible = false;
                    form.txtWizardLevel.Visible = false;
                    form.txtWizardLevel.Enabled = false;
                    break;
            }

            if (form.cmbSpellLevel.Text != "")
            {
                form.btnRoll.Enabled = true;
            }
        }

        public static void cmbSpellLevel()
        {
            if (form.cmbClass.Text != "")
            {
                form.btnRoll.Enabled = true;
            }
        }
    }
}