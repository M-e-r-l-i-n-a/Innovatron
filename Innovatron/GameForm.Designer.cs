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
            components = new System.ComponentModel.Container();
            moveTimer = new System.Windows.Forms.Timer(components);
            player = new PictureBox();
            key = new PictureBox();
            ActionsList = new ListBox();
            button1 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)key).BeginInit();
            SuspendLayout();
            // 
            // moveTimer
            // 
            moveTimer.Enabled = true;
            moveTimer.Interval = 20;
            moveTimer.Tick += moveTimerEvent;
            // 
            // player
            // 
            player.BackColor = SystemColors.ActiveCaption;
            player.Location = new Point(457, 269);
            player.Name = "player";
            player.Size = new Size(75, 75);
            player.TabIndex = 0;
            player.TabStop = false;
            // 
            // key
            // 
            key.BackColor = SystemColors.Info;
            key.Location = new Point(229, 269);
            key.Name = "key";
            key.Size = new Size(75, 75);
            key.TabIndex = 1;
            key.TabStop = false;
            // 
            // ActionsList
            // 
            ActionsList.FormattingEnabled = true;
            ActionsList.ItemHeight = 25;
            ActionsList.Location = new Point(405, 12);
            ActionsList.Name = "ActionsList";
            ActionsList.Size = new Size(180, 129);
            ActionsList.TabIndex = 2;
            ActionsList.KeyDown += KeyDownList;
            // 
            // button1
            // 
            button1.Location = new Point(591, 12);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 3;
            button1.Text = "select";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(255, 12);
            label1.Name = "label1";
            label1.Size = new Size(144, 25);
            label1.TabIndex = 4;
            label1.Text = " Select an action:";
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(ActionsList);
            Controls.Add(key);
            Controls.Add(player);
            Margin = new Padding(4);
            Name = "GameForm";
            Text = "GameForm";
            FormClosed += GameForm_FormClosed;
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)key).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer moveTimer;
        private PictureBox player;
        private PictureBox key;
        private ListBox ActionsList;
        private Button button1;
        private Label label1;
    }
}