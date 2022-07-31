namespace Design_Patterns_Project
{
    partial class ChannelChoice
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
            this.label_ChooseChannelType = new System.Windows.Forms.Label();
            this.groupBox_ChannelTypes = new System.Windows.Forms.GroupBox();
            this.button_Instrument = new System.Windows.Forms.Button();
            this.button_Drum = new System.Windows.Forms.Button();
            this.button_Automation = new System.Windows.Forms.Button();
            this.button_GoBack = new System.Windows.Forms.Button();
            this.groupBox_ChannelTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_ChooseChannelType
            // 
            this.label_ChooseChannelType.AutoSize = true;
            this.label_ChooseChannelType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ChooseChannelType.Location = new System.Drawing.Point(88, 9);
            this.label_ChooseChannelType.Name = "label_ChooseChannelType";
            this.label_ChooseChannelType.Size = new System.Drawing.Size(172, 18);
            this.label_ChooseChannelType.TabIndex = 0;
            this.label_ChooseChannelType.Text = "Select Channel Type";
            // 
            // groupBox_ChannelTypes
            // 
            this.groupBox_ChannelTypes.Controls.Add(this.button_Instrument);
            this.groupBox_ChannelTypes.Controls.Add(this.button_Drum);
            this.groupBox_ChannelTypes.Controls.Add(this.button_Automation);
            this.groupBox_ChannelTypes.Location = new System.Drawing.Point(19, 37);
            this.groupBox_ChannelTypes.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox_ChannelTypes.Name = "groupBox_ChannelTypes";
            this.groupBox_ChannelTypes.Size = new System.Drawing.Size(309, 159);
            this.groupBox_ChannelTypes.TabIndex = 2;
            this.groupBox_ChannelTypes.TabStop = false;
            this.groupBox_ChannelTypes.Text = "Channel Types";
            // 
            // button_Instrument
            // 
            this.button_Instrument.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Instrument.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_Instrument.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Instrument.Location = new System.Drawing.Point(8, 111);
            this.button_Instrument.Margin = new System.Windows.Forms.Padding(5);
            this.button_Instrument.Name = "button_Instrument";
            this.button_Instrument.Size = new System.Drawing.Size(293, 35);
            this.button_Instrument.TabIndex = 2;
            this.button_Instrument.Text = "Instrument Channel";
            this.button_Instrument.UseVisualStyleBackColor = true;
            this.button_Instrument.Click += new System.EventHandler(this.button_Instrument_Click);
            // 
            // button_Drum
            // 
            this.button_Drum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Drum.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_Drum.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Drum.Location = new System.Drawing.Point(8, 66);
            this.button_Drum.Margin = new System.Windows.Forms.Padding(5);
            this.button_Drum.Name = "button_Drum";
            this.button_Drum.Size = new System.Drawing.Size(293, 35);
            this.button_Drum.TabIndex = 1;
            this.button_Drum.Text = "Drum Channel";
            this.button_Drum.UseVisualStyleBackColor = true;
            this.button_Drum.Click += new System.EventHandler(this.button_Drum_Click);
            // 
            // button_Automation
            // 
            this.button_Automation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Automation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_Automation.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Automation.Location = new System.Drawing.Point(8, 21);
            this.button_Automation.Margin = new System.Windows.Forms.Padding(5);
            this.button_Automation.Name = "button_Automation";
            this.button_Automation.Size = new System.Drawing.Size(293, 35);
            this.button_Automation.TabIndex = 0;
            this.button_Automation.Text = "Automation Channel";
            this.button_Automation.UseVisualStyleBackColor = true;
            this.button_Automation.Click += new System.EventHandler(this.button_Automation_Click);
            // 
            // button_GoBack
            // 
            this.button_GoBack.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_GoBack.Location = new System.Drawing.Point(253, 209);
            this.button_GoBack.Name = "button_GoBack";
            this.button_GoBack.Size = new System.Drawing.Size(75, 23);
            this.button_GoBack.TabIndex = 3;
            this.button_GoBack.Text = "Go Back";
            this.button_GoBack.UseVisualStyleBackColor = true;
            this.button_GoBack.Click += new System.EventHandler(this.button_GoBack_Click);
            // 
            // ChannelChoice
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(347, 243);
            this.Controls.Add(this.button_GoBack);
            this.Controls.Add(this.groupBox_ChannelTypes);
            this.Controls.Add(this.label_ChooseChannelType);
            this.Name = "ChannelChoice";
            this.Text = "Channel Choice";
            this.groupBox_ChannelTypes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ChooseChannelType;
        private System.Windows.Forms.GroupBox groupBox_ChannelTypes;
        private System.Windows.Forms.Button button_Instrument;
        private System.Windows.Forms.Button button_Drum;
        private System.Windows.Forms.Button button_Automation;
        private System.Windows.Forms.Button button_GoBack;
    }
}