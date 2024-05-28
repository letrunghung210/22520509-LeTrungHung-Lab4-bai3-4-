namespace Lab4_webserver
{
    partial class Menu
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
            this.btnBai3 = new System.Windows.Forms.Button();
            this.btnBai4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBai3
            // 
            this.btnBai3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBai3.Location = new System.Drawing.Point(185, 159);
            this.btnBai3.Name = "btnBai3";
            this.btnBai3.Size = new System.Drawing.Size(71, 39);
            this.btnBai3.TabIndex = 3;
            this.btnBai3.Text = "Bài 3";
            this.btnBai3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBai3.UseVisualStyleBackColor = true;
            this.btnBai3.Click += new System.EventHandler(this.btnBai3_Click);
            // 
            // btnBai4
            // 
            this.btnBai4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBai4.Location = new System.Drawing.Point(377, 159);
            this.btnBai4.Name = "btnBai4";
            this.btnBai4.Size = new System.Drawing.Size(71, 39);
            this.btnBai4.TabIndex = 4;
            this.btnBai4.Text = "Bài 4";
            this.btnBai4.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBai4.UseVisualStyleBackColor = true;
            this.btnBai4.Click += new System.EventHandler(this.btnBai4_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 590);
            this.Controls.Add(this.btnBai4);
            this.Controls.Add(this.btnBai3);
            this.Name = "Menu";
            this.Text = "Lab4";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBai3;
        private System.Windows.Forms.Button btnBai4;
    }
}

