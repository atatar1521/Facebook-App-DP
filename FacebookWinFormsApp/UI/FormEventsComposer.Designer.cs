namespace BasicFacebookFeatures.UI
{
    partial class FormEventComposer
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
            this.labelStartingOn = new System.Windows.Forms.Label();
            this.labelMinimumAttendingCount = new System.Windows.Forms.Label();
            this.labelMaximumAttendingCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.textBoxMinAttending = new System.Windows.Forms.TextBox();
            this.textBoxMaxAttending = new System.Windows.Forms.TextBox();
            this.buttonCancle = new System.Windows.Forms.Button();
            this.buttonApprove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelStartingOn
            // 
            this.labelStartingOn.AutoSize = true;
            this.labelStartingOn.Location = new System.Drawing.Point(53, 135);
            this.labelStartingOn.Name = "labelStartingOn";
            this.labelStartingOn.Size = new System.Drawing.Size(58, 13);
            this.labelStartingOn.TabIndex = 0;
            this.labelStartingOn.Text = "Starting on";
            // 
            // labelMinimumAttendingCount
            // 
            this.labelMinimumAttendingCount.AutoSize = true;
            this.labelMinimumAttendingCount.Location = new System.Drawing.Point(53, 176);
            this.labelMinimumAttendingCount.Name = "labelMinimumAttendingCount";
            this.labelMinimumAttendingCount.Size = new System.Drawing.Size(127, 13);
            this.labelMinimumAttendingCount.TabIndex = 1;
            this.labelMinimumAttendingCount.Text = "Minimum Attending Count";
            // 
            // labelMaximumAttendingCount
            // 
            this.labelMaximumAttendingCount.AutoSize = true;
            this.labelMaximumAttendingCount.Location = new System.Drawing.Point(53, 216);
            this.labelMaximumAttendingCount.Name = "labelMaximumAttendingCount";
            this.labelMaximumAttendingCount.Size = new System.Drawing.Size(133, 13);
            this.labelMaximumAttendingCount.TabIndex = 2;
            this.labelMaximumAttendingCount.Text = "Maximum  Attending Count";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(502, 109);
            this.label4.TabIndex = 3;
            this.label4.Text = "Choose Maximum And Minimum Attending Participants due to Covid-19 Regulation ";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(205, 135);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStart.TabIndex = 4;
            // 
            // textBoxMinAttending
            // 
            this.textBoxMinAttending.Location = new System.Drawing.Point(220, 173);
            this.textBoxMinAttending.Name = "textBoxMinAttending";
            this.textBoxMinAttending.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinAttending.TabIndex = 5;
            this.textBoxMinAttending.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMinAttending_KeyPress);
            // 
            // textBoxMaxAttending
            // 
            this.textBoxMaxAttending.Location = new System.Drawing.Point(220, 213);
            this.textBoxMaxAttending.Name = "textBoxMaxAttending";
            this.textBoxMaxAttending.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxAttending.TabIndex = 6;
            this.textBoxMaxAttending.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMaxAttending_KeyPress);
            // 
            // buttonCancle
            // 
            this.buttonCancle.Location = new System.Drawing.Point(153, 276);
            this.buttonCancle.Name = "buttonCancle";
            this.buttonCancle.Size = new System.Drawing.Size(123, 23);
            this.buttonCancle.TabIndex = 7;
            this.buttonCancle.Text = "Cancel";
            this.buttonCancle.UseVisualStyleBackColor = true;
            this.buttonCancle.Click += new System.EventHandler(this.buttonCancle_Click);
            // 
            // buttonApprove
            // 
            this.buttonApprove.Location = new System.Drawing.Point(282, 276);
            this.buttonApprove.Name = "buttonApprove";
            this.buttonApprove.Size = new System.Drawing.Size(123, 23);
            this.buttonApprove.TabIndex = 8;
            this.buttonApprove.Text = "Approve";
            this.buttonApprove.UseVisualStyleBackColor = true;
            this.buttonApprove.Click += new System.EventHandler(this.buttonApprove_Click);
            // 
            // FormEventComposer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 337);
            this.Controls.Add(this.buttonApprove);
            this.Controls.Add(this.buttonCancle);
            this.Controls.Add(this.textBoxMaxAttending);
            this.Controls.Add(this.textBoxMinAttending);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelMaximumAttendingCount);
            this.Controls.Add(this.labelMinimumAttendingCount);
            this.Controls.Add(this.labelStartingOn);
            this.Name = "FormEventComposer";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormEventComposer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStartingOn;
        private System.Windows.Forms.Label labelMinimumAttendingCount;
        private System.Windows.Forms.Label labelMaximumAttendingCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.TextBox textBoxMinAttending;
        private System.Windows.Forms.TextBox textBoxMaxAttending;
        private System.Windows.Forms.Button buttonCancle;
        private System.Windows.Forms.Button buttonApprove;
    }
}