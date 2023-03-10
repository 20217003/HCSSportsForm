using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    //ＨＣＳスポーツクラブフォームメイン画面
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 新規登録する(Form2)のフォームを表示させる。
        /// </summary>
        private void NewRegistrationButtonClick(object sender, EventArgs e)//新規登録
        {
            NewRegistrationForm Form2 = new NewRegistrationForm();
            Form2.Show();
        }

        /// <summary>
        /// データ削除(Form3)のフォームを表示させる。
        /// </summary>
        private void DeletionButtonClick(object sender, EventArgs e)//登録削除
        {
            DataDeletionForm form3 = new DataDeletionForm();
            form3.Show();
        }

        /// <summary>
        /// 既に登録された情報を更新する(Form4)のフォームを表示させる。
        /// </summary>
        private void DataModificationButtonClick(object sender, EventArgs e)//登録変更
        {
            DataUpdateForm form4 = new DataUpdateForm();
            form4.Show();
        }

        /// <summary>
        /// 登録情報を検索する(Form5)のフォームを表示させる。
        /// </summary>
        private void DataSearchButtonClick(object sender, EventArgs e)//登録情報検索
        {
            DataSearchForm form5 = new DataSearchForm();
            form5.Show();
        }

        /// <summary>
        /// 終了していいかをメッセージボックスで確認をした後、
        /// はいを選択したらフォーム終了する。
        /// いいえを選択した場合は何も起きない。
        /// </summary>
        private void EndButtonClick(object sender, EventArgs e)//終了
        {
            //メッセージボックスを表示する
            DialogResult result = MessageBox.Show("終了しますか？",
                "確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);

            //何が選択されたか調べる
            if (result == DialogResult.Yes)
            {
                //「はい」が選択された時
                // フォームを閉じる
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                //「いいえ」が選択された時
            }
        }

        /// <summary>
        /// テーブルを管理(Form6)のフォームを表示させる。
        /// </summary>
        private void TableButtonClick(object sender, EventArgs e)//テーブル管理するページ行き
        {
            TableManagementForm form6 = new TableManagementForm();
            form6.Show();
        }
    }
}
