
namespace BCA_Practical.Pages
{
    partial class DistrictForm
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
            this.gvDistrict = new System.Windows.Forms.DataGridView();
            this.DistrictName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistrictCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProvinceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDistrictName = new System.Windows.Forms.TextBox();
            this.txtDistrictCode = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvDistrict)).BeginInit();
            this.SuspendLayout();
            // 
            // gvDistrict
            // 
            this.gvDistrict.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvDistrict.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDistrict.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DistrictName,
            this.DistrictCode,
            this.ProvinceID});
            this.gvDistrict.Location = new System.Drawing.Point(12, 142);
            this.gvDistrict.Name = "gvDistrict";
            this.gvDistrict.Size = new System.Drawing.Size(406, 244);
            this.gvDistrict.TabIndex = 0;
            // 
            // DistrictName
            // 
            this.DistrictName.DataPropertyName = "DistrictName";
            this.DistrictName.HeaderText = "District Name";
            this.DistrictName.Name = "DistrictName";
            // 
            // DistrictCode
            // 
            this.DistrictCode.DataPropertyName = "DistrictCode";
            this.DistrictCode.HeaderText = "DistrictCode";
            this.DistrictCode.Name = "DistrictCode";
            // 
            // ProvinceID
            // 
            this.ProvinceID.DataPropertyName = "ProvinceID";
            this.ProvinceID.HeaderText = "ProvinceID";
            this.ProvinceID.Name = "ProvinceID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "District Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "District Code";
            // 
            // txtDistrictName
            // 
            this.txtDistrictName.Location = new System.Drawing.Point(12, 85);
            this.txtDistrictName.Name = "txtDistrictName";
            this.txtDistrictName.Size = new System.Drawing.Size(100, 20);
            this.txtDistrictName.TabIndex = 3;
            // 
            // txtDistrictCode
            // 
            this.txtDistrictCode.Location = new System.Drawing.Point(119, 85);
            this.txtDistrictCode.Name = "txtDistrictCode";
            this.txtDistrictCode.Size = new System.Drawing.Size(100, 20);
            this.txtDistrictCode.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(226, 81);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(22, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "District List";
            // 
            // DistrictForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 398);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtDistrictCode);
            this.Controls.Add(this.txtDistrictName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvDistrict);
            this.Name = "DistrictForm";
            this.Text = "DistrictForm";
            ((System.ComponentModel.ISupportInitialize)(this.gvDistrict)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvDistrict;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistrictName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistrictCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProvinceID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDistrictName;
        private System.Windows.Forms.TextBox txtDistrictCode;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
    }
}