
namespace WeatherApp {
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
            this.tbWeatherInfo = new System.Windows.Forms.TextBox();
            this.btWeatherGet = new System.Windows.Forms.Button();
            this.tbAreaCode = new System.Windows.Forms.TextBox();
            this.lbAreaCode = new System.Windows.Forms.Label();
            this.tbAreaName = new System.Windows.Forms.TextBox();
            this.lbAreaName = new System.Windows.Forms.Label();
            this.tbPublishingOffice = new System.Windows.Forms.TextBox();
            this.lbPublishingOffice = new System.Windows.Forms.Label();
            this.tbReportDatetime = new System.Windows.Forms.TextBox();
            this.lbReportDatetime = new System.Windows.Forms.Label();
            this.tbHeadlineText = new System.Windows.Forms.TextBox();
            this.lbHeadlineText = new System.Windows.Forms.Label();
            this.lbWeatherInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbWeatherInfo
            // 
            this.tbWeatherInfo.Location = new System.Drawing.Point(130, 212);
            this.tbWeatherInfo.Multiline = true;
            this.tbWeatherInfo.Name = "tbWeatherInfo";
            this.tbWeatherInfo.Size = new System.Drawing.Size(658, 226);
            this.tbWeatherInfo.TabIndex = 0;
            // 
            // btWeatherGet
            // 
            this.btWeatherGet.Location = new System.Drawing.Point(12, 12);
            this.btWeatherGet.Name = "btWeatherGet";
            this.btWeatherGet.Size = new System.Drawing.Size(116, 32);
            this.btWeatherGet.TabIndex = 1;
            this.btWeatherGet.Text = "取得";
            this.btWeatherGet.UseVisualStyleBackColor = true;
            this.btWeatherGet.Click += new System.EventHandler(this.btWeatherGet_Click);
            // 
            // tbAreaCode
            // 
            this.tbAreaCode.Location = new System.Drawing.Point(303, 18);
            this.tbAreaCode.Multiline = true;
            this.tbAreaCode.Name = "tbAreaCode";
            this.tbAreaCode.Size = new System.Drawing.Size(195, 26);
            this.tbAreaCode.TabIndex = 0;
            this.tbAreaCode.TextChanged += new System.EventHandler(this.tbAreaCode_TextChanged);
            // 
            // lbAreaCode
            // 
            this.lbAreaCode.AutoSize = true;
            this.lbAreaCode.Location = new System.Drawing.Point(240, 22);
            this.lbAreaCode.Name = "lbAreaCode";
            this.lbAreaCode.Size = new System.Drawing.Size(57, 12);
            this.lbAreaCode.TabIndex = 2;
            this.lbAreaCode.Text = "エリアコード";
            // 
            // tbAreaName
            // 
            this.tbAreaName.Location = new System.Drawing.Point(593, 19);
            this.tbAreaName.Multiline = true;
            this.tbAreaName.Name = "tbAreaName";
            this.tbAreaName.Size = new System.Drawing.Size(195, 26);
            this.tbAreaName.TabIndex = 0;
            // 
            // lbAreaName
            // 
            this.lbAreaName.AutoSize = true;
            this.lbAreaName.Location = new System.Drawing.Point(545, 22);
            this.lbAreaName.Name = "lbAreaName";
            this.lbAreaName.Size = new System.Drawing.Size(42, 12);
            this.lbAreaName.TabIndex = 2;
            this.lbAreaName.Text = "エリア名";
            // 
            // tbPublishingOffice
            // 
            this.tbPublishingOffice.Location = new System.Drawing.Point(130, 70);
            this.tbPublishingOffice.Multiline = true;
            this.tbPublishingOffice.Name = "tbPublishingOffice";
            this.tbPublishingOffice.Size = new System.Drawing.Size(195, 26);
            this.tbPublishingOffice.TabIndex = 0;
            this.tbPublishingOffice.TextChanged += new System.EventHandler(this.tbAreaCode_TextChanged);
            // 
            // lbPublishingOffice
            // 
            this.lbPublishingOffice.AutoSize = true;
            this.lbPublishingOffice.Location = new System.Drawing.Point(67, 74);
            this.lbPublishingOffice.Name = "lbPublishingOffice";
            this.lbPublishingOffice.Size = new System.Drawing.Size(41, 12);
            this.lbPublishingOffice.TabIndex = 2;
            this.lbPublishingOffice.Text = "発表者";
            // 
            // tbReportDatetime
            // 
            this.tbReportDatetime.Location = new System.Drawing.Point(130, 120);
            this.tbReportDatetime.Multiline = true;
            this.tbReportDatetime.Name = "tbReportDatetime";
            this.tbReportDatetime.Size = new System.Drawing.Size(195, 26);
            this.tbReportDatetime.TabIndex = 0;
            this.tbReportDatetime.TextChanged += new System.EventHandler(this.tbAreaCode_TextChanged);
            // 
            // lbReportDatetime
            // 
            this.lbReportDatetime.AutoSize = true;
            this.lbReportDatetime.Location = new System.Drawing.Point(67, 124);
            this.lbReportDatetime.Name = "lbReportDatetime";
            this.lbReportDatetime.Size = new System.Drawing.Size(53, 12);
            this.lbReportDatetime.TabIndex = 2;
            this.lbReportDatetime.Text = "報告日時";
            // 
            // tbHeadlineText
            // 
            this.tbHeadlineText.Location = new System.Drawing.Point(130, 164);
            this.tbHeadlineText.Multiline = true;
            this.tbHeadlineText.Name = "tbHeadlineText";
            this.tbHeadlineText.Size = new System.Drawing.Size(658, 26);
            this.tbHeadlineText.TabIndex = 0;
            this.tbHeadlineText.TextChanged += new System.EventHandler(this.tbAreaCode_TextChanged);
            // 
            // lbHeadlineText
            // 
            this.lbHeadlineText.AutoSize = true;
            this.lbHeadlineText.Location = new System.Drawing.Point(67, 168);
            this.lbHeadlineText.Name = "lbHeadlineText";
            this.lbHeadlineText.Size = new System.Drawing.Size(57, 12);
            this.lbHeadlineText.TabIndex = 2;
            this.lbHeadlineText.Text = "ヘッドライン";
            // 
            // lbWeatherInfo
            // 
            this.lbWeatherInfo.AutoSize = true;
            this.lbWeatherInfo.Location = new System.Drawing.Point(71, 212);
            this.lbWeatherInfo.Name = "lbWeatherInfo";
            this.lbWeatherInfo.Size = new System.Drawing.Size(53, 12);
            this.lbWeatherInfo.TabIndex = 2;
            this.lbWeatherInfo.Text = "天気概況";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbAreaName);
            this.Controls.Add(this.lbHeadlineText);
            this.Controls.Add(this.lbReportDatetime);
            this.Controls.Add(this.lbPublishingOffice);
            this.Controls.Add(this.lbAreaCode);
            this.Controls.Add(this.lbWeatherInfo);
            this.Controls.Add(this.btWeatherGet);
            this.Controls.Add(this.tbAreaName);
            this.Controls.Add(this.tbHeadlineText);
            this.Controls.Add(this.tbReportDatetime);
            this.Controls.Add(this.tbPublishingOffice);
            this.Controls.Add(this.tbAreaCode);
            this.Controls.Add(this.tbWeatherInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWeatherInfo;
        private System.Windows.Forms.Button btWeatherGet;
        private System.Windows.Forms.TextBox tbAreaCode;
        private System.Windows.Forms.Label lbAreaCode;
        private System.Windows.Forms.TextBox tbAreaName;
        private System.Windows.Forms.Label lbAreaName;
        private System.Windows.Forms.TextBox tbPublishingOffice;
        private System.Windows.Forms.Label lbPublishingOffice;
        private System.Windows.Forms.TextBox tbReportDatetime;
        private System.Windows.Forms.Label lbReportDatetime;
        private System.Windows.Forms.TextBox tbHeadlineText;
        private System.Windows.Forms.Label lbHeadlineText;
        private System.Windows.Forms.Label lbWeatherInfo;
    }
}

