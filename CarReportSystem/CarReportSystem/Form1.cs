using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class Form1 : Form {

        BindingList<CarReport> listCarReport = new BindingList<CarReport>();
        public Form1() {
            InitializeComponent();
            dgvCarReport.DataSource = listCarReport;
        }

        private void btAdd_Click(object sender, EventArgs e) {
            if (String.IsNullOrWhiteSpace(tbReport.Text)) {
                MessageBox.Show("レポートが入力されていません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        //コンボボックスに車名を登録する（重複なし）
        private void setCbAuther(string Name) {
            if (!cbAuther.Items.Contains(Name)) {
                cbCarName.Items.Add(Name);
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

        private void EnabledCheck() {
            btDelete.Enabled =  btFix.Enabled = listCarReport.Count() > 0 ? true : false;
        }

        private void btPictureClear_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
            btPictureClear.Enabled = false;
        }

        private void btPictureOpen_Click(object sender, EventArgs e) {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);
            }
        }
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

        

        private void btDelete_Click(object sender, EventArgs e) {
            listCarReport.RemoveAt(dgvCarReport.CurrentRow.Index);
            EnabledCheck(); //マスク処理呼び出し
        }

        private void btFix_Click(object sender, EventArgs e) {
            if (tbReport.Text == "") {
                MessageBox.Show("レポートが入力されていません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
