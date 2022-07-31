namespace Design_Patterns_Project
{
    partial class ChooseAutomationLink
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_SelectAutomationControls = new System.Windows.Forms.Label();
            this.button_GoBack = new System.Windows.Forms.Button();
            this.dataGridView_Controls = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChannelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Control = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Choose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Controls)).BeginInit();
            this.SuspendLayout();
            // 
            // label_SelectAutomationControls
            // 
            this.label_SelectAutomationControls.AutoSize = true;
            this.label_SelectAutomationControls.BackColor = System.Drawing.SystemColors.Control;
            this.label_SelectAutomationControls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_SelectAutomationControls.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SelectAutomationControls.Location = new System.Drawing.Point(46, 18);
            this.label_SelectAutomationControls.Name = "label_SelectAutomationControls";
            this.label_SelectAutomationControls.Size = new System.Drawing.Size(335, 18);
            this.label_SelectAutomationControls.TabIndex = 0;
            this.label_SelectAutomationControls.Text = "Select A Control You Want To Automate";
            this.label_SelectAutomationControls.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_SelectAutomationControls.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_GoBack
            // 
            this.button_GoBack.Location = new System.Drawing.Point(343, 303);
            this.button_GoBack.Name = "button_GoBack";
            this.button_GoBack.Size = new System.Drawing.Size(75, 23);
            this.button_GoBack.TabIndex = 2;
            this.button_GoBack.Text = "Go Back";
            this.button_GoBack.UseVisualStyleBackColor = true;
            this.button_GoBack.Click += new System.EventHandler(this.button_GoBack_Click);
            // 
            // dataGridView_Controls
            // 
            this.dataGridView_Controls.AllowUserToAddRows = false;
            this.dataGridView_Controls.AllowUserToDeleteRows = false;
            this.dataGridView_Controls.AllowUserToResizeColumns = false;
            this.dataGridView_Controls.AllowUserToResizeRows = false;
            this.dataGridView_Controls.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dataGridView_Controls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Controls.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ChannelName,
            this.Control});
            this.dataGridView_Controls.EnableHeadersVisualStyles = false;
            this.dataGridView_Controls.Location = new System.Drawing.Point(16, 47);
            this.dataGridView_Controls.MultiSelect = false;
            this.dataGridView_Controls.Name = "dataGridView_Controls";
            this.dataGridView_Controls.ReadOnly = true;
            this.dataGridView_Controls.RowHeadersVisible = false;
            this.dataGridView_Controls.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Controls.ShowEditingIcon = false;
            this.dataGridView_Controls.Size = new System.Drawing.Size(402, 250);
            this.dataGridView_Controls.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.HeaderText = "ChannelId";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // ChannelName
            // 
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            this.ChannelName.DefaultCellStyle = dataGridViewCellStyle1;
            this.ChannelName.HeaderText = "Channel Name";
            this.ChannelName.Name = "ChannelName";
            this.ChannelName.ReadOnly = true;
            this.ChannelName.Width = 175;
            // 
            // Control
            // 
            this.Control.HeaderText = "Control";
            this.Control.Name = "Control";
            this.Control.ReadOnly = true;
            this.Control.Width = 125;
            // 
            // button_Choose
            // 
            this.button_Choose.Location = new System.Drawing.Point(262, 303);
            this.button_Choose.Name = "button_Choose";
            this.button_Choose.Size = new System.Drawing.Size(75, 23);
            this.button_Choose.TabIndex = 3;
            this.button_Choose.Text = "Choose";
            this.button_Choose.UseVisualStyleBackColor = true;
            this.button_Choose.Click += new System.EventHandler(this.button_Choose_Click);
            // 
            // ChooseAutomationLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 336);
            this.Controls.Add(this.button_Choose);
            this.Controls.Add(this.button_GoBack);
            this.Controls.Add(this.dataGridView_Controls);
            this.Controls.Add(this.label_SelectAutomationControls);
            this.Name = "ChooseAutomationLink";
            this.Text = "Choose Automation Link";
            this.Load += new System.EventHandler(this.ChooseAutomationLink_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Controls)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_SelectAutomationControls;
        private System.Windows.Forms.Button button_GoBack;
        private System.Windows.Forms.DataGridView dataGridView_Controls;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChannelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Control;
        private System.Windows.Forms.Button button_Choose;
    }
}