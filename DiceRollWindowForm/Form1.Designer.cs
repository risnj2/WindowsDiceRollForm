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
            this.textBoxModifier = new System.Windows.Forms.TextBox();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textCharFileLocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCharacterFileChoice = new System.Windows.Forms.Button();
            this.buttonPrintStats = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            // textBoxModifier
            // 
            this.textBoxModifier.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxModifier.Location = new System.Drawing.Point(134, 42);
            this.textBoxModifier.Name = "textBoxModifier";
            this.textBoxModifier.Size = new System.Drawing.Size(100, 20);
            this.textBoxModifier.TabIndex = 3;
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
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(426, 253);
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
            this.tabPage1.Size = new System.Drawing.Size(418, 227);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DiceRollPage";
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
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.buttonPrintStats);
            this.tabPage2.Controls.Add(this.buttonCharacterFileChoice);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.textCharFileLocation);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(418, 227);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // textCharFileLocation
            // 
            this.textCharFileLocation.Location = new System.Drawing.Point(9, 35);
            this.textCharFileLocation.Name = "textCharFileLocation";
            this.textCharFileLocation.Size = new System.Drawing.Size(100, 20);
            this.textCharFileLocation.TabIndex = 0;
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
            // buttonPrintStats
            // 
            this.buttonPrintStats.Location = new System.Drawing.Point(294, 19);
            this.buttonPrintStats.Name = "buttonPrintStats";
            this.buttonPrintStats.Size = new System.Drawing.Size(75, 23);
            this.buttonPrintStats.TabIndex = 3;
            this.buttonPrintStats.Text = "Print Stats";
            this.buttonPrintStats.UseVisualStyleBackColor = true;
            this.buttonPrintStats.Click += new System.EventHandler(this.buttonPrintStats_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(450, 277);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DiceRoll";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxModifier;
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
    }
}

