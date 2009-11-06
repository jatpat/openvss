// tzhj	 IMPORTANT: READ BEFORE DOWNLOADING, COPYING, INSTALLING OR USING. 
// hhrs	
// avtn	 By downloading, copying, installing or using the software you agree to this license.
// mctz	 If you do not agree to this license, do not download, install,
// jyuz	 copy or use the software.
// wivd	
// jrez	                          License Agreement
// arrk	         For OpenVss - Open Source Video Surveillance System
// cbmh	
// oaux	Copyright (C) 2007-2009, Prince of Songkla University, All rights reserved.
// jpbg	
// aixn	Third party copyrights are property of their respective owners.
// zjtu	
// lfgl	Redistribution and use in source and binary forms, with or without modification,
// edap	are permitted provided that the following conditions are met:
// dsrj	
// djkl	  * Redistribution's of source code must retain the above copyright notice,
// qmlj	    this list of conditions and the following disclaimer.
// dwph	
// goda	  * Redistribution's in binary form must reproduce the above copyright notice,
// uqzr	    this list of conditions and the following disclaimer in the documentation
// yxzw	    and/or other materials provided with the distribution.
// uack	
// zeuq	  * Neither the name of the copyright holders nor the names of its contributors 
// xscr	    may not be used to endorse or promote products derived from this software 
// xmxn	    without specific prior written permission.
// xjqp	
// qyfp	This software is provided by the copyright holders and contributors "as is" and
// aavn	any express or implied warranties, including, but not limited to, the implied
// takg	warranties of merchantability and fitness for a particular purpose are disclaimed.
// koqp	In no event shall the Prince of Songkla University or contributors be liable 
// jajz	for any direct, indirect, incidental, special, exemplary, or consequential damages
// czko	(including, but not limited to, procurement of substitute goods or services;
// mlch	loss of use, data, or profits; or business interruption) however caused
// smto	and on any theory of liability, whether in contract, strict liability,
// gjgv	or tort (including negligence or otherwise) arising in any way out of
// vmkz	the use of this software, even if advised of the possibility of such damage.

namespace Vs.Monitor
{
    partial class VsAlarmControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colTime = new System.Windows.Forms.ColumnHeader();
            this.colCamera = new System.Windows.Forms.ColumnHeader();
            this.colAlarm = new System.Windows.Forms.ColumnHeader();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.49223F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.50777F));
            this.tableLayoutPanel1.Controls.Add(this.listView1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(772, 79);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ControlText;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTime,
            this.colCamera,
            this.colAlarm});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.ForeColor = System.Drawing.Color.Red;
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView1.HideSelection = false;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(84, 3);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.ShowGroups = false;
            this.listView1.Size = new System.Drawing.Size(685, 73);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colTime
            // 
            this.colTime.Text = "Time";
            this.colTime.Width = 223;
            // 
            // colCamera
            // 
            this.colCamera.Text = "Device";
            this.colCamera.Width = 192;
            // 
            // colAlarm
            // 
            this.colAlarm.Text = "Detail";
            this.colAlarm.Width = 220;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ErrorImage = global::Vs.Monitor.Properties.Resources.isyscolor;
            this.pictureBox1.Image = global::Vs.Monitor.Properties.Resources.isyscolor;
            this.pictureBox1.InitialImage = global::Vs.Monitor.Properties.Resources.isyscolor;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // VsAlarmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "VsAlarmControl";
            this.Size = new System.Drawing.Size(772, 79);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colTime;
        private System.Windows.Forms.ColumnHeader colCamera;
        private System.Windows.Forms.ColumnHeader colAlarm;
        private System.Windows.Forms.PictureBox pictureBox1;


    }
}
