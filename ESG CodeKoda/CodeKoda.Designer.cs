namespace ESG_CodeKoda
{
    partial class CodeKoda
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
            btnAdd = new Button();
            txtNumbers = new TextBox();
            txtResult = new TextBox();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(299, 100);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 32);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtNumbers
            // 
            txtNumbers.Location = new Point(12, 14);
            txtNumbers.Multiline = true;
            txtNumbers.Name = "txtNumbers";
            txtNumbers.Size = new Size(362, 49);
            txtNumbers.TabIndex = 1;
            txtNumbers.Text = "//[|||][*]\r\n1|||2*3\r\n";
            // 
            // txtResult
            // 
            txtResult.Location = new Point(12, 71);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(362, 23);
            txtResult.TabIndex = 2;
            // 
            // CodeKoda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 150);
            Controls.Add(txtResult);
            Controls.Add(txtNumbers);
            Controls.Add(btnAdd);
            Name = "CodeKoda";
            Text = "Code Koda";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private TextBox txtNumbers;
        private TextBox txtResult;
    }
}
