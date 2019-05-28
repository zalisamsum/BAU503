namespace AdoGiris
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
            this.btnSqlBaglan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSqlBaglan
            // 
            this.btnSqlBaglan.Location = new System.Drawing.Point(301, 151);
            this.btnSqlBaglan.Name = "btnSqlBaglan";
            this.btnSqlBaglan.Size = new System.Drawing.Size(160, 83);
            this.btnSqlBaglan.TabIndex = 0;
            this.btnSqlBaglan.Text = "SQL\'e Bağlan";
            this.btnSqlBaglan.UseVisualStyleBackColor = true;
            this.btnSqlBaglan.Click += new System.EventHandler(this.btnSqlBaglan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSqlBaglan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSqlBaglan;
    }
}

