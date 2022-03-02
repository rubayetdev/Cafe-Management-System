
namespace Cafe_Management_System
{
    partial class Employe
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtaddr = new System.Windows.Forms.TextBox();
            this.txtphn = new System.Windows.Forms.TextBox();
            this.btnInt = new System.Windows.Forms.Button();
            this.btnupd = new System.Windows.Forms.Button();
            this.btnrmv = new System.Windows.Forms.Button();
            this.btnrst = new System.Windows.Forms.Button();
            this.DataEmployee = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Waiter ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 186);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone Number:";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(261, 25);
            this.txtid.Margin = new System.Windows.Forms.Padding(2);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(218, 26);
            this.txtid.TabIndex = 4;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(261, 77);
            this.txtname.Margin = new System.Windows.Forms.Padding(2);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(218, 26);
            this.txtname.TabIndex = 5;
            // 
            // txtaddr
            // 
            this.txtaddr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddr.Location = new System.Drawing.Point(261, 127);
            this.txtaddr.Margin = new System.Windows.Forms.Padding(2);
            this.txtaddr.Name = "txtaddr";
            this.txtaddr.Size = new System.Drawing.Size(218, 26);
            this.txtaddr.TabIndex = 6;
            // 
            // txtphn
            // 
            this.txtphn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphn.Location = new System.Drawing.Point(261, 180);
            this.txtphn.Margin = new System.Windows.Forms.Padding(2);
            this.txtphn.Name = "txtphn";
            this.txtphn.Size = new System.Drawing.Size(218, 26);
            this.txtphn.TabIndex = 7;
            // 
            // btnInt
            // 
            this.btnInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInt.Location = new System.Drawing.Point(82, 245);
            this.btnInt.Margin = new System.Windows.Forms.Padding(2);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(78, 29);
            this.btnInt.TabIndex = 8;
            this.btnInt.Text = "Insert";
            this.btnInt.UseVisualStyleBackColor = true;
            this.btnInt.Click += new System.EventHandler(this.btnInt_Click);
            // 
            // btnupd
            // 
            this.btnupd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupd.Location = new System.Drawing.Point(171, 245);
            this.btnupd.Margin = new System.Windows.Forms.Padding(2);
            this.btnupd.Name = "btnupd";
            this.btnupd.Size = new System.Drawing.Size(78, 28);
            this.btnupd.TabIndex = 10;
            this.btnupd.Text = "Update";
            this.btnupd.UseVisualStyleBackColor = true;
            this.btnupd.Click += new System.EventHandler(this.btnupd_Click);
            // 
            // btnrmv
            // 
            this.btnrmv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrmv.Location = new System.Drawing.Point(260, 245);
            this.btnrmv.Margin = new System.Windows.Forms.Padding(2);
            this.btnrmv.Name = "btnrmv";
            this.btnrmv.Size = new System.Drawing.Size(91, 28);
            this.btnrmv.TabIndex = 11;
            this.btnrmv.Text = "Remove";
            this.btnrmv.UseVisualStyleBackColor = true;
            this.btnrmv.Click += new System.EventHandler(this.btnrmv_Click);
            // 
            // btnrst
            // 
            this.btnrst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrst.Location = new System.Drawing.Point(362, 245);
            this.btnrst.Margin = new System.Windows.Forms.Padding(2);
            this.btnrst.Name = "btnrst";
            this.btnrst.Size = new System.Drawing.Size(78, 28);
            this.btnrst.TabIndex = 12;
            this.btnrst.Text = "Reset";
            this.btnrst.UseVisualStyleBackColor = true;
            this.btnrst.Click += new System.EventHandler(this.btnrst_Click);
            // 
            // DataEmployee
            // 
            this.DataEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataEmployee.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataEmployee.Location = new System.Drawing.Point(37, 283);
            this.DataEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.DataEmployee.Name = "DataEmployee";
            this.DataEmployee.RowHeadersWidth = 62;
            this.DataEmployee.RowTemplate.Height = 28;
            this.DataEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataEmployee.Size = new System.Drawing.Size(442, 103);
            this.DataEmployee.TabIndex = 13;
            this.DataEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataEmployee_CellContentClick);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(403, 395);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Employe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 430);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.DataEmployee);
            this.Controls.Add(this.btnrst);
            this.Controls.Add(this.btnrmv);
            this.Controls.Add(this.btnupd);
            this.Controls.Add(this.btnInt);
            this.Controls.Add(this.txtphn);
            this.Controls.Add(this.txtaddr);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Employe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employe";
            this.Load += new System.EventHandler(this.Employe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtaddr;
        private System.Windows.Forms.TextBox txtphn;
        private System.Windows.Forms.Button btnInt;
        private System.Windows.Forms.Button btnupd;
        private System.Windows.Forms.Button btnrmv;
        private System.Windows.Forms.Button btnrst;
        private System.Windows.Forms.DataGridView DataEmployee;
        private System.Windows.Forms.Button btnBack;
    }
}