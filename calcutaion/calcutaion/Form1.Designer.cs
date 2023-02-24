
namespace calcutaion
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
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtresult = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.multi = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.subsub = new System.Windows.Forms.Button();
            this.plusplus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculation";
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(101, 87);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(187, 20);
            this.txtnum1.TabIndex = 1;
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(101, 125);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(187, 20);
            this.txtnum2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "num1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "num2";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 35);
            this.label4.TabIndex = 5;
            this.label4.Text = "RESULT";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtresult
            // 
            this.txtresult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtresult.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtresult.Location = new System.Drawing.Point(101, 168);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(187, 35);
            this.txtresult.TabIndex = 6;
            this.txtresult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(101, 246);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(74, 25);
            this.sum.TabIndex = 7;
            this.sum.Text = "SUM";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(214, 246);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(74, 25);
            this.sub.TabIndex = 8;
            this.sub.Text = "SUB";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // multi
            // 
            this.multi.Location = new System.Drawing.Point(214, 277);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(74, 25);
            this.multi.TabIndex = 9;
            this.multi.Text = "MULTI";
            this.multi.UseVisualStyleBackColor = true;
            this.multi.Click += new System.EventHandler(this.multi_Click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(101, 277);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(74, 25);
            this.div.TabIndex = 10;
            this.div.Text = "DIV";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // subsub
            // 
            this.subsub.Location = new System.Drawing.Point(308, 120);
            this.subsub.Name = "subsub";
            this.subsub.Size = new System.Drawing.Size(74, 25);
            this.subsub.TabIndex = 11;
            this.subsub.Text = "_ _";
            this.subsub.UseVisualStyleBackColor = true;
            this.subsub.Click += new System.EventHandler(this.subsub_Click);
            // 
            // plusplus
            // 
            this.plusplus.Location = new System.Drawing.Point(308, 82);
            this.plusplus.Name = "plusplus";
            this.plusplus.Size = new System.Drawing.Size(74, 25);
            this.plusplus.TabIndex = 12;
            this.plusplus.Text = "++";
            this.plusplus.UseVisualStyleBackColor = true;
            this.plusplus.Click += new System.EventHandler(this.plusplus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 319);
            this.Controls.Add(this.plusplus);
            this.Controls.Add(this.subsub);
            this.Controls.Add(this.div);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtresult;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button multi;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button subsub;
        private System.Windows.Forms.Button plusplus;
    }
}

