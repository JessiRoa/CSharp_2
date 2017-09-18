namespace StorytellerWindowsApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numAgeOfChild = new System.Windows.Forms.NumericUpDown();
            this.checkBoxScary = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textStory = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numAgeOfChild)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of Child";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Age of Child\r\n";
            // 
            // numAgeOfChild
            // 
            this.numAgeOfChild.Location = new System.Drawing.Point(15, 69);
            this.numAgeOfChild.Name = "numAgeOfChild";
            this.numAgeOfChild.Size = new System.Drawing.Size(120, 20);
            this.numAgeOfChild.TabIndex = 3;
            // 
            // checkBoxScary
            // 
            this.checkBoxScary.AutoSize = true;
            this.checkBoxScary.Location = new System.Drawing.Point(18, 96);
            this.checkBoxScary.Name = "checkBoxScary";
            this.checkBoxScary.Size = new System.Drawing.Size(102, 17);
            this.checkBoxScary.TabIndex = 4;
            this.checkBoxScary.Text = "Should be scary";
            this.checkBoxScary.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Tell story!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textStory
            // 
            this.textStory.Location = new System.Drawing.Point(12, 197);
            this.textStory.Multiline = true;
            this.textStory.Name = "textStory";
            this.textStory.Size = new System.Drawing.Size(530, 157);
            this.textStory.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 375);
            this.Controls.Add(this.textStory);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxScary);
            this.Controls.Add(this.numAgeOfChild);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Storyteller";
            ((System.ComponentModel.ISupportInitialize)(this.numAgeOfChild)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numAgeOfChild;
        private System.Windows.Forms.CheckBox checkBoxScary;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textStory;
    }
}

