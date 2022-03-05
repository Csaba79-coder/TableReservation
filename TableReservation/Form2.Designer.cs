namespace TableReservation
{
    partial class ApplyForm
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
            this.tbNameOfGuest = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numNumberOfGuest = new System.Windows.Forms.NumericUpDown();
            this.numArrivalHour = new System.Windows.Forms.NumericUpDown();
            this.dtbArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.cbRegularGuest = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfGuest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArrivalHour)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNameOfGuest
            // 
            this.tbNameOfGuest.Location = new System.Drawing.Point(44, 36);
            this.tbNameOfGuest.Name = "tbNameOfGuest";
            this.tbNameOfGuest.Size = new System.Drawing.Size(100, 23);
            this.tbNameOfGuest.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(44, 18);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(86, 15);
            this.label.TabIndex = 1;
            this.label.Text = "Name of Guest";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of Guests";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Arrival Hour";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date of Arrival";
            // 
            // numNumberOfGuest
            // 
            this.numNumberOfGuest.Location = new System.Drawing.Point(44, 93);
            this.numNumberOfGuest.Name = "numNumberOfGuest";
            this.numNumberOfGuest.Size = new System.Drawing.Size(120, 23);
            this.numNumberOfGuest.TabIndex = 5;
            // 
            // numArrivalHour
            // 
            this.numArrivalHour.Location = new System.Drawing.Point(44, 148);
            this.numArrivalHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numArrivalHour.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numArrivalHour.Name = "numArrivalHour";
            this.numArrivalHour.Size = new System.Drawing.Size(120, 23);
            this.numArrivalHour.TabIndex = 6;
            this.numArrivalHour.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // dtbArrivalDate
            // 
            this.dtbArrivalDate.Location = new System.Drawing.Point(44, 218);
            this.dtbArrivalDate.Name = "dtbArrivalDate";
            this.dtbArrivalDate.Size = new System.Drawing.Size(197, 23);
            this.dtbArrivalDate.TabIndex = 7;
            // 
            // cbRegularGuest
            // 
            this.cbRegularGuest.AutoSize = true;
            this.cbRegularGuest.Location = new System.Drawing.Point(43, 270);
            this.cbRegularGuest.Name = "cbRegularGuest";
            this.cbRegularGuest.Size = new System.Drawing.Size(99, 19);
            this.cbRegularGuest.TabIndex = 8;
            this.cbRegularGuest.Text = "Regular Guest";
            this.cbRegularGuest.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(40, 327);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ApplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbRegularGuest);
            this.Controls.Add(this.dtbArrivalDate);
            this.Controls.Add(this.numArrivalHour);
            this.Controls.Add(this.numNumberOfGuest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.tbNameOfGuest);
            this.Name = "ApplyForm";
            this.Text = "Apply Form";
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfGuest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArrivalHour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbNameOfGuest;
        private Label label;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown numNumberOfGuest;
        private NumericUpDown numArrivalHour;
        private DateTimePicker dtbArrivalDate;
        private CheckBox cbRegularGuest;
        private Button btnAdd;
    }
}