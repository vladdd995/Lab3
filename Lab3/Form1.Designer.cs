
namespace Lab3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.clean = new System.Windows.Forms.Button();
            this.XOR = new System.Windows.Forms.Button();
            this.groupBox_OUT = new System.Windows.Forms.GroupBox();
            this.P_decrypt = new System.Windows.Forms.TextBox();
            this.Key_decrypt = new System.Windows.Forms.TextBox();
            this.decrypt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox_IN = new System.Windows.Forms.GroupBox();
            this.P_encrypt = new System.Windows.Forms.TextBox();
            this.K_encrypt = new System.Windows.Forms.TextBox();
            this.encrypt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox_OUT.SuspendLayout();
            this.groupBox_IN.SuspendLayout();
            this.SuspendLayout();
            // 
            // clean
            // 
            this.clean.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clean.Location = new System.Drawing.Point(319, 232);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(104, 69);
            this.clean.TabIndex = 7;
            this.clean.Text = "Очистити";
            this.clean.UseVisualStyleBackColor = true;
            this.clean.Click += new System.EventHandler(this.clean_Click);
            // 
            // XOR
            // 
            this.XOR.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XOR.Location = new System.Drawing.Point(198, 232);
            this.XOR.Name = "XOR";
            this.XOR.Size = new System.Drawing.Size(104, 69);
            this.XOR.TabIndex = 6;
            this.XOR.Text = "XOR";
            this.XOR.UseVisualStyleBackColor = true;
            this.XOR.Click += new System.EventHandler(this.XOR_Click);
            // 
            // groupBox_OUT
            // 
            this.groupBox_OUT.Controls.Add(this.P_decrypt);
            this.groupBox_OUT.Controls.Add(this.Key_decrypt);
            this.groupBox_OUT.Controls.Add(this.decrypt);
            this.groupBox_OUT.Controls.Add(this.label4);
            this.groupBox_OUT.Controls.Add(this.label5);
            this.groupBox_OUT.Controls.Add(this.label6);
            this.groupBox_OUT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_OUT.Location = new System.Drawing.Point(319, 12);
            this.groupBox_OUT.Name = "groupBox_OUT";
            this.groupBox_OUT.Size = new System.Drawing.Size(286, 214);
            this.groupBox_OUT.TabIndex = 5;
            this.groupBox_OUT.TabStop = false;
            this.groupBox_OUT.Text = "Розшифрувати";
            // 
            // P_decrypt
            // 
            this.P_decrypt.Location = new System.Drawing.Point(91, 37);
            this.P_decrypt.Name = "P_decrypt";
            this.P_decrypt.Size = new System.Drawing.Size(171, 26);
            this.P_decrypt.TabIndex = 6;
            // 
            // Key_decrypt
            // 
            this.Key_decrypt.Location = new System.Drawing.Point(91, 96);
            this.Key_decrypt.Name = "Key_decrypt";
            this.Key_decrypt.Size = new System.Drawing.Size(171, 26);
            this.Key_decrypt.TabIndex = 7;
            // 
            // decrypt
            // 
            this.decrypt.Location = new System.Drawing.Point(91, 161);
            this.decrypt.Name = "decrypt";
            this.decrypt.ReadOnly = true;
            this.decrypt.Size = new System.Drawing.Size(171, 26);
            this.decrypt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(27, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = " P =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(24, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = " Key =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(24, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = " C = ";
            // 
            // groupBox_IN
            // 
            this.groupBox_IN.Controls.Add(this.P_encrypt);
            this.groupBox_IN.Controls.Add(this.K_encrypt);
            this.groupBox_IN.Controls.Add(this.encrypt);
            this.groupBox_IN.Controls.Add(this.label1);
            this.groupBox_IN.Controls.Add(this.label2);
            this.groupBox_IN.Controls.Add(this.label3);
            this.groupBox_IN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_IN.Location = new System.Drawing.Point(12, 12);
            this.groupBox_IN.Name = "groupBox_IN";
            this.groupBox_IN.Size = new System.Drawing.Size(290, 214);
            this.groupBox_IN.TabIndex = 4;
            this.groupBox_IN.TabStop = false;
            this.groupBox_IN.Text = "Зашифрувати";
            // 
            // P_encrypt
            // 
            this.P_encrypt.Location = new System.Drawing.Point(94, 35);
            this.P_encrypt.Name = "P_encrypt";
            this.P_encrypt.Size = new System.Drawing.Size(171, 26);
            this.P_encrypt.TabIndex = 6;
            // 
            // K_encrypt
            // 
            this.K_encrypt.Location = new System.Drawing.Point(94, 96);
            this.K_encrypt.Name = "K_encrypt";
            this.K_encrypt.Size = new System.Drawing.Size(171, 26);
            this.K_encrypt.TabIndex = 7;
            // 
            // encrypt
            // 
            this.encrypt.Location = new System.Drawing.Point(94, 160);
            this.encrypt.Name = "encrypt";
            this.encrypt.ReadOnly = true;
            this.encrypt.Size = new System.Drawing.Size(171, 26);
            this.encrypt.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(48, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "P = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(27, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Key = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(43, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "C = ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 316);
            this.Controls.Add(this.clean);
            this.Controls.Add(this.XOR);
            this.Controls.Add(this.groupBox_OUT);
            this.Controls.Add(this.groupBox_IN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(650, 355);
            this.MinimumSize = new System.Drawing.Size(650, 355);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Шифратор/Дешифратор Тексту";
            this.groupBox_OUT.ResumeLayout(false);
            this.groupBox_OUT.PerformLayout();
            this.groupBox_IN.ResumeLayout(false);
            this.groupBox_IN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clean;
        private System.Windows.Forms.Button XOR;
        private System.Windows.Forms.GroupBox groupBox_OUT;
        private System.Windows.Forms.TextBox P_decrypt;
        private System.Windows.Forms.TextBox Key_decrypt;
        private System.Windows.Forms.TextBox decrypt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox_IN;
        private System.Windows.Forms.TextBox P_encrypt;
        private System.Windows.Forms.TextBox K_encrypt;
        private System.Windows.Forms.TextBox encrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

