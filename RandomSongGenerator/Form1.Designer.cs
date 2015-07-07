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
            this.components = new System.ComponentModel.Container();
            this.PlayButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tempoInput = new System.Windows.Forms.NumericUpDown();
            this.PlaySeptatonicScale = new System.Windows.Forms.Button();
            this.RandomButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.ScaleOptions = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tempoInput)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.Location = new System.Drawing.Point(68, 40);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(121, 38);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.Text = "Play Mary...";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayMaryButton);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(68, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Play Smoke...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.PlaySmokeButton_Click);
            // 
            // tempoInput
            // 
            this.tempoInput.Location = new System.Drawing.Point(253, 40);
            this.tempoInput.Name = "tempoInput";
            this.tempoInput.Size = new System.Drawing.Size(120, 20);
            this.tempoInput.TabIndex = 2;
            // 
            // PlaySeptatonicScale
            // 
            this.PlaySeptatonicScale.Location = new System.Drawing.Point(68, 180);
            this.PlaySeptatonicScale.Name = "PlaySeptatonicScale";
            this.PlaySeptatonicScale.Size = new System.Drawing.Size(121, 32);
            this.PlaySeptatonicScale.TabIndex = 3;
            this.PlaySeptatonicScale.Text = "PlayScale";
            this.PlaySeptatonicScale.UseVisualStyleBackColor = true;
            this.PlaySeptatonicScale.Click += new System.EventHandler(this.PlayScale_Click);
            // 
            // RandomButton
            // 
            this.RandomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomButton.Location = new System.Drawing.Point(68, 236);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(145, 35);
            this.RandomButton.TabIndex = 4;
            this.RandomButton.Text = "Scale randomized";
            this.RandomButton.UseVisualStyleBackColor = true;
            this.RandomButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(585, 236);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(152, 92);
            this.StopButton.TabIndex = 5;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // ScaleOptions
            // 
            this.ScaleOptions.FormattingEnabled = true;
            this.ScaleOptions.Location = new System.Drawing.Point(389, 40);
            this.ScaleOptions.Name = "ScaleOptions";
            this.ScaleOptions.Size = new System.Drawing.Size(419, 108);
            this.ScaleOptions.TabIndex = 6;
            this.ScaleOptions.DoubleClick += new System.EventHandler(this.ScaleOptions_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ChosenScale";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Timer";
            this.label2.Click += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 386);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ScaleOptions);
            this.Controls.Add(this.StopButton);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown tempoInput;
        private System.Windows.Forms.Button PlaySeptatonicScale;
        private System.Windows.Forms.Button RandomButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.ListBox ScaleOptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}

