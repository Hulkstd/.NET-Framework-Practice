namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbbSelect = new System.Windows.Forms.ComboBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cbbSelect
            // 
            this.cbbSelect.FormattingEnabled = true;
            this.cbbSelect.Items.AddRange(new object[] {
            "2 단",
            "3 단",
            "4 단",
            "5 단",
            "6 단",
            "7 단",
            "8 단",
            "9 단",
            "10 단",
            "11 단",
            "12 단",
            "13 단",
            "14 단",
            "15 단",
            "16 단",
            "17 단",
            "18 단",
            "19 단"});
            this.cbbSelect.Location = new System.Drawing.Point(57, 12);
            this.cbbSelect.Name = "cbbSelect";
            this.cbbSelect.Size = new System.Drawing.Size(239, 20);
            this.cbbSelect.TabIndex = 0;
            this.cbbSelect.SelectedIndexChanged += new System.EventHandler(this.cbbSelect_SelectedIndexChanged);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblSelect.Location = new System.Drawing.Point(13, 12);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(29, 12);
            this.lblSelect.TabIndex = 1;
            this.lblSelect.Text = "선택";
            // 
            // lbResult
            // 
            this.lbResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbResult.FormattingEnabled = true;
            this.lbResult.ItemHeight = 12;
            this.lbResult.Location = new System.Drawing.Point(15, 47);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(281, 278);
            this.lbResult.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 346);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.cbbSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "구구단";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbSelect;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.ListBox lbResult;
    }
}

