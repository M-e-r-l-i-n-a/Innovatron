namespace Innovatron
{
    partial class GetHelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetHelpForm));
            label1 = new Label();
            label2 = new Label();
            CloseHelpFormBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(312, 27);
            label1.Name = "label1";
            label1.Size = new Size(186, 23);
            label1.TabIndex = 0;
            label1.Text = "TUTORIAL: How to play";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 101);
            label2.Name = "label2";
            label2.Size = new Size(678, 207);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            // 
            // CloseHelpFormBtn
            // 
            CloseHelpFormBtn.BackColor = Color.Transparent;
            CloseHelpFormBtn.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CloseHelpFormBtn.Location = new Point(338, 341);
            CloseHelpFormBtn.Name = "CloseHelpFormBtn";
            CloseHelpFormBtn.Size = new Size(94, 41);
            CloseHelpFormBtn.TabIndex = 2;
            CloseHelpFormBtn.Text = "OK";
            CloseHelpFormBtn.UseVisualStyleBackColor = false;
            CloseHelpFormBtn.Click += CloseHelpFormBtn_Click;
            // 
            // GetHelpForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CloseHelpFormBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GetHelpForm";
            Text = "GetHelpForm";
            FormClosed += GetHelpForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button CloseHelpFormBtn;
    }
}