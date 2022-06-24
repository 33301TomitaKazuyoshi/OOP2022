using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddresBook {
    public partial class Form1 : Form {

        BindingList<Person> listPerson = new BindingList<Person>();
        public Form1() {
            InitializeComponent();
            dgvPersons.DataSource = listPerson;
        }

        private void btAddPerson_Click(object sender, EventArgs e) {
            if (String.IsNullOrWhiteSpace(tbName.Text)) {
                MessageBox.Show("氏名が入力されていません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else {


                Person newPerson = new Person {

                    Name = tbName.Text,
                    MailAddress = tbMailAddress.Text,
                    Address = tbAddress.Text,
                    Company = cbCompany.Text,
                    Picture = pbPicture.Image,
                    cbListGroup = GetCheckBoxGroup(),
                    rbListGroup = GetRadioButtonGroup(),
                    TelNumber = tbTelNumber.Text,
                    Registration = DateTime.Today,
            };

                listPerson.Add(newPerson);
                EnabledCheck();

                setCbCompany(cbCompany.Text);
                dtpRegistDate.Value = DateTime.Today;
            }
        }
        //コンボボックスに会社名を登録する（重複なし）
        private void setCbCompany(string company) {
            if (!cbCompany.Items.Contains(company)) {
                cbCompany.Items.Add(company);
            }
        }
        //ラジオボタンにセットされている値をリストとして取り出す
        private List<Person.KindNumberType> GetRadioButtonGroup() {
            var listGroup = new List<Person.KindNumberType>();
            if (rbHome.Checked) {
                listGroup.Add(Person.KindNumberType.自宅);
            }
            if (rbMobile.Checked) {
                listGroup.Add(Person.KindNumberType.携帯);
            }
            return listGroup;
        }
            //チェックボックスにセットされている値をリストとして取り出す
            private List<Person.GroupType> GetCheckBoxGroup() {
            var listGroup = new List<Person.GroupType>();
            if (cbFamily.Checked) {
                listGroup.Add(Person.GroupType.GAY);
            }
            if (cbFriend.Checked) {
                listGroup.Add(Person.GroupType.友人);
            }
            if (cbWork.Checked) {
                listGroup.Add(Person.GroupType.仕事);
            }
            if (cbOther.Checked) {
                listGroup.Add(Person.GroupType.その他);
            }
            return listGroup;
        }

        private void btPictureOpen_Click(object sender, EventArgs e) {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);
            }
        }

        private void btPictureClear_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
            btPictureClear.Enabled = false;
        }

        private void cbFamily_CheckedChanged(object sender, EventArgs e) {

        }

        //データグリッドビューをクリックしたときのイベントハンドラ
        private void dgvPersons_Click(object sender, EventArgs e) {

            if (dgvPersons.CurrentRow == null) return;

            int index = dgvPersons.CurrentRow.Index;

            tbName.Text = listPerson[index].Name;
            tbMailAddress.Text = listPerson[index].MailAddress;
            tbAddress.Text = listPerson[index].Address;
            cbCompany.Text = listPerson[index].Company;
            tbTelNumber.Text = listPerson[index].TelNumber;
            dtpRegistDate.Value = listPerson[index].Registration.Year > 1900 ? listPerson[index].Registration : DateTime.Today; ;
            pbPicture.Image = listPerson[index].Picture;

            groupCheckBoxAllClear();


            foreach (var group in listPerson[index].cbListGroup) {
                switch (group) {
                    case Person.GroupType.GAY:
                        cbFamily.Checked = true;
                        break;
                    case Person.GroupType.友人:
                        cbFriend.Checked = true;
                        break;
                    case Person.GroupType.仕事:
                        cbWork.Checked = true;
                        break;
                    case Person.GroupType.その他:
                        cbOther.Checked = true;
                        break;
                }
            }
            foreach (var group in listPerson[index].rbListGroup) {
                switch (group) {
                    case Person.KindNumberType.携帯:
                        rbMobile.Checked = true;
                        break;
                    case Person.KindNumberType.自宅:
                        rbHome.Checked = true;
                        break;
                }
            }


        }
        private void groupCheckBoxAllClear() {
            cbFamily.Checked = cbFriend.Checked = cbWork.Checked = cbOther.Checked = false;
        }

        private void btUpdate_Click(object sender, EventArgs e) {
            if (tbName.Text == "") {
                MessageBox.Show("氏名が入力されていません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            listPerson[dgvPersons.CurrentRow.Index].Name = tbName.Text;
            listPerson[dgvPersons.CurrentRow.Index].MailAddress = tbMailAddress.Text;
            listPerson[dgvPersons.CurrentRow.Index].Address = tbAddress.Text;
            listPerson[dgvPersons.CurrentRow.Index].Company = cbCompany.Text;
            listPerson[dgvPersons.CurrentRow.Index].cbListGroup = GetCheckBoxGroup();
            listPerson[dgvPersons.CurrentRow.Index].rbListGroup = GetRadioButtonGroup();
            listPerson[dgvPersons.CurrentRow.Index].TelNumber = tbTelNumber.Text;
            listPerson[dgvPersons.CurrentRow.Index].Registration = DateTime.Today;
            listPerson[dgvPersons.CurrentRow.Index].Picture = pbPicture.Image;
            dgvPersons.Refresh(); //データグリッドビュー更新
            if (!cbCompany.Items.Contains(cbCompany.Text)) {
                cbCompany.Items.Add(cbCompany.Text);
            }
            dtpRegistDate.Value = DateTime.Now;
        }

        private void btDelete_Click(object sender, EventArgs e) {
            listPerson.RemoveAt(dgvPersons.CurrentRow.Index);
            EnabledCheck(); //マスク処理呼び出し
        }

        private void dgvPersons_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (listPerson[dgvPersons.CurrentRow.Index].Picture != null) {
                btPictureClear.Enabled = true;
            } else {
                btPictureClear.Enabled = false;
            }
            dtpRegistDate.Value = listPerson[dgvPersons.CurrentRow.Index].Registration;
        }

        private void tbName_TextChanged(object sender, EventArgs e) {
            if (tbName.Text.Length == 0) {
                btAddPerson.Enabled = false;
                btUpdate.Enabled = false;
            }

            if (tbName.Text.Length != 0) {
                btAddPerson.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            EnabledCheck();
        }

        private void EnabledCheck() {
            btDelete.Enabled = btUpdate.Enabled = listPerson.Count() > 0 ? true : false;
        }

        private void btSave_Click(object sender, EventArgs e) {
            if (sfdSaveDialog.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(sfdSaveDialog.FileName,FileMode.Create)) {
                        bf.Serialize(fs,listPerson);
                    }

                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btOpen_Click(object sender, EventArgs e) {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式で逆シリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(ofdFileOpenDialog.FileName, FileMode.Open,FileAccess.Read)) {
                        //逆シリアル化して読み込む
                        listPerson = (BindingList<Person>)bf.Deserialize(fs);
                        dgvPersons.DataSource = null;
                        dgvPersons.DataSource = listPerson;
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                cbCompany.Items.Clear();
                foreach (var item in listPerson.Select(p => p.Company)) {
                    setCbCompany(item); //存在する会社を登録
                }
            }
            EnabledCheck();//マスク処理の呼び出し
        }
    }
}
