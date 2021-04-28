
namespace ChuckNorrisForm
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
            this.generateJokeCmd = new System.Windows.Forms.Button();
            this.jokeIdTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.categoriesTxt = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.jokeDescriptionTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // generateJokeCmd
            // 
            this.generateJokeCmd.Location = new System.Drawing.Point(267, 257);
            this.generateJokeCmd.Name = "generateJokeCmd";
            this.generateJokeCmd.Size = new System.Drawing.Size(138, 71);
            this.generateJokeCmd.TabIndex = 0;
            this.generateJokeCmd.Text = "Chuck Button";
            this.generateJokeCmd.UseVisualStyleBackColor = true;
            // 
            // jokeIdTxt
            // 
            this.jokeIdTxt.Location = new System.Drawing.Point(267, 129);
            this.jokeIdTxt.Name = "jokeIdTxt";
            this.jokeIdTxt.Size = new System.Drawing.Size(84, 22);
            this.jokeIdTxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Joke ID:";
            // 
            // categoriesTxt
            // 
            this.categoriesTxt.FormattingEnabled = true;
            this.categoriesTxt.Location = new System.Drawing.Point(267, 186);
            this.categoriesTxt.Name = "categoriesTxt";
            this.categoriesTxt.Size = new System.Drawing.Size(138, 24);
            this.categoriesTxt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Categories";
            // 
            // jokeDescriptionTxt
            // 
            this.jokeDescriptionTxt.Location = new System.Drawing.Point(494, 126);
            this.jokeDescriptionTxt.Multiline = true;
            this.jokeDescriptionTxt.Name = "jokeDescriptionTxt";
            this.jokeDescriptionTxt.Size = new System.Drawing.Size(252, 132);
            this.jokeDescriptionTxt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(491, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "The Joke";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.jokeDescriptionTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.categoriesTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jokeIdTxt);
            this.Controls.Add(this.generateJokeCmd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateJokeCmd;
        private System.Windows.Forms.TextBox jokeIdTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox categoriesTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox jokeDescriptionTxt;
        private System.Windows.Forms.Label label3;
    }
}

