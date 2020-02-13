﻿namespace OpenForensics
{
    partial class Analysis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Analysis));
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.lblProcess = new System.Windows.Forms.Label();
            this.grpGPUActivity = new System.Windows.Forms.GroupBox();
            this.tblGPU = new System.Windows.Forms.TableLayoutPanel();
            this.grpProcessed = new System.Windows.Forms.GroupBox();
            this.lblFoundValue = new System.Windows.Forms.Label();
            this.lblSegmentsValue = new System.Windows.Forms.Label();
            this.lblTimeRemainingValue = new System.Windows.Forms.Label();
            this.lblTimeElapsedValue = new System.Windows.Forms.Label();
            this.lblTimeRemaining = new System.Windows.Forms.Label();
            this.lblTimeElapsed = new System.Windows.Forms.Label();
            this.lblFound = new System.Windows.Forms.Label();
            this.lblSegments = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnCarve = new System.Windows.Forms.Button();
            this.btnAnalysisLog = new System.Windows.Forms.Button();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.lblImageStatus = new System.Windows.Forms.Label();
            this.grpGPUActivity.SuspendLayout();
            this.grpProcessed.SuspendLayout();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // pbProgress
            // 
            this.pbProgress.Location = new System.Drawing.Point(11, 32);
            this.pbProgress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(551, 26);
            this.pbProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbProgress.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblHeader.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(11, 6);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(155, 23);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Carving Started...";
            // 
            // lblProgress
            // 
            this.lblProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProgress.BackColor = System.Drawing.SystemColors.Control;
            this.lblProgress.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblProgress.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.Location = new System.Drawing.Point(505, 62);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(57, 20);
            this.lblProgress.TabIndex = 2;
            this.lblProgress.Text = "0%";
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblProcess.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcess.Location = new System.Drawing.Point(11, 62);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(85, 18);
            this.lblProcess.TabIndex = 3;
            this.lblProcess.Text = "Processing:";
            // 
            // grpGPUActivity
            // 
            this.grpGPUActivity.Controls.Add(this.tblGPU);
            this.grpGPUActivity.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpGPUActivity.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGPUActivity.Location = new System.Drawing.Point(174, 86);
            this.grpGPUActivity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpGPUActivity.Name = "grpGPUActivity";
            this.grpGPUActivity.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpGPUActivity.Size = new System.Drawing.Size(388, 95);
            this.grpGPUActivity.TabIndex = 4;
            this.grpGPUActivity.TabStop = false;
            this.grpGPUActivity.Text = "Thread Activity";
            // 
            // tblGPU
            // 
            this.tblGPU.AutoSize = true;
            this.tblGPU.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblGPU.BackColor = System.Drawing.SystemColors.Control;
            this.tblGPU.ColumnCount = 1;
            this.tblGPU.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 380F));
            this.tblGPU.Font = new System.Drawing.Font("Bahnschrift", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblGPU.Location = new System.Drawing.Point(3, 21);
            this.tblGPU.Margin = new System.Windows.Forms.Padding(0);
            this.tblGPU.MaximumSize = new System.Drawing.Size(380, 70);
            this.tblGPU.MinimumSize = new System.Drawing.Size(380, 70);
            this.tblGPU.Name = "tblGPU";
            this.tblGPU.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tblGPU.RowCount = 1;
            this.tblGPU.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblGPU.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tblGPU.Size = new System.Drawing.Size(380, 70);
            this.tblGPU.TabIndex = 0;
            // 
            // grpProcessed
            // 
            this.grpProcessed.Controls.Add(this.lblFoundValue);
            this.grpProcessed.Controls.Add(this.lblSegmentsValue);
            this.grpProcessed.Controls.Add(this.lblTimeRemainingValue);
            this.grpProcessed.Controls.Add(this.lblTimeElapsedValue);
            this.grpProcessed.Controls.Add(this.lblTimeRemaining);
            this.grpProcessed.Controls.Add(this.lblTimeElapsed);
            this.grpProcessed.Controls.Add(this.lblFound);
            this.grpProcessed.Controls.Add(this.lblSegments);
            this.grpProcessed.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpProcessed.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpProcessed.Location = new System.Drawing.Point(11, 86);
            this.grpProcessed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpProcessed.Name = "grpProcessed";
            this.grpProcessed.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpProcessed.Size = new System.Drawing.Size(157, 95);
            this.grpProcessed.TabIndex = 6;
            this.grpProcessed.TabStop = false;
            this.grpProcessed.Text = "Status";
            // 
            // lblFoundValue
            // 
            this.lblFoundValue.AutoSize = true;
            this.lblFoundValue.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblFoundValue.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoundValue.Location = new System.Drawing.Point(101, 71);
            this.lblFoundValue.Name = "lblFoundValue";
            this.lblFoundValue.Size = new System.Drawing.Size(13, 13);
            this.lblFoundValue.TabIndex = 7;
            this.lblFoundValue.Text = "0";
            // 
            // lblSegmentsValue
            // 
            this.lblSegmentsValue.AutoSize = true;
            this.lblSegmentsValue.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblSegmentsValue.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegmentsValue.Location = new System.Drawing.Point(101, 56);
            this.lblSegmentsValue.Name = "lblSegmentsValue";
            this.lblSegmentsValue.Size = new System.Drawing.Size(13, 13);
            this.lblSegmentsValue.TabIndex = 6;
            this.lblSegmentsValue.Text = "0";
            // 
            // lblTimeRemainingValue
            // 
            this.lblTimeRemainingValue.AutoSize = true;
            this.lblTimeRemainingValue.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTimeRemainingValue.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeRemainingValue.Location = new System.Drawing.Point(101, 40);
            this.lblTimeRemainingValue.Name = "lblTimeRemainingValue";
            this.lblTimeRemainingValue.Size = new System.Drawing.Size(47, 13);
            this.lblTimeRemainingValue.TabIndex = 5;
            this.lblTimeRemainingValue.Text = "00:00:00";
            // 
            // lblTimeElapsedValue
            // 
            this.lblTimeElapsedValue.AutoSize = true;
            this.lblTimeElapsedValue.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTimeElapsedValue.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeElapsedValue.Location = new System.Drawing.Point(101, 23);
            this.lblTimeElapsedValue.Name = "lblTimeElapsedValue";
            this.lblTimeElapsedValue.Size = new System.Drawing.Size(47, 13);
            this.lblTimeElapsedValue.TabIndex = 4;
            this.lblTimeElapsedValue.Text = "00:00:00";
            // 
            // lblTimeRemaining
            // 
            this.lblTimeRemaining.AutoSize = true;
            this.lblTimeRemaining.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTimeRemaining.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeRemaining.Location = new System.Drawing.Point(6, 40);
            this.lblTimeRemaining.Name = "lblTimeRemaining";
            this.lblTimeRemaining.Size = new System.Drawing.Size(87, 13);
            this.lblTimeRemaining.TabIndex = 3;
            this.lblTimeRemaining.Text = "Time Remaining:";
            // 
            // lblTimeElapsed
            // 
            this.lblTimeElapsed.AutoSize = true;
            this.lblTimeElapsed.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTimeElapsed.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeElapsed.Location = new System.Drawing.Point(6, 23);
            this.lblTimeElapsed.Name = "lblTimeElapsed";
            this.lblTimeElapsed.Size = new System.Drawing.Size(75, 13);
            this.lblTimeElapsed.TabIndex = 2;
            this.lblTimeElapsed.Text = "Time Elapsed:";
            // 
            // lblFound
            // 
            this.lblFound.AutoSize = true;
            this.lblFound.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblFound.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFound.Location = new System.Drawing.Point(6, 71);
            this.lblFound.Name = "lblFound";
            this.lblFound.Size = new System.Drawing.Size(89, 13);
            this.lblFound.TabIndex = 1;
            this.lblFound.Text = "Traces Detected:";
            // 
            // lblSegments
            // 
            this.lblSegments.AutoSize = true;
            this.lblSegments.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblSegments.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegments.Location = new System.Drawing.Point(6, 56);
            this.lblSegments.Name = "lblSegments";
            this.lblSegments.Size = new System.Drawing.Size(87, 13);
            this.lblSegments.TabIndex = 0;
            this.lblSegments.Text = "Segments Done:";
            // 
            // btnStop
            // 
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnStop.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(405, 186);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(157, 27);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop Processing";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnCarve
            // 
            this.btnCarve.Enabled = false;
            this.btnCarve.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCarve.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarve.Location = new System.Drawing.Point(11, 186);
            this.btnCarve.Name = "btnCarve";
            this.btnCarve.Size = new System.Drawing.Size(157, 27);
            this.btnCarve.TabIndex = 1;
            this.btnCarve.Text = "Reconstruct Files";
            this.btnCarve.UseVisualStyleBackColor = true;
            this.btnCarve.Click += new System.EventHandler(this.btnCarve_Click);
            // 
            // btnAnalysisLog
            // 
            this.btnAnalysisLog.Enabled = false;
            this.btnAnalysisLog.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAnalysisLog.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalysisLog.Location = new System.Drawing.Point(174, 186);
            this.btnAnalysisLog.Name = "btnAnalysisLog";
            this.btnAnalysisLog.Size = new System.Drawing.Size(157, 27);
            this.btnAnalysisLog.TabIndex = 2;
            this.btnAnalysisLog.Text = "Open Analysis Log";
            this.btnAnalysisLog.UseVisualStyleBackColor = true;
            this.btnAnalysisLog.Click += new System.EventHandler(this.btnAnalysisLog_Click);
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.btnStop);
            this.pnlControls.Controls.Add(this.lblProgress);
            this.pnlControls.Controls.Add(this.btnAnalysisLog);
            this.pnlControls.Controls.Add(this.lblHeader);
            this.pnlControls.Controls.Add(this.grpGPUActivity);
            this.pnlControls.Controls.Add(this.btnCarve);
            this.pnlControls.Controls.Add(this.pbProgress);
            this.pnlControls.Controls.Add(this.lblProcess);
            this.pnlControls.Controls.Add(this.grpProcessed);
            this.pnlControls.Location = new System.Drawing.Point(1, 454);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(574, 221);
            this.pnlControls.TabIndex = 12;
            // 
            // pbPreview
            // 
            this.pbPreview.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pbPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbPreview.Location = new System.Drawing.Point(12, 12);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(551, 414);
            this.pbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPreview.TabIndex = 13;
            this.pbPreview.TabStop = false;
            // 
            // lblImageStatus
            // 
            this.lblImageStatus.Location = new System.Drawing.Point(12, 429);
            this.lblImageStatus.Name = "lblImageStatus";
            this.lblImageStatus.Size = new System.Drawing.Size(551, 22);
            this.lblImageStatus.TabIndex = 14;
            this.lblImageStatus.Text = "Images Queued: 0 (Preview Errors: 0)";
            this.lblImageStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Analysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(575, 675);
            this.Controls.Add(this.lblImageStatus);
            this.Controls.Add(this.pbPreview);
            this.Controls.Add(this.pnlControls);
            this.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Analysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Analysis";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Carve_FormClosing);
            this.Load += new System.EventHandler(this.Carve_Load);
            this.grpGPUActivity.ResumeLayout(false);
            this.grpGPUActivity.PerformLayout();
            this.grpProcessed.ResumeLayout(false);
            this.grpProcessed.PerformLayout();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.GroupBox grpGPUActivity;
        private System.Windows.Forms.GroupBox grpProcessed;
        private System.Windows.Forms.Label lblFound;
        private System.Windows.Forms.Label lblSegments;
        private System.Windows.Forms.TableLayoutPanel tblGPU;
        private System.Windows.Forms.Label lblTimeRemaining;
        private System.Windows.Forms.Label lblTimeElapsed;
        private System.Windows.Forms.Label lblFoundValue;
        private System.Windows.Forms.Label lblSegmentsValue;
        private System.Windows.Forms.Label lblTimeRemainingValue;
        private System.Windows.Forms.Label lblTimeElapsedValue;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnCarve;
        private System.Windows.Forms.Button btnAnalysisLog;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.PictureBox pbPreview;
        private System.Windows.Forms.Label lblImageStatus;
    }
}