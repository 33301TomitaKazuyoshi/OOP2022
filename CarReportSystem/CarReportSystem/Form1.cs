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

        Settings settings = new Settings {};
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            dgvCarReport.DataSource = listCarReport;
        }
        //追加
        private void btAdd_Click(object sender, EventArgs e) {
            if (String.IsNullOrWhiteSpace(tbReport.Text) && String.IsNullOrWhiteSpace(cbAuther.Text) && String.IsNullOrWhiteSpace(cbCarName.Text)) {
                MessageBox.Show("未入力の項目があります。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else {


                CarReport newPersons = new CarReport {

                    Date = dtpDate.Value,
                    Auther = cbAuther.Text,
                    Maker = GetRadioButtonGroup(),
                    CarName = cbCarName.Text,
                    Report = tbReport.Text,
                    Picture = pbPicture.Image,
                };

                listCarReport.Add(newPersons);
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
            if (dgvCarReport.CurrentRow == null) return;

            int index = dgvCarReport.CurrentRow.Index;

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
            listCarReport.RemoveAt(dgvCarReport.CurrentRow.Index);
            EnabledCheck(); //マスク処理呼び出し
        }
        //修正
        private void btFix_Click(object sender, EventArgs e) {
            if (String.IsNullOrWhiteSpace(tbReport.Text) && String.IsNullOrWhiteSpace(cbAuther.Text) && String.IsNullOrWhiteSpace(cbCarName.Text)) {
                MessageBox.Show("未入力の項目があります。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            listCarReport[dgvCarReport.CurrentRow.Index].Date = dtpDate.Value;
            listCarReport[dgvCarReport.CurrentRow.Index].Auther = cbAuther.Text;
            listCarReport[dgvCarReport.CurrentRow.Index].Maker = GetRadioButtonGroup();
            listCarReport[dgvCarReport.CurrentRow.Index].CarName = cbCarName.Text;
            listCarReport[dgvCarReport.CurrentRow.Index].Report = tbReport.Text;
            listCarReport[dgvCarReport.CurrentRow.Index].Picture = pbPicture.Image;
            dgvCarReport.Refresh();//データグリッドビュー修正
            setCbAuther(cbAuther.Text);
            setCbCarName(cbCarName.Text);
            dtpDate.Value = DateTime.Now;
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
                        dgvCarReport.DataSource = null;
                        dgvCarReport.DataSource = listCarReport;
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
                settings.MainFormColor = cdColor.Color;
            }
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            var settings = new Settings {
                MainFormColor = cdColor.Color,
            };
            using (var color = XmlWriter.Create("settings.xml")) {
                var serializer = new XmlSerializer(settings.GetType());
                serializer.Serialize(color,settings);
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            using (XmlReader reader = XmlReader.Create("settings.xml")) {
                var serializer = new XmlSerializer(typeof(Settings));
                var color = serializer.Deserialize(reader) as Settings;

            }
        }

        private void btModeSelect_Click(object sender, EventArgs e) {
            
        }
    }
}
