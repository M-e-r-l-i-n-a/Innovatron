namespace Innovatron
{
    partial class room1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(room1));
            moveTimer = new System.Windows.Forms.Timer(components);
            ActionsList = new ListBox();
            button1 = new Button();
            label1 = new Label();
            player = new PictureBox();
            helpbutton = new PictureBox();
            label2 = new Label();
            door1 = new PictureBox();
            key = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)helpbutton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)door1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)key).BeginInit();
            SuspendLayout();
            // 
            // moveTimer
            // 
            moveTimer.Enabled = true;
            moveTimer.Interval = 20;
            moveTimer.Tick += moveTimerEvent;
            // 
            // ActionsList
            // 
            ActionsList.FormattingEnabled = true;
            ActionsList.ItemHeight = 23;
            ActionsList.Location = new Point(364, 11);
            ActionsList.Margin = new Padding(2);
            ActionsList.Name = "ActionsList";
            ActionsList.Size = new Size(162, 119);
            ActionsList.TabIndex = 2;
            ActionsList.SelectedIndexChanged += this.ActionsList_SelectedIndexChanged;
            ActionsList.KeyDown += KeyDownList;
            // 
            // button1
            // 
            button1.Location = new Point(532, 11);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(101, 31);
            button1.TabIndex = 3;
            button1.Text = "select";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(230, 11);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(140, 23);
            label1.TabIndex = 4;
            label1.Text = " Select an action:";
            label1.Click += this.label1_Click;
            // 
            // player
            // 
            player.BackColor = Color.Transparent;
            player.Image = (Image)resources.GetObject("player.Image");
            player.Location = new Point(399, 331);
            player.Margin = new Padding(0);
            player.Name = "player";
            player.Size = new Size(69, 103);
            player.SizeMode = PictureBoxSizeMode.Zoom;
            player.TabIndex = 0;
            player.TabStop = false;
            player.Click += this.player_Click;
            // 
            // helpbutton
            // 
            helpbutton.BackColor = Color.Transparent;
            helpbutton.ErrorImage = null;
            helpbutton.Image = (Image)resources.GetObject("helpbutton.Image");
            helpbutton.Location = new Point(12, 11);
            helpbutton.Name = "helpbutton";
            helpbutton.Size = new Size(61, 60);
            helpbutton.TabIndex = 5;
            helpbutton.TabStop = false;
            helpbutton.Click += helpbutton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(410, 236);
            label2.Name = "label2";
            label2.Size = new Size(0, 23);
            label2.TabIndex = 6;
            // 
            // door1
            // 
            door1.BackColor = Color.Transparent;
            door1.Image = (Image)resources.GetObject("door1.Image");
            door1.Location = new Point(749, 236);
            door1.Name = "door1";
            door1.Size = new Size(140, 198);
            door1.SizeMode = PictureBoxSizeMode.Zoom;
            door1.TabIndex = 7;
            door1.TabStop = false;
            door1.Click += this.door1_Click;
            // 
            // key
            // 
            key.BackColor = Color.Transparent;
            key.Image = (Image)resources.GetObject("key.Image");
            key.Location = new Point(130, 382);
            key.Margin = new Padding(2);
            key.Name = "key";
            key.Size = new Size(58, 27);
            key.SizeMode = PictureBoxSizeMode.Zoom;
            key.TabIndex = 1;
            key.TabStop = false;
            // 
            // room1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 517);
            Controls.Add(player);
            Controls.Add(door1);
            Controls.Add(label2);
            Controls.Add(helpbutton);
            Controls.Add(key);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(ActionsList);
            Margin = new Padding(4);
            Name = "room1";
            Text = "GameForm";
            FormClosed += GameForm_FormClosed;
            Load += this.room1_Load;
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)helpbutton).EndInit();
            ((System.ComponentModel.ISupportInitialize)door1).EndInit();
            ((System.ComponentModel.ISupportInitialize)key).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer moveTimer;
        private ListBox ActionsList;
        private Button button1;
        private Label label1;
        private PictureBox player;
        private PictureBox helpbutton;
        private Label label2;
        private PictureBox door1;
        private PictureBox key;
    }
}