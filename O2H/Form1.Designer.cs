using System;

namespace O2H
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.outLabel = new System.Windows.Forms.Label();
            this.hexLabel = new System.Windows.Forms.Label();
            this.outName = new System.Windows.Forms.Label();
            this.hexName = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outLabel
            // 
            this.outLabel.AllowDrop = true;
            this.outLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.outLabel.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.outLabel.Location = new System.Drawing.Point(75, 130);
            this.outLabel.Name = "outLabel";
            this.outLabel.Size = new System.Drawing.Size(180, 180);
            this.outLabel.TabIndex = 2;
            this.outLabel.Text = "OUT";
            this.outLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.outLabel.Enter += new System.EventHandler(this.HexName_LostFocus);
            // 
            // hexLabel
            // 
            this.hexLabel.AllowDrop = true;
            this.hexLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.hexLabel.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.hexLabel.Location = new System.Drawing.Point(345, 130);
            this.hexLabel.Name = "hexLabel";
            this.hexLabel.Size = new System.Drawing.Size(180, 180);
            this.hexLabel.TabIndex = 3;
            this.hexLabel.Text = "HEX";
            this.hexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outName
            // 
            this.outName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.outName.Location = new System.Drawing.Point(65, 333);
            this.outName.Name = "outName";
            this.outName.Size = new System.Drawing.Size(200, 21);
            this.outName.TabIndex = 4;
            this.outName.Text = "拖入文件";
            this.outName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.outName.Enter += new System.EventHandler(this.HexName_LostFocus);
            // 
            // hexName
            // 
            this.hexName.BackColor = System.Drawing.SystemColors.Control;
            this.hexName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hexName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hexName.Location = new System.Drawing.Point(336, 332);
            this.hexName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.hexName.Name = "hexName";
            this.hexName.Size = new System.Drawing.Size(200, 21);
            this.hexName.TabIndex = 99;
            this.hexName.Text = "修改名称";
            this.hexName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hexName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.OrangeRed;
            this.linkLabel1.Location = new System.Drawing.Point(146, 23);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(62, 18);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "CCS3.3";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "在左边框中拖入";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "生成的out文件，";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(359, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "会在原文件目录下自动生成同名的hex文件；";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(512, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "你也可以修改右框下的文件名称，并拖拽出文件至目标文件夹。";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 377);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.hexName);
            this.Controls.Add(this.outName);
            this.Controls.Add(this.hexLabel);
            this.Controls.Add(this.outLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Out2Hex";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Label outLabel;
        private System.Windows.Forms.Label hexLabel;
        private System.Windows.Forms.Label outName;
        private System.Windows.Forms.TextBox hexName;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

