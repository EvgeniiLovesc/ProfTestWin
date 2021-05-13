
namespace NK_TEST.Users
{
    partial class AddRules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRules));
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.id_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTests = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbType = new System.Windows.Forms.DataGridViewImageColumn();
            this.tbName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbRulesGroup = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rasp3_dateFinish = new System.Windows.Forms.DateTimePicker();
            this.rasp3_dateStart = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.rasp2_dateFinish = new System.Windows.Forms.DateTimePicker();
            this.rasp2_dateStart = new System.Windows.Forms.DateTimePicker();
            this.rbRaspType3 = new System.Windows.Forms.RadioButton();
            this.rbRaspType2 = new System.Windows.Forms.RadioButton();
            this.rbRaspType1 = new System.Windows.Forms.RadioButton();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rasp1_dateFinish = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.rasp1_dateStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.cbNumberAttempt = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbTestsAllinGroup = new System.Windows.Forms.CheckBox();
            this.cbTests = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbUsersAllInGroup = new System.Windows.Forms.CheckBox();
            this.cbUsers = new System.Windows.Forms.ComboBox();
            this.cbNumberAttemptValue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTests)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(779, 900);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(130, 30);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Сохранить";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(922, 900);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 30);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvUsers);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(534, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 398);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Пользователи";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_user,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn1});
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.Location = new System.Drawing.Point(3, 18);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(512, 377);
            this.dgvUsers.TabIndex = 1;
            // 
            // id_user
            // 
            this.id_user.HeaderText = "id_user";
            this.id_user.Name = "id_user";
            this.id_user.Visible = false;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 25;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTests);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(11, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 398);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тесты";
            // 
            // dgvTests
            // 
            this.dgvTests.AllowUserToAddRows = false;
            this.dgvTests.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.cb_selected,
            this.tbType,
            this.tbName});
            this.dgvTests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTests.Location = new System.Drawing.Point(3, 18);
            this.dgvTests.Name = "dgvTests";
            this.dgvTests.Size = new System.Drawing.Size(511, 377);
            this.dgvTests.TabIndex = 1;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // cb_selected
            // 
            this.cb_selected.HeaderText = "";
            this.cb_selected.Name = "cb_selected";
            this.cb_selected.Width = 25;
            // 
            // tbType
            // 
            this.tbType.HeaderText = "";
            this.tbType.Name = "tbType";
            this.tbType.Width = 25;
            // 
            // tbName
            // 
            this.tbName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tbName.HeaderText = "Название";
            this.tbName.Name = "tbName";
            this.tbName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tbName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cbNumberAttemptValue);
            this.groupBox3.Controls.Add(this.cbRulesGroup);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.rasp3_dateFinish);
            this.groupBox3.Controls.Add(this.rasp3_dateStart);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.rasp2_dateFinish);
            this.groupBox3.Controls.Add(this.rasp2_dateStart);
            this.groupBox3.Controls.Add(this.rbRaspType3);
            this.groupBox3.Controls.Add(this.rbRaspType2);
            this.groupBox3.Controls.Add(this.rbRaspType1);
            this.groupBox3.Controls.Add(this.tb_Name);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.rasp1_dateFinish);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.rasp1_dateStart);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tbDescription);
            this.groupBox3.Controls.Add(this.cbNumberAttempt);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(12, 520);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1040, 369);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Расписание";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // cbRulesGroup
            // 
            this.cbRulesGroup.FormattingEnabled = true;
            this.cbRulesGroup.Location = new System.Drawing.Point(111, 233);
            this.cbRulesGroup.Name = "cbRulesGroup";
            this.cbRulesGroup.Size = new System.Drawing.Size(918, 24);
            this.cbRulesGroup.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Группа";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "- ";
            // 
            // rasp3_dateFinish
            // 
            this.rasp3_dateFinish.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.rasp3_dateFinish.Location = new System.Drawing.Point(415, 117);
            this.rasp3_dateFinish.Name = "rasp3_dateFinish";
            this.rasp3_dateFinish.Size = new System.Drawing.Size(200, 22);
            this.rasp3_dateFinish.TabIndex = 17;
            // 
            // rasp3_dateStart
            // 
            this.rasp3_dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.rasp3_dateStart.Location = new System.Drawing.Point(179, 117);
            this.rasp3_dateStart.Name = "rasp3_dateStart";
            this.rasp3_dateStart.Size = new System.Drawing.Size(200, 22);
            this.rasp3_dateStart.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "- ";
            // 
            // rasp2_dateFinish
            // 
            this.rasp2_dateFinish.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.rasp2_dateFinish.Location = new System.Drawing.Point(415, 74);
            this.rasp2_dateFinish.Name = "rasp2_dateFinish";
            this.rasp2_dateFinish.Size = new System.Drawing.Size(200, 22);
            this.rasp2_dateFinish.TabIndex = 14;
            // 
            // rasp2_dateStart
            // 
            this.rasp2_dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.rasp2_dateStart.Location = new System.Drawing.Point(179, 74);
            this.rasp2_dateStart.Name = "rasp2_dateStart";
            this.rasp2_dateStart.Size = new System.Drawing.Size(200, 22);
            this.rasp2_dateStart.TabIndex = 13;
            // 
            // rbRaspType3
            // 
            this.rbRaspType3.AutoSize = true;
            this.rbRaspType3.Location = new System.Drawing.Point(15, 117);
            this.rbRaspType3.Name = "rbRaspType3";
            this.rbRaspType3.Size = new System.Drawing.Size(117, 20);
            this.rbRaspType3.TabIndex = 12;
            this.rbRaspType3.TabStop = true;
            this.rbRaspType3.Text = "Еженедельно";
            this.rbRaspType3.UseVisualStyleBackColor = true;
            // 
            // rbRaspType2
            // 
            this.rbRaspType2.AutoSize = true;
            this.rbRaspType2.Location = new System.Drawing.Point(15, 73);
            this.rbRaspType2.Name = "rbRaspType2";
            this.rbRaspType2.Size = new System.Drawing.Size(102, 20);
            this.rbRaspType2.TabIndex = 11;
            this.rbRaspType2.TabStop = true;
            this.rbRaspType2.Text = "Ежедневно";
            this.rbRaspType2.UseVisualStyleBackColor = true;
            // 
            // rbRaspType1
            // 
            this.rbRaspType1.AutoSize = true;
            this.rbRaspType1.Location = new System.Drawing.Point(16, 32);
            this.rbRaspType1.Name = "rbRaspType1";
            this.rbRaspType1.Size = new System.Drawing.Size(146, 20);
            this.rbRaspType1.TabIndex = 10;
            this.rbRaspType1.TabStop = true;
            this.rbRaspType1.Text = "Период времени с";
            this.rbRaspType1.UseVisualStyleBackColor = true;
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(111, 197);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(918, 22);
            this.tb_Name.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Название";
            // 
            // rasp1_dateFinish
            // 
            this.rasp1_dateFinish.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rasp1_dateFinish.Location = new System.Drawing.Point(415, 31);
            this.rasp1_dateFinish.Name = "rasp1_dateFinish";
            this.rasp1_dateFinish.Size = new System.Drawing.Size(200, 22);
            this.rasp1_dateFinish.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "до";
            // 
            // rasp1_dateStart
            // 
            this.rasp1_dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rasp1_dateStart.Location = new System.Drawing.Point(179, 32);
            this.rasp1_dateStart.Name = "rasp1_dateStart";
            this.rasp1_dateStart.Size = new System.Drawing.Size(200, 22);
            this.rasp1_dateStart.TabIndex = 5;
            this.rasp1_dateStart.ValueChanged += new System.EventHandler(this.rasp1_dateStart_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Комментарии";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(111, 271);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(918, 81);
            this.tbDescription.TabIndex = 2;
            // 
            // cbNumberAttempt
            // 
            this.cbNumberAttempt.AutoSize = true;
            this.cbNumberAttempt.Location = new System.Drawing.Point(15, 159);
            this.cbNumberAttempt.Name = "cbNumberAttempt";
            this.cbNumberAttempt.Size = new System.Drawing.Size(163, 20);
            this.cbNumberAttempt.TabIndex = 1;
            this.cbNumberAttempt.Text = "Количество попыток";
            this.cbNumberAttempt.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbTestsAllinGroup);
            this.groupBox4.Controls.Add(this.cbTests);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(11, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(514, 83);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Выберите группу тестов";
            // 
            // cbTestsAllinGroup
            // 
            this.cbTestsAllinGroup.AutoSize = true;
            this.cbTestsAllinGroup.Location = new System.Drawing.Point(6, 56);
            this.cbTestsAllinGroup.Name = "cbTestsAllinGroup";
            this.cbTestsAllinGroup.Size = new System.Drawing.Size(260, 21);
            this.cbTestsAllinGroup.TabIndex = 2;
            this.cbTestsAllinGroup.Text = "Применить правило ко всей группе";
            this.cbTestsAllinGroup.UseVisualStyleBackColor = true;
            // 
            // cbTests
            // 
            this.cbTests.FormattingEnabled = true;
            this.cbTests.Location = new System.Drawing.Point(6, 23);
            this.cbTests.Name = "cbTests";
            this.cbTests.Size = new System.Drawing.Size(502, 24);
            this.cbTests.TabIndex = 0;
            this.cbTests.SelectedIndexChanged += new System.EventHandler(this.cbTests_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbUsersAllInGroup);
            this.groupBox5.Controls.Add(this.cbUsers);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(539, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(514, 83);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Выберите группу пользователей";
            // 
            // cbUsersAllInGroup
            // 
            this.cbUsersAllInGroup.AutoSize = true;
            this.cbUsersAllInGroup.Location = new System.Drawing.Point(6, 56);
            this.cbUsersAllInGroup.Name = "cbUsersAllInGroup";
            this.cbUsersAllInGroup.Size = new System.Drawing.Size(260, 21);
            this.cbUsersAllInGroup.TabIndex = 2;
            this.cbUsersAllInGroup.Text = "Применить правило ко всей группе";
            this.cbUsersAllInGroup.UseVisualStyleBackColor = true;
            // 
            // cbUsers
            // 
            this.cbUsers.FormattingEnabled = true;
            this.cbUsers.Location = new System.Drawing.Point(6, 23);
            this.cbUsers.Name = "cbUsers";
            this.cbUsers.Size = new System.Drawing.Size(502, 24);
            this.cbUsers.TabIndex = 0;
            this.cbUsers.SelectedIndexChanged += new System.EventHandler(this.cbUsers_SelectedIndexChanged);
            // 
            // cbNumberAttemptValue
            // 
            this.cbNumberAttemptValue.Location = new System.Drawing.Point(179, 158);
            this.cbNumberAttemptValue.Name = "cbNumberAttemptValue";
            this.cbNumberAttemptValue.Size = new System.Drawing.Size(67, 22);
            this.cbNumberAttemptValue.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(252, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "раз";
            // 
            // AddRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 939);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddRules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новое правило";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTests)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.CheckBox cbNumberAttempt;
        private System.Windows.Forms.DateTimePicker rasp1_dateFinish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker rasp1_dateStart;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridView dgvTests;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cb_selected;
        private System.Windows.Forms.DataGridViewImageColumn tbType;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbTests;
        private System.Windows.Forms.CheckBox cbTestsAllinGroup;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox cbUsersAllInGroup;
        private System.Windows.Forms.ComboBox cbUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_user;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.RadioButton rbRaspType1;
        private System.Windows.Forms.RadioButton rbRaspType3;
        private System.Windows.Forms.RadioButton rbRaspType2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker rasp3_dateFinish;
        private System.Windows.Forms.DateTimePicker rasp3_dateStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker rasp2_dateFinish;
        private System.Windows.Forms.DateTimePicker rasp2_dateStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbRulesGroup;
        private System.Windows.Forms.TextBox cbNumberAttemptValue;
        private System.Windows.Forms.Label label7;
    }
}