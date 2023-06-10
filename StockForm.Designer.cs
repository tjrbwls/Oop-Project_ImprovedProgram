namespace OopProject
{
    partial class StateForm
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
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_number = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "재고명";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "수량";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(403, 64);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(86, 23);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "재고 검색";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(122, 394);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(132, 23);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "선택 재고 수정";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.Button2_Click);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(100, 33);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(154, 25);
            this.tb_name.TabIndex = 5;
            // 
            // tb_number
            // 
            this.tb_number.Location = new System.Drawing.Point(325, 33);
            this.tb_number.Name = "tb_number";
            this.tb_number.Size = new System.Drawing.Size(164, 25);
            this.tb_number.TabIndex = 6;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(285, 394);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(133, 23);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "선택 재고 삭제";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(403, 93);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(86, 23);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "재고 추가";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.number});
            this.dataGridView1.Location = new System.Drawing.Point(61, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(428, 258);
            this.dataGridView1.TabIndex = 12;
            // 
            // name
            // 
            this.name.HeaderText = "재고명";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 187;
            // 
            // number
            // 
            this.number.HeaderText = "수량";
            this.number.MinimumWidth = 6;
            this.number.Name = "number";
            this.number.Width = 187;
            // 
            // StateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.tb_number);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StateForm";
            this.Text = "재고 관리";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_number;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
    }
}
