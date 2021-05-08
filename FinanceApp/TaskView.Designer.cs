
namespace FinanceApp
{
    partial class TaskView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskView));
            this.radioRecurring = new System.Windows.Forms.RadioButton();
            this.radioOneOff = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.taskTitle = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.taskDescription = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.taskStatus = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioRecurring
            // 
            this.radioRecurring.AutoSize = true;
            this.radioRecurring.Location = new System.Drawing.Point(178, 26);
            this.radioRecurring.Name = "radioRecurring";
            this.radioRecurring.Size = new System.Drawing.Size(85, 21);
            this.radioRecurring.TabIndex = 0;
            this.radioRecurring.TabStop = true;
            this.radioRecurring.Text = "Recurring";
            this.radioRecurring.UseVisualStyleBackColor = true;
            // 
            // radioOneOff
            // 
            this.radioOneOff.AutoSize = true;
            this.radioOneOff.Location = new System.Drawing.Point(366, 26);
            this.radioOneOff.Name = "radioOneOff";
            this.radioOneOff.Size = new System.Drawing.Size(74, 21);
            this.radioOneOff.TabIndex = 1;
            this.radioOneOff.TabStop = true;
            this.radioOneOff.Text = "One-off";
            this.radioOneOff.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SlateGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(178, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 18);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Title";
            // 
            // taskTitle
            // 
            this.taskTitle.Location = new System.Drawing.Point(366, 74);
            this.taskTitle.Name = "taskTitle";
            this.taskTitle.Size = new System.Drawing.Size(186, 25);
            this.taskTitle.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.SlateGray;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(178, 120);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 18);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Description";
            // 
            // taskDescription
            // 
            this.taskDescription.Location = new System.Drawing.Point(366, 117);
            this.taskDescription.Name = "taskDescription";
            this.taskDescription.Size = new System.Drawing.Size(186, 25);
            this.taskDescription.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.SlateGray;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.ForeColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(178, 165);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 18);
            this.textBox5.TabIndex = 6;
            this.textBox5.Text = "Status";
            // 
            // taskStatus
            // 
            this.taskStatus.Location = new System.Drawing.Point(366, 165);
            this.taskStatus.Name = "taskStatus";
            this.taskStatus.Size = new System.Drawing.Size(186, 25);
            this.taskStatus.TabIndex = 7;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit.Location = new System.Drawing.Point(264, 226);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(157, 27);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.SubmitTask);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(618, 184);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 121);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // TaskView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(754, 306);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.taskStatus);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.taskDescription);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.taskTitle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioOneOff);
            this.Controls.Add(this.radioRecurring);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "TaskView";
            this.Text = "Create Task";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioRecurring;
        private System.Windows.Forms.RadioButton radioOneOff;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox taskTitle;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox taskDescription;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox taskStatus;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}