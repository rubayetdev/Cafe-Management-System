
namespace Cafe_Management_System
{
    partial class Chef
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
            this.DataChef = new System.Windows.Forms.DataGridView();
            this.btnrst = new System.Windows.Forms.Button();
            this.btnrmv = new System.Windows.Forms.Button();
            this.btnupd = new System.Windows.Forms.Button();
            this.btnInt = new System.Windows.Forms.Button();
            this.txtphn = new System.Windows.Forms.TextBox();
            this.txtaddr = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataChef)).BeginInit();
            this.SuspendLayout();
            // 
            // DataChef
            // 
            this.DataChef.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataChef.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataChef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataChef.Location = new System.Drawing.Point(11, 207);
            this.DataChef.Margin = new System.Windows.Forms.Padding(2);
            this.DataChef.Name = "DataChef";
            this.DataChef.RowHeadersWidth = 62;
            this.DataChef.RowTemplate.Height = 28;
            this.DataChef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataChef.Size = new System.Drawing.Size(778, 178);
            this.DataChef.TabIndex = 26;
            this.DataChef.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataChef_CellContentClick);
            // 
            // btnrst
            // 
            this.btnrst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrst.Location = new System.Drawing.Point(504, 411);
            this.btnrst.Margin = new System.Windows.Forms.Padding(2);
            this.btnrst.Name = "btnrst";
            this.btnrst.Size = new System.Drawing.Size(78, 28);
            this.btnrst.TabIndex = 25;
            this.btnrst.Text = "Reset";
            this.btnrst.UseVisualStyleBackColor = true;
            this.btnrst.Click += new System.EventHandler(this.btnrst_Click);
            // 
            // btnrmv
            // 
            this.btnrmv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrmv.Location = new System.Drawing.Point(402, 411);
            this.btnrmv.Margin = new System.Windows.Forms.Padding(2);
            this.btnrmv.Name = "btnrmv";
            this.btnrmv.Size = new System.Drawing.Size(91, 28);
            this.btnrmv.TabIndex = 24;
            this.btnrmv.Text = "Remove";
            this.btnrmv.UseVisualStyleBackColor = true;
            this.btnrmv.Click += new System.EventHandler(this.btnrmv_Click);
            // 
            // btnupd
            // 
            this.btnupd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupd.Location = new System.Drawing.Point(313, 411);
            this.btnupd.Margin = new System.Windows.Forms.Padding(2);
            this.btnupd.Name = "btnupd";
            this.btnupd.Size = new System.Drawing.Size(78, 28);
            this.btnupd.TabIndex = 23;
            this.btnupd.Text = "Update";
            this.btnupd.UseVisualStyleBackColor = true;
            this.btnupd.Click += new System.EventHandler(this.btnupd_Click);
            // 
            // btnInt
            // 
            this.btnInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInt.Location = new System.Drawing.Point(224, 411);
            this.btnInt.Margin = new System.Windows.Forms.Padding(2);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(78, 29);
            this.btnInt.TabIndex = 22;
            this.btnInt.Text = "Insert";
            this.btnInt.UseVisualStyleBackColor = true;
            this.btnInt.Click += new System.EventHandler(this.btnInt_Click);
            // 
            // txtphn
            // 
            this.txtphn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphn.Location = new System.Drawing.Point(377, 160);
            this.txtphn.Margin = new System.Windows.Forms.Padding(2);
            this.txtphn.Name = "txtphn";
            this.txtphn.Size = new System.Drawing.Size(218, 26);
            this.txtphn.TabIndex = 21;
            // 
            // txtaddr
            // 
            this.txtaddr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddr.Location = new System.Drawing.Point(377, 107);
            this.txtaddr.Margin = new System.Windows.Forms.Padding(2);
            this.txtaddr.Name = "txtaddr";
            this.txtaddr.Size = new System.Drawing.Size(218, 26);
            this.txtaddr.TabIndex = 20;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(377, 57);
            this.txtname.Margin = new System.Windows.Forms.Padding(2);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(218, 26);
            this.txtname.TabIndex = 19;
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(377, 5);
            this.txtid.Margin = new System.Windows.Forms.Padding(2);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(218, 26);
            this.txtid.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(162, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Phone Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(162, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Chef ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(713, 411);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 27;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Chef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.DataChef);
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
            this.Name = "Chef";
            this.Text = "Chef";
            this.Load += new System.EventHandler(this.Chef_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataChef)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataChef;
        private System.Windows.Forms.Button btnrst;
        private System.Windows.Forms.Button btnrmv;
        private System.Windows.Forms.Button btnupd;
        private System.Windows.Forms.Button btnInt;
        private System.Windows.Forms.TextBox txtphn;
        private System.Windows.Forms.TextBox txtaddr;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
    }
}