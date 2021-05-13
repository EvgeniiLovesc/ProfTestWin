
namespace NK_TEST.Users
{
    partial class ImportUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportUser));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridImportedUsers = new System.Windows.Forms.DataGridView();
            this.UserImageGroup = new System.Windows.Forms.DataGridViewImageColumn();
            this.UserGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.UserSername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMove = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridImportedUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel1.Controls.Add(this.btnMove);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1140, 95);
            this.flowLayoutPanel1.TabIndex = 8;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1139F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 95);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1140, 25);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // dataGridImportedUsers
            // 
            this.dataGridImportedUsers.AllowUserToAddRows = false;
            this.dataGridImportedUsers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridImportedUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridImportedUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserImageGroup,
            this.UserGroup,
            this.UserImage,
            this.UserSername,
            this.UserName,
            this.UserMiddleName,
            this.UserLogin,
            this.UserNotes});
            this.dataGridImportedUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridImportedUsers.Location = new System.Drawing.Point(0, 120);
            this.dataGridImportedUsers.Name = "dataGridImportedUsers";
            this.dataGridImportedUsers.RowHeadersWidth = 51;
            this.dataGridImportedUsers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridImportedUsers.Size = new System.Drawing.Size(1140, 376);
            this.dataGridImportedUsers.TabIndex = 12;
            // 
            // UserImageGroup
            // 
            this.UserImageGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UserImageGroup.FillWeight = 300F;
            this.UserImageGroup.HeaderText = "";
            this.UserImageGroup.MinimumWidth = 20;
            this.UserImageGroup.Name = "UserImageGroup";
            this.UserImageGroup.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UserImageGroup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.UserImageGroup.Width = 20;
            // 
            // UserGroup
            // 
            this.UserGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UserGroup.FillWeight = 300F;
            this.UserGroup.HeaderText = "Группа";
            this.UserGroup.MinimumWidth = 250;
            this.UserGroup.Name = "UserGroup";
            this.UserGroup.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UserGroup.Width = 250;
            // 
            // UserImage
            // 
            this.UserImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UserImage.HeaderText = "";
            this.UserImage.MinimumWidth = 20;
            this.UserImage.Name = "UserImage";
            this.UserImage.Width = 20;
            // 
            // UserSername
            // 
            this.UserSername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UserSername.HeaderText = "Фамилия";
            this.UserSername.MinimumWidth = 250;
            this.UserSername.Name = "UserSername";
            this.UserSername.Width = 250;
            // 
            // UserName
            // 
            this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UserName.HeaderText = "Имя";
            this.UserName.MinimumWidth = 200;
            this.UserName.Name = "UserName";
            this.UserName.Width = 200;
            // 
            // UserMiddleName
            // 
            this.UserMiddleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UserMiddleName.HeaderText = "Отчество";
            this.UserMiddleName.MinimumWidth = 200;
            this.UserMiddleName.Name = "UserMiddleName";
            this.UserMiddleName.Width = 200;
            // 
            // UserLogin
            // 
            this.UserLogin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UserLogin.HeaderText = "Логин";
            this.UserLogin.MinimumWidth = 200;
            this.UserLogin.Name = "UserLogin";
            this.UserLogin.Width = 200;
            // 
            // UserNotes
            // 
            this.UserNotes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserNotes.HeaderText = "Заметки";
            this.UserNotes.Name = "UserNotes";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(509, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Результаты импорта";
            // 
            // btnMove
            // 
            this.btnMove.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMove.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMove.FlatAppearance.BorderSize = 0;
            this.btnMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMove.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMove.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMove.Image = global::NK_TEST.Properties.Resources.folder_move_icon;
            this.btnMove.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMove.Location = new System.Drawing.Point(3, 3);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(95, 90);
            this.btnMove.TabIndex = 5;
            this.btnMove.Text = "Загрузить из txt файла";
            this.btnMove.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMove.UseVisualStyleBackColor = false;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = global::NK_TEST.Properties.Resources.list_user;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(104, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 90);
            this.button1.TabIndex = 11;
            this.button1.Text = "Сохранить в базу данных ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ImportUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 496);
            this.Controls.Add(this.dataGridImportedUsers);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImportUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Импорт пользователей";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridImportedUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridImportedUsers;
        private System.Windows.Forms.DataGridViewImageColumn UserImageGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserGroup;
        private System.Windows.Forms.DataGridViewImageColumn UserImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserSername;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserMiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNotes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}