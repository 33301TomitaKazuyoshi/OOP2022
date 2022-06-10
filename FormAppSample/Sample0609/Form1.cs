using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            Person newPerson = new Person {
                Name = tbName.Text,
                MailAddress = tbMailAddress.Text,
                Address = tbAddress.Text,
                Company = tbCompany.Text,
                Picture = pbPicture.Image,
                listGroup = GetCheckBoxGroup(),
            };

            listPerson.Add(newPerson);
        }

        //チェックボックスにセットされている値をリストとして取り出す
        private List<Person.GroupType> GetCheckBoxGroup() {
            var listGroup = new List<Person.GroupType>();
            if (cbFamily.Checked) {
                listGroup.Add(Person.GroupType.家族);
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
        }

        private void cbFamily_CheckedChanged(object sender, EventArgs e) {

        }

        //データグリッドビューをクリックしたときのイベントハンドラ
        private void dgvPersons_Click(object sender, EventArgs e) {
            int index = dgvPersons.CurrentRow.Index;
            tbName.Text = listPerson[index].Name;
            tbMailAddress.Text = listPerson[index].MailAddress;
            tbAddress.Text = listPerson[index].Address;
            tbCompany.Text = listPerson[index].Company;
            pbPicture.Image = listPerson[index].Picture;
            foreach (var group in listPerson[index].listGroup) {
                switch (group) {
                    case Person.GroupType.家族:
                        cbFamily.CheckState = CheckState.Checked;
                        cbFriend.CheckState = CheckState.Unchecked;
                        cbWork.CheckState = CheckState.Unchecked;
                        cbOther.CheckState = CheckState.Unchecked;
                        break;
                    case Person.GroupType.友人:
                        cbFamily.CheckState = CheckState.Unchecked;
                        cbFriend.CheckState = CheckState.Checked;
                        cbWork.CheckState = CheckState.Unchecked;
                        cbOther.CheckState = CheckState.Unchecked;
                        break;
                    case Person.GroupType.仕事:
                        cbFamily.CheckState = CheckState.Unchecked;
                        cbFriend.CheckState = CheckState.Unchecked;
                        cbWork.CheckState = CheckState.Checked;
                        cbOther.CheckState = CheckState.Unchecked;
                        break;

                    case Person.GroupType.その他:
                        cbFamily.CheckState = CheckState.Unchecked;
                        cbFriend.CheckState = CheckState.Unchecked;
                        cbWork.CheckState = CheckState.Unchecked;
                        cbOther.CheckState = CheckState.Checked;
                        break;
                }
            }
            /*
            foreach (DataGridViewRow index in dgvPersons.SelectedRows) {
                tbName.Text = listPerson[index.Index].Name;
                tbMailAddress.Text = listPerson[index.Index].MailAddress;
                tbAddress.Text = listPerson[index.Index].Address;
                tbCompany.Text = listPerson[index.Index].Company;
                pbPicture.Image = listPerson[index.Index].Picture;
            }
            */
        }
    }
}
