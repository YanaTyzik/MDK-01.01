namespace Бандинчетотам
{
    partial class EditUsers
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
            this.EditName = new System.Windows.Forms.TextBox();
            this.EditSurname = new System.Windows.Forms.TextBox();
            this.EditDateBirth = new System.Windows.Forms.DateTimePicker();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonOtmena = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EditName
            // 
            this.EditName.Location = new System.Drawing.Point(42, 27);
            this.EditName.Name = "EditName";
            this.EditName.Size = new System.Drawing.Size(177, 20);
            this.EditName.TabIndex = 0;
            // 
            // EditSurname
            // 
            this.EditSurname.Location = new System.Drawing.Point(42, 81);
            this.EditSurname.Name = "EditSurname";
            this.EditSurname.Size = new System.Drawing.Size(177, 20);
            this.EditSurname.TabIndex = 1;
            this.EditSurname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // EditDateBirth
            // 
            this.EditDateBirth.Location = new System.Drawing.Point(42, 132);
            this.EditDateBirth.Name = "EditDateBirth";
            this.EditDateBirth.Size = new System.Drawing.Size(177, 20);
            this.EditDateBirth.TabIndex = 2;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(42, 209);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonOtmena
            // 
            this.buttonOtmena.Location = new System.Drawing.Point(144, 209);
            this.buttonOtmena.Name = "buttonOtmena";
            this.buttonOtmena.Size = new System.Drawing.Size(75, 23);
            this.buttonOtmena.TabIndex = 4;
            this.buttonOtmena.Text = "Отмена";
            this.buttonOtmena.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "DateBirth";
            // 
            // EditUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 256);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOtmena);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.EditDateBirth);
            this.Controls.Add(this.EditSurname);
            this.Controls.Add(this.EditName);
            this.Name = "EditUsers";
            this.Text = "EditUsers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EditName;
        private System.Windows.Forms.TextBox EditSurname;
        private System.Windows.Forms.DateTimePicker EditDateBirth;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonOtmena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}