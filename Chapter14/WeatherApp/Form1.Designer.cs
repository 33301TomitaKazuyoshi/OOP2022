﻿
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
            this.cbTohoku = new System.Windows.Forms.ComboBox();
            this.cbKanto = new System.Windows.Forms.ComboBox();
            this.cbKinki = new System.Windows.Forms.ComboBox();
            this.cbTyubu = new System.Windows.Forms.ComboBox();
            this.cbChugokuShikoku = new System.Windows.Forms.ComboBox();
            this.cbKyushu = new System.Windows.Forms.ComboBox();
            this.lbKyushu = new System.Windows.Forms.Label();
            this.lbChugokuShikoku = new System.Windows.Forms.Label();
            this.lbKinki = new System.Windows.Forms.Label();
            this.lbTyubu = new System.Windows.Forms.Label();
            this.lbKanto = new System.Windows.Forms.Label();
            this.lbTohoku = new System.Windows.Forms.Label();
            this.lbHokkaido = new System.Windows.Forms.Label();
            this.cbHokkaido = new System.Windows.Forms.ComboBox();
            this.lbOkinawa = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPublishingOffice = new System.Windows.Forms.Label();
            this.lbAreaName = new System.Windows.Forms.Label();
            this.lbReportDatetime = new System.Windows.Forms.Label();
            this.lbPubli = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbWeatherInfo = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbWeatherImage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeatherImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTohoku
            // 
            this.cbTohoku.FormattingEnabled = true;
            this.cbTohoku.Items.AddRange(new object[] {
            "青森県",
            "岩手県",
            "秋田県",
            "宮城県",
            "山形県",
            "福島県"});
            this.cbTohoku.Location = new System.Drawing.Point(381, 218);
            this.cbTohoku.Name = "cbTohoku";
            this.cbTohoku.Size = new System.Drawing.Size(94, 20);
            this.cbTohoku.TabIndex = 10;
            this.cbTohoku.SelectedIndexChanged += new System.EventHandler(this.cbTohoku_SelectedIndexChanged);
            // 
            // cbKanto
            // 
            this.cbKanto.FormattingEnabled = true;
            this.cbKanto.Items.AddRange(new object[] {
            "茨城県",
            "栃木県",
            "群馬県",
            "埼玉県",
            "千葉県",
            "東京都",
            "神奈川県"});
            this.cbKanto.Location = new System.Drawing.Point(365, 301);
            this.cbKanto.Name = "cbKanto";
            this.cbKanto.Size = new System.Drawing.Size(90, 20);
            this.cbKanto.TabIndex = 10;
            this.cbKanto.SelectedIndexChanged += new System.EventHandler(this.cbKanto_SelectedIndexChanged);
            // 
            // cbKinki
            // 
            this.cbKinki.FormattingEnabled = true;
            this.cbKinki.Items.AddRange(new object[] {
            "三重県",
            "滋賀県",
            "京都府",
            "大阪府",
            "兵庫県",
            "奈良県",
            "和歌山県"});
            this.cbKinki.Location = new System.Drawing.Point(229, 368);
            this.cbKinki.Name = "cbKinki";
            this.cbKinki.Size = new System.Drawing.Size(88, 20);
            this.cbKinki.TabIndex = 10;
            this.cbKinki.SelectedIndexChanged += new System.EventHandler(this.cbKinki_SelectedIndexChanged);
            // 
            // cbTyubu
            // 
            this.cbTyubu.FormattingEnabled = true;
            this.cbTyubu.Items.AddRange(new object[] {
            "山梨県",
            "長野県",
            "岐阜県",
            "静岡県",
            "愛知県",
            "新潟県",
            "富山県",
            "石川県",
            "福井県"});
            this.cbTyubu.Location = new System.Drawing.Point(268, 320);
            this.cbTyubu.Name = "cbTyubu";
            this.cbTyubu.Size = new System.Drawing.Size(91, 20);
            this.cbTyubu.TabIndex = 10;
            this.cbTyubu.SelectedIndexChanged += new System.EventHandler(this.cbTyubu_SelectedIndexChanged);
            // 
            // cbChugokuShikoku
            // 
            this.cbChugokuShikoku.FormattingEnabled = true;
            this.cbChugokuShikoku.Items.AddRange(new object[] {
            "鳥取県",
            "島根県",
            "岡山県",
            "広島県",
            "徳島県",
            "香川県",
            "愛媛県",
            "高知県",
            "山口県"});
            this.cbChugokuShikoku.Location = new System.Drawing.Point(114, 383);
            this.cbChugokuShikoku.Name = "cbChugokuShikoku";
            this.cbChugokuShikoku.Size = new System.Drawing.Size(98, 20);
            this.cbChugokuShikoku.TabIndex = 10;
            this.cbChugokuShikoku.SelectedIndexChanged += new System.EventHandler(this.cbChugokuShikoku_SelectedIndexChanged);
            // 
            // cbKyushu
            // 
            this.cbKyushu.FormattingEnabled = true;
            this.cbKyushu.Items.AddRange(new object[] {
            "福岡県",
            "佐賀県",
            "長崎県",
            "熊本県",
            "大分県",
            "宮崎県",
            "鹿児島県",
            "奄美地方"});
            this.cbKyushu.Location = new System.Drawing.Point(34, 415);
            this.cbKyushu.Name = "cbKyushu";
            this.cbKyushu.Size = new System.Drawing.Size(93, 20);
            this.cbKyushu.TabIndex = 10;
            this.cbKyushu.SelectedIndexChanged += new System.EventHandler(this.cbKyushu_SelectedIndexChanged);
            // 
            // lbKyushu
            // 
            this.lbKyushu.AutoSize = true;
            this.lbKyushu.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbKyushu.Location = new System.Drawing.Point(46, 393);
            this.lbKyushu.Name = "lbKyushu";
            this.lbKyushu.Size = new System.Drawing.Size(49, 19);
            this.lbKyushu.TabIndex = 11;
            this.lbKyushu.Text = "九州";
            // 
            // lbChugokuShikoku
            // 
            this.lbChugokuShikoku.AutoSize = true;
            this.lbChugokuShikoku.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbChugokuShikoku.Location = new System.Drawing.Point(99, 361);
            this.lbChugokuShikoku.Name = "lbChugokuShikoku";
            this.lbChugokuShikoku.Size = new System.Drawing.Size(100, 19);
            this.lbChugokuShikoku.TabIndex = 11;
            this.lbChugokuShikoku.Text = "中国・四国";
            // 
            // lbKinki
            // 
            this.lbKinki.AutoSize = true;
            this.lbKinki.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbKinki.Location = new System.Drawing.Point(225, 346);
            this.lbKinki.Name = "lbKinki";
            this.lbKinki.Size = new System.Drawing.Size(49, 19);
            this.lbKinki.TabIndex = 11;
            this.lbKinki.Text = "近畿";
            // 
            // lbTyubu
            // 
            this.lbTyubu.AutoSize = true;
            this.lbTyubu.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTyubu.Location = new System.Drawing.Point(281, 298);
            this.lbTyubu.Name = "lbTyubu";
            this.lbTyubu.Size = new System.Drawing.Size(49, 19);
            this.lbTyubu.TabIndex = 11;
            this.lbTyubu.Text = "中部";
            // 
            // lbKanto
            // 
            this.lbKanto.AutoSize = true;
            this.lbKanto.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbKanto.Location = new System.Drawing.Point(361, 279);
            this.lbKanto.Name = "lbKanto";
            this.lbKanto.Size = new System.Drawing.Size(49, 19);
            this.lbKanto.TabIndex = 11;
            this.lbKanto.Text = "関東";
            // 
            // lbTohoku
            // 
            this.lbTohoku.AutoSize = true;
            this.lbTohoku.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTohoku.Location = new System.Drawing.Point(377, 196);
            this.lbTohoku.Name = "lbTohoku";
            this.lbTohoku.Size = new System.Drawing.Size(49, 19);
            this.lbTohoku.TabIndex = 11;
            this.lbTohoku.Text = "東北";
            // 
            // lbHokkaido
            // 
            this.lbHokkaido.AutoSize = true;
            this.lbHokkaido.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbHokkaido.Location = new System.Drawing.Point(406, 68);
            this.lbHokkaido.Name = "lbHokkaido";
            this.lbHokkaido.Size = new System.Drawing.Size(69, 19);
            this.lbHokkaido.TabIndex = 11;
            this.lbHokkaido.Text = "北海道";
            // 
            // cbHokkaido
            // 
            this.cbHokkaido.FormattingEnabled = true;
            this.cbHokkaido.Items.AddRange(new object[] {
            "宗谷地方",
            "上川・留萌地方",
            "綱走・北見・紋別地方",
            "十勝地方",
            "釧路・根室地方",
            "胆振・日高地方",
            "石狩・空知・後志地方",
            "渡島・檜山地方"});
            this.cbHokkaido.Location = new System.Drawing.Point(410, 90);
            this.cbHokkaido.Name = "cbHokkaido";
            this.cbHokkaido.Size = new System.Drawing.Size(142, 20);
            this.cbHokkaido.TabIndex = 10;
            this.cbHokkaido.SelectedIndexChanged += new System.EventHandler(this.cbHokkaido_SelectedIndexChanged);
            // 
            // lbOkinawa
            // 
            this.lbOkinawa.AutoSize = true;
            this.lbOkinawa.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbOkinawa.Location = new System.Drawing.Point(406, 412);
            this.lbOkinawa.Name = "lbOkinawa";
            this.lbOkinawa.Size = new System.Drawing.Size(49, 19);
            this.lbOkinawa.TabIndex = 11;
            this.lbOkinawa.Text = "沖縄";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "沖縄本島地方",
            "大東島地方",
            "宮古島地方",
            "八重山地方"});
            this.comboBox1.Location = new System.Drawing.Point(400, 434);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 20);
            this.comboBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(631, 463);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "発表者：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(881, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "報告日時：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(631, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "エリア";
            // 
            // lbPublishingOffice
            // 
            this.lbPublishingOffice.AutoSize = true;
            this.lbPublishingOffice.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbPublishingOffice.Location = new System.Drawing.Point(717, 463);
            this.lbPublishingOffice.Name = "lbPublishingOffice";
            this.lbPublishingOffice.Size = new System.Drawing.Size(20, 19);
            this.lbPublishingOffice.TabIndex = 11;
            this.lbPublishingOffice.Text = "-";
            // 
            // lbAreaName
            // 
            this.lbAreaName.AutoSize = true;
            this.lbAreaName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbAreaName.Location = new System.Drawing.Point(698, 26);
            this.lbAreaName.Name = "lbAreaName";
            this.lbAreaName.Size = new System.Drawing.Size(170, 24);
            this.lbAreaName.TabIndex = 11;
            this.lbAreaName.Text = "選択してください";
            // 
            // lbReportDatetime
            // 
            this.lbReportDatetime.AutoSize = true;
            this.lbReportDatetime.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbReportDatetime.Location = new System.Drawing.Point(987, 463);
            this.lbReportDatetime.Name = "lbReportDatetime";
            this.lbReportDatetime.Size = new System.Drawing.Size(20, 19);
            this.lbReportDatetime.TabIndex = 11;
            this.lbReportDatetime.Text = "-";
            // 
            // lbPubli
            // 
            this.lbPubli.AutoSize = true;
            this.lbPubli.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbPubli.Location = new System.Drawing.Point(717, 463);
            this.lbPubli.Name = "lbPubli";
            this.lbPubli.Size = new System.Drawing.Size(69, 19);
            this.lbPubli.TabIndex = 11;
            this.lbPubli.Text = "発表者";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(633, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "概況";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbWeatherInfo
            // 
            this.tbWeatherInfo.Location = new System.Drawing.Point(688, 313);
            this.tbWeatherInfo.Multiline = true;
            this.tbWeatherInfo.Name = "tbWeatherInfo";
            this.tbWeatherInfo.Size = new System.Drawing.Size(485, 140);
            this.tbWeatherInfo.TabIndex = 13;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBox3.Location = new System.Drawing.Point(951, 104);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(121, 111);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBox2.Location = new System.Drawing.Point(792, 104);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(121, 111);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pbWeatherImage
            // 
            this.pbWeatherImage.BackColor = System.Drawing.SystemColors.Info;
            this.pbWeatherImage.Location = new System.Drawing.Point(637, 104);
            this.pbWeatherImage.Name = "pbWeatherImage";
            this.pbWeatherImage.Size = new System.Drawing.Size(121, 111);
            this.pbWeatherImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWeatherImage.TabIndex = 12;
            this.pbWeatherImage.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = global::WeatherApp.Properties.Resources.Japan2;
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(604, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 524);
            this.Controls.Add(this.tbWeatherInfo);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pbWeatherImage);
            this.Controls.Add(this.lbOkinawa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbPublishingOffice);
            this.Controls.Add(this.lbAreaName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbReportDatetime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbHokkaido);
            this.Controls.Add(this.lbTohoku);
            this.Controls.Add(this.lbKanto);
            this.Controls.Add(this.lbTyubu);
            this.Controls.Add(this.lbKinki);
            this.Controls.Add(this.lbChugokuShikoku);
            this.Controls.Add(this.lbKyushu);
            this.Controls.Add(this.cbKyushu);
            this.Controls.Add(this.cbChugokuShikoku);
            this.Controls.Add(this.cbTyubu);
            this.Controls.Add(this.cbKinki);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cbKanto);
            this.Controls.Add(this.cbHokkaido);
            this.Controls.Add(this.cbTohoku);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeatherImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbTohoku;
        private System.Windows.Forms.ComboBox cbKanto;
        private System.Windows.Forms.ComboBox cbKinki;
        private System.Windows.Forms.ComboBox cbTyubu;
        private System.Windows.Forms.ComboBox cbChugokuShikoku;
        private System.Windows.Forms.ComboBox cbKyushu;
        private System.Windows.Forms.Label lbKyushu;
        private System.Windows.Forms.Label lbChugokuShikoku;
        private System.Windows.Forms.Label lbKinki;
        private System.Windows.Forms.Label lbTyubu;
        private System.Windows.Forms.Label lbKanto;
        private System.Windows.Forms.Label lbTohoku;
        private System.Windows.Forms.Label lbHokkaido;
        private System.Windows.Forms.ComboBox cbHokkaido;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbOkinawa;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pbWeatherImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbPublishingOffice;
        private System.Windows.Forms.Label lbAreaName;
        private System.Windows.Forms.Label lbReportDatetime;
        private System.Windows.Forms.Label lbPubli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbWeatherInfo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

