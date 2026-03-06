namespace Домашня_робота
{
    partial class ExitForm
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
            btnExit = new Button();
            btnStay = new Button();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(69, 152);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(72, 59);
            btnExit.TabIndex = 0;
            btnExit.Text = "Хoчу вийти";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnStay
            // 
            btnStay.Location = new Point(216, 152);
            btnStay.Name = "btnStay";
            btnStay.Size = new Size(85, 59);
            btnStay.TabIndex = 0;
            btnStay.Text = "Залишитись в програмі";
            btnStay.UseVisualStyleBackColor = true;
            btnStay.Click += btnExit_Click;
            // 
            // ExitForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 340);
            Controls.Add(btnStay);
            Controls.Add(btnExit);
            Name = "ExitForm";
            Text = "ExitForm";
            Load += ExitForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit;
        private Button btnStay;
    }
}