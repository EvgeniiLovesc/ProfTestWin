
namespace NK_TEST.Users
{
    partial class DeleteUserGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteUserGroup));
            this.cbUserGroupDelete = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbUserGroupMove = new System.Windows.Forms.ComboBox();
            this.rbMoveUser = new System.Windows.Forms.RadioButton();
            this.rbDeleteUser = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbUserGroupDelete
            // 
            this.cbUserGroupDelete.FormattingEnabled = true;
            this.cbUserGroupDelete.Location = new System.Drawing.Point(144, 29);
            this.cbUserGroupDelete.Name = "cbUserGroupDelete";
            this.cbUserGroupDelete.Size = new System.Drawing.Size(514, 24);
            this.cbUserGroupDelete.TabIndex = 13;
            this.cbUserGroupDelete.SelectedIndexChanged += new System.EventHandler(this.cbUserTypes_SelectedIndexChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(420, 229);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(130, 30);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Удалить";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите группу";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(556, 229);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 30);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbUserGroupMove);
            this.groupBox1.Controls.Add(this.rbMoveUser);
            this.groupBox1.Controls.Add(this.rbDeleteUser);
            this.groupBox1.Controls.Add(this.cbUserGroupDelete);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(11, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 203);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип";
            // 
            // cbUserGroupMove
            // 
            this.cbUserGroupMove.FormattingEnabled = true;
            this.cbUserGroupMove.Location = new System.Drawing.Point(37, 163);
            this.cbUserGroupMove.Name = "cbUserGroupMove";
            this.cbUserGroupMove.Size = new System.Drawing.Size(621, 24);
            this.cbUserGroupMove.TabIndex = 16;
            // 
            // rbMoveUser
            // 
            this.rbMoveUser.AutoSize = true;
            this.rbMoveUser.Location = new System.Drawing.Point(37, 126);
            this.rbMoveUser.Name = "rbMoveUser";
            this.rbMoveUser.Size = new System.Drawing.Size(278, 20);
            this.rbMoveUser.TabIndex = 15;
            this.rbMoveUser.TabStop = true;
            this.rbMoveUser.Text = "Переместить пользователей в группу";
            this.rbMoveUser.UseVisualStyleBackColor = true;
            // 
            // rbDeleteUser
            // 
            this.rbDeleteUser.AutoSize = true;
            this.rbDeleteUser.Location = new System.Drawing.Point(37, 89);
            this.rbDeleteUser.Name = "rbDeleteUser";
            this.rbDeleteUser.Size = new System.Drawing.Size(353, 20);
            this.rbDeleteUser.TabIndex = 14;
            this.rbDeleteUser.TabStop = true;
            this.rbDeleteUser.Text = "Удалить пользователей группы вместе с группой";
            this.rbDeleteUser.UseVisualStyleBackColor = true;
            // 
            // DeleteUserGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 273);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteUserGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удаление группы ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbUserGroupDelete;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMoveUser;
        private System.Windows.Forms.RadioButton rbDeleteUser;
        private System.Windows.Forms.ComboBox cbUserGroupMove;
    }
}