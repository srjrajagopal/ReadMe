namespace ReadMe
{
    partial class TextReader
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.lblFLongest = new System.Windows.Forms.Label();
            this.lblSLongest = new System.Windows.Forms.Label();
            this.lblTotalWords = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblThird = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(361, 36);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(30, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtFilePath.Location = new System.Drawing.Point(21, 37);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(334, 20);
            this.txtFilePath.TabIndex = 1;
            this.txtFilePath.Text = "Select the input text file (only .txt format is supported)";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(206, 9);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 2;
            // 
            // lblFLongest
            // 
            this.lblFLongest.AutoSize = true;
            this.lblFLongest.Location = new System.Drawing.Point(38, 82);
            this.lblFLongest.Name = "lblFLongest";
            this.lblFLongest.Size = new System.Drawing.Size(102, 13);
            this.lblFLongest.TabIndex = 3;
            this.lblFLongest.Text = "First Longest Word :";
            // 
            // lblSLongest
            // 
            this.lblSLongest.AutoSize = true;
            this.lblSLongest.Location = new System.Drawing.Point(21, 116);
            this.lblSLongest.Name = "lblSLongest";
            this.lblSLongest.Size = new System.Drawing.Size(120, 13);
            this.lblSLongest.TabIndex = 4;
            this.lblSLongest.Text = "Second Longest Word :";
            // 
            // lblTotalWords
            // 
            this.lblTotalWords.AutoSize = true;
            this.lblTotalWords.Location = new System.Drawing.Point(28, 151);
            this.lblTotalWords.Name = "lblTotalWords";
            this.lblTotalWords.Size = new System.Drawing.Size(112, 13);
            this.lblTotalWords.TabIndex = 5;
            this.lblTotalWords.Text = "Total Longest Words :";
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirst.Location = new System.Drawing.Point(149, 83);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(0, 13);
            this.lblFirst.TabIndex = 6;
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecond.Location = new System.Drawing.Point(149, 116);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(0, 13);
            this.lblSecond.TabIndex = 7;
            // 
            // lblThird
            // 
            this.lblThird.AutoSize = true;
            this.lblThird.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThird.Location = new System.Drawing.Point(149, 151);
            this.lblThird.Name = "lblThird";
            this.lblThird.Size = new System.Drawing.Size(0, 13);
            this.lblThird.TabIndex = 8;
            // 
            // TextReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 183);
            this.Controls.Add(this.lblThird);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.lblTotalWords);
            this.Controls.Add(this.lblSLongest);
            this.Controls.Add(this.lblFLongest);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnBrowse);
            this.Name = "TextReader";
            this.Text = "ReadMe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblFLongest;
        private System.Windows.Forms.Label lblSLongest;
        private System.Windows.Forms.Label lblTotalWords;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblThird;
    }
}

