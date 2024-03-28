namespace Innovatron
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            moveTimer = new System.Windows.Forms.Timer(components);
            ActionsList = new ListBox();
            selectAction = new Button();
            labelAction = new Label();
            player = new PictureBox();
            helpbutton = new PictureBox();
            text = new Label();
            door1 = new PictureBox();
            key = new PictureBox();
            door2 = new PictureBox();
            door3 = new PictureBox();
            cupboard = new PictureBox();
            glasses = new PictureBox();
            paper = new PictureBox();
            schloss = new PictureBox();
            wireCutter = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)helpbutton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)door1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)key).BeginInit();
            ((System.ComponentModel.ISupportInitialize)door2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)door3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cupboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)glasses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)paper).BeginInit();
            ((System.ComponentModel.ISupportInitialize)schloss).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wireCutter).BeginInit();
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
            // selectAction
            // 
            selectAction.Location = new Point(591, 12);
            selectAction.Margin = new Padding(2);
            selectAction.Name = "selectAction";
            selectAction.Size = new Size(112, 34);
            selectAction.TabIndex = 3;
            selectAction.Text = "select";
            selectAction.UseVisualStyleBackColor = true;
            selectAction.Click += button1_Click;
            // 
            // labelAction
            // 
            labelAction.AutoSize = true;
            labelAction.Location = new Point(256, 12);
            labelAction.Margin = new Padding(2, 0, 2, 0);
            labelAction.Name = "labelAction";
            labelAction.Size = new Size(144, 25);
            labelAction.TabIndex = 4;
            labelAction.Text = " Select an action:";
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
            // text
            // 
            text.AutoSize = true;
            text.Location = new Point(456, 257);
            text.Name = "text";
            text.Size = new Size(0, 25);
            text.TabIndex = 6;
            // 
            // door1
            // 
            door1.BackColor = Color.Transparent;
            door1.Image = (Image)resources.GetObject("door1.Image");
            door1.Location = new Point(13, 257);
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
            key.Location = new Point(256, 403);
            key.Margin = new Padding(2);
            key.Name = "key";
            key.Size = new Size(64, 29);
            key.SizeMode = PictureBoxSizeMode.Zoom;
            key.TabIndex = 1;
            key.TabStop = false;
            // 
            // door2
            // 
            door2.BackColor = Color.Transparent;
            door2.Image = (Image)resources.GetObject("door2.Image");
            door2.Location = new Point(417, 257);
            door2.Name = "door2";
            door2.Size = new Size(156, 215);
            door2.SizeMode = PictureBoxSizeMode.Zoom;
            door2.TabIndex = 8;
            door2.TabStop = false;
            // 
            // door3
            // 
            door3.BackColor = Color.Transparent;
            door3.Image = (Image)resources.GetObject("door3.Image");
            door3.Location = new Point(832, 257);
            door3.Name = "door3";
            door3.Size = new Size(156, 215);
            door3.SizeMode = PictureBoxSizeMode.Zoom;
            door3.TabIndex = 9;
            door3.TabStop = false;
            // 
            // cupboard
            // 
            cupboard.BackColor = Color.Transparent;
            cupboard.Image = (Image)resources.GetObject("cupboard.Image");
            cupboard.Location = new Point(381, 193);
            cupboard.Name = "cupboard";
            cupboard.Size = new Size(241, 279);
            cupboard.SizeMode = PictureBoxSizeMode.Zoom;
            cupboard.TabIndex = 10;
            cupboard.TabStop = false;
            // 
            // glasses
            // 
            glasses.BackColor = Color.Transparent;
            glasses.Image = (Image)resources.GetObject("glasses.Image");
            glasses.Location = new Point(749, 381);
            glasses.Name = "glasses";
            glasses.Size = new Size(88, 81);
            glasses.SizeMode = PictureBoxSizeMode.Zoom;
            glasses.TabIndex = 11;
            glasses.TabStop = false;
            // 
            // paper
            // 
            paper.BackColor = Color.Transparent;
            paper.Image = (Image)resources.GetObject("paper.Image");
            paper.Location = new Point(659, 372);
            paper.Name = "paper";
            paper.Size = new Size(131, 100);
            paper.SizeMode = PictureBoxSizeMode.Zoom;
            paper.TabIndex = 12;
            paper.TabStop = false;
            // 
            // schloss
            // 
            schloss.Location = new Point(12, 381);
            schloss.Name = "schloss";
            schloss.Size = new Size(150, 75);
            schloss.TabIndex = 13;
            schloss.TabStop = false;
            // 
            // wireCutter
            // 
            wireCutter.Location = new Point(417, 387);
            wireCutter.Name = "wireCutter";
            wireCutter.Size = new Size(150, 75);
            wireCutter.TabIndex = 14;
            wireCutter.TabStop = false;
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(player);
            Controls.Add(schloss);
            Controls.Add(paper);
            Controls.Add(text);
            Controls.Add(helpbutton);
            Controls.Add(key);
            Controls.Add(labelAction);
            Controls.Add(selectAction);
            Controls.Add(ActionsList);
            Controls.Add(glasses);
            Controls.Add(door1);
            Controls.Add(door3);
            Controls.Add(wireCutter);
            Controls.Add(door2);
            Controls.Add(cupboard);
            Margin = new Padding(4);
            Name = "BaseForm";
            Text = "Innovatron";
            FormClosed += GameForm_FormClosed;
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)helpbutton).EndInit();
            ((System.ComponentModel.ISupportInitialize)door1).EndInit();
            ((System.ComponentModel.ISupportInitialize)key).EndInit();
            ((System.ComponentModel.ISupportInitialize)door2).EndInit();
            ((System.ComponentModel.ISupportInitialize)door3).EndInit();
            ((System.ComponentModel.ISupportInitialize)cupboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)glasses).EndInit();
            ((System.ComponentModel.ISupportInitialize)paper).EndInit();
            ((System.ComponentModel.ISupportInitialize)schloss).EndInit();
            ((System.ComponentModel.ISupportInitialize)wireCutter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer moveTimer;
        private ListBox ActionsList;
        private Button selectAction;
        private Label labelAction;
        public PictureBox player;
        private PictureBox helpbutton;
        private Label text;

        public PictureBox door1;
        public PictureBox door2;
        public PictureBox door3;
        public PictureBox key;
        public PictureBox cupboard;
        public PictureBox glasses;
        public PictureBox paper;
        public PictureBox schloss;
        public PictureBox wireCutter;
    }
}