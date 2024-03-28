namespace Innovatron
{
    partial class MainForm
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
            newGameBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // newGameBtn
            // 
            newGameBtn.BackColor = Color.Transparent;
            newGameBtn.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            newGameBtn.ForeColor = SystemColors.ActiveCaptionText;
            newGameBtn.Location = new Point(369, 219);
            newGameBtn.Margin = new Padding(4);
            newGameBtn.Name = "newGameBtn";
            newGameBtn.Size = new Size(157, 74);
            newGameBtn.TabIndex = 0;
            newGameBtn.Text = "Start new \r\nGame";
            newGameBtn.UseVisualStyleBackColor = false;
            newGameBtn.Click += newGameBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(316, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(247, 46);
            label1.TabIndex = 1;
            label1.Text = "Welcome to:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Snap ITC", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(226, 84);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(413, 61);
            label2.TabIndex = 2;
            label2.Text = "INNOVATRON";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 517);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(newGameBtn);
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "MainForm";
            FormClosed += onFormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button newGameBtn;
        private Label label1;
        private Label label2;
    }
}