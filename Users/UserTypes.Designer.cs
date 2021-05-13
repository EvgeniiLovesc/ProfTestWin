
namespace NK_TEST.Users
{
    partial class UserTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserTypes));
            this.cbUserTypes = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.auto_exam = new System.Windows.Forms.CheckBox();
            this.perm_user_management = new System.Windows.Forms.CheckBox();
            this.perm_set_examiner = new System.Windows.Forms.CheckBox();
            this.perm_protocol_delete = new System.Windows.Forms.CheckBox();
            this.perm_protocol_create = new System.Windows.Forms.CheckBox();
            this.perm_test_delete = new System.Windows.Forms.CheckBox();
            this.perm_test_edit = new System.Windows.Forms.CheckBox();
            this.perm_test_create = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.m_yt = new System.Windows.Forms.CheckBox();
            this.m_ae = new System.Windows.Forms.CheckBox();
            this.m_tk = new System.Windows.Forms.CheckBox();
            this.m_pvt = new System.Windows.Forms.CheckBox();
            this.m_vd = new System.Windows.Forms.CheckBox();
            this.m_mk = new System.Windows.Forms.CheckBox();
            this.m_pvk = new System.Windows.Forms.CheckBox();
            this.m_ek = new System.Windows.Forms.CheckBox();
            this.m_pk = new System.Windows.Forms.CheckBox();
            this.m_yk = new System.Windows.Forms.CheckBox();
            this.m_vik = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.o12 = new System.Windows.Forms.CheckBox();
            this.o10 = new System.Windows.Forms.CheckBox();
            this.o7 = new System.Windows.Forms.CheckBox();
            this.o8 = new System.Windows.Forms.CheckBox();
            this.o9 = new System.Windows.Forms.CheckBox();
            this.o11 = new System.Windows.Forms.CheckBox();
            this.o6 = new System.Windows.Forms.CheckBox();
            this.o4 = new System.Windows.Forms.CheckBox();
            this.o5 = new System.Windows.Forms.CheckBox();
            this.o2 = new System.Windows.Forms.CheckBox();
            this.o1 = new System.Windows.Forms.CheckBox();
            this.o3 = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbUserTypes
            // 
            this.cbUserTypes.FormattingEnabled = true;
            this.cbUserTypes.Location = new System.Drawing.Point(121, 29);
            this.cbUserTypes.Name = "cbUserTypes";
            this.cbUserTypes.Size = new System.Drawing.Size(537, 24);
            this.cbUserTypes.TabIndex = 13;
            this.cbUserTypes.SelectedIndexChanged += new System.EventHandler(this.cbUserTypes_SelectedIndexChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(420, 678);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(130, 30);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Сохранить";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите тип";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(556, 678);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 30);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Закрыть";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.auto_exam);
            this.groupBox2.Controls.Add(this.perm_user_management);
            this.groupBox2.Controls.Add(this.perm_set_examiner);
            this.groupBox2.Controls.Add(this.perm_protocol_delete);
            this.groupBox2.Controls.Add(this.perm_protocol_create);
            this.groupBox2.Controls.Add(this.perm_test_delete);
            this.groupBox2.Controls.Add(this.perm_test_edit);
            this.groupBox2.Controls.Add(this.perm_test_create);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(11, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 360);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Права";
            // 
            // auto_exam
            // 
            this.auto_exam.AutoSize = true;
            this.auto_exam.Location = new System.Drawing.Point(15, 212);
            this.auto_exam.Name = "auto_exam";
            this.auto_exam.Size = new System.Drawing.Size(165, 20);
            this.auto_exam.TabIndex = 18;
            this.auto_exam.Text = "Автосдача экзамена";
            this.auto_exam.UseVisualStyleBackColor = true;
            // 
            // perm_user_management
            // 
            this.perm_user_management.AutoSize = true;
            this.perm_user_management.Location = new System.Drawing.Point(15, 186);
            this.perm_user_management.Name = "perm_user_management";
            this.perm_user_management.Size = new System.Drawing.Size(273, 20);
            this.perm_user_management.TabIndex = 17;
            this.perm_user_management.Text = "Управление правами пользователей";
            this.perm_user_management.UseVisualStyleBackColor = true;
            // 
            // perm_set_examiner
            // 
            this.perm_set_examiner.AutoSize = true;
            this.perm_set_examiner.Location = new System.Drawing.Point(15, 160);
            this.perm_set_examiner.Name = "perm_set_examiner";
            this.perm_set_examiner.Size = new System.Drawing.Size(215, 20);
            this.perm_set_examiner.TabIndex = 16;
            this.perm_set_examiner.Text = "Назначение экзаменаторов";
            this.perm_set_examiner.UseVisualStyleBackColor = true;
            // 
            // perm_protocol_delete
            // 
            this.perm_protocol_delete.AutoSize = true;
            this.perm_protocol_delete.Location = new System.Drawing.Point(15, 134);
            this.perm_protocol_delete.Name = "perm_protocol_delete";
            this.perm_protocol_delete.Size = new System.Drawing.Size(173, 20);
            this.perm_protocol_delete.TabIndex = 15;
            this.perm_protocol_delete.Text = "Удаление протоколов";
            this.perm_protocol_delete.UseVisualStyleBackColor = true;
            // 
            // perm_protocol_create
            // 
            this.perm_protocol_create.AutoSize = true;
            this.perm_protocol_create.Location = new System.Drawing.Point(15, 108);
            this.perm_protocol_create.Name = "perm_protocol_create";
            this.perm_protocol_create.Size = new System.Drawing.Size(208, 20);
            this.perm_protocol_create.TabIndex = 14;
            this.perm_protocol_create.Text = "Формирование протоколов";
            this.perm_protocol_create.UseVisualStyleBackColor = true;
            // 
            // perm_test_delete
            // 
            this.perm_test_delete.AutoSize = true;
            this.perm_test_delete.Location = new System.Drawing.Point(15, 82);
            this.perm_test_delete.Name = "perm_test_delete";
            this.perm_test_delete.Size = new System.Drawing.Size(140, 20);
            this.perm_test_delete.TabIndex = 13;
            this.perm_test_delete.Text = "Удаление тестов";
            this.perm_test_delete.UseVisualStyleBackColor = true;
            // 
            // perm_test_edit
            // 
            this.perm_test_edit.AutoSize = true;
            this.perm_test_edit.Location = new System.Drawing.Point(15, 56);
            this.perm_test_edit.Name = "perm_test_edit";
            this.perm_test_edit.Size = new System.Drawing.Size(150, 20);
            this.perm_test_edit.TabIndex = 12;
            this.perm_test_edit.Text = "Изменение тестов";
            this.perm_test_edit.UseVisualStyleBackColor = true;
            // 
            // perm_test_create
            // 
            this.perm_test_create.AutoSize = true;
            this.perm_test_create.Location = new System.Drawing.Point(15, 30);
            this.perm_test_create.Name = "perm_test_create";
            this.perm_test_create.Size = new System.Drawing.Size(140, 20);
            this.perm_test_create.TabIndex = 11;
            this.perm_test_create.Text = "Создание тестов";
            this.perm_test_create.UseVisualStyleBackColor = true;
            this.perm_test_create.CheckedChanged += new System.EventHandler(this.cbTests_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.description);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.cbUserTypes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(11, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 262);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(392, 71);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 30);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Добавить тип";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(19, 128);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(639, 113);
            this.description.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Описание";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(528, 71);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 30);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Удалить тип";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.m_yt);
            this.groupBox3.Controls.Add(this.m_ae);
            this.groupBox3.Controls.Add(this.m_tk);
            this.groupBox3.Controls.Add(this.m_pvt);
            this.groupBox3.Controls.Add(this.m_vd);
            this.groupBox3.Controls.Add(this.m_mk);
            this.groupBox3.Controls.Add(this.m_pvk);
            this.groupBox3.Controls.Add(this.m_ek);
            this.groupBox3.Controls.Add(this.m_pk);
            this.groupBox3.Controls.Add(this.m_yk);
            this.groupBox3.Controls.Add(this.m_vik);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(381, 296);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(142, 360);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Методы";
            // 
            // m_yt
            // 
            this.m_yt.AutoSize = true;
            this.m_yt.Location = new System.Drawing.Point(15, 264);
            this.m_yt.Name = "m_yt";
            this.m_yt.Size = new System.Drawing.Size(45, 20);
            this.m_yt.TabIndex = 21;
            this.m_yt.Text = "УТ";
            this.m_yt.UseVisualStyleBackColor = true;
            // 
            // m_ae
            // 
            this.m_ae.AutoSize = true;
            this.m_ae.Location = new System.Drawing.Point(15, 186);
            this.m_ae.Name = "m_ae";
            this.m_ae.Size = new System.Drawing.Size(46, 20);
            this.m_ae.TabIndex = 20;
            this.m_ae.Text = "АЭ";
            this.m_ae.UseVisualStyleBackColor = true;
            // 
            // m_tk
            // 
            this.m_tk.AutoSize = true;
            this.m_tk.Location = new System.Drawing.Point(15, 212);
            this.m_tk.Name = "m_tk";
            this.m_tk.Size = new System.Drawing.Size(44, 20);
            this.m_tk.TabIndex = 19;
            this.m_tk.Text = "ТК";
            this.m_tk.UseVisualStyleBackColor = true;
            // 
            // m_pvt
            // 
            this.m_pvt.AutoSize = true;
            this.m_pvt.Location = new System.Drawing.Point(15, 238);
            this.m_pvt.Name = "m_pvt";
            this.m_pvt.Size = new System.Drawing.Size(55, 20);
            this.m_pvt.TabIndex = 18;
            this.m_pvt.Text = "ПВТ";
            this.m_pvt.UseVisualStyleBackColor = true;
            // 
            // m_vd
            // 
            this.m_vd.AutoSize = true;
            this.m_vd.Location = new System.Drawing.Point(14, 290);
            this.m_vd.Name = "m_vd";
            this.m_vd.Size = new System.Drawing.Size(45, 20);
            this.m_vd.TabIndex = 17;
            this.m_vd.Text = "ВД";
            this.m_vd.UseVisualStyleBackColor = true;
            // 
            // m_mk
            // 
            this.m_mk.AutoSize = true;
            this.m_mk.Location = new System.Drawing.Point(15, 160);
            this.m_mk.Name = "m_mk";
            this.m_mk.Size = new System.Drawing.Size(46, 20);
            this.m_mk.TabIndex = 16;
            this.m_mk.Text = "МК";
            this.m_mk.UseVisualStyleBackColor = true;
            // 
            // m_pvk
            // 
            this.m_pvk.AutoSize = true;
            this.m_pvk.Location = new System.Drawing.Point(15, 108);
            this.m_pvk.Name = "m_pvk";
            this.m_pvk.Size = new System.Drawing.Size(54, 20);
            this.m_pvk.TabIndex = 15;
            this.m_pvk.Text = "ПВК";
            this.m_pvk.UseVisualStyleBackColor = true;
            // 
            // m_ek
            // 
            this.m_ek.AutoSize = true;
            this.m_ek.Location = new System.Drawing.Point(15, 134);
            this.m_ek.Name = "m_ek";
            this.m_ek.Size = new System.Drawing.Size(45, 20);
            this.m_ek.TabIndex = 14;
            this.m_ek.Text = "ЭК";
            this.m_ek.UseVisualStyleBackColor = true;
            // 
            // m_pk
            // 
            this.m_pk.AutoSize = true;
            this.m_pk.Location = new System.Drawing.Point(15, 56);
            this.m_pk.Name = "m_pk";
            this.m_pk.Size = new System.Drawing.Size(44, 20);
            this.m_pk.TabIndex = 13;
            this.m_pk.Text = "РК";
            this.m_pk.UseVisualStyleBackColor = true;
            // 
            // m_yk
            // 
            this.m_yk.AutoSize = true;
            this.m_yk.Location = new System.Drawing.Point(15, 30);
            this.m_yk.Name = "m_yk";
            this.m_yk.Size = new System.Drawing.Size(44, 20);
            this.m_yk.TabIndex = 12;
            this.m_yk.Text = "УК";
            this.m_yk.UseVisualStyleBackColor = true;
            // 
            // m_vik
            // 
            this.m_vik.AutoSize = true;
            this.m_vik.Location = new System.Drawing.Point(15, 82);
            this.m_vik.Name = "m_vik";
            this.m_vik.Size = new System.Drawing.Size(54, 20);
            this.m_vik.TabIndex = 11;
            this.m_vik.Text = "ВИК";
            this.m_vik.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.o12);
            this.groupBox4.Controls.Add(this.o10);
            this.groupBox4.Controls.Add(this.o7);
            this.groupBox4.Controls.Add(this.o8);
            this.groupBox4.Controls.Add(this.o9);
            this.groupBox4.Controls.Add(this.o11);
            this.groupBox4.Controls.Add(this.o6);
            this.groupBox4.Controls.Add(this.o4);
            this.groupBox4.Controls.Add(this.o5);
            this.groupBox4.Controls.Add(this.o2);
            this.groupBox4.Controls.Add(this.o1);
            this.groupBox4.Controls.Add(this.o3);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(539, 296);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(147, 360);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Объекты";
            // 
            // o12
            // 
            this.o12.AutoSize = true;
            this.o12.Location = new System.Drawing.Point(15, 316);
            this.o12.Name = "o12";
            this.o12.Size = new System.Drawing.Size(41, 20);
            this.o12.TabIndex = 22;
            this.o12.Text = "12";
            this.o12.UseVisualStyleBackColor = true;
            // 
            // o10
            // 
            this.o10.AutoSize = true;
            this.o10.Location = new System.Drawing.Point(15, 264);
            this.o10.Name = "o10";
            this.o10.Size = new System.Drawing.Size(41, 20);
            this.o10.TabIndex = 21;
            this.o10.Text = "10";
            this.o10.UseVisualStyleBackColor = true;
            // 
            // o7
            // 
            this.o7.AutoSize = true;
            this.o7.Location = new System.Drawing.Point(15, 186);
            this.o7.Name = "o7";
            this.o7.Size = new System.Drawing.Size(34, 20);
            this.o7.TabIndex = 20;
            this.o7.Text = "7";
            this.o7.UseVisualStyleBackColor = true;
            // 
            // o8
            // 
            this.o8.AutoSize = true;
            this.o8.Location = new System.Drawing.Point(15, 212);
            this.o8.Name = "o8";
            this.o8.Size = new System.Drawing.Size(34, 20);
            this.o8.TabIndex = 19;
            this.o8.Text = "8";
            this.o8.UseVisualStyleBackColor = true;
            // 
            // o9
            // 
            this.o9.AutoSize = true;
            this.o9.Location = new System.Drawing.Point(15, 238);
            this.o9.Name = "o9";
            this.o9.Size = new System.Drawing.Size(34, 20);
            this.o9.TabIndex = 18;
            this.o9.Text = "9";
            this.o9.UseVisualStyleBackColor = true;
            // 
            // o11
            // 
            this.o11.AutoSize = true;
            this.o11.Location = new System.Drawing.Point(15, 290);
            this.o11.Name = "o11";
            this.o11.Size = new System.Drawing.Size(41, 20);
            this.o11.TabIndex = 17;
            this.o11.Text = "11";
            this.o11.UseVisualStyleBackColor = true;
            // 
            // o6
            // 
            this.o6.AutoSize = true;
            this.o6.Location = new System.Drawing.Point(15, 160);
            this.o6.Name = "o6";
            this.o6.Size = new System.Drawing.Size(34, 20);
            this.o6.TabIndex = 16;
            this.o6.Text = "6";
            this.o6.UseVisualStyleBackColor = true;
            // 
            // o4
            // 
            this.o4.AutoSize = true;
            this.o4.Location = new System.Drawing.Point(15, 108);
            this.o4.Name = "o4";
            this.o4.Size = new System.Drawing.Size(34, 20);
            this.o4.TabIndex = 15;
            this.o4.Text = "4";
            this.o4.UseVisualStyleBackColor = true;
            // 
            // o5
            // 
            this.o5.AutoSize = true;
            this.o5.Location = new System.Drawing.Point(15, 134);
            this.o5.Name = "o5";
            this.o5.Size = new System.Drawing.Size(34, 20);
            this.o5.TabIndex = 14;
            this.o5.Text = "5";
            this.o5.UseVisualStyleBackColor = true;
            // 
            // o2
            // 
            this.o2.AutoSize = true;
            this.o2.Location = new System.Drawing.Point(15, 56);
            this.o2.Name = "o2";
            this.o2.Size = new System.Drawing.Size(34, 20);
            this.o2.TabIndex = 13;
            this.o2.Text = "2";
            this.o2.UseVisualStyleBackColor = true;
            // 
            // o1
            // 
            this.o1.AutoSize = true;
            this.o1.Location = new System.Drawing.Point(15, 30);
            this.o1.Name = "o1";
            this.o1.Size = new System.Drawing.Size(34, 20);
            this.o1.TabIndex = 12;
            this.o1.Text = "1";
            this.o1.UseVisualStyleBackColor = true;
            // 
            // o3
            // 
            this.o3.AutoSize = true;
            this.o3.Location = new System.Drawing.Point(15, 82);
            this.o3.Name = "o3";
            this.o3.Size = new System.Drawing.Size(34, 20);
            this.o3.TabIndex = 11;
            this.o3.Text = "3";
            this.o3.UseVisualStyleBackColor = true;
            // 
            // UserTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 734);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Типы пользователей";
            this.Load += new System.EventHandler(this.UserTypes_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbUserTypes;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox perm_test_edit;
        private System.Windows.Forms.CheckBox perm_test_create;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox perm_user_management;
        private System.Windows.Forms.CheckBox perm_set_examiner;
        private System.Windows.Forms.CheckBox perm_protocol_delete;
        private System.Windows.Forms.CheckBox perm_protocol_create;
        private System.Windows.Forms.CheckBox perm_test_delete;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox m_pvk;
        private System.Windows.Forms.CheckBox m_ek;
        private System.Windows.Forms.CheckBox m_pk;
        private System.Windows.Forms.CheckBox m_yk;
        private System.Windows.Forms.CheckBox m_vik;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox m_yt;
        private System.Windows.Forms.CheckBox m_ae;
        private System.Windows.Forms.CheckBox m_tk;
        private System.Windows.Forms.CheckBox m_pvt;
        private System.Windows.Forms.CheckBox m_vd;
        private System.Windows.Forms.CheckBox m_mk;
        private System.Windows.Forms.CheckBox auto_exam;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox o10;
        private System.Windows.Forms.CheckBox o7;
        private System.Windows.Forms.CheckBox o8;
        private System.Windows.Forms.CheckBox o9;
        private System.Windows.Forms.CheckBox o11;
        private System.Windows.Forms.CheckBox o6;
        private System.Windows.Forms.CheckBox o4;
        private System.Windows.Forms.CheckBox o5;
        private System.Windows.Forms.CheckBox o2;
        private System.Windows.Forms.CheckBox o1;
        private System.Windows.Forms.CheckBox o3;
        private System.Windows.Forms.CheckBox o12;
    }
}