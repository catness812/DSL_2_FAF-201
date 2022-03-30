namespace GraphicsForLDSL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Draw = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Hide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Draw
            // 
            this.Draw.Location = new System.Drawing.Point(137, 86);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(75, 23);
            this.Draw.TabIndex = 0;
            this.Draw.Text = "Draw";
            this.Draw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Draw.UseVisualStyleBackColor = true;
            this.Draw.Click += new System.EventHandler(this.Draw_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(225, 292);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(128, 55);
            this.Reset.TabIndex = 1;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Hide
            // 
            this.Hide.Location = new System.Drawing.Point(91, 197);
            this.Hide.Name = "Hide";
            this.Hide.Size = new System.Drawing.Size(98, 47);
            this.Hide.TabIndex = 2;
            this.Hide.Text = "Hide";
            this.Hide.UseVisualStyleBackColor = true;
            this.Hide.Click += new System.EventHandler(this.Hide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 470);
            this.Controls.Add(this.Hide);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Draw);
            this.Name = "Form1";
            this.Text = "Turtle Graphics";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Draw;
        private Button Reset;
        private Button Hide;
    }
}