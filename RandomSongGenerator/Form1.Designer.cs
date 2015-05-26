namespace RandomSongGenerator
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
            this.PlayButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tempoInput = new System.Windows.Forms.NumericUpDown();
            this.PlaySeptatonicScale = new System.Windows.Forms.Button();
            this.RandomButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tempoInput)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.Location = new System.Drawing.Point(68, 40);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(180, 77);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.Text = "Play Mary...";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayMaryButton);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(68, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 92);
            this.button1.TabIndex = 1;
            this.button1.Text = "Play Smoke...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.PlaySmokeButton_Click);
            // 
            // tempoInput
            // 
            this.tempoInput.Location = new System.Drawing.Point(359, 40);
            this.tempoInput.Name = "tempoInput";
            this.tempoInput.Size = new System.Drawing.Size(120, 20);
            this.tempoInput.TabIndex = 2;
            // 
            // PlaySeptatonicScale
            // 
            this.PlaySeptatonicScale.Location = new System.Drawing.Point(350, 160);
            this.PlaySeptatonicScale.Name = "PlaySeptatonicScale";
            this.PlaySeptatonicScale.Size = new System.Drawing.Size(75, 23);
            this.PlaySeptatonicScale.TabIndex = 3;
            this.PlaySeptatonicScale.Text = "PlayScale";
            this.PlaySeptatonicScale.UseVisualStyleBackColor = true;
            this.PlaySeptatonicScale.Click += new System.EventHandler(this.PlaySeptatonicScale_Click);
            // 
            // RandomButton
            // 
            this.RandomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomButton.Location = new System.Drawing.Point(350, 236);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(160, 92);
            this.RandomButton.TabIndex = 4;
            this.RandomButton.Text = "Scale randomized";
            this.RandomButton.UseVisualStyleBackColor = true;
            this.RandomButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 386);
            this.Controls.Add(this.RandomButton);
            this.Controls.Add(this.PlaySeptatonicScale);
            this.Controls.Add(this.tempoInput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PlayButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tempoInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown tempoInput;
        private System.Windows.Forms.Button PlaySeptatonicScale;
        private System.Windows.Forms.Button RandomButton;
    }
}

