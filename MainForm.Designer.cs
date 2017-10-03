namespace hw1pt2
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ResetSettingsButt = new System.Windows.Forms.Button();
            this.SaveLocation = new System.Windows.Forms.Button();
            this.SaveSize = new System.Windows.Forms.Button();
            this.AddNames = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ResetSettingsButt);
            this.groupBox1.Controls.Add(this.SaveLocation);
            this.groupBox1.Controls.Add(this.SaveSize);
            this.groupBox1.Controls.Add(this.AddNames);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // ResetSettingsButt
            // 
            this.ResetSettingsButt.Location = new System.Drawing.Point(274, 20);
            this.ResetSettingsButt.Name = "ResetSettingsButt";
            this.ResetSettingsButt.Size = new System.Drawing.Size(108, 23);
            this.ResetSettingsButt.TabIndex = 3;
            this.ResetSettingsButt.Text = "Reset Settings";
            this.ResetSettingsButt.UseVisualStyleBackColor = true;
            this.ResetSettingsButt.Click += new System.EventHandler(this.ResetSettingsButt_Click);
            // 
            // SaveLocation
            // 
            this.SaveLocation.Location = new System.Drawing.Point(171, 19);
            this.SaveLocation.Name = "SaveLocation";
            this.SaveLocation.Size = new System.Drawing.Size(97, 23);
            this.SaveLocation.TabIndex = 2;
            this.SaveLocation.Text = "Save Location";
            this.SaveLocation.UseVisualStyleBackColor = true;
            this.SaveLocation.Click += new System.EventHandler(this.SaveLocation_Click);
            // 
            // SaveSize
            // 
            this.SaveSize.Location = new System.Drawing.Point(89, 19);
            this.SaveSize.Name = "SaveSize";
            this.SaveSize.Size = new System.Drawing.Size(75, 23);
            this.SaveSize.TabIndex = 1;
            this.SaveSize.Text = "Save Size";
            this.SaveSize.UseVisualStyleBackColor = true;
            this.SaveSize.Click += new System.EventHandler(this.SaveSize_Click);
            // 
            // AddNames
            // 
            this.AddNames.Location = new System.Drawing.Point(7, 20);
            this.AddNames.Name = "AddNames";
            this.AddNames.Size = new System.Drawing.Size(75, 23);
            this.AddNames.TabIndex = 0;
            this.AddNames.Text = "Add Names";
            this.AddNames.UseVisualStyleBackColor = true;
            this.AddNames.Click += new System.EventHandler(this.AddNames_Click);
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 80);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(507, 200);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 280);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ResetSettingsButt;
        private System.Windows.Forms.Button SaveLocation;
        private System.Windows.Forms.Button SaveSize;
        private System.Windows.Forms.Button AddNames;
        private System.Windows.Forms.ListView listView1;
    }
}