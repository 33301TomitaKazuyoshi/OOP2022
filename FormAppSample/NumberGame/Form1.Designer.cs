
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
            this.ssText = new System.Windows.Forms.StatusStrip();
            this.ssMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbJudge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudMaxValue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Number)).BeginInit();
            this.ssText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxValue)).BeginInit();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.BackColor = System.Drawing.Color.Lavender;
            this.input.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.input.Location = new System.Drawing.Point(77, 164);
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
            this.label1.Location = new System.Drawing.Point(43, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "1～";
            // 
            // Number
            // 
            this.Number.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Number.Location = new System.Drawing.Point(382, 176);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(120, 71);
            this.Number.TabIndex = 2;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(478, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 64);
            this.label2.TabIndex = 1;
            this.label2.Text = "判定：";
            // 
            // tbJudge
            // 
            this.tbJudge.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbJudge.Location = new System.Drawing.Point(683, 341);
            this.tbJudge.Name = "tbJudge";
            this.tbJudge.Size = new System.Drawing.Size(71, 71);
            this.tbJudge.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(281, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(368, 64);
            this.label3.TabIndex = 1;
            this.label3.Text = "の中から入力";
            // 
            // nudMaxValue
            // 
            this.nudMaxValue.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudMaxValue.Location = new System.Drawing.Point(155, 32);
            this.nudMaxValue.Name = "nudMaxValue";
            this.nudMaxValue.Size = new System.Drawing.Size(120, 71);
            this.nudMaxValue.TabIndex = 2;
            this.nudMaxValue.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudMaxValue.ValueChanged += new System.EventHandler(this.nudMaxValue_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbJudge);
            this.Controls.Add(this.ssText);
            this.Controls.Add(this.nudMaxValue);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input);
            this.Name = "Form1";
            this.Text = "数当てゲーム";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Number)).EndInit();
            this.ssText.ResumeLayout(false);
            this.ssText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Number;
        private System.Windows.Forms.StatusStrip ssText;
        private System.Windows.Forms.ToolStripStatusLabel ssMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbJudge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudMaxValue;
    }
}

