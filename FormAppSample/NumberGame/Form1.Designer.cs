
namespace NumberGame {
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
            this.input = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.NumericUpDown();
            this.labelAns = new System.Windows.Forms.Label();
            this.ssText = new System.Windows.Forms.StatusStrip();
            this.ssMessage = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Number)).BeginInit();
            this.ssText.SuspendLayout();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.BackColor = System.Drawing.Color.Lavender;
            this.input.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.input.Location = new System.Drawing.Point(491, 179);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(240, 110);
            this.input.TabIndex = 0;
            this.input.Text = "入力";
            this.input.UseVisualStyleBackColor = false;
            this.input.Click += new System.EventHandler(this.input_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(57, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "1～50の中から";
            // 
            // Number
            // 
            this.Number.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Number.Location = new System.Drawing.Point(243, 191);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(120, 71);
            this.Number.TabIndex = 2;
            // 
            // labelAns
            // 
            this.labelAns.AutoSize = true;
            this.labelAns.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelAns.Location = new System.Drawing.Point(57, 320);
            this.labelAns.Name = "labelAns";
            this.labelAns.Size = new System.Drawing.Size(0, 64);
            this.labelAns.TabIndex = 1;
            // 
            // ssText
            // 
            this.ssText.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssMessage});
            this.ssText.Location = new System.Drawing.Point(0, 428);
            this.ssText.Name = "ssText";
            this.ssText.Size = new System.Drawing.Size(800, 22);
            this.ssText.TabIndex = 3;
            this.ssText.Text = "statusStrip1";
            // 
            // ssMessage
            // 
            this.ssMessage.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ssMessage.Name = "ssMessage";
            this.ssMessage.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ssText);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.labelAns);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input);
            this.Name = "Form1";
            this.Text = "数当てゲーム";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Number)).EndInit();
            this.ssText.ResumeLayout(false);
            this.ssText.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Number;
        private System.Windows.Forms.Label labelAns;
        private System.Windows.Forms.StatusStrip ssText;
        private System.Windows.Forms.ToolStripStatusLabel ssMessage;
    }
}

