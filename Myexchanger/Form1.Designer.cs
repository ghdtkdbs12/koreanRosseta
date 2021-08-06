
namespace Myexchanger
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
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.btn_Exchange = new System.Windows.Forms.Button();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.btn_Copy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_SizeChange = new System.Windows.Forms.Button();
            this.txtBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Clear2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_ClearAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(12, 42);
            this.txtBox1.Multiline = true;
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(400, 200);
            this.txtBox1.TabIndex = 0;
            this.txtBox1.TextChanged += new System.EventHandler(this.txtBox1_TextChanged);
            // 
            // btn_Exchange
            // 
            this.btn_Exchange.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Exchange.Location = new System.Drawing.Point(418, 42);
            this.btn_Exchange.Name = "btn_Exchange";
            this.btn_Exchange.Size = new System.Drawing.Size(100, 50);
            this.btn_Exchange.TabIndex = 1;
            this.btn_Exchange.Text = "번역하기";
            this.btn_Exchange.UseVisualStyleBackColor = false;
            this.btn_Exchange.Click += new System.EventHandler(this.btn_Exchange_Click);
            // 
            // txtBox2
            // 
            this.txtBox2.Location = new System.Drawing.Point(12, 293);
            this.txtBox2.Multiline = true;
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(400, 200);
            this.txtBox2.TabIndex = 2;
            this.txtBox2.TextChanged += new System.EventHandler(this.txtBox2_TextChanged);
            // 
            // btn_Copy
            // 
            this.btn_Copy.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Copy.Location = new System.Drawing.Point(418, 293);
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(100, 50);
            this.btn_Copy.TabIndex = 3;
            this.btn_Copy.Text = "복사하기";
            this.btn_Copy.UseVisualStyleBackColor = false;
            this.btn_Copy.Click += new System.EventHandler(this.btn_Copy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "변역할 내용 입력 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(9, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "변역 된 내용(영어 소문자) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "제작:   홍승진";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "로제타 v. 1.0.0";
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Clear.Location = new System.Drawing.Point(418, 444);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(100, 50);
            this.btn_Clear.TabIndex = 9;
            this.btn_Clear.Text = "초기화";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_SizeChange
            // 
            this.btn_SizeChange.Location = new System.Drawing.Point(421, 534);
            this.btn_SizeChange.Name = "btn_SizeChange";
            this.btn_SizeChange.Size = new System.Drawing.Size(100, 50);
            this.btn_SizeChange.TabIndex = 10;
            this.btn_SizeChange.Text = "복사하기";
            this.btn_SizeChange.UseVisualStyleBackColor = true;
            this.btn_SizeChange.Click += new System.EventHandler(this.btn_SizeChange_Click);
            // 
            // txtBox3
            // 
            this.txtBox3.Location = new System.Drawing.Point(15, 534);
            this.txtBox3.Multiline = true;
            this.txtBox3.Name = "txtBox3";
            this.txtBox3.Size = new System.Drawing.Size(400, 200);
            this.txtBox3.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(12, 516);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "변역 된 내용(영어 대문자) :";
            // 
            // btn_Clear2
            // 
            this.btn_Clear2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Clear2.Location = new System.Drawing.Point(418, 684);
            this.btn_Clear2.Name = "btn_Clear2";
            this.btn_Clear2.Size = new System.Drawing.Size(100, 50);
            this.btn_Clear2.TabIndex = 14;
            this.btn_Clear2.Text = "초기화";
            this.btn_Clear2.UseVisualStyleBackColor = false;
            this.btn_Clear2.Click += new System.EventHandler(this.btn_Clear2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(418, 192);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 50);
            this.button3.TabIndex = 15;
            this.button3.Text = "초기화";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_ClearAll
            // 
            this.btn_ClearAll.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ClearAll.Location = new System.Drawing.Point(418, 116);
            this.btn_ClearAll.Name = "btn_ClearAll";
            this.btn_ClearAll.Size = new System.Drawing.Size(100, 50);
            this.btn_ClearAll.TabIndex = 16;
            this.btn_ClearAll.Text = "전체초기화";
            this.btn_ClearAll.UseVisualStyleBackColor = false;
            this.btn_ClearAll.Click += new System.EventHandler(this.btn_ClearAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(534, 747);
            this.Controls.Add(this.btn_ClearAll);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_Clear2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBox3);
            this.Controls.Add(this.btn_SizeChange);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Copy);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.btn_Exchange);
            this.Controls.Add(this.txtBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Korean Rosetta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.Button btn_Exchange;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.Button btn_Copy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_SizeChange;
        private System.Windows.Forms.TextBox txtBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Clear2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_ClearAll;
    }
}

