namespace HostSimulator
{
    partial class ErrLimit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TransactionsList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Send = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DriverName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ErrProduct = new System.Windows.Forms.RadioButton();
            this.ErrTime = new System.Windows.Forms.RadioButton();
            this.ErrUnknown = new System.Windows.Forms.RadioButton();
            this.ErrLim = new System.Windows.Forms.RadioButton();
            this.ErrStation = new System.Windows.Forms.RadioButton();
            this.OK = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Absolute = new System.Windows.Forms.RadioButton();
            this.Precentage = new System.Windows.Forms.RadioButton();
            this.Discount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Volume = new System.Windows.Forms.RadioButton();
            this.Limit = new System.Windows.Forms.TextBox();
            this.Money = new System.Windows.Forms.RadioButton();
            this.CardNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Request = new System.Windows.Forms.GroupBox();
            this.StationCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Message = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Request.SuspendLayout();
            this.SuspendLayout();
            // 
            // TransactionsList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            this.TransactionsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TransactionsList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TransactionsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TransactionsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column9,
            this.Column3,
            this.Column7,
            this.Column8,
            this.Column4,
            this.Column5,
            this.Column6});
            this.TransactionsList.Location = new System.Drawing.Point(6, 19);
            this.TransactionsList.Name = "TransactionsList";
            this.TransactionsList.RowHeadersVisible = false;
            this.TransactionsList.Size = new System.Drawing.Size(1135, 364);
            this.TransactionsList.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Date";
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Card Number";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Driver Name";
            this.Column9.Name = "Column9";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Station";
            this.Column3.Name = "Column3";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Reference";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Status";
            this.Column8.Name = "Column8";
            this.Column8.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Volume";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Money";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Product";
            this.Column6.Name = "Column6";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.TransactionsList);
            this.groupBox1.Location = new System.Drawing.Point(12, 413);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1240, 389);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transactions";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1159, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Clear List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(1132, 189);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 3;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DriverName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.Send);
            this.groupBox2.Location = new System.Drawing.Point(18, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1234, 241);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Respond";
            // 
            // DriverName
            // 
            this.DriverName.Location = new System.Drawing.Point(130, 33);
            this.DriverName.Name = "DriverName";
            this.DriverName.Size = new System.Drawing.Size(448, 20);
            this.DriverName.TabIndex = 19;
            this.DriverName.Text = "Alex Smith";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Driver Name:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ErrProduct);
            this.groupBox5.Controls.Add(this.ErrTime);
            this.groupBox5.Controls.Add(this.ErrUnknown);
            this.groupBox5.Controls.Add(this.ErrLim);
            this.groupBox5.Controls.Add(this.ErrStation);
            this.groupBox5.Controls.Add(this.OK);
            this.groupBox5.Location = new System.Drawing.Point(636, 74);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(459, 143);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Message";
            // 
            // ErrProduct
            // 
            this.ErrProduct.AutoSize = true;
            this.ErrProduct.Location = new System.Drawing.Point(245, 21);
            this.ErrProduct.Name = "ErrProduct";
            this.ErrProduct.Size = new System.Drawing.Size(119, 17);
            this.ErrProduct.TabIndex = 5;
            this.ErrProduct.Text = "Product not allowed";
            this.ErrProduct.UseVisualStyleBackColor = true;
            // 
            // ErrTime
            // 
            this.ErrTime.AutoSize = true;
            this.ErrTime.Location = new System.Drawing.Point(19, 115);
            this.ErrTime.Name = "ErrTime";
            this.ErrTime.Size = new System.Drawing.Size(134, 17);
            this.ErrTime.TabIndex = 4;
            this.ErrTime.Text = "Not allowed at this time";
            this.ErrTime.UseVisualStyleBackColor = true;
            // 
            // ErrUnknown
            // 
            this.ErrUnknown.AutoSize = true;
            this.ErrUnknown.Location = new System.Drawing.Point(19, 92);
            this.ErrUnknown.Name = "ErrUnknown";
            this.ErrUnknown.Size = new System.Drawing.Size(95, 17);
            this.ErrUnknown.TabIndex = 3;
            this.ErrUnknown.Text = "Unknown card";
            this.ErrUnknown.UseVisualStyleBackColor = true;
            // 
            // ErrLim
            // 
            this.ErrLim.AutoSize = true;
            this.ErrLim.Location = new System.Drawing.Point(19, 69);
            this.ErrLim.Name = "ErrLim";
            this.ErrLim.Size = new System.Drawing.Size(74, 17);
            this.ErrLim.TabIndex = 2;
            this.ErrLim.Text = "Out of limit";
            this.ErrLim.UseVisualStyleBackColor = true;
            // 
            // ErrStation
            // 
            this.ErrStation.AutoSize = true;
            this.ErrStation.Location = new System.Drawing.Point(19, 44);
            this.ErrStation.Name = "ErrStation";
            this.ErrStation.Size = new System.Drawing.Size(145, 17);
            this.ErrStation.TabIndex = 1;
            this.ErrStation.Text = "Not allowed in this station";
            this.ErrStation.UseVisualStyleBackColor = true;
            // 
            // OK
            // 
            this.OK.AutoSize = true;
            this.OK.Checked = true;
            this.OK.Location = new System.Drawing.Point(19, 21);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(40, 17);
            this.OK.TabIndex = 0;
            this.OK.TabStop = true;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Absolute);
            this.groupBox4.Controls.Add(this.Precentage);
            this.groupBox4.Controls.Add(this.Discount);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(318, 74);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(260, 143);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Discount";
            // 
            // Absolute
            // 
            this.Absolute.AutoSize = true;
            this.Absolute.Location = new System.Drawing.Point(102, 97);
            this.Absolute.Name = "Absolute";
            this.Absolute.Size = new System.Drawing.Size(66, 17);
            this.Absolute.TabIndex = 14;
            this.Absolute.Text = "Absolute";
            this.Absolute.UseVisualStyleBackColor = true;
            // 
            // Precentage
            // 
            this.Precentage.AutoSize = true;
            this.Precentage.Checked = true;
            this.Precentage.Location = new System.Drawing.Point(102, 58);
            this.Precentage.Name = "Precentage";
            this.Precentage.Size = new System.Drawing.Size(80, 17);
            this.Precentage.TabIndex = 13;
            this.Precentage.TabStop = true;
            this.Precentage.Text = "Precentage";
            this.Precentage.UseVisualStyleBackColor = true;
            // 
            // Discount
            // 
            this.Discount.Location = new System.Drawing.Point(102, 24);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(100, 20);
            this.Discount.TabIndex = 12;
            this.Discount.Text = "5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Discount:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.Volume);
            this.groupBox3.Controls.Add(this.Limit);
            this.groupBox3.Controls.Add(this.Money);
            this.groupBox3.Location = new System.Drawing.Point(19, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 143);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Limit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Limit:";
            // 
            // Volume
            // 
            this.Volume.AutoSize = true;
            this.Volume.Location = new System.Drawing.Point(65, 97);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(60, 17);
            this.Volume.TabIndex = 14;
            this.Volume.Text = "Volume";
            this.Volume.UseVisualStyleBackColor = true;
            // 
            // Limit
            // 
            this.Limit.Location = new System.Drawing.Point(65, 20);
            this.Limit.Name = "Limit";
            this.Limit.Size = new System.Drawing.Size(100, 20);
            this.Limit.TabIndex = 7;
            this.Limit.Text = "100";
            // 
            // Money
            // 
            this.Money.AutoSize = true;
            this.Money.Checked = true;
            this.Money.Location = new System.Drawing.Point(65, 58);
            this.Money.Name = "Money";
            this.Money.Size = new System.Drawing.Size(57, 17);
            this.Money.TabIndex = 13;
            this.Money.TabStop = true;
            this.Money.Text = "Money";
            this.Money.UseVisualStyleBackColor = true;
            // 
            // CardNumber
            // 
            this.CardNumber.Location = new System.Drawing.Point(130, 94);
            this.CardNumber.Name = "CardNumber";
            this.CardNumber.Size = new System.Drawing.Size(324, 20);
            this.CardNumber.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Card Number:";
            // 
            // Request
            // 
            this.Request.Controls.Add(this.StationCode);
            this.Request.Controls.Add(this.label3);
            this.Request.Controls.Add(this.Message);
            this.Request.Controls.Add(this.label1);
            this.Request.Controls.Add(this.CardNumber);
            this.Request.Location = new System.Drawing.Point(18, 25);
            this.Request.Name = "Request";
            this.Request.Size = new System.Drawing.Size(1234, 135);
            this.Request.TabIndex = 5;
            this.Request.TabStop = false;
            this.Request.Text = "Request";
            // 
            // StationCode
            // 
            this.StationCode.Location = new System.Drawing.Point(646, 94);
            this.StationCode.Name = "StationCode";
            this.StationCode.Size = new System.Drawing.Size(147, 20);
            this.StationCode.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(530, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Station Code:";
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Message.Location = new System.Drawing.Point(12, 29);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(508, 37);
            this.Message.TabIndex = 6;
            this.Message.Text = "Waiting for authorization request...";
            // 
            // ErrLimit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 814);
            this.Controls.Add(this.Request);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ErrLimit";
            this.Text = "Host Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Request.ResumeLayout(false);
            this.Request.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox CardNumber;
        private System.Windows.Forms.RadioButton Volume;
        private System.Windows.Forms.RadioButton Money;
        private System.Windows.Forms.TextBox Discount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Limit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Request;
        private System.Windows.Forms.TextBox StationCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton Absolute;
        private System.Windows.Forms.RadioButton Precentage;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton ErrTime;
        private System.Windows.Forms.RadioButton ErrUnknown;
        private System.Windows.Forms.RadioButton ErrLim;
        private System.Windows.Forms.RadioButton ErrStation;
        private System.Windows.Forms.RadioButton OK;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton ErrProduct;
        public System.Windows.Forms.DataGridView TransactionsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox DriverName;
        private System.Windows.Forms.Label label5;
    }
}

