
namespace Autoserv
{
    partial class AddClientForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.DelTag = new System.Windows.Forms.Button();
            this.CmbTags = new System.Windows.Forms.ComboBox();
            this.AddTag = new System.Windows.Forms.Button();
            this.TagsTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.AddPhoto = new System.Windows.Forms.Button();
            this.CmbGender = new System.Windows.Forms.ComboBox();
            this.TxtDate = new System.Windows.Forms.DateTimePicker();
            this.TxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.PhoneLab = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EmailLab = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.MiddleLab = new System.Windows.Forms.Label();
            this.TxtMiddle = new System.Windows.Forms.TextBox();
            this.LastNameLab = new System.Windows.Forms.Label();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.MainText = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TagsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.BottomPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Controls.Add(this.DelTag);
            this.MainPanel.Controls.Add(this.CmbTags);
            this.MainPanel.Controls.Add(this.AddTag);
            this.MainPanel.Controls.Add(this.TagsTable);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.AddPhoto);
            this.MainPanel.Controls.Add(this.CmbGender);
            this.MainPanel.Controls.Add(this.TxtDate);
            this.MainPanel.Controls.Add(this.TxtPhone);
            this.MainPanel.Controls.Add(this.ImageBox);
            this.MainPanel.Controls.Add(this.PhoneLab);
            this.MainPanel.Controls.Add(this.label6);
            this.MainPanel.Controls.Add(this.label5);
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Controls.Add(this.EmailLab);
            this.MainPanel.Controls.Add(this.TxtEmail);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.TxtName);
            this.MainPanel.Controls.Add(this.MiddleLab);
            this.MainPanel.Controls.Add(this.TxtMiddle);
            this.MainPanel.Controls.Add(this.LastNameLab);
            this.MainPanel.Controls.Add(this.TxtLastName);
            this.MainPanel.Controls.Add(this.BottomPanel);
            this.MainPanel.Controls.Add(this.TopPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(584, 561);
            this.MainPanel.TabIndex = 1;
            // 
            // DelTag
            // 
            this.DelTag.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelTag.Location = new System.Drawing.Point(462, 472);
            this.DelTag.Name = "DelTag";
            this.DelTag.Size = new System.Drawing.Size(110, 32);
            this.DelTag.TabIndex = 43;
            this.DelTag.Text = "Удалить";
            this.DelTag.UseVisualStyleBackColor = true;
            this.DelTag.Click += new System.EventHandler(this.DelTag_Click);
            // 
            // CmbTags
            // 
            this.CmbTags.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTags.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CmbTags.FormattingEnabled = true;
            this.CmbTags.Location = new System.Drawing.Point(332, 436);
            this.CmbTags.Name = "CmbTags";
            this.CmbTags.Size = new System.Drawing.Size(240, 31);
            this.CmbTags.TabIndex = 42;
            // 
            // AddTag
            // 
            this.AddTag.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddTag.Location = new System.Drawing.Point(332, 472);
            this.AddTag.Name = "AddTag";
            this.AddTag.Size = new System.Drawing.Size(110, 32);
            this.AddTag.TabIndex = 41;
            this.AddTag.Text = "Добавить";
            this.AddTag.UseVisualStyleBackColor = true;
            this.AddTag.Click += new System.EventHandler(this.AddTag_Click);
            // 
            // TagsTable
            // 
            this.TagsTable.AllowUserToAddRows = false;
            this.TagsTable.AllowUserToDeleteRows = false;
            this.TagsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TagsTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TagsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TagsTable.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TagsTable.Location = new System.Drawing.Point(332, 305);
            this.TagsTable.Name = "TagsTable";
            this.TagsTable.ReadOnly = true;
            this.TagsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TagsTable.Size = new System.Drawing.Size(240, 124);
            this.TagsTable.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(332, 280);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 16, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 22);
            this.label1.TabIndex = 39;
            this.label1.Text = "Теги:";
            // 
            // AddPhoto
            // 
            this.AddPhoto.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddPhoto.Location = new System.Drawing.Point(332, 229);
            this.AddPhoto.Name = "AddPhoto";
            this.AddPhoto.Size = new System.Drawing.Size(240, 32);
            this.AddPhoto.TabIndex = 38;
            this.AddPhoto.Text = "Добавить фото";
            this.AddPhoto.UseVisualStyleBackColor = true;
            this.AddPhoto.Click += new System.EventHandler(this.AddPhoto_Click);
            // 
            // CmbGender
            // 
            this.CmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbGender.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CmbGender.FormattingEnabled = true;
            this.CmbGender.Location = new System.Drawing.Point(12, 473);
            this.CmbGender.Name = "CmbGender";
            this.CmbGender.Size = new System.Drawing.Size(240, 31);
            this.CmbGender.TabIndex = 36;
            // 
            // TxtDate
            // 
            this.TxtDate.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtDate.Location = new System.Drawing.Point(12, 408);
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.Size = new System.Drawing.Size(240, 31);
            this.TxtDate.TabIndex = 35;
            // 
            // TxtPhone
            // 
            this.TxtPhone.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtPhone.Location = new System.Drawing.Point(12, 343);
            this.TxtPhone.Mask = "+9(999)999-99-99 ";
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(240, 31);
            this.TxtPhone.TabIndex = 34;
            this.TxtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ImageBox
            // 
            this.ImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImageBox.Location = new System.Drawing.Point(332, 83);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(240, 140);
            this.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageBox.TabIndex = 33;
            this.ImageBox.TabStop = false;
            // 
            // PhoneLab
            // 
            this.PhoneLab.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneLab.Location = new System.Drawing.Point(12, 318);
            this.PhoneLab.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.PhoneLab.Name = "PhoneLab";
            this.PhoneLab.Size = new System.Drawing.Size(240, 22);
            this.PhoneLab.TabIndex = 32;
            this.PhoneLab.Text = "Телефон:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(332, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 22);
            this.label6.TabIndex = 30;
            this.label6.Text = "Фотография";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 448);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 22);
            this.label5.TabIndex = 28;
            this.label5.Text = "Пол:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 383);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 22);
            this.label4.TabIndex = 26;
            this.label4.Text = "Дата рождения:";
            // 
            // EmailLab
            // 
            this.EmailLab.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailLab.Location = new System.Drawing.Point(12, 253);
            this.EmailLab.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.EmailLab.Name = "EmailLab";
            this.EmailLab.Size = new System.Drawing.Size(240, 22);
            this.EmailLab.TabIndex = 24;
            this.EmailLab.Text = "Email:";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtEmail.Location = new System.Drawing.Point(12, 278);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(240, 31);
            this.TxtEmail.TabIndex = 23;
            this.TxtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "Имя:";
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtName.Location = new System.Drawing.Point(12, 148);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(240, 31);
            this.TxtName.TabIndex = 21;
            this.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MiddleLab
            // 
            this.MiddleLab.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MiddleLab.Location = new System.Drawing.Point(12, 188);
            this.MiddleLab.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.MiddleLab.Name = "MiddleLab";
            this.MiddleLab.Size = new System.Drawing.Size(240, 22);
            this.MiddleLab.TabIndex = 20;
            this.MiddleLab.Text = "Отчество:";
            // 
            // TxtMiddle
            // 
            this.TxtMiddle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtMiddle.Location = new System.Drawing.Point(12, 213);
            this.TxtMiddle.Name = "TxtMiddle";
            this.TxtMiddle.Size = new System.Drawing.Size(240, 31);
            this.TxtMiddle.TabIndex = 19;
            this.TxtMiddle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LastNameLab
            // 
            this.LastNameLab.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNameLab.Location = new System.Drawing.Point(12, 58);
            this.LastNameLab.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.LastNameLab.Name = "LastNameLab";
            this.LastNameLab.Size = new System.Drawing.Size(240, 22);
            this.LastNameLab.TabIndex = 18;
            this.LastNameLab.Text = "Фамилия:";
            // 
            // TxtLastName
            // 
            this.TxtLastName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtLastName.Location = new System.Drawing.Point(12, 83);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(240, 31);
            this.TxtLastName.TabIndex = 17;
            this.TxtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.BottomPanel.Controls.Add(this.BtnAdd);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 511);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(584, 50);
            this.BottomPanel.TabIndex = 1;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.White;
            this.BtnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnAdd.FlatAppearance.BorderSize = 2;
            this.BtnAdd.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAdd.Location = new System.Drawing.Point(174, 6);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(237, 38);
            this.BtnAdd.TabIndex = 37;
            this.BtnAdd.Text = "Добавить клиента";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.TopPanel.Controls.Add(this.BtnExit);
            this.TopPanel.Controls.Add(this.MainText);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(584, 50);
            this.TopPanel.TabIndex = 0;
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.White;
            this.BtnExit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnExit.Location = new System.Drawing.Point(472, 9);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(100, 32);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "Закрыть";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // MainText
            // 
            this.MainText.AutoSize = true;
            this.MainText.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainText.Location = new System.Drawing.Point(179, 14);
            this.MainText.Name = "MainText";
            this.MainText.Size = new System.Drawing.Size(226, 23);
            this.MainText.TabIndex = 0;
            this.MainText.Text = "Добавить данные клиента";
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.ControlBox = false;
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddClientForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление клиента";
            this.Load += new System.EventHandler(this.AddClientForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TagsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.BottomPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label MainText;
        private System.Windows.Forms.Label LastNameLab;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.Label PhoneLab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label EmailLab;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label MiddleLab;
        private System.Windows.Forms.TextBox TxtMiddle;
        private System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.MaskedTextBox TxtPhone;
        private System.Windows.Forms.ComboBox CmbGender;
        private System.Windows.Forms.DateTimePicker TxtDate;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button AddPhoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DelTag;
        private System.Windows.Forms.ComboBox CmbTags;
        private System.Windows.Forms.Button AddTag;
        private System.Windows.Forms.DataGridView TagsTable;
    }
}