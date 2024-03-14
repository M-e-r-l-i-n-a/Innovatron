namespace Innovatron
{
    partial class room2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(room2));
            door1 = new PictureBox();
            helpbutton = new PictureBox();
            key = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            ActionsList = new ListBox();
            player = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)door1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)helpbutton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)key).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            SuspendLayout();
            // 
            // door1
            // 
            door1.BackColor = Color.Transparent;
            door1.Image = (Image)resources.GetObject("door1.Image");
            door1.Location = new Point(748, 272);
            door1.Name = "door1";
            door1.Size = new Size(140, 198);
            door1.SizeMode = PictureBoxSizeMode.Zoom;
            door1.TabIndex = 15;
            door1.TabStop = false;
            // 
            // helpbutton
            // 
            helpbutton.BackColor = Color.Transparent;
            helpbutton.ErrorImage = null;
            helpbutton.Image = (Image)resources.GetObject("helpbutton.Image");
            helpbutton.Location = new Point(15, 11);
            helpbutton.Name = "helpbutton";
            helpbutton.Size = new Size(61, 60);
            helpbutton.TabIndex = 13;
            helpbutton.TabStop = false;
            // 
            // key
            // 
            key.BackColor = Color.Transparent;
            key.Image = (Image)resources.GetObject("key.Image");
            key.Location = new Point(130, 418);
            key.Margin = new Padding(2);
            key.Name = "key";
            key.Size = new Size(58, 27);
            key.SizeMode = PictureBoxSizeMode.Zoom;
            key.TabIndex = 9;
            key.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(223, 11);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(140, 23);
            label1.TabIndex = 12;
            label1.Text = " Select an action:";
            // 
            // button1
            // 
            button1.Location = new Point(535, 11);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(101, 31);
            button1.TabIndex = 11;
            button1.Text = "select";
            button1.UseVisualStyleBackColor = true;
            // 
            // ActionsList
            // 
            ActionsList.FormattingEnabled = true;
            ActionsList.ItemHeight = 23;
            ActionsList.Location = new Point(367, 11);
            ActionsList.Margin = new Padding(2);
            ActionsList.Name = "ActionsList";
            ActionsList.Size = new Size(162, 119);
            ActionsList.TabIndex = 10;
            // 
            // player
            // 
            player.BackColor = Color.Transparent;
            player.Image = (Image)resources.GetObject("player.Image");
            player.Location = new Point(399, 367);
            player.Margin = new Padding(0);
            player.Name = "player";
            player.Size = new Size(69, 103);
            player.SizeMode = PictureBoxSizeMode.Zoom;
            player.TabIndex = 8;
            player.TabStop = false;
            player.Click += player_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(413, 236);
            label2.Name = "label2";
            label2.Size = new Size(0, 23);
            label2.TabIndex = 14;
            // 
            // room2
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
            Name = "room2";
            Text = "room2";
            FormClosed += room2_FormClosed;
            ((System.ComponentModel.ISupportInitialize)door1).EndInit();
            ((System.ComponentModel.ISupportInitialize)helpbutton).EndInit();
            ((System.ComponentModel.ISupportInitialize)key).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox door1;
        private PictureBox helpbutton;
        private PictureBox key;
        private Label label1;
        private Button button1;
        private ListBox ActionsList;
        private PictureBox player;
        private Label label2;
    }
}