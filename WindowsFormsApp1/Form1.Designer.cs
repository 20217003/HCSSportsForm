
namespace WindowsFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.TableButton = new System.Windows.Forms.Button();
            this.EndButton = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.DataSearchButton = new System.Windows.Forms.Button();
            this.DataDeletionButton = new System.Windows.Forms.Button();
            this.DataUpdateButton = new System.Windows.Forms.Button();
            this.NewRegistrationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TableButton
            // 
            this.TableButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TableButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TableButton.Font = new System.Drawing.Font("ＭＳ 明朝", 15.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TableButton.ForeColor = System.Drawing.Color.Black;
            this.TableButton.Location = new System.Drawing.Point(12, 400);
            this.TableButton.Name = "TableButton";
            this.TableButton.Size = new System.Drawing.Size(427, 59);
            this.TableButton.TabIndex = 53;
            this.TableButton.Text = "テーブル作成・削除はコチラ";
            this.TableButton.UseVisualStyleBackColor = false;
            this.TableButton.Click += new System.EventHandler(this.TableButtonClick);
            // 
            // EndButton
            // 
            this.EndButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EndButton.Font = new System.Drawing.Font("MS UI Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EndButton.ForeColor = System.Drawing.Color.DarkOrchid;
            this.EndButton.Location = new System.Drawing.Point(952, 414);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(134, 45);
            this.EndButton.TabIndex = 39;
            this.EndButton.Text = "終了";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButtonClick);
            // 
            // Label
            // 
            this.Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 28F, System.Drawing.FontStyle.Bold);
            this.Label.ForeColor = System.Drawing.Color.DarkOrchid;
            this.Label.Location = new System.Drawing.Point(48, 58);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(932, 47);
            this.Label.TabIndex = 34;
            this.Label.Text = "ＨＣＳスポーツクラブフォームへようこそ";
            this.Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DataSearchButton
            // 
            this.DataSearchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataSearchButton.Font = new System.Drawing.Font("MS UI Gothic", 23F);
            this.DataSearchButton.ForeColor = System.Drawing.Color.DarkOrchid;
            this.DataSearchButton.Location = new System.Drawing.Point(817, 182);
            this.DataSearchButton.Name = "DataSearchButton";
            this.DataSearchButton.Size = new System.Drawing.Size(198, 139);
            this.DataSearchButton.TabIndex = 33;
            this.DataSearchButton.Text = "登録情報検索";
            this.DataSearchButton.UseVisualStyleBackColor = true;
            this.DataSearchButton.Click += new System.EventHandler(this.DataSearchButtonClick);
            // 
            // DataDeletionButton
            // 
            this.DataDeletionButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataDeletionButton.Font = new System.Drawing.Font("MS UI Gothic", 23F);
            this.DataDeletionButton.ForeColor = System.Drawing.Color.DarkOrchid;
            this.DataDeletionButton.Location = new System.Drawing.Point(572, 182);
            this.DataDeletionButton.Name = "DataDeletionButton";
            this.DataDeletionButton.Size = new System.Drawing.Size(198, 139);
            this.DataDeletionButton.TabIndex = 32;
            this.DataDeletionButton.Text = "登録削除";
            this.DataDeletionButton.UseVisualStyleBackColor = true;
            this.DataDeletionButton.Click += new System.EventHandler(this.DeletionButtonClick);
            // 
            // DataUpdateButton
            // 
            this.DataUpdateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataUpdateButton.Font = new System.Drawing.Font("MS UI Gothic", 23F);
            this.DataUpdateButton.ForeColor = System.Drawing.Color.DarkOrchid;
            this.DataUpdateButton.Location = new System.Drawing.Point(330, 182);
            this.DataUpdateButton.Name = "DataUpdateButton";
            this.DataUpdateButton.Size = new System.Drawing.Size(198, 139);
            this.DataUpdateButton.TabIndex = 31;
            this.DataUpdateButton.Text = "登録変更";
            this.DataUpdateButton.UseVisualStyleBackColor = true;
            this.DataUpdateButton.Click += new System.EventHandler(this.DataModificationButtonClick);
            // 
            // NewRegistrationButton
            // 
            this.NewRegistrationButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NewRegistrationButton.Font = new System.Drawing.Font("MS UI Gothic", 23F);
            this.NewRegistrationButton.ForeColor = System.Drawing.Color.DarkOrchid;
            this.NewRegistrationButton.Location = new System.Drawing.Point(82, 182);
            this.NewRegistrationButton.Name = "NewRegistrationButton";
            this.NewRegistrationButton.Size = new System.Drawing.Size(198, 139);
            this.NewRegistrationButton.TabIndex = 30;
            this.NewRegistrationButton.Text = "新規登録";
            this.NewRegistrationButton.UseVisualStyleBackColor = true;
            this.NewRegistrationButton.Click += new System.EventHandler(this.NewRegistrationButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1098, 471);
            this.Controls.Add(this.TableButton);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.DataSearchButton);
            this.Controls.Add(this.DataDeletionButton);
            this.Controls.Add(this.DataUpdateButton);
            this.Controls.Add(this.NewRegistrationButton);
            this.Name = "MainForm";
            this.Text = "ＨＣＳスポーツクラブフォームメイン画面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TableButton;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button DataSearchButton;
        private System.Windows.Forms.Button DataDeletionButton;
        private System.Windows.Forms.Button DataUpdateButton;
        private System.Windows.Forms.Button NewRegistrationButton;
    }
}

