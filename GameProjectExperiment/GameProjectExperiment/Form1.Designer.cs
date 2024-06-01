namespace GameProjectExperiment
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            windowFrame = new PictureBox();
            StartGame = new Button();
            timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)windowFrame).BeginInit();
            SuspendLayout();
            // 
            // windowFrame
            // 
            windowFrame.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            windowFrame.Location = new Point(12, 60);
            windowFrame.Name = "windowFrame";
            windowFrame.Size = new Size(1536, 864);
            windowFrame.SizeMode = PictureBoxSizeMode.Zoom;
            windowFrame.TabIndex = 0;
            windowFrame.TabStop = false;
            // 
            // StartGame
            // 
            StartGame.Location = new Point(12, 12);
            StartGame.Name = "StartGame";
            StartGame.Size = new Size(366, 42);
            StartGame.TabIndex = 1;
            StartGame.Text = "Start Game";
            StartGame.UseVisualStyleBackColor = true;
            StartGame.Click += StartGameClicked;
            // 
            // timer
            // 
            timer.Interval = 5;
            timer.Tick += TimerTicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1561, 936);
            Controls.Add(StartGame);
            Controls.Add(windowFrame);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            KeyDown += FormKeyDown;
            KeyUp += FormKeyUp;
            ((System.ComponentModel.ISupportInitialize)windowFrame).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox windowFrame;
        private Button StartGame;
        private System.Windows.Forms.Timer timer;
    }
}
