
namespace Cafe_Management_System
{
    partial class All_Item
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
            this.ItemData = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnsrch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ItemData)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemData
            // 
            this.ItemData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItemData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ItemData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ItemData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemData.Location = new System.Drawing.Point(12, 12);
            this.ItemData.Name = "ItemData";
            this.ItemData.RowHeadersWidth = 62;
            this.ItemData.Size = new System.Drawing.Size(776, 368);
            this.ItemData.TabIndex = 0;
            this.ItemData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemData_CellContentClick);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(734, 411);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(54, 27);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnsrch
            // 
            this.btnsrch.Location = new System.Drawing.Point(645, 411);
            this.btnsrch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsrch.Name = "btnsrch";
            this.btnsrch.Size = new System.Drawing.Size(50, 27);
            this.btnsrch.TabIndex = 2;
            this.btnsrch.Text = "Search";
            this.btnsrch.UseVisualStyleBackColor = true;
            this.btnsrch.Click += new System.EventHandler(this.btnsrch_Click);
            // 
            // All_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsrch);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.ItemData);
            this.Name = "All_Item";
            this.Text = "All_Item";
            this.Load += new System.EventHandler(this.All_Item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ItemData;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnsrch;
    }
}