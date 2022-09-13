using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //設定情報保存用オブジェクト
        Settings settings = Settings.getInstance();
        //カーレポート管理用リスト
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();

        private void carReportBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202228DataSet);

        }

        int mode = 0;
        public Form1() {
            InitializeComponent();
        }
        //追加
        private void btAdd_Click(object sender, EventArgs e) {
            if (String.IsNullOrWhiteSpace(tbReport.Text) && String.IsNullOrWhiteSpace(cbAuther.Text) && String.IsNullOrWhiteSpace(cbCarName.Text)) {
                MessageBox.Show("未入力の項目があります。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else {


                DataRow newRow = infosys202228DataSet.CarReport.NewRow();
                newRow[1] = dtpDate.Value;
                newRow[2] = cbAuther.Text;
                newRow[3] = GetRadioButtonGroup();
                newRow[4] = cbCarName.Text;
                newRow[5] = tbReport.Text;
                newRow[6] = pbPicture.Image;

                //データセットへ新しいレコードを追加
                infosys202228DataSet.CarReport.Rows.Add(newRow);

                //データベース更新
                this.carReportTableAdapter.Update(this.infosys202228DataSet.CarReport);

                EnabledCheck();

                setCbAuther(cbAuther.Text);
                setCbCarName(cbCarName.Text);
                dtpDate.Value = DateTime.Today;
            }


            }
        //コンボボックスに記録者名を登録する（重複なし）
        private void setCbAuther(string Name) {
            if (!cbAuther.Items.Contains(Name)) {
                cbAuther.Items.Add(Name);
            }
        }
        //コンボボックスに車名を登録する（重複なし）
        private void setCbCarName(string Name) {
            if (!cbCarName.Items.Contains(Name)) {
                cbCarName.Items.Add(Name);
            }
        }
        //ラジオボタンにセットされている値をリストとして取り出す
        private List<CarReport.MakerGroup> GetRadioButtonGroup() {
            var listGroup = new List<CarReport.MakerGroup>();
            if (rbToyota.Checked) {
                listGroup.Add(CarReport.MakerGroup.トヨタ);
            }
            if (rbNissan.Checked) {
                listGroup.Add(CarReport.MakerGroup.日産);
            }
            if (rbHonda.Checked) {
                listGroup.Add(CarReport.MakerGroup.ホンダ);
            }
            if (rbSubaru.Checked) {
                listGroup.Add(CarReport.MakerGroup.スバル);
            }
            if (rbForeignCar.Checked) {
                listGroup.Add(CarReport.MakerGroup.外国車);
            }
            if (rbOther.Checked) {
                listGroup.Add(CarReport.MakerGroup.その他);
            }
            return listGroup;
        }
        //ボタンの有効化・無効化
        private void EnabledCheck() {
            btDelete.Enabled =  btFix.Enabled = listCarReport.Count() > 0 ? true : false;
        }
        //添付画像削除
        private void btPictureClear_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }
        //画像ファイルを開く
        private void btPictureOpen_Click(object sender, EventArgs e) {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);
            }
        }
        //データグリッドビュー
        private void dgvCarReport_Click(object sender, EventArgs e) {
            if (dgvCarReporta.CurrentRow == null) return;


            //データグリッドビューの選択レコードを各テキストボックスへ設定
            dtpDate.Value = (DateTime)dgvCarReporta.CurrentRow.Cells[1].Value;
            cbAuther.Text = dgvCarReporta.CurrentRow.Cells[2].Value.ToString();
            //GetRadioButtonGroup() = dgvCarReport.CurrentRow.Cells[3].Value;
            cbCarName.Text = dgvCarReporta.CurrentRow.Cells[4].Value.ToString();
            tbReport.Text = dgvCarReporta.CurrentRow.Cells[5].Value.ToString();
            if (!(dgvCarReporta.CurrentRow.Cells[6].Value is DBNull)) {
                pbPicture.Image = ByteArrayToImage((byte[])dgvCarReporta.CurrentRow.Cells[6].Value);
            } else {
                pbPicture.Image = null;
            }










            int index = dgvCarReporta.CurrentRow.Index;

            dtpDate.Value = listCarReport[index].Date;
            cbAuther.Text = listCarReport[index].Auther;
            foreach (var group in listCarReport[index].Maker) {
                switch (group) {
                    case CarReport.MakerGroup.トヨタ:
                        rbToyota.Checked = true;
                        break;
                    case CarReport.MakerGroup.日産:
                        rbNissan.Checked = true;
                        break;
                    case CarReport.MakerGroup.ホンダ:
                        rbHonda.Checked = true;
                        break;
                    case CarReport.MakerGroup.スバル:
                        rbSubaru.Checked = true;
                        break;
                    case CarReport.MakerGroup.外国車:
                        rbForeignCar.Checked = true;
                        break;
                    case CarReport.MakerGroup.その他:
                        rbOther.Checked = true;
                        break;
                }
            }
            cbCarName.Text = listCarReport[index].CarName;
            tbReport.Text = listCarReport[index].Report;
            pbPicture.Image = listCarReport[index].Picture;
        }
        //アプリケーションの終了
        private void btExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        //削除
        private void btDelete_Click(object sender, EventArgs e) {
            listCarReport.RemoveAt(dgvCarReporta.CurrentRow.Index);
            EnabledCheck(); //マスク処理呼び出し
        }
        //修正
        private void btFix_Click(object sender, EventArgs e) {
            if (String.IsNullOrWhiteSpace(tbReport.Text) && String.IsNullOrWhiteSpace(cbAuther.Text) && String.IsNullOrWhiteSpace(cbCarName.Text)) {
                MessageBox.Show("未入力の項目があります。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dgvCarReporta.CurrentRow.Cells[1].Value = dtpDate.Value;
            dgvCarReporta.CurrentRow.Cells[2].Value = cbAuther.Text;
            dgvCarReporta.CurrentRow.Cells[3].Value = GetRadioButtonGroup();
            dgvCarReporta.CurrentRow.Cells[4].Value = cbCarName.Text;
            dgvCarReporta.CurrentRow.Cells[5].Value = tbReport.Text;
            dgvCarReporta.CurrentRow.Cells[6].Value = ImageToByteArray(pbPicture.Image);
            dgvCarReporta.Refresh();//データグリッドビュー修正
            setCbAuther(cbAuther.Text);
            setCbCarName(cbCarName.Text);
            dtpDate.Value = DateTime.Now;
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202228DataSet);
        }
        //ファイルを開く
        private void btOpen_Click(object sender, EventArgs e) {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式で逆シリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(ofdFileOpenDialog.FileName, FileMode.Open, FileAccess.Read)) {
                        //逆シリアル化して読み込む
                        listCarReport = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvCarReporta.DataSource = null;
                        dgvCarReporta.DataSource = listCarReport;
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                cbAuther.Items.Clear();
                cbCarName.Items.Clear();
                foreach (var item in listCarReport.Select(p => p.Auther)) {
                    setCbAuther(item); //存在する記録者名を登録
                }
                foreach (var item in listCarReport.Select(p => p.CarName)) {
                    setCbCarName(item); //存在する車名を登録
                }
                
            }
            EnabledCheck();//マスク処理の呼び出し
        }
        //ファイルを保存
        private void btSave_Click(object sender, EventArgs e) {
            if (sfdSaveFileDialog.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(sfdSaveFileDialog.FileName, FileMode.Create)) {
                        bf.Serialize(fs, listCarReport);
                    }
                    
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //色設定
        private void btColorSetting_Click(object sender, EventArgs e) {
            if (cdColor.ShowDialog() == DialogResult.OK) {
                BackColor = cdColor.Color;
                settings.MainFormColor = BackColor.ToArgb();  //設定オブジェクトにセット
            }
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            
            using (var color = XmlWriter.Create("settings.xml")) {
                var serializer = new XmlSerializer(settings.GetType());
                serializer.Serialize(color,settings);
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202228DataSet.CarReport' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportTableAdapter.Fill(this.infosys202228DataSet.CarReport);
            //設定ファイルを逆シリアル化（P307）して背景の色を設定
            try {
                using (var reader = XmlReader.Create("settings.xml")) {
                    var serializer = new XmlSerializer(typeof(Settings));
                    settings = serializer.Deserialize(reader) as Settings;
                    SetStyle(ControlStyles.SupportsTransparentBackColor, true);
                    BackColor = Color.FromArgb(settings.MainFormColor);
                }
            } catch (Exception) { } 
            finally {
                EnabledCheck(); //マスク処理呼び出し
            }
        }

        private void btModeSelect_Click(object sender, EventArgs e) {
            pbPicture.SizeMode = (PictureBoxSizeMode)mode;
            mode = mode < 4 ? ++mode : 0;
        }

        //データベース接続
        private void btConnect_Click(object sender, EventArgs e) {
            this.carReportTableAdapter.Fill(this.infosys202228DataSet.CarReport);
        }

        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b) {
            try {
                ImageConverter imgconv = new ImageConverter();
                Image img = (Image)imgconv.ConvertFrom(b);
                return img;
            } catch {
                return null;
            }
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img) {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }

        //エラー回避
        private void dgvAddressTable_DataError(object sender, DataGridViewDataErrorEventArgs e) {
        }


    }
}
