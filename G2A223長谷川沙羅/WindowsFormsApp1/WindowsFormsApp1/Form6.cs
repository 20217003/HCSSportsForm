using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WindowsFormsApp1
{
    public partial class TableManagementForm : Form//データベース管理画面
    {
        private bool isPassword = default;//パスワード判定
        public TableManagementForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 指定のパスワードとテキストボックスに記入された内容と一致しているか判定する。
        /// 一致していればフラグがtrue。一致してなければfalseとなる。
        /// </summary>
        private void Password()//パスワード一致確認処理
        {
            string password = "1q2w3e4r";//パスワード

            if (password == PasswordTextBox.Text)
            {
                isPassword = true;
            }
            else
            {
                isPassword = false;
            }
        }

        /// <summary>
        /// パスワード判定で一致していればHCSSportsForm.dbから、
        /// その中のMemberテーブルを削除する。
        /// </summary>
        private void DeleteTablebButtonClick(object sender, EventArgs e)//DB削除ボタン
        {
            Password();
            if (isPassword == true)//パスワード合ってたら消す

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
                    // コネクションを開いてテーブル削除して閉じる  
                    using (var con = new SQLiteConnection("Data Source=HCSSportsForm.db"))
                    {
                        con.Open();
                        using (SQLiteCommand command = con.CreateCommand())
                        {
                            command.CommandText =
                                "drop table Member";
                            command.ExecuteNonQuery();
                        }
                        con.Close();
                        MessageBox.Show("削除に成功しました。");
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
        /// パスワード判定で一致していればHCSSportsForm.dbを作成し、
        /// その中にMemberテーブルを作成する。
        /// </summary>
        private void CreateATableButtonClick(object sender, EventArgs e)//DB作成ボタン
        {
            Password();
            if (isPassword == true)
            {
                // コネクションを開いてテーブル作成して閉じる  
                using (var con = new SQLiteConnection("Data Source=HCSSportsForm.db"))
                {
                    con.Open();
                    using (SQLiteCommand command = con.CreateCommand())
                    {
                        command.CommandText =
                            "create table Member(idNo INTEGER  PRIMARY KEY AUTOINCREMENT,schoolID TEXT," +
                            " surname TEXT,name TEXT,address TEXT, telephone TEXT)";
                        //ID、学籍番号、苗字、名前、住所、電話番号
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                    MessageBox.Show("作成に成功しました。");
                    // フォームを閉じる
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("パスワードが違います。", "エラー",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }
    }
}