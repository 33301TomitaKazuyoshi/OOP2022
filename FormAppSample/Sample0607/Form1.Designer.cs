﻿
namespace Sample0607 {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nudNum1 = new System.Windows.Forms.NumericUpDown();
            this.nudNum2 = new System.Windows.Forms.NumericUpDown();
            this.nudAns = new System.Windows.Forms.NumericUpDown();
            this.nudMod = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudNum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNum2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMod)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(148, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "÷";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(354, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "=";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(487, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 77);
            this.button1.TabIndex = 2;
            this.button1.Text = "計算";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(534, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "あまり";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // nudNum1
            // 
            this.nudNum1.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudNum1.Location = new System.Drawing.Point(20, 56);
            this.nudNum1.Name = "nudNum1";
            this.nudNum1.Size = new System.Drawing.Size(122, 44);
            this.nudNum1.TabIndex = 3;
            this.nudNum1.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // nudNum2
            // 
            this.nudNum2.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudNum2.Location = new System.Drawing.Point(208, 53);
            this.nudNum2.Name = "nudNum2";
            this.nudNum2.Size = new System.Drawing.Size(122, 44);
            this.nudNum2.TabIndex = 3;
            // 
            // nudAns
            // 
            this.nudAns.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudAns.Location = new System.Drawing.Point(406, 53);
            this.nudAns.Name = "nudAns";
            this.nudAns.Size = new System.Drawing.Size(122, 44);
            this.nudAns.TabIndex = 3;
            // 
            // nudMod
            // 
            this.nudMod.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudMod.Location = new System.Drawing.Point(638, 53);
            this.nudMod.Name = "nudMod";
            this.nudMod.Size = new System.Drawing.Size(122, 44);
            this.nudMod.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nudMod);
            this.Controls.Add(this.nudAns);
            this.Controls.Add(this.nudNum2);
            this.Controls.Add(this.nudNum1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudNum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNum2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudNum1;
        private System.Windows.Forms.NumericUpDown nudNum2;
        private System.Windows.Forms.NumericUpDown nudAns;
        private System.Windows.Forms.NumericUpDown nudMod;
    }
}

