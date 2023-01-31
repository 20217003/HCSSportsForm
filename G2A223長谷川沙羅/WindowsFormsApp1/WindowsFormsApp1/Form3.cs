using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WindowsFormsApp1
{
    //登録削除画面
    public partial class DataDeletionForm : Form
    {
        private bool isPassword = default;//パスワード判定
        public DataDeletionForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 指定のパスワードとテキストボックスに記入された内容と一致しているか判定する。
        /// 一致していればフラグがtrue。一致してなければfalseとなる。
        /// </summary>
        private void Password()//パスワード確認処理
        {
            string Password = "1q2w3e4r";

            if (Password == PasswordTextBox.Text)//パスワードが一致しているか
            {
                isPassword = true;
            }
            else
            {
                isPassword = false;
            }
        }

        /// <summary>
        /// パスワードが一致しているか判断した後
        /// 本当に削除していいか確認をとってから
        /// 指定されたIDのデータを消す。
        /// </summary>
        private void DeleteButtonClick(object sender, EventArgs e)//データ削除ボタン
        {
            Password();
            if (isPassword == true)
            {
                //メッセージボックスを表示する
                DialogResult result = MessageBox.Show("本当に削除して宜しいですか？",
                    "削除確認",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button2);

                //何が選択されたか調べる
                if (result == DialogResult.Yes)
                {
                    //「はい」が選択された時
                    Console.WriteLine("「はい」が選択されました");
                    using (SQLiteConnection con = new SQLiteConnection("Data Source=HCSSportsForm.db"))
                    {
                        con.Open();
                        using (SQLiteTransaction trans = con.BeginTransaction())
                        {
                            SQLiteCommand cmd = con.CreateCommand();
                            // インサート
                            cmd.CommandText = "DELETE FROM Member WHERE idNo = @Id;";
                            // パラメータセット
                            cmd.Parameters.Add("Id", System.Data.DbType.Int64);
                            // データ削除
                            cmd.Parameters["Id"].Value = int.Parse(IDTextBox.Text);
                            cmd.ExecuteNonQuery();
                            // コミット
                            trans.Commit();

                            // DataTableを生成します。
                            var dataTable = new DataTable();
                            // SQLの実行
                            var adapter = new SQLiteDataAdapter("SELECT * FROM Member", con);
                            adapter.Fill(dataTable);
                            DataBaseView.DataSource = dataTable;
                        }
                    }
                }
                else if (result == DialogResult.No)
                {
                    //「いいえ」が選択された時
                    Console.WriteLine("「いいえ」が選択されました");
                }
            }
            else
            {
                MessageBox.Show("パスワードが違います。", "エラー",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// データ削除画面（Form3）を閉じる。
        /// </summary>
        private void CloseButtonClick(object sender, EventArgs e)//登録削除画面終了ボタン
        {
            // フォームを閉じる
            this.Close();
        }

        /// <summary>
        /// Memberテーブルをビューで表示する。
        /// </summary>
        private void TableCheckButtonClick(object sender, EventArgs e)//テーブル内容確認ボタン
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
        /// IDを記入するテキストボックスに対し英数字のみしか入力出来ないように設定。
        /// </summary>
        private void NumberTextKeyPress(object sender, KeyPressEventArgs Number)//英数字のみ入力可能（設定）
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