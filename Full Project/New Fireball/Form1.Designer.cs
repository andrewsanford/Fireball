
namespace New_Fireball
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblClass = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.cmbSpellLevel = new System.Windows.Forms.ComboBox();
            this.lblEleAdept = new System.Windows.Forms.Label();
            this.chkEleAdept = new System.Windows.Forms.CheckBox();
            this.chkFoP = new System.Windows.Forms.CheckBox();
            this.lblFoP = new System.Windows.Forms.Label();
            this.btnRoll = new System.Windows.Forms.Button();
            this.lblEleAffinity = new System.Windows.Forms.Label();
            this.chkEleAffinity = new System.Windows.Forms.CheckBox();
            this.txtChaMod1 = new System.Windows.Forms.TextBox();
            this.lblChaMod1 = new System.Windows.Forms.Label();
            this.lblOverchannel = new System.Windows.Forms.Label();
            this.chkOverchannel = new System.Windows.Forms.CheckBox();
            this.lblSpellBomb = new System.Windows.Forms.Label();
            this.chkSpellBomb = new System.Windows.Forms.CheckBox();
            this.lblEmpEvo = new System.Windows.Forms.Label();
            this.chkEmpEvo = new System.Windows.Forms.CheckBox();
            this.lblIntMod = new System.Windows.Forms.Label();
            this.txtIntMod = new System.Windows.Forms.TextBox();
            this.lblEmpSpell = new System.Windows.Forms.Label();
            this.chkEmpSpell = new System.Windows.Forms.CheckBox();
            this.lblChaMod2 = new System.Windows.Forms.Label();
            this.txtChaMod2 = new System.Windows.Forms.TextBox();
            this.lblRerolls = new System.Windows.Forms.Label();
            this.lblRerollsRemaining = new System.Windows.Forms.Label();
            this.lblPowerSurge = new System.Windows.Forms.Label();
            this.chkPowerSurge = new System.Windows.Forms.CheckBox();
            this.lblWizardLevel = new System.Windows.Forms.Label();
            this.txtWizardLevel = new System.Windows.Forms.TextBox();
            this.lblDice = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnReroll1 = new System.Windows.Forms.Button();
            this.btnReroll2 = new System.Windows.Forms.Button();
            this.btnReroll3 = new System.Windows.Forms.Button();
            this.btnReroll4 = new System.Windows.Forms.Button();
            this.btnReroll5 = new System.Windows.Forms.Button();
            this.btnReroll6 = new System.Windows.Forms.Button();
            this.btnReroll7 = new System.Windows.Forms.Button();
            this.btnReroll8 = new System.Windows.Forms.Button();
            this.btnReroll9 = new System.Windows.Forms.Button();
            this.btnReroll10 = new System.Windows.Forms.Button();
            this.btnReroll11 = new System.Windows.Forms.Button();
            this.btnReroll12 = new System.Windows.Forms.Button();
            this.btnReroll13 = new System.Windows.Forms.Button();
            this.btnReroll14 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblClass
            // 
            this.lblClass.AccessibleName = "";
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblClass.Location = new System.Drawing.Point(28, 35);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(106, 37);
            this.lblClass.TabIndex = 0;
            this.lblClass.Text = "Class:";
            // 
            // cmbClass
            // 
            this.cmbClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Items.AddRange(new object[] {
            "Sorcerer",
            "Wizard",
            "Other"});
            this.cmbClass.Location = new System.Drawing.Point(141, 32);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(206, 45);
            this.cmbClass.TabIndex = 1;
            this.cmbClass.SelectedIndexChanged += new System.EventHandler(this.cmbClass_SelectedIndexChanged);
            // 
            // lblLevel
            // 
            this.lblLevel.AccessibleName = "lblClass";
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblLevel.Location = new System.Drawing.Point(28, 115);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(179, 37);
            this.lblLevel.TabIndex = 2;
            this.lblLevel.Text = "Spell Level:";
            // 
            // cmbSpellLevel
            // 
            this.cmbSpellLevel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbSpellLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpellLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cmbSpellLevel.FormattingEnabled = true;
            this.cmbSpellLevel.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbSpellLevel.Location = new System.Drawing.Point(214, 112);
            this.cmbSpellLevel.Name = "cmbSpellLevel";
            this.cmbSpellLevel.Size = new System.Drawing.Size(134, 45);
            this.cmbSpellLevel.TabIndex = 2;
            this.cmbSpellLevel.SelectedIndexChanged += new System.EventHandler(this.cmbSpellLevel_SelectedIndexChanged);
            // 
            // lblEleAdept
            // 
            this.lblEleAdept.AccessibleName = "lblClass";
            this.lblEleAdept.AutoSize = true;
            this.lblEleAdept.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblEleAdept.Location = new System.Drawing.Point(30, 182);
            this.lblEleAdept.Name = "lblEleAdept";
            this.lblEleAdept.Size = new System.Drawing.Size(306, 32);
            this.lblEleAdept.TabIndex = 4;
            this.lblEleAdept.Text = "Elemental Adept (feat):";
            // 
            // chkEleAdept
            // 
            this.chkEleAdept.AutoSize = true;
            this.chkEleAdept.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.chkEleAdept.Location = new System.Drawing.Point(342, 189);
            this.chkEleAdept.Name = "chkEleAdept";
            this.chkEleAdept.Size = new System.Drawing.Size(22, 21);
            this.chkEleAdept.TabIndex = 5;
            this.chkEleAdept.UseVisualStyleBackColor = true;
            // 
            // chkFoP
            // 
            this.chkFoP.AutoSize = true;
            this.chkFoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.chkFoP.Location = new System.Drawing.Point(501, 246);
            this.chkFoP.Name = "chkFoP";
            this.chkFoP.Size = new System.Drawing.Size(22, 21);
            this.chkFoP.TabIndex = 7;
            this.chkFoP.UseVisualStyleBackColor = true;
            // 
            // lblFoP
            // 
            this.lblFoP.AccessibleName = "lblClass";
            this.lblFoP.AutoSize = true;
            this.lblFoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblFoP.Location = new System.Drawing.Point(30, 237);
            this.lblFoP.Name = "lblFoP";
            this.lblFoP.Size = new System.Drawing.Size(463, 32);
            this.lblFoP.TabIndex = 6;
            this.lblFoP.Text = "Flames of Phlegethos (tiefling feat):";
            // 
            // btnRoll
            // 
            this.btnRoll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoll.Enabled = false;
            this.btnRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.btnRoll.Location = new System.Drawing.Point(342, 708);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(202, 85);
            this.btnRoll.TabIndex = 8;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // lblEleAffinity
            // 
            this.lblEleAffinity.AccessibleName = "lblClass";
            this.lblEleAffinity.AutoSize = true;
            this.lblEleAffinity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblEleAffinity.Location = new System.Drawing.Point(30, 289);
            this.lblEleAffinity.Name = "lblEleAffinity";
            this.lblEleAffinity.Size = new System.Drawing.Size(245, 32);
            this.lblEleAffinity.TabIndex = 9;
            this.lblEleAffinity.Text = "Elemental Affinity:";
            this.lblEleAffinity.Visible = false;
            // 
            // chkEleAffinity
            // 
            this.chkEleAffinity.AutoSize = true;
            this.chkEleAffinity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.chkEleAffinity.Location = new System.Drawing.Point(280, 297);
            this.chkEleAffinity.Name = "chkEleAffinity";
            this.chkEleAffinity.Size = new System.Drawing.Size(22, 21);
            this.chkEleAffinity.TabIndex = 10;
            this.chkEleAffinity.UseVisualStyleBackColor = true;
            this.chkEleAffinity.Visible = false;
            this.chkEleAffinity.CheckedChanged += new System.EventHandler(this.chkEleAffinity_CheckedChanged);
            // 
            // txtChaMod1
            // 
            this.txtChaMod1.Enabled = false;
            this.txtChaMod1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtChaMod1.Location = new System.Drawing.Point(280, 334);
            this.txtChaMod1.Name = "txtChaMod1";
            this.txtChaMod1.Size = new System.Drawing.Size(80, 35);
            this.txtChaMod1.TabIndex = 11;
            this.txtChaMod1.Visible = false;
            this.txtChaMod1.TextChanged += new System.EventHandler(this.txtChaMod1_TextChanged);
            // 
            // lblChaMod1
            // 
            this.lblChaMod1.AccessibleName = "lblClass";
            this.lblChaMod1.AutoSize = true;
            this.lblChaMod1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblChaMod1.Location = new System.Drawing.Point(60, 337);
            this.lblChaMod1.Name = "lblChaMod1";
            this.lblChaMod1.Size = new System.Drawing.Size(215, 29);
            this.lblChaMod1.TabIndex = 12;
            this.lblChaMod1.Text = "Charisma Modifier:";
            this.lblChaMod1.Visible = false;
            // 
            // lblOverchannel
            // 
            this.lblOverchannel.AccessibleName = "lblClass";
            this.lblOverchannel.AutoSize = true;
            this.lblOverchannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblOverchannel.Location = new System.Drawing.Point(30, 383);
            this.lblOverchannel.Name = "lblOverchannel";
            this.lblOverchannel.Size = new System.Drawing.Size(185, 32);
            this.lblOverchannel.TabIndex = 13;
            this.lblOverchannel.Text = "Overchannel:";
            this.lblOverchannel.Visible = false;
            // 
            // chkOverchannel
            // 
            this.chkOverchannel.AutoSize = true;
            this.chkOverchannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.chkOverchannel.Location = new System.Drawing.Point(220, 391);
            this.chkOverchannel.Name = "chkOverchannel";
            this.chkOverchannel.Size = new System.Drawing.Size(22, 21);
            this.chkOverchannel.TabIndex = 14;
            this.chkOverchannel.UseVisualStyleBackColor = true;
            this.chkOverchannel.Visible = false;
            this.chkOverchannel.CheckedChanged += new System.EventHandler(this.chkOverchannel_CheckedChanged);
            // 
            // lblSpellBomb
            // 
            this.lblSpellBomb.AccessibleName = "lblClass";
            this.lblSpellBomb.AutoSize = true;
            this.lblSpellBomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblSpellBomb.Location = new System.Drawing.Point(30, 438);
            this.lblSpellBomb.Name = "lblSpellBomb";
            this.lblSpellBomb.Size = new System.Drawing.Size(273, 32);
            this.lblSpellBomb.TabIndex = 15;
            this.lblSpellBomb.Text = "Spell Bombardment:";
            this.lblSpellBomb.Visible = false;
            // 
            // chkSpellBomb
            // 
            this.chkSpellBomb.AutoSize = true;
            this.chkSpellBomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.chkSpellBomb.Location = new System.Drawing.Point(309, 446);
            this.chkSpellBomb.Name = "chkSpellBomb";
            this.chkSpellBomb.Size = new System.Drawing.Size(22, 21);
            this.chkSpellBomb.TabIndex = 16;
            this.chkSpellBomb.UseVisualStyleBackColor = true;
            this.chkSpellBomb.Visible = false;
            this.chkSpellBomb.CheckedChanged += new System.EventHandler(this.chkSpellBomb_CheckedChanged);
            // 
            // lblEmpEvo
            // 
            this.lblEmpEvo.AccessibleName = "lblClass";
            this.lblEmpEvo.AutoSize = true;
            this.lblEmpEvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblEmpEvo.Location = new System.Drawing.Point(30, 495);
            this.lblEmpEvo.Name = "lblEmpEvo";
            this.lblEmpEvo.Size = new System.Drawing.Size(307, 32);
            this.lblEmpEvo.TabIndex = 17;
            this.lblEmpEvo.Text = "Empowered Evocation:";
            this.lblEmpEvo.Visible = false;
            // 
            // chkEmpEvo
            // 
            this.chkEmpEvo.AutoSize = true;
            this.chkEmpEvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.chkEmpEvo.Location = new System.Drawing.Point(344, 505);
            this.chkEmpEvo.Name = "chkEmpEvo";
            this.chkEmpEvo.Size = new System.Drawing.Size(22, 21);
            this.chkEmpEvo.TabIndex = 18;
            this.chkEmpEvo.UseVisualStyleBackColor = true;
            this.chkEmpEvo.Visible = false;
            this.chkEmpEvo.CheckedChanged += new System.EventHandler(this.chkEmpEvo_CheckedChanged);
            // 
            // lblIntMod
            // 
            this.lblIntMod.AccessibleName = "lblClass";
            this.lblIntMod.AutoSize = true;
            this.lblIntMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblIntMod.Location = new System.Drawing.Point(100, 542);
            this.lblIntMod.Name = "lblIntMod";
            this.lblIntMod.Size = new System.Drawing.Size(237, 29);
            this.lblIntMod.TabIndex = 19;
            this.lblIntMod.Text = "Intelligence Modifier:";
            this.lblIntMod.Visible = false;
            // 
            // txtIntMod
            // 
            this.txtIntMod.Enabled = false;
            this.txtIntMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtIntMod.Location = new System.Drawing.Point(344, 538);
            this.txtIntMod.Name = "txtIntMod";
            this.txtIntMod.Size = new System.Drawing.Size(80, 35);
            this.txtIntMod.TabIndex = 20;
            this.txtIntMod.Visible = false;
            // 
            // lblEmpSpell
            // 
            this.lblEmpSpell.AccessibleName = "lblClass";
            this.lblEmpSpell.AutoSize = true;
            this.lblEmpSpell.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblEmpSpell.Location = new System.Drawing.Point(30, 585);
            this.lblEmpSpell.Name = "lblEmpSpell";
            this.lblEmpSpell.Size = new System.Drawing.Size(246, 32);
            this.lblEmpSpell.TabIndex = 21;
            this.lblEmpSpell.Text = "Empowered Spell:";
            this.lblEmpSpell.Visible = false;
            // 
            // chkEmpSpell
            // 
            this.chkEmpSpell.AutoSize = true;
            this.chkEmpSpell.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.chkEmpSpell.Location = new System.Drawing.Point(282, 591);
            this.chkEmpSpell.Name = "chkEmpSpell";
            this.chkEmpSpell.Size = new System.Drawing.Size(22, 21);
            this.chkEmpSpell.TabIndex = 22;
            this.chkEmpSpell.UseVisualStyleBackColor = true;
            this.chkEmpSpell.Visible = false;
            this.chkEmpSpell.CheckedChanged += new System.EventHandler(this.chkEmpSpell_CheckedChanged);
            // 
            // lblChaMod2
            // 
            this.lblChaMod2.AccessibleName = "lblClass";
            this.lblChaMod2.AutoSize = true;
            this.lblChaMod2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblChaMod2.Location = new System.Drawing.Point(60, 629);
            this.lblChaMod2.Name = "lblChaMod2";
            this.lblChaMod2.Size = new System.Drawing.Size(215, 29);
            this.lblChaMod2.TabIndex = 24;
            this.lblChaMod2.Text = "Charisma Modifier:";
            this.lblChaMod2.Visible = false;
            // 
            // txtChaMod2
            // 
            this.txtChaMod2.Enabled = false;
            this.txtChaMod2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtChaMod2.Location = new System.Drawing.Point(280, 626);
            this.txtChaMod2.Name = "txtChaMod2";
            this.txtChaMod2.Size = new System.Drawing.Size(80, 35);
            this.txtChaMod2.TabIndex = 23;
            this.txtChaMod2.Visible = false;
            this.txtChaMod2.TextChanged += new System.EventHandler(this.txtChaMod2_TextChanged);
            // 
            // lblRerolls
            // 
            this.lblRerolls.AccessibleName = "lblClass";
            this.lblRerolls.AutoSize = true;
            this.lblRerolls.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRerolls.Location = new System.Drawing.Point(57, 669);
            this.lblRerolls.Name = "lblRerolls";
            this.lblRerolls.Size = new System.Drawing.Size(218, 29);
            this.lblRerolls.TabIndex = 25;
            this.lblRerolls.Text = "Rerolls Remaining:";
            this.lblRerolls.Visible = false;
            // 
            // lblRerollsRemaining
            // 
            this.lblRerollsRemaining.AccessibleName = "lblClass";
            this.lblRerollsRemaining.AutoSize = true;
            this.lblRerollsRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblRerollsRemaining.Location = new System.Drawing.Point(272, 669);
            this.lblRerollsRemaining.Name = "lblRerollsRemaining";
            this.lblRerollsRemaining.Size = new System.Drawing.Size(31, 32);
            this.lblRerollsRemaining.TabIndex = 26;
            this.lblRerollsRemaining.Text = "0";
            this.lblRerollsRemaining.Visible = false;
            // 
            // lblPowerSurge
            // 
            this.lblPowerSurge.AccessibleName = "lblClass";
            this.lblPowerSurge.AutoSize = true;
            this.lblPowerSurge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPowerSurge.Location = new System.Drawing.Point(30, 698);
            this.lblPowerSurge.Name = "lblPowerSurge";
            this.lblPowerSurge.Size = new System.Drawing.Size(186, 32);
            this.lblPowerSurge.TabIndex = 27;
            this.lblPowerSurge.Text = "Power Surge:";
            this.lblPowerSurge.Visible = false;
            // 
            // chkPowerSurge
            // 
            this.chkPowerSurge.AutoSize = true;
            this.chkPowerSurge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.chkPowerSurge.Location = new System.Drawing.Point(222, 706);
            this.chkPowerSurge.Name = "chkPowerSurge";
            this.chkPowerSurge.Size = new System.Drawing.Size(22, 21);
            this.chkPowerSurge.TabIndex = 28;
            this.chkPowerSurge.UseVisualStyleBackColor = true;
            this.chkPowerSurge.Visible = false;
            this.chkPowerSurge.CheckedChanged += new System.EventHandler(this.chkPowerSurge_CheckedChanged);
            // 
            // lblWizardLevel
            // 
            this.lblWizardLevel.AccessibleName = "lblClass";
            this.lblWizardLevel.AutoSize = true;
            this.lblWizardLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblWizardLevel.Location = new System.Drawing.Point(57, 742);
            this.lblWizardLevel.Name = "lblWizardLevel";
            this.lblWizardLevel.Size = new System.Drawing.Size(157, 29);
            this.lblWizardLevel.TabIndex = 29;
            this.lblWizardLevel.Text = "Wizard Level:";
            this.lblWizardLevel.Visible = false;
            // 
            // txtWizardLevel
            // 
            this.txtWizardLevel.Enabled = false;
            this.txtWizardLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtWizardLevel.Location = new System.Drawing.Point(220, 738);
            this.txtWizardLevel.Name = "txtWizardLevel";
            this.txtWizardLevel.Size = new System.Drawing.Size(80, 35);
            this.txtWizardLevel.TabIndex = 30;
            this.txtWizardLevel.Visible = false;
            // 
            // lblDice
            // 
            this.lblDice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblDice.Location = new System.Drawing.Point(579, 32);
            this.lblDice.Name = "lblDice";
            this.lblDice.Size = new System.Drawing.Size(533, 647);
            this.lblDice.TabIndex = 31;
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblResult.Location = new System.Drawing.Point(579, 698);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(533, 94);
            this.lblResult.TabIndex = 32;
            // 
            // btnReroll1
            // 
            this.btnReroll1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReroll1.Enabled = false;
            this.btnReroll1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnReroll1.Location = new System.Drawing.Point(706, 38);
            this.btnReroll1.Name = "btnReroll1";
            this.btnReroll1.Size = new System.Drawing.Size(82, 31);
            this.btnReroll1.TabIndex = 33;
            this.btnReroll1.Text = "Reroll";
            this.btnReroll1.UseVisualStyleBackColor = true;
            this.btnReroll1.Visible = false;
            this.btnReroll1.Click += new System.EventHandler(this.btnReroll1_Click);
            // 
            // btnReroll2
            // 
            this.btnReroll2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReroll2.Enabled = false;
            this.btnReroll2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnReroll2.Location = new System.Drawing.Point(706, 78);
            this.btnReroll2.Name = "btnReroll2";
            this.btnReroll2.Size = new System.Drawing.Size(82, 31);
            this.btnReroll2.TabIndex = 34;
            this.btnReroll2.Text = "Reroll";
            this.btnReroll2.UseVisualStyleBackColor = true;
            this.btnReroll2.Visible = false;
            this.btnReroll2.Click += new System.EventHandler(this.btnReroll2_Click);
            // 
            // btnReroll3
            // 
            this.btnReroll3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReroll3.Enabled = false;
            this.btnReroll3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnReroll3.Location = new System.Drawing.Point(706, 118);
            this.btnReroll3.Name = "btnReroll3";
            this.btnReroll3.Size = new System.Drawing.Size(82, 31);
            this.btnReroll3.TabIndex = 35;
            this.btnReroll3.Text = "Reroll";
            this.btnReroll3.UseVisualStyleBackColor = true;
            this.btnReroll3.Visible = false;
            this.btnReroll3.Click += new System.EventHandler(this.btnReroll3_Click);
            // 
            // btnReroll4
            // 
            this.btnReroll4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReroll4.Enabled = false;
            this.btnReroll4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnReroll4.Location = new System.Drawing.Point(706, 158);
            this.btnReroll4.Name = "btnReroll4";
            this.btnReroll4.Size = new System.Drawing.Size(82, 31);
            this.btnReroll4.TabIndex = 36;
            this.btnReroll4.Text = "Reroll";
            this.btnReroll4.UseVisualStyleBackColor = true;
            this.btnReroll4.Visible = false;
            this.btnReroll4.Click += new System.EventHandler(this.btnReroll4_Click);
            // 
            // btnReroll5
            // 
            this.btnReroll5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReroll5.Enabled = false;
            this.btnReroll5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnReroll5.Location = new System.Drawing.Point(706, 198);
            this.btnReroll5.Name = "btnReroll5";
            this.btnReroll5.Size = new System.Drawing.Size(82, 31);
            this.btnReroll5.TabIndex = 37;
            this.btnReroll5.Text = "Reroll";
            this.btnReroll5.UseVisualStyleBackColor = true;
            this.btnReroll5.Visible = false;
            this.btnReroll5.Click += new System.EventHandler(this.btnReroll5_Click);
            // 
            // btnReroll6
            // 
            this.btnReroll6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReroll6.Enabled = false;
            this.btnReroll6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnReroll6.Location = new System.Drawing.Point(706, 238);
            this.btnReroll6.Name = "btnReroll6";
            this.btnReroll6.Size = new System.Drawing.Size(82, 31);
            this.btnReroll6.TabIndex = 38;
            this.btnReroll6.Text = "Reroll";
            this.btnReroll6.UseVisualStyleBackColor = true;
            this.btnReroll6.Visible = false;
            this.btnReroll6.Click += new System.EventHandler(this.btnReroll6_Click);
            // 
            // btnReroll7
            // 
            this.btnReroll7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReroll7.Enabled = false;
            this.btnReroll7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnReroll7.Location = new System.Drawing.Point(706, 278);
            this.btnReroll7.Name = "btnReroll7";
            this.btnReroll7.Size = new System.Drawing.Size(82, 31);
            this.btnReroll7.TabIndex = 39;
            this.btnReroll7.Text = "Reroll";
            this.btnReroll7.UseVisualStyleBackColor = true;
            this.btnReroll7.Visible = false;
            this.btnReroll7.Click += new System.EventHandler(this.btnReroll7_Click);
            // 
            // btnReroll8
            // 
            this.btnReroll8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReroll8.Enabled = false;
            this.btnReroll8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnReroll8.Location = new System.Drawing.Point(706, 318);
            this.btnReroll8.Name = "btnReroll8";
            this.btnReroll8.Size = new System.Drawing.Size(82, 31);
            this.btnReroll8.TabIndex = 40;
            this.btnReroll8.Text = "Reroll";
            this.btnReroll8.UseVisualStyleBackColor = true;
            this.btnReroll8.Visible = false;
            this.btnReroll8.Click += new System.EventHandler(this.btnReroll8_Click);
            // 
            // btnReroll9
            // 
            this.btnReroll9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReroll9.Enabled = false;
            this.btnReroll9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnReroll9.Location = new System.Drawing.Point(706, 358);
            this.btnReroll9.Name = "btnReroll9";
            this.btnReroll9.Size = new System.Drawing.Size(82, 31);
            this.btnReroll9.TabIndex = 41;
            this.btnReroll9.Text = "Reroll";
            this.btnReroll9.UseVisualStyleBackColor = true;
            this.btnReroll9.Visible = false;
            this.btnReroll9.Click += new System.EventHandler(this.btnReroll9_Click);
            // 
            // btnReroll10
            // 
            this.btnReroll10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReroll10.Enabled = false;
            this.btnReroll10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnReroll10.Location = new System.Drawing.Point(724, 398);
            this.btnReroll10.Name = "btnReroll10";
            this.btnReroll10.Size = new System.Drawing.Size(82, 31);
            this.btnReroll10.TabIndex = 42;
            this.btnReroll10.Text = "Reroll";
            this.btnReroll10.UseVisualStyleBackColor = true;
            this.btnReroll10.Visible = false;
            this.btnReroll10.Click += new System.EventHandler(this.btnReroll10_Click);
            // 
            // btnReroll11
            // 
            this.btnReroll11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReroll11.Enabled = false;
            this.btnReroll11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnReroll11.Location = new System.Drawing.Point(724, 438);
            this.btnReroll11.Name = "btnReroll11";
            this.btnReroll11.Size = new System.Drawing.Size(82, 31);
            this.btnReroll11.TabIndex = 43;
            this.btnReroll11.Text = "Reroll";
            this.btnReroll11.UseVisualStyleBackColor = true;
            this.btnReroll11.Visible = false;
            this.btnReroll11.Click += new System.EventHandler(this.btnReroll11_Click);
            // 
            // btnReroll12
            // 
            this.btnReroll12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReroll12.Enabled = false;
            this.btnReroll12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnReroll12.Location = new System.Drawing.Point(724, 478);
            this.btnReroll12.Name = "btnReroll12";
            this.btnReroll12.Size = new System.Drawing.Size(82, 31);
            this.btnReroll12.TabIndex = 44;
            this.btnReroll12.Text = "Reroll";
            this.btnReroll12.UseVisualStyleBackColor = true;
            this.btnReroll12.Visible = false;
            this.btnReroll12.Click += new System.EventHandler(this.btnReroll12_Click);
            // 
            // btnReroll13
            // 
            this.btnReroll13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReroll13.Enabled = false;
            this.btnReroll13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnReroll13.Location = new System.Drawing.Point(724, 518);
            this.btnReroll13.Name = "btnReroll13";
            this.btnReroll13.Size = new System.Drawing.Size(82, 31);
            this.btnReroll13.TabIndex = 45;
            this.btnReroll13.Text = "Reroll";
            this.btnReroll13.UseVisualStyleBackColor = true;
            this.btnReroll13.Visible = false;
            this.btnReroll13.Click += new System.EventHandler(this.btnReroll13_Click);
            // 
            // btnReroll14
            // 
            this.btnReroll14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReroll14.Enabled = false;
            this.btnReroll14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnReroll14.Location = new System.Drawing.Point(724, 558);
            this.btnReroll14.Name = "btnReroll14";
            this.btnReroll14.Size = new System.Drawing.Size(82, 31);
            this.btnReroll14.TabIndex = 46;
            this.btnReroll14.Text = "Reroll";
            this.btnReroll14.UseVisualStyleBackColor = true;
            this.btnReroll14.Visible = false;
            this.btnReroll14.Click += new System.EventHandler(this.btnReroll14_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 858);
            this.Controls.Add(this.btnReroll14);
            this.Controls.Add(this.btnReroll13);
            this.Controls.Add(this.btnReroll12);
            this.Controls.Add(this.btnReroll11);
            this.Controls.Add(this.btnReroll10);
            this.Controls.Add(this.btnReroll9);
            this.Controls.Add(this.btnReroll8);
            this.Controls.Add(this.btnReroll7);
            this.Controls.Add(this.btnReroll6);
            this.Controls.Add(this.btnReroll5);
            this.Controls.Add(this.btnReroll4);
            this.Controls.Add(this.btnReroll3);
            this.Controls.Add(this.btnReroll2);
            this.Controls.Add(this.btnReroll1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblDice);
            this.Controls.Add(this.txtWizardLevel);
            this.Controls.Add(this.lblWizardLevel);
            this.Controls.Add(this.chkPowerSurge);
            this.Controls.Add(this.lblPowerSurge);
            this.Controls.Add(this.lblRerollsRemaining);
            this.Controls.Add(this.lblRerolls);
            this.Controls.Add(this.lblChaMod2);
            this.Controls.Add(this.txtChaMod2);
            this.Controls.Add(this.chkEmpSpell);
            this.Controls.Add(this.lblEmpSpell);
            this.Controls.Add(this.txtIntMod);
            this.Controls.Add(this.lblIntMod);
            this.Controls.Add(this.chkEmpEvo);
            this.Controls.Add(this.lblEmpEvo);
            this.Controls.Add(this.chkSpellBomb);
            this.Controls.Add(this.lblSpellBomb);
            this.Controls.Add(this.chkOverchannel);
            this.Controls.Add(this.lblOverchannel);
            this.Controls.Add(this.lblChaMod1);
            this.Controls.Add(this.txtChaMod1);
            this.Controls.Add(this.chkEleAffinity);
            this.Controls.Add(this.lblEleAffinity);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.chkFoP);
            this.Controls.Add(this.lblFoP);
            this.Controls.Add(this.chkEleAdept);
            this.Controls.Add(this.lblEleAdept);
            this.Controls.Add(this.cmbSpellLevel);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.lblClass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fireball";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblEleAdept;
        private System.Windows.Forms.Label lblFoP;
        public System.Windows.Forms.Label lblDice;
        public System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnReroll1;
        private System.Windows.Forms.Button btnReroll2;
        private System.Windows.Forms.Button btnReroll3;
        private System.Windows.Forms.Button btnReroll4;
        private System.Windows.Forms.Button btnReroll5;
        private System.Windows.Forms.Button btnReroll6;
        private System.Windows.Forms.Button btnReroll7;
        private System.Windows.Forms.Button btnReroll8;
        private System.Windows.Forms.Button btnReroll9;
        private System.Windows.Forms.Button btnReroll10;
        private System.Windows.Forms.Button btnReroll11;
        private System.Windows.Forms.Button btnReroll12;
        private System.Windows.Forms.Button btnReroll13;
        private System.Windows.Forms.Button btnReroll14;
        public System.Windows.Forms.TextBox txtChaMod2;
        public System.Windows.Forms.Label lblRerolls;
        public System.Windows.Forms.Label lblRerollsRemaining;
        public System.Windows.Forms.ComboBox cmbClass;
        public System.Windows.Forms.ComboBox cmbSpellLevel;
        public System.Windows.Forms.CheckBox chkEleAdept;
        public System.Windows.Forms.CheckBox chkFoP;
        public System.Windows.Forms.Label lblEleAffinity;
        public System.Windows.Forms.CheckBox chkEleAffinity;
        public System.Windows.Forms.TextBox txtChaMod1;
        public System.Windows.Forms.Label lblChaMod1;
        public System.Windows.Forms.Label lblOverchannel;
        public System.Windows.Forms.CheckBox chkOverchannel;
        public System.Windows.Forms.Label lblSpellBomb;
        public System.Windows.Forms.CheckBox chkSpellBomb;
        public System.Windows.Forms.Label lblEmpEvo;
        public System.Windows.Forms.CheckBox chkEmpEvo;
        public System.Windows.Forms.Label lblIntMod;
        public System.Windows.Forms.TextBox txtIntMod;
        public System.Windows.Forms.Label lblEmpSpell;
        public System.Windows.Forms.CheckBox chkEmpSpell;
        public System.Windows.Forms.Label lblChaMod2;
        public System.Windows.Forms.Label lblPowerSurge;
        public System.Windows.Forms.CheckBox chkPowerSurge;
        public System.Windows.Forms.Label lblWizardLevel;
        public System.Windows.Forms.TextBox txtWizardLevel;
        public System.Windows.Forms.Button btnRoll;
    }
}

