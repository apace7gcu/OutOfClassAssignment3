namespace OutOfClassAssignment3
{
    partial class FileReader
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
            this.opnFileDialogue = new System.Windows.Forms.OpenFileDialog();
            this.bttnReadFile = new System.Windows.Forms.Button();
            this.txtDisplayText = new System.Windows.Forms.RichTextBox();
            this.txtLongestWord = new System.Windows.Forms.TextBox();
            this.txtMostVowels = new System.Windows.Forms.TextBox();
            this.txtFirstWord = new System.Windows.Forms.TextBox();
            this.txtLastWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // opnFileDialogue
            // 
            this.opnFileDialogue.FileName = "opnFileDialogue";
            // 
            // bttnReadFile
            // 
            this.bttnReadFile.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bttnReadFile.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnReadFile.Location = new System.Drawing.Point(264, 12);
            this.bttnReadFile.Name = "bttnReadFile";
            this.bttnReadFile.Size = new System.Drawing.Size(289, 43);
            this.bttnReadFile.TabIndex = 1;
            this.bttnReadFile.Text = "Select Your File!";
            this.bttnReadFile.UseVisualStyleBackColor = false;
            this.bttnReadFile.Click += new System.EventHandler(this.bttnReadFile_Click);
            // 
            // txtDisplayText
            // 
            this.txtDisplayText.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtDisplayText.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplayText.Location = new System.Drawing.Point(212, 85);
            this.txtDisplayText.Name = "txtDisplayText";
            this.txtDisplayText.Size = new System.Drawing.Size(401, 155);
            this.txtDisplayText.TabIndex = 2;
            this.txtDisplayText.Text = "";
            // 
            // txtLongestWord
            // 
            this.txtLongestWord.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtLongestWord.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLongestWord.Location = new System.Drawing.Point(437, 246);
            this.txtLongestWord.Name = "txtLongestWord";
            this.txtLongestWord.Size = new System.Drawing.Size(157, 29);
            this.txtLongestWord.TabIndex = 3;
            // 
            // txtMostVowels
            // 
            this.txtMostVowels.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtMostVowels.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMostVowels.Location = new System.Drawing.Point(455, 294);
            this.txtMostVowels.Name = "txtMostVowels";
            this.txtMostVowels.Size = new System.Drawing.Size(158, 29);
            this.txtMostVowels.TabIndex = 4;
            // 
            // txtFirstWord
            // 
            this.txtFirstWord.BackColor = System.Drawing.SystemColors.Info;
            this.txtFirstWord.Location = new System.Drawing.Point(35, 64);
            this.txtFirstWord.Name = "txtFirstWord";
            this.txtFirstWord.Size = new System.Drawing.Size(140, 29);
            this.txtFirstWord.TabIndex = 5;
            // 
            // txtLastWord
            // 
            this.txtLastWord.BackColor = System.Drawing.SystemColors.Info;
            this.txtLastWord.Location = new System.Drawing.Point(197, 64);
            this.txtLastWord.Name = "txtLastWord";
            this.txtLastWord.Size = new System.Drawing.Size(141, 29);
            this.txtLastWord.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Text, in lowercase:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Longest Word: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Word with the Most Vowels:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "First Word:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Last Word:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFirstWord);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtLastWord);
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(229, 338);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 100);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sorted Alphabetically:";
            // 
            // FileReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMostVowels);
            this.Controls.Add(this.txtLongestWord);
            this.Controls.Add(this.txtDisplayText);
            this.Controls.Add(this.bttnReadFile);
            this.Name = "FileReader";
            this.Text = "Welcome to File Reader!";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog opnFileDialogue;
        private System.Windows.Forms.Button bttnReadFile;
        private System.Windows.Forms.RichTextBox txtDisplayText;
        private System.Windows.Forms.TextBox txtLongestWord;
        private System.Windows.Forms.TextBox txtMostVowels;
        private System.Windows.Forms.TextBox txtFirstWord;
        private System.Windows.Forms.TextBox txtLastWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

