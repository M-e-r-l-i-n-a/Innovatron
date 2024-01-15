namespace Innovatron
{
    partial class GameForm
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
            goBackBtn = new Button();
            SuspendLayout();
            // 
            // goBackBtn
            // 
            goBackBtn.Location = new Point(12, 12);
            goBackBtn.Name = "goBackBtn";
            goBackBtn.Size = new Size(165, 29);
            goBackBtn.TabIndex = 0;
            goBackBtn.Text = "Go back to the Menu";
            goBackBtn.UseVisualStyleBackColor = true;
            goBackBtn.Click += goBackBtn_Click;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(goBackBtn);
            Name = "GameForm";
            Text = "GameForm";
            ResumeLayout(false);
        }

        #endregion

        private Button goBackBtn;
    }
}