using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WindowsFormsApp1
{
    //登録情報の更新画面
    public partial class DataUpdateForm : Form
    {
        public DataUpdateForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 記入されたデータを（Memberテーブルのデータにて）指定されたIDに更新する。
        /// </summary>
        private void UpdateButtonClick(object sender, EventArgs e)//データ変更ボタン
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=HCSSportsForm.db"))
            {
                if (AddressTextBox.Text == "" || TelephoneTextBox.Text == "" 
                    || RenameTextBox.Text == "" || NameTextBox.Text == "" 
                    || IDTextBox.Text == "" || SchoolIDTextBox.Text == "")//未記入の場合
                {
                    MessageBox.Show("記入ミスです、記入欄を確認してください。", "エラー",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }
                else//すべて記入していれば
                {
                    con.Open();
                    using (SQLiteTransaction trans = con.BeginTransaction())
                    {
                        SQLiteCommand cmd = con.CreateCommand();
                        // インサート コマンド　テーブル名　セット（挿入）行名=＠引数, 行名2=＠引数2 where ID
                        cmd.CommandText = "UPDATE Member set schoolID = @SchoolID, surname = @Surname," +
                            " name = @Name, address = @Address, telephone = @Telephone WHERE idNo = @Id;";
                        // パラメータセット
                        cmd.Parameters.Add("SchoolID", System.Data.DbType.String);//学籍番号=SchoolIDTextBox
                        cmd.Parameters.Add("Surname", System.Data.DbType.String);//苗字=RenameTextBox
                        cmd.Parameters.Add("Name", System.Data.DbType.String);//名前=NameTextBox
                        cmd.Parameters.Add("Address", System.Data.DbType.String);//住所=AddressTextBox
                        cmd.Parameters.Add("Telephone", System.Data.DbType.String);//電話番号=TelephoneTextBox
                        cmd.Parameters.Add("Id", System.Data.DbType.String);//ID=IDTextBox
                        // データ修正
                        cmd.Parameters["SchoolID"].Value = SchoolIDTextBox.Text;
                        cmd.Parameters["Surname"].Value = RenameTextBox.Text;
                        cmd.Parameters["Name"].Value = NameTextBox.Text;
                        cmd.Parameters["Address"].Value = AddressTextBox.Text;
                        cmd.Parameters["Telephone"].Value = TelephoneTextBox.Text;
                        cmd.Parameters["Id"].Value = int.Parse(IDTextBox.Text);
                        cmd.ExecuteNonQuery();
                        // コミット
                        trans.Commit();
                        MessageBox.Show("変更に成功しました。");
                        // DataTableを生成します。
                        var dataTable = new DataTable();
                        // SQLの実行
                        var adapter = new SQLiteDataAdapter("SELECT * FROM Member", con);
                        adapter.Fill(dataTable);
                        DataBaseView.DataSource = dataTable;//ビューを更新
                    }
                }
            }
        }

        /// <summary>
        /// Memberテーブルをビューで表示する。
        /// </summary>
        private void TableCheckButtonClick(object sender, EventArgs e)//テーブル確認
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=HCSSportsForm.db"))
            {
                // DataTableを生成します。
                var dataTable = new DataTable();
                // SQLの実行
                var adapter = new SQLiteDataAdapter("SELECT * FROM Member", con);
                adapter.Fill(dataTable);
                DataBaseView.DataSource = dataTable;
            }
        }

        /// <summary>
        /// 情報更新画面（Form4）を閉じる。
        /// </summary
        private void CloseButtonClick(object sender, EventArgs e)//閉じる
        {
            // フォームを閉じる
            this.Close();

        }

        /// <summary>
        /// ID、電話番号、学籍番号に対し英数字のみしか入力出来ないように設定。
        /// </summary>
        private void NumberTextKeyPress(object sender, KeyPressEventArgs Number)//英数字のみ記入可能（設定）
        {
            //バックスペースが押された時は有効（Deleteキーも有効）
            if (Number.KeyChar == '\b')
            {
                return;
            }

            //数値0～9以外が押された時はイベントをキャンセルする
            if ((Number.KeyChar < '0' || '9' < Number.KeyChar))
            {
                Number.Handled = true;
            }
        }
    }
}