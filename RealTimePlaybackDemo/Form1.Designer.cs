
namespace RealTimePlaybackDemo
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
            this.StopButton = new System.Windows.Forms.Button();
            this.RecordButton = new System.Windows.Forms.Button();
            this.PlaybackDeviceComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RecordingDeviceComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(425, 328);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(107, 44);
            this.StopButton.TabIndex = 15;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // RecordButton
            // 
            this.RecordButton.Location = new System.Drawing.Point(269, 328);
            this.RecordButton.Name = "RecordButton";
            this.RecordButton.Size = new System.Drawing.Size(107, 44);
            this.RecordButton.TabIndex = 14;
            this.RecordButton.Text = "Record";
            this.RecordButton.UseVisualStyleBackColor = true;
            this.RecordButton.Click += new System.EventHandler(this.RecordButton_Click);
            // 
            // PlaybackDeviceComboBox
            // 
            this.PlaybackDeviceComboBox.FormattingEnabled = true;
            this.PlaybackDeviceComboBox.Location = new System.Drawing.Point(269, 211);
            this.PlaybackDeviceComboBox.Name = "PlaybackDeviceComboBox";
            this.PlaybackDeviceComboBox.Size = new System.Drawing.Size(397, 28);
            this.PlaybackDeviceComboBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Playback Device";
            // 
            // RecordingDeviceComboBox
            // 
            this.RecordingDeviceComboBox.FormattingEnabled = true;
            this.RecordingDeviceComboBox.Location = new System.Drawing.Point(269, 124);
            this.RecordingDeviceComboBox.Name = "RecordingDeviceComboBox";
            this.RecordingDeviceComboBox.Size = new System.Drawing.Size(397, 28);
            this.RecordingDeviceComboBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Recording Device";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.RecordButton);
            this.Controls.Add(this.PlaybackDeviceComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RecordingDeviceComboBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button RecordButton;
        private System.Windows.Forms.ComboBox PlaybackDeviceComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox RecordingDeviceComboBox;
        private System.Windows.Forms.Label label1;
    }
}

