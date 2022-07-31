namespace Design_Patterns_Project
{
    partial class Music_Sequencer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Music_Sequencer));
            this.Label_MusicSequencer = new System.Windows.Forms.Label();
            this.Label_Metronome = new System.Windows.Forms.Label();
            this.checkBox_Metronome = new System.Windows.Forms.CheckBox();
            this.button_AddChannel = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.PictureBox();
            this.Play_Button = new System.Windows.Forms.Button();
            this.Stop_Button = new System.Windows.Forms.Button();
            this.panel_TrackControls = new System.Windows.Forms.Panel();
            this.audioIntervalTimer = new System.Windows.Forms.Timer(this.components);
            this.pot_Tempo = new NAudio.Gui.Pot();
            this.label_Tempo = new System.Windows.Forms.Label();
            this.Tempo = new System.Windows.Forms.Label();
            this.BPM = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar)).BeginInit();
            this.panel_TrackControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_MusicSequencer
            // 
            this.Label_MusicSequencer.AutoSize = true;
            this.Label_MusicSequencer.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_MusicSequencer.Location = new System.Drawing.Point(546, 9);
            this.Label_MusicSequencer.Name = "Label_MusicSequencer";
            this.Label_MusicSequencer.Size = new System.Drawing.Size(158, 24);
            this.Label_MusicSequencer.TabIndex = 0;
            this.Label_MusicSequencer.Text = "Music Sequencer";
            // 
            // Label_Metronome
            // 
            this.Label_Metronome.AutoSize = true;
            this.Label_Metronome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Metronome.Location = new System.Drawing.Point(12, 9);
            this.Label_Metronome.Name = "Label_Metronome";
            this.Label_Metronome.Size = new System.Drawing.Size(107, 24);
            this.Label_Metronome.TabIndex = 3;
            this.Label_Metronome.Text = "Metronome";
            // 
            // checkBox_Metronome
            // 
            this.checkBox_Metronome.AutoSize = true;
            this.checkBox_Metronome.Location = new System.Drawing.Point(125, 13);
            this.checkBox_Metronome.Name = "checkBox_Metronome";
            this.checkBox_Metronome.Size = new System.Drawing.Size(15, 14);
            this.checkBox_Metronome.TabIndex = 4;
            this.checkBox_Metronome.UseVisualStyleBackColor = true;
            // 
            // button_AddChannel
            // 
            this.button_AddChannel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_AddChannel.BackColor = System.Drawing.Color.PaleGreen;
            this.button_AddChannel.BackgroundImage = global::Design_Patterns_Project.Properties.Resources.Plus;
            this.button_AddChannel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_AddChannel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_AddChannel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_AddChannel.ForeColor = System.Drawing.SystemColors.Control;
            this.button_AddChannel.Location = new System.Drawing.Point(289, 155);
            this.button_AddChannel.Name = "button_AddChannel";
            this.button_AddChannel.Padding = new System.Windows.Forms.Padding(5);
            this.button_AddChannel.Size = new System.Drawing.Size(100, 30);
            this.button_AddChannel.TabIndex = 5;
            this.button_AddChannel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_AddChannel.UseVisualStyleBackColor = false;
            this.button_AddChannel.Click += new System.EventHandler(this.button_AddChannel_Click);
            // 
            // progressBar
            // 
            this.progressBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressBar.BackgroundImage")));
            this.progressBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.progressBar.Location = new System.Drawing.Point(310, 70);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 20);
            this.progressBar.TabIndex = 0;
            this.progressBar.TabStop = false;
            // 
            // Play_Button
            // 
            this.Play_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Play_Button.BackgroundImage")));
            this.Play_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Play_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Play_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Play_Button.ForeColor = System.Drawing.SystemColors.Control;
            this.Play_Button.Location = new System.Drawing.Point(500, 8);
            this.Play_Button.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Play_Button.Name = "Play_Button";
            this.Play_Button.Size = new System.Drawing.Size(30, 30);
            this.Play_Button.TabIndex = 2;
            this.Play_Button.UseVisualStyleBackColor = true;
            this.Play_Button.Click += new System.EventHandler(this.Play_Button_Click);
            // 
            // Stop_Button
            // 
            this.Stop_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Stop_Button.BackgroundImage")));
            this.Stop_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Stop_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Stop_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stop_Button.ForeColor = System.Drawing.SystemColors.Control;
            this.Stop_Button.Location = new System.Drawing.Point(724, 8);
            this.Stop_Button.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Stop_Button.Name = "Stop_Button";
            this.Stop_Button.Size = new System.Drawing.Size(30, 30);
            this.Stop_Button.TabIndex = 1;
            this.Stop_Button.UseVisualStyleBackColor = true;
            this.Stop_Button.Click += new System.EventHandler(this.Stop_Button_Click);
            // 
            // panel_TrackControls
            // 
            this.panel_TrackControls.AutoScroll = true;
            this.panel_TrackControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_TrackControls.Controls.Add(this.button_AddChannel);
            this.panel_TrackControls.Location = new System.Drawing.Point(10, 100);
            this.panel_TrackControls.Name = "panel_TrackControls";
            this.panel_TrackControls.Size = new System.Drawing.Size(1212, 449);
            this.panel_TrackControls.TabIndex = 6;
            this.panel_TrackControls.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_TrackControls_Paint);
            // 
            // audioIntervalTimer
            // 
            this.audioIntervalTimer.Interval = 500;
            this.audioIntervalTimer.Tick += new System.EventHandler(this.audioIntervalTimer_Tick);
            // 
            // pot_Tempo
            // 
            this.pot_Tempo.Location = new System.Drawing.Point(1190, 12);
            this.pot_Tempo.Maximum = 180D;
            this.pot_Tempo.Minimum = 60D;
            this.pot_Tempo.Name = "pot_Tempo";
            this.pot_Tempo.Size = new System.Drawing.Size(32, 32);
            this.pot_Tempo.TabIndex = 7;
            this.pot_Tempo.Value = 120D;
            this.pot_Tempo.ValueChanged += new System.EventHandler(this.pot_Tempo_ValueChanged);
            this.pot_Tempo.Load += new System.EventHandler(this.pot_Tempo_Load);
            // 
            // label_Tempo
            // 
            this.label_Tempo.AutoSize = true;
            this.label_Tempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Tempo.Location = new System.Drawing.Point(1112, 5);
            this.label_Tempo.Name = "label_Tempo";
            this.label_Tempo.Size = new System.Drawing.Size(71, 24);
            this.label_Tempo.TabIndex = 8;
            this.label_Tempo.Text = "Tempo";
            this.label_Tempo.Click += new System.EventHandler(this.label_Tempo_Click);
            // 
            // Tempo
            // 
            this.Tempo.AutoSize = true;
            this.Tempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tempo.Location = new System.Drawing.Point(1115, 29);
            this.Tempo.Name = "Tempo";
            this.Tempo.Size = new System.Drawing.Size(28, 15);
            this.Tempo.TabIndex = 9;
            this.Tempo.Text = "120";
            // 
            // BPM
            // 
            this.BPM.AutoSize = true;
            this.BPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BPM.Location = new System.Drawing.Point(1149, 29);
            this.BPM.Name = "BPM";
            this.BPM.Size = new System.Drawing.Size(34, 15);
            this.BPM.TabIndex = 10;
            this.BPM.Text = "BPM";
            this.BPM.Click += new System.EventHandler(this.BPM_Click);
            // 
            // Music_Sequencer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 561);
            this.Controls.Add(this.BPM);
            this.Controls.Add(this.Tempo);
            this.Controls.Add(this.label_Tempo);
            this.Controls.Add(this.pot_Tempo);
            this.Controls.Add(this.panel_TrackControls);
            this.Controls.Add(this.checkBox_Metronome);
            this.Controls.Add(this.Label_Metronome);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.Play_Button);
            this.Controls.Add(this.Stop_Button);
            this.Controls.Add(this.Label_MusicSequencer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1250, 600);
            this.MinimumSize = new System.Drawing.Size(1250, 600);
            this.Name = "Music_Sequencer";
            this.Text = "Music Sequencer";
            this.Load += new System.EventHandler(this.Music_Sequencer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.progressBar)).EndInit();
            this.panel_TrackControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_MusicSequencer;
        private System.Windows.Forms.Button Stop_Button;
        private System.Windows.Forms.Button Play_Button;
        private System.Windows.Forms.PictureBox progressBar;
        private System.Windows.Forms.Label Label_Metronome;
        private System.Windows.Forms.CheckBox checkBox_Metronome;
        private System.Windows.Forms.Button button_AddChannel;
        private System.Windows.Forms.Panel panel_TrackControls;
        private System.Windows.Forms.Timer audioIntervalTimer;
        private NAudio.Gui.Pot pot_Tempo;
        private System.Windows.Forms.Label label_Tempo;
        private System.Windows.Forms.Label Tempo;
        private System.Windows.Forms.Label BPM;
    }
}