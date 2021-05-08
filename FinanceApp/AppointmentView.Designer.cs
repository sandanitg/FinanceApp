
namespace FinanceApp
{
    partial class AppointmentView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentView));
            this.radioRecurring = new System.Windows.Forms.RadioButton();
            this.radioOneoff = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.appTitle = new System.Windows.Forms.TextBox();
            this.appStartTime = new System.Windows.Forms.DateTimePicker();
            this.appEndTime = new System.Windows.Forms.DateTimePicker();
            this.appLocation = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioRecurring
            // 
            this.radioRecurring.AutoSize = true;
            this.radioRecurring.Location = new System.Drawing.Point(163, 36);
            this.radioRecurring.Name = "radioRecurring";
            this.radioRecurring.Size = new System.Drawing.Size(85, 21);
            this.radioRecurring.TabIndex = 0;
            this.radioRecurring.TabStop = true;
            this.radioRecurring.Text = "Recurring";
            this.radioRecurring.UseVisualStyleBackColor = true;
            // 
            // radioOneoff
            // 
            this.radioOneoff.AutoSize = true;
            this.radioOneoff.Location = new System.Drawing.Point(362, 36);
            this.radioOneoff.Name = "radioOneoff";
            this.radioOneoff.Size = new System.Drawing.Size(74, 21);
            this.radioOneoff.TabIndex = 1;
            this.radioOneoff.TabStop = true;
            this.radioOneoff.Text = "One-off";
            this.radioOneoff.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SlateGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(163, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 18);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Title";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.SlateGray;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(163, 132);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 18);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Start Time";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.SlateGray;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(163, 171);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 18);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "End time";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.SlateGray;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(163, 210);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 18);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "Location";
            // 
            // appTitle
            // 
            this.appTitle.Location = new System.Drawing.Point(348, 86);
            this.appTitle.Name = "appTitle";
            this.appTitle.Size = new System.Drawing.Size(242, 25);
            this.appTitle.TabIndex = 6;
            // 
            // appStartTime
            // 
            this.appStartTime.Location = new System.Drawing.Point(348, 127);
            this.appStartTime.Name = "appStartTime";
            this.appStartTime.Size = new System.Drawing.Size(242, 25);
            this.appStartTime.TabIndex = 7;
            // 
            // appEndTime
            // 
            this.appEndTime.Location = new System.Drawing.Point(348, 168);
            this.appEndTime.Name = "appEndTime";
            this.appEndTime.Size = new System.Drawing.Size(242, 25);
            this.appEndTime.TabIndex = 8;
            this.appEndTime.ValueChanged += new System.EventHandler(this.ValidateEndDate);
            // 
            // appLocation
            // 
            this.appLocation.Location = new System.Drawing.Point(348, 209);
            this.appLocation.Name = "appLocation";
            this.appLocation.Size = new System.Drawing.Size(242, 25);
            this.appLocation.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit.Location = new System.Drawing.Point(265, 271);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(145, 32);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.SubmitAppointment);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(625, 238);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 141);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // AppointmentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(787, 379);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.appLocation);
            this.Controls.Add(this.appEndTime);
            this.Controls.Add(this.appStartTime);
            this.Controls.Add(this.appTitle);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioOneoff);
            this.Controls.Add(this.radioRecurring);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "AppointmentView";
            this.Text = "Create Appointment";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioRecurring;
        private System.Windows.Forms.RadioButton radioOneoff;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox appTitle;
        private System.Windows.Forms.DateTimePicker appStartTime;
        private System.Windows.Forms.DateTimePicker appEndTime;
        private System.Windows.Forms.TextBox appLocation;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}