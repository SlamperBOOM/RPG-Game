namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbMain = new System.Windows.Forms.Label();
            this.btstart = new System.Windows.Forms.Button();
            this.btload = new System.Windows.Forms.Button();
            this.btexit = new System.Windows.Forms.Button();
            this.tbname = new System.Windows.Forms.TextBox();
            this.btstart1 = new System.Windows.Forms.Button();
            this.lbname = new System.Windows.Forms.Label();
            this.btback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMain
            // 
            this.lbMain.AutoSize = true;
            this.lbMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMain.Location = new System.Drawing.Point(41, 9);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(196, 39);
            this.lbMain.TabIndex = 0;
            this.lbMain.Text = "RPG game";
            this.lbMain.Click += new System.EventHandler(this.lbMain_Click);
            // 
            // btstart
            // 
            this.btstart.Location = new System.Drawing.Point(83, 119);
            this.btstart.Name = "btstart";
            this.btstart.Size = new System.Drawing.Size(118, 23);
            this.btstart.TabIndex = 1;
            this.btstart.Text = "Начать игру";
            this.btstart.UseVisualStyleBackColor = true;
            this.btstart.Click += new System.EventHandler(this.btstart_Click);
            // 
            // btload
            // 
            this.btload.Location = new System.Drawing.Point(83, 148);
            this.btload.Name = "btload";
            this.btload.Size = new System.Drawing.Size(118, 23);
            this.btload.TabIndex = 2;
            this.btload.Text = "Загрузить игру";
            this.btload.UseVisualStyleBackColor = true;
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(83, 177);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(118, 23);
            this.btexit.TabIndex = 3;
            this.btexit.Text = "Выйти";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(83, 119);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(118, 20);
            this.tbname.TabIndex = 4;
            this.tbname.Visible = false;
            // 
            // btstart1
            // 
            this.btstart1.Location = new System.Drawing.Point(83, 148);
            this.btstart1.Name = "btstart1";
            this.btstart1.Size = new System.Drawing.Size(118, 23);
            this.btstart1.TabIndex = 5;
            this.btstart1.Text = "Начать игру";
            this.btstart1.UseVisualStyleBackColor = true;
            this.btstart1.Visible = false;
            this.btstart1.Click += new System.EventHandler(this.btstart1_Click);
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbname.Location = new System.Drawing.Point(45, 89);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(198, 18);
            this.lbname.TabIndex = 6;
            this.lbname.Text = "Введите имя персонажа";
            this.lbname.Visible = false;
            // 
            // btback
            // 
            this.btback.Location = new System.Drawing.Point(83, 178);
            this.btback.Name = "btback";
            this.btback.Size = new System.Drawing.Size(118, 23);
            this.btback.TabIndex = 7;
            this.btback.Text = "Назад";
            this.btback.UseVisualStyleBackColor = true;
            this.btback.Visible = false;
            this.btback.Click += new System.EventHandler(this.btback_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 349);
            this.Controls.Add(this.btback);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.btstart1);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btload);
            this.Controls.Add(this.btstart);
            this.Controls.Add(this.lbMain);
            this.Name = "Form1";
            this.Text = "RPG Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMain;
        private System.Windows.Forms.Button btstart;
        private System.Windows.Forms.Button btload;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Button btstart1;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Button btback;

    }
}

