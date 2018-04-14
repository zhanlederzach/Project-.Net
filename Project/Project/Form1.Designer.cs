namespace Project
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
            this.components = new System.ComponentModel.Container();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonAdd = new System.Windows.Forms.Button();
            this.radioButtonBreakfast = new System.Windows.Forms.RadioButton();
            this.radioButtonLunch = new System.Windows.Forms.RadioButton();
            this.radioButtonDinner = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxBreakfast = new System.Windows.Forms.ListBox();
            this.listBoxLunch = new System.Windows.Forms.ListBox();
            this.listBoxDinner = new System.Windows.Forms.ListBox();
            this.buttonAnalyze = new System.Windows.Forms.Button();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(268, 48);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(147, 26);
            this.textBoxInput.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(74, 4);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(434, 48);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(62, 42);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.btnAddClick);
            // 
            // radioButtonBreakfast
            // 
            this.radioButtonBreakfast.AutoSize = true;
            this.radioButtonBreakfast.Location = new System.Drawing.Point(6, 44);
            this.radioButtonBreakfast.Name = "radioButtonBreakfast";
            this.radioButtonBreakfast.Size = new System.Drawing.Size(103, 24);
            this.radioButtonBreakfast.TabIndex = 3;
            this.radioButtonBreakfast.TabStop = true;
            this.radioButtonBreakfast.Text = "Breakfast";
            this.radioButtonBreakfast.UseVisualStyleBackColor = true;
            // 
            // radioButtonLunch
            // 
            this.radioButtonLunch.AutoSize = true;
            this.radioButtonLunch.Location = new System.Drawing.Point(128, 44);
            this.radioButtonLunch.Name = "radioButtonLunch";
            this.radioButtonLunch.Size = new System.Drawing.Size(78, 24);
            this.radioButtonLunch.TabIndex = 4;
            this.radioButtonLunch.TabStop = true;
            this.radioButtonLunch.Text = "Lunch";
            this.radioButtonLunch.UseVisualStyleBackColor = true;
            // 
            // radioButtonDinner
            // 
            this.radioButtonDinner.AutoSize = true;
            this.radioButtonDinner.Location = new System.Drawing.Point(224, 43);
            this.radioButtonDinner.Name = "radioButtonDinner";
            this.radioButtonDinner.Size = new System.Drawing.Size(81, 24);
            this.radioButtonDinner.TabIndex = 5;
            this.radioButtonDinner.TabStop = true;
            this.radioButtonDinner.Text = "Dinner";
            this.radioButtonDinner.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonBreakfast);
            this.groupBox1.Controls.Add(this.radioButtonLunch);
            this.groupBox1.Controls.Add(this.radioButtonDinner);
            this.groupBox1.Location = new System.Drawing.Point(535, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 88);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose time";
            // 
            // listBoxBreakfast
            // 
            this.listBoxBreakfast.FormattingEnabled = true;
            this.listBoxBreakfast.ItemHeight = 20;
            this.listBoxBreakfast.Location = new System.Drawing.Point(535, 163);
            this.listBoxBreakfast.Name = "listBoxBreakfast";
            this.listBoxBreakfast.Size = new System.Drawing.Size(109, 124);
            this.listBoxBreakfast.TabIndex = 7;
            // 
            // listBoxLunch
            // 
            this.listBoxLunch.FormattingEnabled = true;
            this.listBoxLunch.ItemHeight = 20;
            this.listBoxLunch.Location = new System.Drawing.Point(650, 163);
            this.listBoxLunch.Name = "listBoxLunch";
            this.listBoxLunch.Size = new System.Drawing.Size(109, 124);
            this.listBoxLunch.TabIndex = 8;
            // 
            // listBoxDinner
            // 
            this.listBoxDinner.FormattingEnabled = true;
            this.listBoxDinner.ItemHeight = 20;
            this.listBoxDinner.Location = new System.Drawing.Point(765, 163);
            this.listBoxDinner.Name = "listBoxDinner";
            this.listBoxDinner.Size = new System.Drawing.Size(109, 124);
            this.listBoxDinner.TabIndex = 9;
            // 
            // buttonAnalyze
            // 
            this.buttonAnalyze.Location = new System.Drawing.Point(535, 291);
            this.buttonAnalyze.Name = "buttonAnalyze";
            this.buttonAnalyze.Size = new System.Drawing.Size(339, 42);
            this.buttonAnalyze.TabIndex = 10;
            this.buttonAnalyze.Text = "Analyze";
            this.buttonAnalyze.UseVisualStyleBackColor = true;
            this.buttonAnalyze.Click += new System.EventHandler(this.btnAnalyzeClick);
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 20;
            this.listBoxResult.Location = new System.Drawing.Point(12, 339);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(1151, 124);
            this.listBoxResult.TabIndex = 11;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(1097, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(46, 37);
            this.buttonClose.TabIndex = 12;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.btnCloseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 545);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.buttonAnalyze);
            this.Controls.Add(this.listBoxDinner);
            this.Controls.Add(this.listBoxLunch);
            this.Controls.Add(this.listBoxBreakfast);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.RadioButton radioButtonBreakfast;
        private System.Windows.Forms.RadioButton radioButtonLunch;
        private System.Windows.Forms.RadioButton radioButtonDinner;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxBreakfast;
        private System.Windows.Forms.ListBox listBoxLunch;
        private System.Windows.Forms.ListBox listBoxDinner;
        private System.Windows.Forms.Button buttonAnalyze;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.Button buttonClose;
    }
}

