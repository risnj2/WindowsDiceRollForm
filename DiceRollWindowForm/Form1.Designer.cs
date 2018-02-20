namespace DiceRollWindowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonD8 = new System.Windows.Forms.RadioButton();
            this.radioButtonD4 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonD10 = new System.Windows.Forms.RadioButton();
            this.radioButtonD20 = new System.Windows.Forms.RadioButton();
            this.radioButtonD100 = new System.Windows.Forms.RadioButton();
            this.radioButtonD12 = new System.Windows.Forms.RadioButton();
            this.radioButtonD6 = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxName = new System.Windows.Forms.MaskedTextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxModifier = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonGetCurrentModifiers = new System.Windows.Forms.Button();
            this.buttonPrintBlankSheet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxModifier1 = new System.Windows.Forms.TextBox();
            this.textBoxModifier5 = new System.Windows.Forms.TextBox();
            this.textBoxModifier6 = new System.Windows.Forms.TextBox();
            this.textBoxModifier4 = new System.Windows.Forms.TextBox();
            this.textBoxModifier2 = new System.Windows.Forms.TextBox();
            this.textBoxModifier3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxStat2 = new System.Windows.Forms.TextBox();
            this.textBoxStat6 = new System.Windows.Forms.TextBox();
            this.textBoxStat7 = new System.Windows.Forms.TextBox();
            this.textBoxStat5 = new System.Windows.Forms.TextBox();
            this.textBoxStat3 = new System.Windows.Forms.TextBox();
            this.textBoxStat4 = new System.Windows.Forms.TextBox();
            this.textBoxStat1 = new System.Windows.Forms.TextBox();
            this.buttonPrintStats = new System.Windows.Forms.Button();
            this.buttonCharacterFileChoice = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textCharFileLocation = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get Roll";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Number of Die - Default 1";
            // 
            // radioButtonD8
            // 
            this.radioButtonD8.AutoSize = true;
            this.radioButtonD8.Location = new System.Drawing.Point(6, 42);
            this.radioButtonD8.Name = "radioButtonD8";
            this.radioButtonD8.Size = new System.Drawing.Size(39, 17);
            this.radioButtonD8.TabIndex = 17;
            this.radioButtonD8.TabStop = true;
            this.radioButtonD8.Text = "D8";
            this.radioButtonD8.UseVisualStyleBackColor = true;
            // 
            // radioButtonD4
            // 
            this.radioButtonD4.AutoSize = true;
            this.radioButtonD4.Location = new System.Drawing.Point(6, 19);
            this.radioButtonD4.Name = "radioButtonD4";
            this.radioButtonD4.Size = new System.Drawing.Size(39, 17);
            this.radioButtonD4.TabIndex = 18;
            this.radioButtonD4.TabStop = true;
            this.radioButtonD4.Text = "D4";
            this.radioButtonD4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.radioButtonD10);
            this.groupBox2.Controls.Add(this.radioButtonD20);
            this.groupBox2.Controls.Add(this.radioButtonD100);
            this.groupBox2.Controls.Add(this.radioButtonD12);
            this.groupBox2.Controls.Add(this.radioButtonD6);
            this.groupBox2.Controls.Add(this.radioButtonD4);
            this.groupBox2.Controls.Add(this.radioButtonD8);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(106, 116);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DieType";
            // 
            // radioButtonD10
            // 
            this.radioButtonD10.AutoSize = true;
            this.radioButtonD10.Location = new System.Drawing.Point(6, 64);
            this.radioButtonD10.Name = "radioButtonD10";
            this.radioButtonD10.Size = new System.Drawing.Size(45, 17);
            this.radioButtonD10.TabIndex = 23;
            this.radioButtonD10.TabStop = true;
            this.radioButtonD10.Text = "D10";
            this.radioButtonD10.UseVisualStyleBackColor = true;
            // 
            // radioButtonD20
            // 
            this.radioButtonD20.AutoSize = true;
            this.radioButtonD20.Location = new System.Drawing.Point(51, 65);
            this.radioButtonD20.Name = "radioButtonD20";
            this.radioButtonD20.Size = new System.Drawing.Size(45, 17);
            this.radioButtonD20.TabIndex = 22;
            this.radioButtonD20.TabStop = true;
            this.radioButtonD20.Text = "D20";
            this.radioButtonD20.UseVisualStyleBackColor = true;
            // 
            // radioButtonD100
            // 
            this.radioButtonD100.AutoSize = true;
            this.radioButtonD100.Location = new System.Drawing.Point(25, 85);
            this.radioButtonD100.Name = "radioButtonD100";
            this.radioButtonD100.Size = new System.Drawing.Size(51, 17);
            this.radioButtonD100.TabIndex = 21;
            this.radioButtonD100.TabStop = true;
            this.radioButtonD100.Text = "D100";
            this.radioButtonD100.UseVisualStyleBackColor = true;
            // 
            // radioButtonD12
            // 
            this.radioButtonD12.AutoSize = true;
            this.radioButtonD12.Location = new System.Drawing.Point(51, 42);
            this.radioButtonD12.Name = "radioButtonD12";
            this.radioButtonD12.Size = new System.Drawing.Size(45, 17);
            this.radioButtonD12.TabIndex = 20;
            this.radioButtonD12.TabStop = true;
            this.radioButtonD12.Text = "D12";
            this.radioButtonD12.UseVisualStyleBackColor = true;
            // 
            // radioButtonD6
            // 
            this.radioButtonD6.AutoSize = true;
            this.radioButtonD6.Location = new System.Drawing.Point(51, 19);
            this.radioButtonD6.Name = "radioButtonD6";
            this.radioButtonD6.Size = new System.Drawing.Size(39, 17);
            this.radioButtonD6.TabIndex = 19;
            this.radioButtonD6.TabStop = true;
            this.radioButtonD6.Text = "D6";
            this.radioButtonD6.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(426, 257);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.maskedTextBoxName);
            this.tabPage1.Controls.Add(this.textBoxResult);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.textBoxModifier);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(418, 231);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "BasicDiceRolls";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Character Name - Optional";
            // 
            // maskedTextBoxName
            // 
            this.maskedTextBoxName.Location = new System.Drawing.Point(291, 42);
            this.maskedTextBoxName.Name = "maskedTextBoxName";
            this.maskedTextBoxName.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxName.TabIndex = 21;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(47, 135);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(315, 86);
            this.textBoxResult.TabIndex = 20;
            // 
            // textBoxModifier
            // 
            this.textBoxModifier.Location = new System.Drawing.Point(130, 41);
            this.textBoxModifier.Name = "textBoxModifier";
            this.textBoxModifier.Size = new System.Drawing.Size(100, 20);
            this.textBoxModifier.TabIndex = 23;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.buttonGetCurrentModifiers);
            this.tabPage2.Controls.Add(this.buttonPrintBlankSheet);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.buttonPrintStats);
            this.tabPage2.Controls.Add(this.buttonCharacterFileChoice);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.textCharFileLocation);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(418, 231);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CharacterInput";
            // 
            // buttonGetCurrentModifiers
            // 
            this.buttonGetCurrentModifiers.Location = new System.Drawing.Point(9, 119);
            this.buttonGetCurrentModifiers.Name = "buttonGetCurrentModifiers";
            this.buttonGetCurrentModifiers.Size = new System.Drawing.Size(136, 23);
            this.buttonGetCurrentModifiers.TabIndex = 6;
            this.buttonGetCurrentModifiers.Text = " Get Current Modifiers";
            this.buttonGetCurrentModifiers.UseVisualStyleBackColor = true;
            this.buttonGetCurrentModifiers.Click += new System.EventHandler(this.buttonGetCurrentModifiers_Click);
            // 
            // buttonPrintBlankSheet
            // 
            this.buttonPrintBlankSheet.Location = new System.Drawing.Point(9, 148);
            this.buttonPrintBlankSheet.Name = "buttonPrintBlankSheet";
            this.buttonPrintBlankSheet.Size = new System.Drawing.Size(139, 23);
            this.buttonPrintBlankSheet.TabIndex = 5;
            this.buttonPrintBlankSheet.Text = "Print Blank Sheet";
            this.buttonPrintBlankSheet.UseVisualStyleBackColor = true;
            this.buttonPrintBlankSheet.Click += new System.EventHandler(this.buttonPrintBlankSheet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxModifier1);
            this.groupBox1.Controls.Add(this.textBoxModifier5);
            this.groupBox1.Controls.Add(this.textBoxModifier6);
            this.groupBox1.Controls.Add(this.textBoxModifier4);
            this.groupBox1.Controls.Add(this.textBoxModifier2);
            this.groupBox1.Controls.Add(this.textBoxModifier3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxStat2);
            this.groupBox1.Controls.Add(this.textBoxStat6);
            this.groupBox1.Controls.Add(this.textBoxStat7);
            this.groupBox1.Controls.Add(this.textBoxStat5);
            this.groupBox1.Controls.Add(this.textBoxStat3);
            this.groupBox1.Controls.Add(this.textBoxStat4);
            this.groupBox1.Controls.Add(this.textBoxStat1);
            this.groupBox1.Location = new System.Drawing.Point(197, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 215);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main Charcter Stats";
            // 
            // textBoxModifier1
            // 
            this.textBoxModifier1.Location = new System.Drawing.Point(169, 55);
            this.textBoxModifier1.Name = "textBoxModifier1";
            this.textBoxModifier1.ReadOnly = true;
            this.textBoxModifier1.Size = new System.Drawing.Size(40, 20);
            this.textBoxModifier1.TabIndex = 20;
            // 
            // textBoxModifier5
            // 
            this.textBoxModifier5.Location = new System.Drawing.Point(169, 159);
            this.textBoxModifier5.Name = "textBoxModifier5";
            this.textBoxModifier5.ReadOnly = true;
            this.textBoxModifier5.Size = new System.Drawing.Size(40, 20);
            this.textBoxModifier5.TabIndex = 19;
            // 
            // textBoxModifier6
            // 
            this.textBoxModifier6.Location = new System.Drawing.Point(169, 185);
            this.textBoxModifier6.Name = "textBoxModifier6";
            this.textBoxModifier6.ReadOnly = true;
            this.textBoxModifier6.Size = new System.Drawing.Size(40, 20);
            this.textBoxModifier6.TabIndex = 18;
            // 
            // textBoxModifier4
            // 
            this.textBoxModifier4.Location = new System.Drawing.Point(169, 133);
            this.textBoxModifier4.Name = "textBoxModifier4";
            this.textBoxModifier4.ReadOnly = true;
            this.textBoxModifier4.Size = new System.Drawing.Size(40, 20);
            this.textBoxModifier4.TabIndex = 17;
            // 
            // textBoxModifier2
            // 
            this.textBoxModifier2.Location = new System.Drawing.Point(169, 81);
            this.textBoxModifier2.Name = "textBoxModifier2";
            this.textBoxModifier2.ReadOnly = true;
            this.textBoxModifier2.Size = new System.Drawing.Size(40, 20);
            this.textBoxModifier2.TabIndex = 16;
            // 
            // textBoxModifier3
            // 
            this.textBoxModifier3.Location = new System.Drawing.Point(169, 107);
            this.textBoxModifier3.Name = "textBoxModifier3";
            this.textBoxModifier3.ReadOnly = true;
            this.textBoxModifier3.Size = new System.Drawing.Size(40, 20);
            this.textBoxModifier3.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Charisma";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Wisdom";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Intelligence";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Constitution";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Dexterity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Strength";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name";
            // 
            // textBoxStat2
            // 
            this.textBoxStat2.Location = new System.Drawing.Point(109, 55);
            this.textBoxStat2.Name = "textBoxStat2";
            this.textBoxStat2.Size = new System.Drawing.Size(40, 20);
            this.textBoxStat2.TabIndex = 6;
            // 
            // textBoxStat6
            // 
            this.textBoxStat6.Location = new System.Drawing.Point(109, 159);
            this.textBoxStat6.Name = "textBoxStat6";
            this.textBoxStat6.Size = new System.Drawing.Size(40, 20);
            this.textBoxStat6.TabIndex = 5;
            // 
            // textBoxStat7
            // 
            this.textBoxStat7.Location = new System.Drawing.Point(109, 185);
            this.textBoxStat7.Name = "textBoxStat7";
            this.textBoxStat7.Size = new System.Drawing.Size(40, 20);
            this.textBoxStat7.TabIndex = 4;
            // 
            // textBoxStat5
            // 
            this.textBoxStat5.Location = new System.Drawing.Point(109, 133);
            this.textBoxStat5.Name = "textBoxStat5";
            this.textBoxStat5.Size = new System.Drawing.Size(40, 20);
            this.textBoxStat5.TabIndex = 3;
            // 
            // textBoxStat3
            // 
            this.textBoxStat3.Location = new System.Drawing.Point(109, 81);
            this.textBoxStat3.Name = "textBoxStat3";
            this.textBoxStat3.Size = new System.Drawing.Size(40, 20);
            this.textBoxStat3.TabIndex = 2;
            // 
            // textBoxStat4
            // 
            this.textBoxStat4.Location = new System.Drawing.Point(109, 107);
            this.textBoxStat4.Name = "textBoxStat4";
            this.textBoxStat4.Size = new System.Drawing.Size(40, 20);
            this.textBoxStat4.TabIndex = 1;
            // 
            // textBoxStat1
            // 
            this.textBoxStat1.Location = new System.Drawing.Point(109, 29);
            this.textBoxStat1.Name = "textBoxStat1";
            this.textBoxStat1.Size = new System.Drawing.Size(100, 20);
            this.textBoxStat1.TabIndex = 0;
            // 
            // buttonPrintStats
            // 
            this.buttonPrintStats.Location = new System.Drawing.Point(9, 90);
            this.buttonPrintStats.Name = "buttonPrintStats";
            this.buttonPrintStats.Size = new System.Drawing.Size(75, 23);
            this.buttonPrintStats.TabIndex = 3;
            this.buttonPrintStats.Text = "Print Stats";
            this.buttonPrintStats.UseVisualStyleBackColor = true;
            this.buttonPrintStats.Click += new System.EventHandler(this.buttonPrintStats_Click);
            // 
            // buttonCharacterFileChoice
            // 
            this.buttonCharacterFileChoice.Location = new System.Drawing.Point(9, 61);
            this.buttonCharacterFileChoice.Name = "buttonCharacterFileChoice";
            this.buttonCharacterFileChoice.Size = new System.Drawing.Size(75, 23);
            this.buttonCharacterFileChoice.TabIndex = 2;
            this.buttonCharacterFileChoice.Text = "Choose File";
            this.buttonCharacterFileChoice.UseVisualStyleBackColor = true;
            this.buttonCharacterFileChoice.Click += new System.EventHandler(this.buttonCharacterFileChoice_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Character File Location";
            // 
            // textCharFileLocation
            // 
            this.textCharFileLocation.Location = new System.Drawing.Point(9, 35);
            this.textCharFileLocation.Name = "textCharFileLocation";
            this.textCharFileLocation.Size = new System.Drawing.Size(100, 20);
            this.textCharFileLocation.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(418, 231);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "CharacterModifiedRoles";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(267, 135);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 86);
            this.textBox1.TabIndex = 4;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Acrobatics",
            "Animal Handle",
            "Arcana",
            "Athletics",
            "Deception",
            "History",
            "Insight",
            "Intimidation",
            "Investigation",
            "Medicine",
            "Nature",
            "Perception",
            "Performance",
            "Persuasion",
            "Religion",
            "Sleight of Hand",
            "Stealth",
            "Survival"});
            this.checkedListBox1.Location = new System.Drawing.Point(6, 19);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(246, 199);
            this.checkedListBox1.Sorted = true;
            this.checkedListBox1.TabIndex = 5;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.CheckOnClick = true;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Strength",
            "Dexterity",
            "Constitution",
            "Intelligence",
            "Wisdom",
            "Charisma"});
            this.checkedListBox2.Location = new System.Drawing.Point(9, 19);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox2.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkedListBox1);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(258, 225);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Skills";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkedListBox2);
            this.groupBox4.Location = new System.Drawing.Point(267, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(137, 126);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Saving Throws";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(450, 281);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiceRoll";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonD8;
        private System.Windows.Forms.RadioButton radioButtonD4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonD20;
        private System.Windows.Forms.RadioButton radioButtonD100;
        private System.Windows.Forms.RadioButton radioButtonD12;
        private System.Windows.Forms.RadioButton radioButtonD6;
        private System.Windows.Forms.RadioButton radioButtonD10;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCharacterFileChoice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCharFileLocation;
        private System.Windows.Forms.Button buttonPrintStats;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxStat2;
        private System.Windows.Forms.TextBox textBoxStat6;
        private System.Windows.Forms.TextBox textBoxStat7;
        private System.Windows.Forms.TextBox textBoxStat5;
        private System.Windows.Forms.TextBox textBoxStat3;
        private System.Windows.Forms.TextBox textBoxStat4;
        private System.Windows.Forms.TextBox textBoxStat1;
        private System.Windows.Forms.Button buttonPrintBlankSheet;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBoxModifier1;
        private System.Windows.Forms.TextBox textBoxModifier5;
        private System.Windows.Forms.TextBox textBoxModifier6;
        private System.Windows.Forms.TextBox textBoxModifier4;
        private System.Windows.Forms.TextBox textBoxModifier2;
        private System.Windows.Forms.TextBox textBoxModifier3;
        private System.Windows.Forms.TextBox textBoxModifier;
        private System.Windows.Forms.Button buttonGetCurrentModifiers;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

