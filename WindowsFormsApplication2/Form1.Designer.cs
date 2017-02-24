namespace WindowsFormsApplication2
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
            this.Rabbit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Rabbit
            // 
            this.Rabbit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Rabbit.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rabbit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(230)))));
            this.Rabbit.Location = new System.Drawing.Point(565, 353);
            this.Rabbit.Name = "Rabbit";
            this.Rabbit.Size = new System.Drawing.Size(440, 314);
            this.Rabbit.TabIndex = 0;
            this.Rabbit.Text = "RabbIT";
            this.Rabbit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Rabbit.UseVisualStyleBackColor = false;
            this.Rabbit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Rabbit_MouseDown);
            this.Rabbit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Rabbit_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(62)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(1589, 949);
            this.Controls.Add(this.Rabbit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Rabbit;
    }
}

