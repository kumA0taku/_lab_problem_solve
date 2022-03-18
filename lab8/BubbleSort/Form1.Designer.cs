namespace BubbleSort
{
    partial class Form1
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.inputBotton = new System.Windows.Forms.Button();
            this.outputBotton = new System.Windows.Forms.Button();
            this.clearBotton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("KoHo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "ค่าที่รับเข้ามาทั้งหมด 10 ค่า ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("KoHo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(347, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "เรียงค่าจากน้อยไปมาก";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("KoHo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextBox.Location = new System.Drawing.Point(354, 178);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(497, 37);
            this.inputTextBox.TabIndex = 2;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Font = new System.Drawing.Font("KoHo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTextBox.Location = new System.Drawing.Point(354, 370);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(497, 37);
            this.outputTextBox.TabIndex = 3;
            // 
            // inputBotton
            // 
            this.inputBotton.Font = new System.Drawing.Font("KoHo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBotton.Location = new System.Drawing.Point(353, 543);
            this.inputBotton.Name = "inputBotton";
            this.inputBotton.Size = new System.Drawing.Size(114, 47);
            this.inputBotton.TabIndex = 4;
            this.inputBotton.Text = "รับค่า";
            this.inputBotton.UseVisualStyleBackColor = true;
            this.inputBotton.Click += new System.EventHandler(this.inputBotton_Click);
            // 
            // outputBotton
            // 
            this.outputBotton.Font = new System.Drawing.Font("KoHo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputBotton.Location = new System.Drawing.Point(538, 538);
            this.outputBotton.Name = "outputBotton";
            this.outputBotton.Size = new System.Drawing.Size(128, 56);
            this.outputBotton.TabIndex = 5;
            this.outputBotton.Text = "แสดงผล";
            this.outputBotton.UseVisualStyleBackColor = true;
            this.outputBotton.Click += new System.EventHandler(this.outputBotton_Click);
            // 
            // clearBotton
            // 
            this.clearBotton.Font = new System.Drawing.Font("KoHo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBotton.Location = new System.Drawing.Point(722, 538);
            this.clearBotton.Name = "clearBotton";
            this.clearBotton.Size = new System.Drawing.Size(128, 56);
            this.clearBotton.TabIndex = 6;
            this.clearBotton.Text = "ล้างข้อมูล";
            this.clearBotton.UseVisualStyleBackColor = true;
            this.clearBotton.Click += new System.EventHandler(this.clearBotton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.clearBotton);
            this.Controls.Add(this.outputBotton);
            this.Controls.Add(this.inputBotton);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "เรียงค่าจากน้อยไปมาก";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button inputBotton;
        private System.Windows.Forms.Button outputBotton;
        private System.Windows.Forms.Button clearBotton;
    }
}

