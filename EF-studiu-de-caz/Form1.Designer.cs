namespace EF_studiu_de_caz
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
            this.getAllButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.addButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getAllButton
            // 
            this.getAllButton.Location = new System.Drawing.Point(481, 80);
            this.getAllButton.Name = "getAllButton";
            this.getAllButton.Size = new System.Drawing.Size(75, 23);
            this.getAllButton.TabIndex = 0;
            this.getAllButton.Text = "GetAll";
            this.getAllButton.UseVisualStyleBackColor = true;
            this.getAllButton.Click += new System.EventHandler(this.getAllButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(71, 80);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(45, 17);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(156, 80);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 22);
            this.nameBox.TabIndex = 2;
            // 
            // addButon
            // 
            this.addButon.Location = new System.Drawing.Point(109, 138);
            this.addButon.Name = "addButon";
            this.addButon.Size = new System.Drawing.Size(75, 23);
            this.addButon.TabIndex = 3;
            this.addButon.Text = "Add";
            this.addButon.UseVisualStyleBackColor = true;
            this.addButon.Click += new System.EventHandler(this.addButon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addButon);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.getAllButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getAllButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button addButon;
    }
}

