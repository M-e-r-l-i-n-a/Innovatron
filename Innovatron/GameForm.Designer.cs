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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
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
            ActionsList.ItemHeight = 25;
            ActionsList.Location = new Point(404, 12);
            ActionsList.Margin = new Padding(2);
            ActionsList.Name = "ActionsList";
            ActionsList.Size = new Size(180, 129);
            ActionsList.TabIndex = 2;
            ActionsList.KeyDown += KeyDownList;
            // 
            // button1
            // 
            button1.Location = new Point(591, 12);
            button1.Margin = new Padding(2);
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
            label1.Location = new Point(256, 12);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(144, 25);
            label1.TabIndex = 4;
            label1.Text = " Select an action:";
            // 
            // player
            // 
            player.BackColor = Color.Transparent;
            player.Image = (Image)resources.GetObject("player.Image");
            player.Location = new Point(443, 360);
            player.Margin = new Padding(0);
            player.Name = "player";
            player.Size = new Size(77, 112);
            player.SizeMode = PictureBoxSizeMode.Zoom;
            player.TabIndex = 0;
            player.TabStop = false;
            // 
            // helpbutton
            // 
            helpbutton.BackColor = Color.Transparent;
            helpbutton.ErrorImage = null;
            helpbutton.Image = (Image)resources.GetObject("helpbutton.Image");
            helpbutton.Location = new Point(13, 12);
            helpbutton.Name = "helpbutton";
            helpbutton.Size = new Size(68, 65);
            helpbutton.TabIndex = 5;
            helpbutton.TabStop = false;
            helpbutton.Click += helpbutton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(455, 257);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 6;
            // 
            // door1
            // 
            door1.BackColor = Color.Transparent;
            door1.Image = (Image)resources.GetObject("door1.Image");
            door1.Location = new Point(832, 257);
            door1.Name = "door1";
            door1.Size = new Size(156, 215);
            door1.SizeMode = PictureBoxSizeMode.Zoom;
            door1.TabIndex = 7;
            door1.TabStop = false;
            // 
            // key
            // 
            key.BackColor = Color.Transparent;
            key.Image = (Image)resources.GetObject("key.Image");
            key.Location = new Point(144, 415);
            key.Margin = new Padding(2);
            key.Name = "key";
            key.Size = new Size(64, 29);
            key.SizeMode = PictureBoxSizeMode.Zoom;
            key.TabIndex = 1;
            key.TabStop = false;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(player);
            Controls.Add(door1);
            Controls.Add(label2);
            Controls.Add(helpbutton);
            Controls.Add(key);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(ActionsList);
            Margin = new Padding(4);
            Name = "GameForm";
            Text = "GameForm";
            FormClosed += GameForm_FormClosed;
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