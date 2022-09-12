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

namespace AddressBook {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void addressTableBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.addressTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202228DataSet);

        }

        private void Form1_Load(object sender, EventArgs e) {
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //更新
        private void btUpdate_Click(object sender, EventArgs e) {
            dgvAddressTable.CurrentRow.Cells[1].Value = tbName.Text;
            dgvAddressTable.CurrentRow.Cells[2].Value = tbAddress.Text;
            dgvAddressTable.CurrentRow.Cells[3].Value = tbTel.Text;
            dgvAddressTable.CurrentRow.Cells[4].Value = tbMail.Text;
            dgvAddressTable.CurrentRow.Cells[5].Value = tbMemo.Text;
            dgvAddressTable.CurrentRow.Cells[6].Value = ImageToByteArray(pbImage.Image);
            this.Validate();
            this.addressTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202228DataSet);
        }

        //接続
        private void btConnect_Click_1(object sender, EventArgs e) {
            this.addressTableTableAdapter.Fill(this.infosys202228DataSet.AddressTable);
        }

        private void dgvAddressTable_Click(object sender, EventArgs e) {
            if (dgvAddressTable.CurrentRow == null) {
                return;
            }

            //データグリッドビューの選択レコードを各テキストボックスへ設定
            tbName.Text = dgvAddressTable.CurrentRow.Cells[1].Value.ToString();
            tbAddress.Text = dgvAddressTable.CurrentRow.Cells[2].Value.ToString();
            tbTel.Text = dgvAddressTable.CurrentRow.Cells[3].Value.ToString();
            tbMail.Text = dgvAddressTable.CurrentRow.Cells[4].Value.ToString();
            tbMemo.Text = dgvAddressTable.CurrentRow.Cells[5].Value.ToString();
            if (!(dgvAddressTable.CurrentRow.Cells[6].Value is DBNull)) {
                pbImage.Image = ByteArrayToImage((byte[])dgvAddressTable.CurrentRow.Cells[6].Value);
            } else {
                pbImage.Image = null;
            }
        }

        //画像ファイル開く
        private void btImageOpen_Click(object sender, EventArgs e) {
            ofdImage.Filter = "画像ファイル(*.jpg;*.png;*.bmp) | *.jpg;*.png;*.bmp";
            if (ofdImage.ShowDialog() == DialogResult.OK) {
                pbImage.Image = System.Drawing.Image.FromFile(ofdImage.FileName);
            }
        }

        //画像を削除
        private void btImageDelete_Click(object sender, EventArgs e) {
            pbImage.Image = null;
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

        private void btSarch_Click(object sender, EventArgs e) {
            this.addressTableTableAdapter.FillByName(this.infosys202228DataSet.AddressTable,tbSarch.Text);
        }

        private void btAdd_Click(object sender, EventArgs e) {
            DataRow newRow = infosys202228DataSet.AddressTable.NewRow();
            newRow[1] = tbName.Text;
            newRow[2] = tbAddress.Text;
            newRow[3] = tbTel.Text;
            newRow[4] = tbMail.Text;
            newRow[5] = tbMemo.Text;
            newRow[6] = pbImage.Image;
            //データセットへ新しいレコードを追加
            infosys202228DataSet.AddressTable.Rows.Add(newRow);
            //データベース更新
            this.addressTableTableAdapter.Update(this.infosys202228DataSet.AddressTable);
        }

        private void btDelite_Click(object sender, EventArgs e) {
            tbName.Text = tbAddress.Text = tbMail.Text = tbTel.Text = tbMemo.Text = tbSarch.Text = null;
            pbImage.Image = null;
            //データセットのレコードを削除
            infosys202228DataSet.AddressTable.Rows.RemoveAt(dgvAddressTable.CurrentRow.Index);
            //データベース更新
            this.addressTableTableAdapter.Update(this.infosys202228DataSet.AddressTable);
        }

        private void btExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btVersion_Click(object sender, EventArgs e) {
            new Version().ShowDialog();
        }
    }
}
