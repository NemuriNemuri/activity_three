namespace ActivityThreeApplication
{
    partial class SurveyForm
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
            this.firstChoice1 = new System.Windows.Forms.CheckBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.questionLabel1 = new System.Windows.Forms.Label();
            this.firstChoice2 = new System.Windows.Forms.CheckBox();
            this.firstChoice3 = new System.Windows.Forms.CheckBox();
            this.firstChoice4 = new System.Windows.Forms.CheckBox();
            this.othersLabel = new System.Windows.Forms.Label();
            this.othersField = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.firstChoiceOthers = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // firstChoice1
            // 
            this.firstChoice1.AutoSize = true;
            this.firstChoice1.Location = new System.Drawing.Point(41, 130);
            this.firstChoice1.Name = "firstChoice1";
            this.firstChoice1.Size = new System.Drawing.Size(55, 17);
            this.firstChoice1.TabIndex = 0;
            this.firstChoice1.Text = "Japan";
            this.firstChoice1.UseVisualStyleBackColor = true;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(139, 46);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(92, 29);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Survey";
            // 
            // questionLabel1
            // 
            this.questionLabel1.AutoSize = true;
            this.questionLabel1.Location = new System.Drawing.Point(38, 104);
            this.questionLabel1.Name = "questionLabel1";
            this.questionLabel1.Size = new System.Drawing.Size(191, 13);
            this.questionLabel1.TabIndex = 2;
            this.questionLabel1.Text = "Which country would you like to go to?";
            // 
            // firstChoice2
            // 
            this.firstChoice2.AutoSize = true;
            this.firstChoice2.Location = new System.Drawing.Point(41, 153);
            this.firstChoice2.Name = "firstChoice2";
            this.firstChoice2.Size = new System.Drawing.Size(76, 17);
            this.firstChoice2.TabIndex = 3;
            this.firstChoice2.Text = "Philippines";
            this.firstChoice2.UseVisualStyleBackColor = true;
            // 
            // firstChoice3
            // 
            this.firstChoice3.AutoSize = true;
            this.firstChoice3.Location = new System.Drawing.Point(134, 130);
            this.firstChoice3.Name = "firstChoice3";
            this.firstChoice3.Size = new System.Drawing.Size(67, 17);
            this.firstChoice3.TabIndex = 4;
            this.firstChoice3.Text = "Thailand";
            this.firstChoice3.UseVisualStyleBackColor = true;
            // 
            // firstChoice4
            // 
            this.firstChoice4.AutoSize = true;
            this.firstChoice4.Location = new System.Drawing.Point(134, 153);
            this.firstChoice4.Name = "firstChoice4";
            this.firstChoice4.Size = new System.Drawing.Size(66, 17);
            this.firstChoice4.TabIndex = 5;
            this.firstChoice4.Text = "Australia";
            this.firstChoice4.UseVisualStyleBackColor = true;
            // 
            // othersLabel
            // 
            this.othersLabel.AutoSize = true;
            this.othersLabel.BackColor = System.Drawing.Color.Transparent;
            this.othersLabel.Location = new System.Drawing.Point(38, 206);
            this.othersLabel.Name = "othersLabel";
            this.othersLabel.Size = new System.Drawing.Size(114, 13);
            this.othersLabel.TabIndex = 6;
            this.othersLabel.Text = "Others, please specify:";
            this.othersLabel.Visible = false;
            // 
            // othersField
            // 
            this.othersField.Location = new System.Drawing.Point(41, 222);
            this.othersField.Name = "othersField";
            this.othersField.Size = new System.Drawing.Size(176, 20);
            this.othersField.TabIndex = 7;
            this.othersField.Visible = false;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(100, 278);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 8;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(181, 278);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 10;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // firstChoiceOthers
            // 
            this.firstChoiceOthers.AutoSize = true;
            this.firstChoiceOthers.Location = new System.Drawing.Point(86, 176);
            this.firstChoiceOthers.Name = "firstChoiceOthers";
            this.firstChoiceOthers.Size = new System.Drawing.Size(57, 17);
            this.firstChoiceOthers.TabIndex = 11;
            this.firstChoiceOthers.Text = "Others";
            this.firstChoiceOthers.UseVisualStyleBackColor = true;
            this.firstChoiceOthers.CheckedChanged += new System.EventHandler(this.firstChoiceOthers_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ActivityThreeApplication.Properties.Resources.hachunemiku;
            this.pictureBox1.Location = new System.Drawing.Point(167, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // SurveyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(370, 334);
            this.Controls.Add(this.firstChoiceOthers);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.othersField);
            this.Controls.Add(this.othersLabel);
            this.Controls.Add(this.firstChoice4);
            this.Controls.Add(this.firstChoice3);
            this.Controls.Add(this.firstChoice2);
            this.Controls.Add(this.questionLabel1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.firstChoice1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SurveyForm";
            this.Text = "Survey Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox firstChoice1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label questionLabel1;
        private System.Windows.Forms.CheckBox firstChoice2;
        private System.Windows.Forms.CheckBox firstChoice3;
        private System.Windows.Forms.CheckBox firstChoice4;
        private System.Windows.Forms.Label othersLabel;
        private System.Windows.Forms.TextBox othersField;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.CheckBox firstChoiceOthers;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

