namespace kvn
{
    partial class Provider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Provider));
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.listViewProvider = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MiddleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelSurName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxSurName = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(83)))), ((int)(((byte)(243)))));
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("BankGothic RUSS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(450, 340);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(202, 44);
            this.buttonEdit.TabIndex = 129;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(83)))), ((int)(((byte)(243)))));
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("BankGothic RUSS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(242, 340);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(202, 44);
            this.buttonAdd.TabIndex = 128;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(83)))), ((int)(((byte)(243)))));
            this.buttonDel.FlatAppearance.BorderSize = 0;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("BankGothic RUSS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.ForeColor = System.Drawing.Color.White;
            this.buttonDel.Location = new System.Drawing.Point(658, 340);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(202, 44);
            this.buttonDel.TabIndex = 127;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::kvn.Properties.Resources.ЛОГО_Кванториум_Цветной;
            this.pictureBox1.Location = new System.Drawing.Point(75, 265);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 125;
            this.pictureBox1.TabStop = false;
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.BackColor = System.Drawing.Color.Transparent;
            this.labelCost.Font = new System.Drawing.Font("Ropa Sans SC PTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCost.Location = new System.Drawing.Point(74, 204);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(151, 25);
            this.labelCost.TabIndex = 121;
            this.labelCost.Text = "Стоимость услуги";
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.BackColor = System.Drawing.Color.Transparent;
            this.labelMiddleName.Font = new System.Drawing.Font("Ropa Sans SC PTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMiddleName.Location = new System.Drawing.Point(76, 145);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(85, 25);
            this.labelMiddleName.TabIndex = 120;
            this.labelMiddleName.Text = "Отчество";
            // 
            // textBoxCost
            // 
            this.textBoxCost.Font = new System.Drawing.Font("BankGothic RUSS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCost.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxCost.Location = new System.Drawing.Point(77, 232);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(160, 27);
            this.textBoxCost.TabIndex = 119;
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxMiddleName.Font = new System.Drawing.Font("BankGothic RUSS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMiddleName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxMiddleName.Location = new System.Drawing.Point(77, 173);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(160, 27);
            this.textBoxMiddleName.TabIndex = 118;
            // 
            // listViewProvider
            // 
            this.listViewProvider.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listViewProvider.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.LastName,
            this.FirstName,
            this.MiddleName,
            this.Cost});
            this.listViewProvider.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewProvider.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.listViewProvider.FullRowSelect = true;
            this.listViewProvider.GridLines = true;
            this.listViewProvider.HideSelection = false;
            this.listViewProvider.Location = new System.Drawing.Point(247, 25);
            this.listViewProvider.MultiSelect = false;
            this.listViewProvider.Name = "listViewProvider";
            this.listViewProvider.Size = new System.Drawing.Size(618, 309);
            this.listViewProvider.TabIndex = 117;
            this.listViewProvider.UseCompatibleStateImageBehavior = false;
            this.listViewProvider.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 29;
            // 
            // LastName
            // 
            this.LastName.Text = "Фамилия";
            this.LastName.Width = 128;
            // 
            // FirstName
            // 
            this.FirstName.Text = "Имя";
            this.FirstName.Width = 115;
            // 
            // MiddleName
            // 
            this.MiddleName.Text = "Отчество";
            this.MiddleName.Width = 166;
            // 
            // Cost
            // 
            this.Cost.Text = "Стоимость услуги";
            this.Cost.Width = 174;
            // 
            // labelSurName
            // 
            this.labelSurName.AutoSize = true;
            this.labelSurName.BackColor = System.Drawing.Color.Transparent;
            this.labelSurName.Font = new System.Drawing.Font("Ropa Sans SC PTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurName.Location = new System.Drawing.Point(76, 25);
            this.labelSurName.Name = "labelSurName";
            this.labelSurName.Size = new System.Drawing.Size(86, 25);
            this.labelSurName.TabIndex = 116;
            this.labelSurName.Text = "Фамилия";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Ropa Sans SC PTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(74, 87);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 25);
            this.labelName.TabIndex = 115;
            this.labelName.Text = "Имя";
            // 
            // textBoxSurName
            // 
            this.textBoxSurName.Font = new System.Drawing.Font("BankGothic RUSS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSurName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxSurName.Location = new System.Drawing.Point(77, 53);
            this.textBoxSurName.Name = "textBoxSurName";
            this.textBoxSurName.Size = new System.Drawing.Size(160, 27);
            this.textBoxSurName.TabIndex = 114;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("BankGothic RUSS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxName.Location = new System.Drawing.Point(77, 115);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(160, 27);
            this.textBoxName.TabIndex = 113;
            // 
            // Provider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kvn.Properties.Resources.BG_for_IS;
            this.ClientSize = new System.Drawing.Size(953, 402);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.listViewProvider);
            this.Controls.Add(this.labelSurName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxSurName);
            this.Controls.Add(this.textBoxName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Provider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поставщики";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.ListView listViewProvider;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader MiddleName;
        private System.Windows.Forms.ColumnHeader Cost;
        private System.Windows.Forms.Label labelSurName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxSurName;
        private System.Windows.Forms.TextBox textBoxName;
    }
}