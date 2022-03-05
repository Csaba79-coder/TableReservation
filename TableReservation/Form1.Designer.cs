namespace TableReservation
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
            this.lbReservation = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbGuestName = new System.Windows.Forms.TextBox();
            this.tbNumberOfPerson = new System.Windows.Forms.TextBox();
            this.tbArrivalHour = new System.Windows.Forms.TextBox();
            this.tbArrivalDate = new System.Windows.Forms.TextBox();
            this.cbRegularGuest = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbReservation
            // 
            this.lbReservation.FormattingEnabled = true;
            this.lbReservation.ItemHeight = 15;
            this.lbReservation.Location = new System.Drawing.Point(84, 44);
            this.lbReservation.Name = "lbReservation";
            this.lbReservation.Size = new System.Drawing.Size(120, 259);
            this.lbReservation.TabIndex = 0;
            this.lbReservation.SelectedIndexChanged += new System.EventHandler(this.lbReservation_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(103, 322);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbGuestName
            // 
            this.tbGuestName.Location = new System.Drawing.Point(268, 80);
            this.tbGuestName.Name = "tbGuestName";
            this.tbGuestName.Size = new System.Drawing.Size(100, 23);
            this.tbGuestName.TabIndex = 2;
            this.tbGuestName.TextChanged += new System.EventHandler(this.tbGuestName_TextChanged);
            // 
            // tbNumberOfPerson
            // 
            this.tbNumberOfPerson.Location = new System.Drawing.Point(268, 137);
            this.tbNumberOfPerson.Name = "tbNumberOfPerson";
            this.tbNumberOfPerson.Size = new System.Drawing.Size(100, 23);
            this.tbNumberOfPerson.TabIndex = 3;
            this.tbNumberOfPerson.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbArrivalHour
            // 
            this.tbArrivalHour.Location = new System.Drawing.Point(268, 209);
            this.tbArrivalHour.Name = "tbArrivalHour";
            this.tbArrivalHour.Size = new System.Drawing.Size(100, 23);
            this.tbArrivalHour.TabIndex = 4;
            // 
            // tbArrivalDate
            // 
            this.tbArrivalDate.Location = new System.Drawing.Point(268, 280);
            this.tbArrivalDate.Name = "tbArrivalDate";
            this.tbArrivalDate.Size = new System.Drawing.Size(100, 23);
            this.tbArrivalDate.TabIndex = 5;
            // 
            // cbRegularGuest
            // 
            this.cbRegularGuest.AutoSize = true;
            this.cbRegularGuest.Location = new System.Drawing.Point(268, 326);
            this.cbRegularGuest.Name = "cbRegularGuest";
            this.cbRegularGuest.Size = new System.Drawing.Size(99, 19);
            this.cbRegularGuest.TabIndex = 6;
            this.cbRegularGuest.Text = "Regular Guest";
            this.cbRegularGuest.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbRegularGuest);
            this.Controls.Add(this.tbArrivalDate);
            this.Controls.Add(this.tbArrivalHour);
            this.Controls.Add(this.tbNumberOfPerson);
            this.Controls.Add(this.tbGuestName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbReservation);
            this.Name = "Form1";
            this.Text = "Reservation App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lbReservation;
        private Button btnAdd;
        private TextBox tbGuestName;
        private TextBox tbNumberOfPerson;
        private TextBox tbArrivalHour;
        private TextBox tbArrivalDate;
        private CheckBox cbRegularGuest;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}