
namespace Desktop_TP_Final
{
    partial class FormEdit
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
            this.editar_ok_btn = new System.Windows.Forms.Button();
            this.status_cb = new System.Windows.Forms.CheckBox();
            this.senha_txt = new System.Windows.Forms.TextBox();
            this.nome_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // editar_ok_btn
            // 
            this.editar_ok_btn.Location = new System.Drawing.Point(101, 162);
            this.editar_ok_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editar_ok_btn.Name = "editar_ok_btn";
            this.editar_ok_btn.Size = new System.Drawing.Size(115, 28);
            this.editar_ok_btn.TabIndex = 12;
            this.editar_ok_btn.Text = "Editar";
            this.editar_ok_btn.UseVisualStyleBackColor = true;
            this.editar_ok_btn.Click += new System.EventHandler(this.editar_ok_btn_Click);
            // 
            // status_cb
            // 
            this.status_cb.AutoSize = true;
            this.status_cb.Location = new System.Drawing.Point(71, 111);
            this.status_cb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.status_cb.Name = "status_cb";
            this.status_cb.Size = new System.Drawing.Size(70, 21);
            this.status_cb.TabIndex = 11;
            this.status_cb.Text = "Status";
            this.status_cb.UseVisualStyleBackColor = true;
            // 
            // senha_txt
            // 
            this.senha_txt.Location = new System.Drawing.Point(71, 63);
            this.senha_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.senha_txt.Name = "senha_txt";
            this.senha_txt.Size = new System.Drawing.Size(220, 22);
            this.senha_txt.TabIndex = 10;
            this.senha_txt.UseSystemPasswordChar = true;
            // 
            // nome_txt
            // 
            this.nome_txt.Location = new System.Drawing.Point(71, 14);
            this.nome_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nome_txt.Name = "nome_txt";
            this.nome_txt.Size = new System.Drawing.Size(220, 22);
            this.nome_txt.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Senha";
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 206);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editar_ok_btn);
            this.Controls.Add(this.status_cb);
            this.Controls.Add(this.senha_txt);
            this.Controls.Add(this.nome_txt);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editar_ok_btn;
        private System.Windows.Forms.CheckBox status_cb;
        private System.Windows.Forms.TextBox senha_txt;
        private System.Windows.Forms.TextBox nome_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}