namespace kvn
{
    partial class Extradition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Extradition));
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelQuant = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.textBoxQuant = new System.Windows.Forms.TextBox();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.listViewProvider = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MiddleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelMaterial = new System.Windows.Forms.Label();
            this.labelAgent = new System.Windows.Forms.Label();
            this.textBoxMaterial = new System.Windows.Forms.TextBox();
            this.textBoxAgent = new System.Windows.Forms.TextBox();
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
            this.buttonEdit.Location = new System.Drawing.Point(457, 337);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(202, 44);
            this.buttonEdit.TabIndex = 142;
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
            this.buttonAdd.Location = new System.Drawing.Point(249, 337);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(202, 44);
            this.buttonAdd.TabIndex = 141;
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
            this.buttonDel.Location = new System.Drawing.Point(665, 337);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(202, 44);
            this.buttonDel.TabIndex = 140;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::kvn.Properties.Resources.ЛОГО_Кванториум_Цветной;
            this.pictureBox1.Location = new System.Drawing.Point(82, 262);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 139;
            this.pictureBox1.TabStop = false;
            // 
            // labelQuant
            // 
            this.labelQuant.AutoSize = true;
            this.labelQuant.BackColor = System.Drawing.Color.Transparent;
            this.labelQuant.Font = new System.Drawing.Font("Ropa Sans SC PTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuant.Location = new System.Drawing.Point(81, 201);
            this.labelQuant.Name = "labelQuant";
            this.labelQuant.Size = new System.Drawing.Size(104, 25);
            this.labelQuant.TabIndex = 138;
            this.labelQuant.Text = "Количество";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Ropa Sans SC PTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.Location = new System.Drawing.Point(83, 142);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(109, 25);
            this.labelDate.TabIndex = 137;
            this.labelDate.Text = "Дата выдачи";
            // 
            // textBoxQuant
            // 
            this.textBoxQuant.Font = new System.Drawing.Font("BankGothic RUSS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxQuant.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxQuant.Location = new System.Drawing.Point(84, 229);
            this.textBoxQuant.Name = "textBoxQuant";
            this.textBoxQuant.Size = new System.Drawing.Size(160, 27);
            this.textBoxQuant.TabIndex = 136;
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxMiddleName.Font = new System.Drawing.Font("BankGothic RUSS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMiddleName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxMiddleName.Location = new System.Drawing.Point(84, 170);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(160, 27);
            this.textBoxMiddleName.TabIndex = 135;
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
            this.listViewProvider.Location = new System.Drawing.Point(254, 22);
            this.listViewProvider.MultiSelect = false;
            this.listViewProvider.Name = "listViewProvider";
            this.listViewProvider.Size = new System.Drawing.Size(618, 309);
            this.listViewProvider.TabIndex = 134;
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
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.BackColor = System.Drawing.Color.Transparent;
            this.labelMaterial.Font = new System.Drawing.Font("Ropa Sans SC PTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaterial.Location = new System.Drawing.Point(83, 22);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(57, 25);
            this.labelMaterial.TabIndex = 133;
            this.labelMaterial.Text = "Товар";
            // 
            // labelAgent
            // 
            this.labelAgent.AutoSize = true;
            this.labelAgent.BackColor = System.Drawing.Color.Transparent;
            this.labelAgent.Font = new System.Drawing.Font("Ropa Sans SC PTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAgent.Location = new System.Drawing.Point(81, 84);
            this.labelAgent.Name = "labelAgent";
            this.labelAgent.Size = new System.Drawing.Size(94, 25);
            this.labelAgent.TabIndex = 132;
            this.labelAgent.Text = "Сотрудник";
            // 
            // textBoxMaterial
            // 
            this.textBoxMaterial.Font = new System.Drawing.Font("BankGothic RUSS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMaterial.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxMaterial.Location = new System.Drawing.Point(84, 50);
            this.textBoxMaterial.Name = "textBoxMaterial";
            this.textBoxMaterial.Size = new System.Drawing.Size(160, 27);
            this.textBoxMaterial.TabIndex = 131;
            // 
            // textBoxAgent
            // 
            this.textBoxAgent.Font = new System.Drawing.Font("BankGothic RUSS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAgent.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxAgent.Location = new System.Drawing.Point(84, 112);
            this.textBoxAgent.Name = "textBoxAgent";
            this.textBoxAgent.Size = new System.Drawing.Size(160, 27);
            this.textBoxAgent.TabIndex = 130;
            // 
            // Extradition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kvn.Properties.Resources.BG_for_IS;
            this.ClientSize = new System.Drawing.Size(953, 402);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelQuant);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.textBoxQuant);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.listViewProvider);
            this.Controls.Add(this.labelMaterial);
            this.Controls.Add(this.labelAgent);
            this.Controls.Add(this.textBoxMaterial);
            this.Controls.Add(this.textBoxAgent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Extradition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выдача материалов и оборудования";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelQuant;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textBoxQuant;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.ListView listViewProvider;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader MiddleName;
        private System.Windows.Forms.ColumnHeader Cost;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.Label labelAgent;
        private System.Windows.Forms.TextBox textBoxMaterial;
        private System.Windows.Forms.TextBox textBoxAgent;
    }
}