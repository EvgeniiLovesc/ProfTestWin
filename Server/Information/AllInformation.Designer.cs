
namespace NK_TEST.Users
{
    partial class AllInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllInformation));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbSetDate = new System.Windows.Forms.ComboBox();
            this.dgvTests = new System.Windows.Forms.DataGridView();
            this.cb_selected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnReceiver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTests)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Показать новости за";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(930, 521);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 30);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Добавить сообщение";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTests);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1048, 405);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Список новостей";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSetDate);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(11, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1049, 78);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтр";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Показать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cbSetDate
            // 
            this.cbSetDate.FormattingEnabled = true;
            this.cbSetDate.Location = new System.Drawing.Point(169, 30);
            this.cbSetDate.Name = "cbSetDate";
            this.cbSetDate.Size = new System.Drawing.Size(179, 24);
            this.cbSetDate.TabIndex = 17;
            // 
            // dgvTests
            // 
            this.dgvTests.AllowUserToAddRows = false;
            this.dgvTests.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cb_selected,
            this.dgvColumnDate,
            this.dgvColumnReceiver,
            this.dgvColumnHeader,
            this.dgvColumnDescription});
            this.dgvTests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTests.Location = new System.Drawing.Point(3, 18);
            this.dgvTests.Name = "dgvTests";
            this.dgvTests.Size = new System.Drawing.Size(1042, 384);
            this.dgvTests.TabIndex = 2;
            // 
            // cb_selected
            // 
            this.cb_selected.HeaderText = "";
            this.cb_selected.Name = "cb_selected";
            this.cb_selected.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cb_selected.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cb_selected.Width = 25;
            // 
            // dgvColumnDate
            // 
            this.dgvColumnDate.HeaderText = "Дата";
            this.dgvColumnDate.Name = "dgvColumnDate";
            // 
            // dgvColumnReceiver
            // 
            this.dgvColumnReceiver.HeaderText = "Получатели";
            this.dgvColumnReceiver.Name = "dgvColumnReceiver";
            this.dgvColumnReceiver.Width = 200;
            // 
            // dgvColumnHeader
            // 
            this.dgvColumnHeader.HeaderText = "Заголовок";
            this.dgvColumnHeader.Name = "dgvColumnHeader";
            this.dgvColumnHeader.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvColumnHeader.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvColumnHeader.Width = 150;
            // 
            // dgvColumnDescription
            // 
            this.dgvColumnDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvColumnDescription.HeaderText = "Описание";
            this.dgvColumnDescription.Name = "dgvColumnDescription";
            // 
            // AllInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 563);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AllInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация";
            this.Load += new System.EventHandler(this.UserTypes_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbSetDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvTests;
        private System.Windows.Forms.DataGridViewTextBoxColumn cb_selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnReceiver;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnDescription;
    }
}