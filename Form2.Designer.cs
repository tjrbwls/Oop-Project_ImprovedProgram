namespace OopProject
{
    partial class Form2
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
            this.money_btn = new System.Windows.Forms.Button();
            this.menu_btn = new System.Windows.Forms.Button();
            this.state_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20F);
            this.label1.Location = new System.Drawing.Point(181, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "보고 싶은것을 선택하세요";
            // 
            // money_btn
            // 
            this.money_btn.Location = new System.Drawing.Point(341, 127);
            this.money_btn.Name = "money_btn";
            this.money_btn.Size = new System.Drawing.Size(93, 23);
            this.money_btn.TabIndex = 1;
            this.money_btn.Text = "매출";
            this.money_btn.UseVisualStyleBackColor = true;
            this.money_btn.Click += new System.EventHandler(this.money_btn_Click);
            // 
            // menu_btn
            // 
            this.menu_btn.Location = new System.Drawing.Point(341, 225);
            this.menu_btn.Name = "menu_btn";
            this.menu_btn.Size = new System.Drawing.Size(93, 23);
            this.menu_btn.TabIndex = 2;
            this.menu_btn.Text = "메뉴";
            this.menu_btn.UseVisualStyleBackColor = true;
            this.menu_btn.Click += new System.EventHandler(this.menu_btn_Click);
            // 
            // state_btn
            // 
            this.state_btn.Location = new System.Drawing.Point(341, 320);
            this.state_btn.Name = "state_btn";
            this.state_btn.Size = new System.Drawing.Size(93, 23);
            this.state_btn.TabIndex = 3;
            this.state_btn.Text = "재고";
            this.state_btn.UseVisualStyleBackColor = true;
            this.state_btn.Click += new System.EventHandler(this.state_btn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.state_btn);
            this.Controls.Add(this.menu_btn);
            this.Controls.Add(this.money_btn);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "보고싶은 것";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button money_btn;
        private System.Windows.Forms.Button menu_btn;
        private System.Windows.Forms.Button state_btn;
    }
}