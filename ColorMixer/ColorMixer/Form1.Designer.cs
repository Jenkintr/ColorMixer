namespace ColorMixer
{
    partial class colorMixer
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
            this.color1GroupBox = new System.Windows.Forms.GroupBox();
            this.color2GroupBox = new System.Windows.Forms.GroupBox();
            this.red1RadioButton = new System.Windows.Forms.RadioButton();
            this.yellow1RadioButton = new System.Windows.Forms.RadioButton();
            this.blue1RadioButton = new System.Windows.Forms.RadioButton();
            this.red2RadioButton = new System.Windows.Forms.RadioButton();
            this.yellow2RadioButton = new System.Windows.Forms.RadioButton();
            this.blue2RadioButton = new System.Windows.Forms.RadioButton();
            this.mixButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.color1GroupBox.SuspendLayout();
            this.color2GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // color1GroupBox
            // 
            this.color1GroupBox.Controls.Add(this.blue1RadioButton);
            this.color1GroupBox.Controls.Add(this.yellow1RadioButton);
            this.color1GroupBox.Controls.Add(this.red1RadioButton);
            this.color1GroupBox.Location = new System.Drawing.Point(12, 12);
            this.color1GroupBox.Name = "color1GroupBox";
            this.color1GroupBox.Size = new System.Drawing.Size(200, 100);
            this.color1GroupBox.TabIndex = 0;
            this.color1GroupBox.TabStop = false;
            this.color1GroupBox.Text = "Select the First Color";
            // 
            // color2GroupBox
            // 
            this.color2GroupBox.Controls.Add(this.blue2RadioButton);
            this.color2GroupBox.Controls.Add(this.yellow2RadioButton);
            this.color2GroupBox.Controls.Add(this.red2RadioButton);
            this.color2GroupBox.Location = new System.Drawing.Point(229, 12);
            this.color2GroupBox.Name = "color2GroupBox";
            this.color2GroupBox.Size = new System.Drawing.Size(200, 100);
            this.color2GroupBox.TabIndex = 1;
            this.color2GroupBox.TabStop = false;
            this.color2GroupBox.Text = "Select the Second Color";
            // 
            // red1RadioButton
            // 
            this.red1RadioButton.AutoSize = true;
            this.red1RadioButton.Location = new System.Drawing.Point(53, 22);
            this.red1RadioButton.Name = "red1RadioButton";
            this.red1RadioButton.Size = new System.Drawing.Size(45, 17);
            this.red1RadioButton.TabIndex = 0;
            this.red1RadioButton.TabStop = true;
            this.red1RadioButton.Text = "Red";
            this.red1RadioButton.UseVisualStyleBackColor = true;
            // 
            // yellow1RadioButton
            // 
            this.yellow1RadioButton.AutoSize = true;
            this.yellow1RadioButton.Location = new System.Drawing.Point(53, 46);
            this.yellow1RadioButton.Name = "yellow1RadioButton";
            this.yellow1RadioButton.Size = new System.Drawing.Size(56, 17);
            this.yellow1RadioButton.TabIndex = 1;
            this.yellow1RadioButton.TabStop = true;
            this.yellow1RadioButton.Text = "Yellow";
            this.yellow1RadioButton.UseVisualStyleBackColor = true;
            // 
            // blue1RadioButton
            // 
            this.blue1RadioButton.AutoSize = true;
            this.blue1RadioButton.Location = new System.Drawing.Point(53, 70);
            this.blue1RadioButton.Name = "blue1RadioButton";
            this.blue1RadioButton.Size = new System.Drawing.Size(46, 17);
            this.blue1RadioButton.TabIndex = 2;
            this.blue1RadioButton.TabStop = true;
            this.blue1RadioButton.Text = "Blue";
            this.blue1RadioButton.UseVisualStyleBackColor = true;
            // 
            // red2RadioButton
            // 
            this.red2RadioButton.AutoSize = true;
            this.red2RadioButton.Location = new System.Drawing.Point(53, 23);
            this.red2RadioButton.Name = "red2RadioButton";
            this.red2RadioButton.Size = new System.Drawing.Size(45, 17);
            this.red2RadioButton.TabIndex = 0;
            this.red2RadioButton.TabStop = true;
            this.red2RadioButton.Text = "Red";
            this.red2RadioButton.UseVisualStyleBackColor = true;
            // 
            // yellow2RadioButton
            // 
            this.yellow2RadioButton.AutoSize = true;
            this.yellow2RadioButton.Location = new System.Drawing.Point(53, 46);
            this.yellow2RadioButton.Name = "yellow2RadioButton";
            this.yellow2RadioButton.Size = new System.Drawing.Size(56, 17);
            this.yellow2RadioButton.TabIndex = 1;
            this.yellow2RadioButton.TabStop = true;
            this.yellow2RadioButton.Text = "Yellow";
            this.yellow2RadioButton.UseVisualStyleBackColor = true;
            // 
            // blue2RadioButton
            // 
            this.blue2RadioButton.AutoSize = true;
            this.blue2RadioButton.Location = new System.Drawing.Point(53, 69);
            this.blue2RadioButton.Name = "blue2RadioButton";
            this.blue2RadioButton.Size = new System.Drawing.Size(46, 17);
            this.blue2RadioButton.TabIndex = 2;
            this.blue2RadioButton.TabStop = true;
            this.blue2RadioButton.Text = "Blue";
            this.blue2RadioButton.UseVisualStyleBackColor = true;
            // 
            // mixButton
            // 
            this.mixButton.Location = new System.Drawing.Point(137, 118);
            this.mixButton.Name = "mixButton";
            this.mixButton.Size = new System.Drawing.Size(75, 23);
            this.mixButton.TabIndex = 2;
            this.mixButton.Text = "Mix Colors";
            this.mixButton.UseVisualStyleBackColor = true;
            this.mixButton.Click += new System.EventHandler(this.mixButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(228, 118);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // colorMixer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 149);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.mixButton);
            this.Controls.Add(this.color2GroupBox);
            this.Controls.Add(this.color1GroupBox);
            this.Name = "colorMixer";
            this.Text = "Color Mixer";
            this.color1GroupBox.ResumeLayout(false);
            this.color1GroupBox.PerformLayout();
            this.color2GroupBox.ResumeLayout(false);
            this.color2GroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button mixButton;
        private System.Windows.Forms.RadioButton red2RadioButton;
        private System.Windows.Forms.RadioButton yellow2RadioButton;
        private System.Windows.Forms.RadioButton blue2RadioButton;
        private System.Windows.Forms.GroupBox color2GroupBox;
        private System.Windows.Forms.RadioButton red1RadioButton;
        private System.Windows.Forms.RadioButton yellow1RadioButton;
        private System.Windows.Forms.RadioButton blue1RadioButton;
        private System.Windows.Forms.GroupBox color1GroupBox;
    }
}

