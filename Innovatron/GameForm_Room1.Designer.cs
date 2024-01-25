namespace Innovatron
{
    partial class GameForm_Room1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm_Room1));
            moveTimer = new System.Windows.Forms.Timer(components);
            roboter = new PictureBox();
            key = new PictureBox();
            door = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)roboter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)key).BeginInit();
            ((System.ComponentModel.ISupportInitialize)door).BeginInit();
            SuspendLayout();
            // 
            // moveTimer
            // 
            moveTimer.Enabled = true;
            moveTimer.Interval = 20;
            moveTimer.Tick += moveTimerEvent;
            // 
            // roboter
            // 
            roboter.BackColor = Color.Transparent;
            roboter.Image = (Image)resources.GetObject("roboter.Image");
            roboter.Location = new Point(275, 296);
            roboter.Margin = new Padding(2);
            roboter.Name = "roboter";
            roboter.Size = new Size(83, 83);
            roboter.SizeMode = PictureBoxSizeMode.AutoSize;
            roboter.TabIndex = 0;
            roboter.TabStop = false;
            roboter.Click += roboter_Click;
            // 
            // key
            // 
            key.BackColor = Color.Transparent;
            key.Image = (Image)resources.GetObject("key.Image");
            key.Location = new Point(692, 341);
            key.Margin = new Padding(2);
            key.Name = "key";
            key.Size = new Size(40, 21);
            key.SizeMode = PictureBoxSizeMode.AutoSize;
            key.TabIndex = 1;
            key.TabStop = false;
            key.Tag = "key";
            // 
            // door
            // 
            door.BackColor = Color.Transparent;
            door.Image = (Image)resources.GetObject("door.Image");
            door.Location = new Point(33, 206);
            door.Margin = new Padding(2);
            door.Name = "door";
            door.Size = new Size(238, 224);
            door.SizeMode = PictureBoxSizeMode.AutoSize;
            door.TabIndex = 2;
            door.TabStop = false;
            door.Tag = "door";
            // 
            // gameTimer
            // 
            gameTimer.Tick += moveTimerEvent;
            // 
            // GameForm_Room1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(key);
            Controls.Add(roboter);
            Controls.Add(door);
            Name = "GameForm_Room1";
            Text = "GameForm";
            FormClosed += GameForm_FormClosed;
            Load += GameForm_Load;
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)roboter).EndInit();
            ((System.ComponentModel.ISupportInitialize)key).EndInit();
            ((System.ComponentModel.ISupportInitialize)door).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer moveTimer;
        private PictureBox roboter;
        private PictureBox key;
        private PictureBox door;
        private System.Windows.Forms.Timer gameTimer;
    }
}