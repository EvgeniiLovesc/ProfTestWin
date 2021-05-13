
namespace NK_TEST.Users
{
    partial class DeleteTestsGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteTestsGroup));
            this.cbTestGroupDelete = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTestGroupMove = new System.Windows.Forms.ComboBox();
            this.rbMoveTest = new System.Windows.Forms.RadioButton();
            this.rbDeleteTest = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbTestGroupDelete
            // 
            this.cbTestGroupDelete.FormattingEnabled = true;
            this.cbTestGroupDelete.Location = new System.Drawing.Point(144, 29);
            this.cbTestGroupDelete.Name = "cbTestGroupDelete";
            this.cbTestGroupDelete.Size = new System.Drawing.Size(514, 24);
            this.cbTestGroupDelete.TabIndex = 13;
            this.cbTestGroupDelete.SelectedIndexChanged += new System.EventHandler(this.cbUserTypes_SelectedIndexChanged);
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
            this.groupBox1.Controls.Add(this.cbTestGroupMove);
            this.groupBox1.Controls.Add(this.rbMoveTest);
            this.groupBox1.Controls.Add(this.rbDeleteTest);
            this.groupBox1.Controls.Add(this.cbTestGroupDelete);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(11, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 203);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип";
            // 
            // cbTestGroupMove
            // 
            this.cbTestGroupMove.FormattingEnabled = true;
            this.cbTestGroupMove.Location = new System.Drawing.Point(37, 163);
            this.cbTestGroupMove.Name = "cbTestGroupMove";
            this.cbTestGroupMove.Size = new System.Drawing.Size(621, 24);
            this.cbTestGroupMove.TabIndex = 16;
            // 
            // rbMoveTest
            // 
            this.rbMoveTest.AutoSize = true;
            this.rbMoveTest.Location = new System.Drawing.Point(37, 126);
            this.rbMoveTest.Name = "rbMoveTest";
            this.rbMoveTest.Size = new System.Drawing.Size(278, 20);
            this.rbMoveTest.TabIndex = 15;
            this.rbMoveTest.TabStop = true;
            this.rbMoveTest.Text = "Переместить пользователей в группу";
            this.rbMoveTest.UseVisualStyleBackColor = true;
            // 
            // rbDeleteTest
            // 
            this.rbDeleteTest.AutoSize = true;
            this.rbDeleteTest.Location = new System.Drawing.Point(37, 89);
            this.rbDeleteTest.Name = "rbDeleteTest";
            this.rbDeleteTest.Size = new System.Drawing.Size(353, 20);
            this.rbDeleteTest.TabIndex = 14;
            this.rbDeleteTest.TabStop = true;
            this.rbDeleteTest.Text = "Удалить пользователей группы вместе с группой";
            this.rbDeleteTest.UseVisualStyleBackColor = true;
            // 
            // DeleteTestsGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 273);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteTestsGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удаление группы ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTestGroupDelete;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMoveTest;
        private System.Windows.Forms.RadioButton rbDeleteTest;
        private System.Windows.Forms.ComboBox cbTestGroupMove;
    }
}