using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WindowsFormsApp1
{
    //登録情報検索画面
    public partial class DataSearchForm : Form
    {
        public DataSearchForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 入力に指定が無ければMemberのテーブルを全表示する。
        /// radiobuttonで指定されたIDまたは学籍番号で
        /// 入力されたテキストボックスの内容と完全一致したデータを検索する。
        /// </summary>
        private void DataSearchButtonClick(object sender, EventArgs e)//データ検索
        {
            if (NumberTextBox.Text == "")//テキストボックス空判定(その場合、全部表示)
            {
                using (SQLiteConnection con = new SQLiteConnection("Data Source=HCSSportsForm.db"))
                {
                    // DataTableを生成します。
                    var dataTable = new DataTable();
                    // SQLの実行
                    var adapter = new SQLiteDataAdapter("SELECT * FROM Member", con);
                    adapter.Fill(dataTable);
                    DataBaseView.DataSource = dataTable;//ビューを更新
                }
            }
            else//記入していたら
            {
                if (IDRadioButton.Checked == true)//ID（ラジオボタン）選択
                {
                    using (SQLiteConnection con = new SQLiteConnection("Data Source=HCSSportsForm.db"))
                    {
                        con.Open();
                        using (SQLiteTransaction trans = con.BeginTransaction())
                        {
                            // DataTableを生成します。
                            var dataTable = new DataTable();
                            // SQLの実行
                            var adapter = new SQLiteDataAdapter("SELECT * FROM Member where idno =" + NumberTextBox.Text, con);
                            adapter.Fill(dataTable);
                            DataBaseView.DataSource = dataTable;
                        }
                    }
                }
                else if (SchoolIDRadioButton.Checked == true)//学籍番号（ラジオボタン）選択
                {
                    using (SQLiteConnection con = new SQLiteConnection("Data Source=HCSSportsForm.db"))
                    {
                        con.Open();
                        using (SQLiteTransaction trans = con.BeginTransaction())
                        {
                            // DataTableを生成します。
                            var dataTable = new DataTable();
                            // SQLの実行
                            var adapter = new SQLiteDataAdapter("SELECT * FROM Member where schoolID =" + NumberTextBox.Text, con);
                            adapter.Fill(dataTable);
                            DataBaseView.DataSource = dataTable;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 情報検索画面（Form5）を閉じる。
        /// </summary
        private void CloseButtonClick(object sender, EventArgs e)//終了ボタン
        {
            // フォームを閉じる
            this.Close();
        }

        /// <summary>
        /// IDまたは学籍番号を入力するテキストボックスに対し英数字のみしか入力出来ないように設定。
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