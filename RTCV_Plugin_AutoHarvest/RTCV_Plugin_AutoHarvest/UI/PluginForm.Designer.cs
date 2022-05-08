using System;
using System.IO;
using System.Windows.Forms;

namespace AUTOHARVEST.UI
{

    partial class PluginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.btnAutoHarvest = new System.Windows.Forms.Button();
            this.btnSendLastCorruptions = new System.Windows.Forms.Button();
            this.btnStashPrevCorruption = new System.Windows.Forms.Button();
            this.btnStashNextCorruption = new System.Windows.Forms.Button();
            this.nmHarvestDelay = new RTCV.UI.Components.NumericUpDownHexFix();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nmCorruptionsToBeSent = new RTCV.UI.Components.NumericUpDownHexFix();
            this.btnReplayCorruption = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmHarvestDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCorruptionsToBeSent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "Auto-Harvest";
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version.ForeColor = System.Drawing.Color.White;
            this.version.Location = new System.Drawing.Point(153, 35);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(14, 13);
            this.version.TabIndex = 41;
            this.version.Text = "v";
            // 
            // btnAutoHarvest
            // 
            this.btnAutoHarvest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAutoHarvest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnAutoHarvest.FlatAppearance.BorderSize = 0;
            this.btnAutoHarvest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoHarvest.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnAutoHarvest.ForeColor = System.Drawing.Color.White;
            this.btnAutoHarvest.Location = new System.Drawing.Point(13, 104);
            this.btnAutoHarvest.Name = "btnAutoHarvest";
            this.btnAutoHarvest.Size = new System.Drawing.Size(284, 57);
            this.btnAutoHarvest.TabIndex = 42;
            this.btnAutoHarvest.Tag = "color:dark2";
            this.btnAutoHarvest.Text = "Start Auto-Harvest";
            this.btnAutoHarvest.UseVisualStyleBackColor = false;
            this.btnAutoHarvest.Click += new System.EventHandler(this.btnAutoHarvest_Click);
            // 
            // btnSendLastCorruptions
            // 
            this.btnSendLastCorruptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSendLastCorruptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSendLastCorruptions.FlatAppearance.BorderSize = 0;
            this.btnSendLastCorruptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendLastCorruptions.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSendLastCorruptions.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnSendLastCorruptions.Location = new System.Drawing.Point(13, 167);
            this.btnSendLastCorruptions.Name = "btnSendLastCorruptions";
            this.btnSendLastCorruptions.Size = new System.Drawing.Size(284, 56);
            this.btnSendLastCorruptions.TabIndex = 43;
            this.btnSendLastCorruptions.Tag = "color:dark2";
            this.btnSendLastCorruptions.Text = "Send Last Corruptions to Stockpile";
            this.btnSendLastCorruptions.UseVisualStyleBackColor = false;
            this.btnSendLastCorruptions.Click += new System.EventHandler(this.btnSendLastCorruptions_Click);
            // 
            // btnStashPrevCorruption
            // 
            this.btnStashPrevCorruption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStashPrevCorruption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnStashPrevCorruption.FlatAppearance.BorderSize = 0;
            this.btnStashPrevCorruption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStashPrevCorruption.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnStashPrevCorruption.ForeColor = System.Drawing.Color.White;
            this.btnStashPrevCorruption.Location = new System.Drawing.Point(13, 71);
            this.btnStashPrevCorruption.Name = "btnStashPrevCorruption";
            this.btnStashPrevCorruption.Size = new System.Drawing.Size(143, 27);
            this.btnStashPrevCorruption.TabIndex = 44;
            this.btnStashPrevCorruption.Tag = "color:dark2";
            this.btnStashPrevCorruption.Text = "Previous Corruption";
            this.btnStashPrevCorruption.UseVisualStyleBackColor = false;
            this.btnStashPrevCorruption.Click += new System.EventHandler(this.btnStashPrevCorruption_Click);
            // 
            // btnStashNextCorruption
            // 
            this.btnStashNextCorruption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStashNextCorruption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnStashNextCorruption.FlatAppearance.BorderSize = 0;
            this.btnStashNextCorruption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStashNextCorruption.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnStashNextCorruption.ForeColor = System.Drawing.Color.White;
            this.btnStashNextCorruption.Location = new System.Drawing.Point(303, 71);
            this.btnStashNextCorruption.Name = "btnStashNextCorruption";
            this.btnStashNextCorruption.Size = new System.Drawing.Size(134, 27);
            this.btnStashNextCorruption.TabIndex = 45;
            this.btnStashNextCorruption.Tag = "color:dark2";
            this.btnStashNextCorruption.Text = "Next Corruption";
            this.btnStashNextCorruption.UseVisualStyleBackColor = false;
            this.btnStashNextCorruption.Click += new System.EventHandler(this.btnStashNextCorruption_Click);
            // 
            // nmHarvestDelay
            // 
            this.nmHarvestDelay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nmHarvestDelay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nmHarvestDelay.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nmHarvestDelay.ForeColor = System.Drawing.Color.White;
            this.nmHarvestDelay.Location = new System.Drawing.Point(312, 129);
            this.nmHarvestDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmHarvestDelay.Name = "nmHarvestDelay";
            this.nmHarvestDelay.Size = new System.Drawing.Size(110, 22);
            this.nmHarvestDelay.TabIndex = 146;
            this.nmHarvestDelay.Tag = "color:dark1";
            this.nmHarvestDelay.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nmHarvestDelay.ValueChanged += new System.EventHandler(this.nmHarvestDelay_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(309, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 147;
            this.label3.Text = "Harvest Delay (sec):";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(309, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 149;
            this.label2.Text = "Corruptions to be sent:";
            // 
            // nmCorruptionsToBeSent
            // 
            this.nmCorruptionsToBeSent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nmCorruptionsToBeSent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nmCorruptionsToBeSent.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nmCorruptionsToBeSent.ForeColor = System.Drawing.Color.White;
            this.nmCorruptionsToBeSent.Location = new System.Drawing.Point(312, 192);
            this.nmCorruptionsToBeSent.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmCorruptionsToBeSent.Name = "nmCorruptionsToBeSent";
            this.nmCorruptionsToBeSent.Size = new System.Drawing.Size(110, 22);
            this.nmCorruptionsToBeSent.TabIndex = 148;
            this.nmCorruptionsToBeSent.Tag = "color:dark1";
            this.nmCorruptionsToBeSent.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnReplayCorruption
            // 
            this.btnReplayCorruption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReplayCorruption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnReplayCorruption.FlatAppearance.BorderSize = 0;
            this.btnReplayCorruption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplayCorruption.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnReplayCorruption.ForeColor = System.Drawing.Color.White;
            this.btnReplayCorruption.Location = new System.Drawing.Point(162, 71);
            this.btnReplayCorruption.Name = "btnReplayCorruption";
            this.btnReplayCorruption.Size = new System.Drawing.Size(135, 27);
            this.btnReplayCorruption.TabIndex = 150;
            this.btnReplayCorruption.Tag = "color:dark2";
            this.btnReplayCorruption.Text = "Replay Corruption";
            this.btnReplayCorruption.UseVisualStyleBackColor = false;
            this.btnReplayCorruption.Click += new System.EventHandler(this.btnReplayCorruption_Click);
            // 
            // PluginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(450, 250);
            this.Controls.Add(this.btnReplayCorruption);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nmCorruptionsToBeSent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nmHarvestDelay);
            this.Controls.Add(this.btnStashNextCorruption);
            this.Controls.Add(this.btnStashPrevCorruption);
            this.Controls.Add(this.btnSendLastCorruptions);
            this.Controls.Add(this.btnAutoHarvest);
            this.Controls.Add(this.version);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(390, 250);
            this.Name = "PluginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "color:dark1";
            this.Text = "Plugin Form";
            this.Load += new System.EventHandler(this.PluginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmHarvestDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCorruptionsToBeSent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void PluginForm_Load(object sender, EventArgs e)
        {
            setDllDir();
        }

        public string setDllDir()
        {
            //get the full location of the assembly with DaoTests in it
            string fullPath = System.Reflection.Assembly.GetAssembly(typeof(AUTOHARVEST)).Location;

            //get the folder that's in
            dlldir = Path.GetDirectoryName(fullPath);
            return dlldir;

        }


        #endregion
        private System.Windows.Forms.Label label1;
        private string dlldir;
        private Label version;
        private Button btnAutoHarvest;
        private Button btnSendLastCorruptions;
        private Button btnStashPrevCorruption;
        private Button btnStashNextCorruption;
        private RTCV.UI.Components.NumericUpDownHexFix nmHarvestDelay;
        private Label label3;
        private Label label2;
        private RTCV.UI.Components.NumericUpDownHexFix nmCorruptionsToBeSent;
        private Button btnReplayCorruption;
    }
}
