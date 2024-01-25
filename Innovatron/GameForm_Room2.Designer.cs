namespace Innovatron
{
    partial class GameForm_Room2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm_Room2));
            door = new PictureBox();
            key = new PictureBox();
            roboter = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)door).BeginInit();
            ((System.ComponentModel.ISupportInitialize)key).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roboter).BeginInit();
            SuspendLayout();
            // 
            // door
            // 
            door.BackColor = Color.Transparent;
            door.Image = (Image)resources.GetObject("door.Image");
            door.Location = new Point(25, 189);
            door.Margin = new Padding(2);
            door.Name = "door";
            door.Size = new Size(238, 224);
            door.SizeMode = PictureBoxSizeMode.AutoSize;
            door.TabIndex = 5;
            door.TabStop = false;
            door.Tag = "door";
            // 
            // key
            // 
            key.BackColor = Color.Transparent;
            key.Image = (Image)resources.GetObject("key.Image");
            key.Location = new Point(684, 324);
            key.Margin = new Padding(2);
            key.Name = "key";
            key.Size = new Size(40, 21);
            key.SizeMode = PictureBoxSizeMode.AutoSize;
            key.TabIndex = 4;
            key.TabStop = false;
            key.Tag = "key";
            // 
            // roboter
            // 
            roboter.BackColor = Color.Transparent;
            roboter.Image = (Image)resources.GetObject("roboter.Image");
            roboter.Location = new Point(370, 296);
            roboter.Margin = new Padding(2);
            roboter.Name = "roboter";
            roboter.Size = new Size(83, 83);
            roboter.SizeMode = PictureBoxSizeMode.AutoSize;
            roboter.TabIndex = 3;
            roboter.TabStop = false;
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += moveTimerEvent;
            // 
            // GameForm_Room2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(key);
            Controls.Add(roboter);
            Controls.Add(door);
            Name = "GameForm_Room2";
            Text = "GameForm_Room2";
            FormClosed += GameForm_Room2_FormClosed;
            Load += GameForm_Room2_Load_1;
            KeyDown += GameForm_Room2_KeyDown;
            KeyUp += GameForm_Room2_KeyUp;
            ((System.ComponentModel.ISupportInitialize)door).EndInit();
            ((System.ComponentModel.ISupportInitialize)key).EndInit();
            ((System.ComponentModel.ISupportInitialize)roboter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox door;
        private PictureBox key;
        private PictureBox roboter;
        private System.Windows.Forms.Timer gameTimer;
    }
}