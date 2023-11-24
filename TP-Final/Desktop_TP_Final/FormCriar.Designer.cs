
namespace Desktop_TP_Final
{
    partial class FormCriar
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
            this.nome_txt = new System.Windows.Forms.TextBox();
            this.senha_txt = new System.Windows.Forms.TextBox();
            this.status_cb = new System.Windows.Forms.CheckBox();
            this.criar_btn = new System.Windows.Forms.Button();
            this.nome_lbl = new System.Windows.Forms.Label();
            this.senha_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nome_txt
            // 
            this.nome_txt.Location = new System.Drawing.Point(71, 14);
            this.nome_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nome_txt.Name = "nome_txt";
            this.nome_txt.Size = new System.Drawing.Size(220, 22);
            this.nome_txt.TabIndex = 0;
            // 
            // senha_txt
            // 
            this.senha_txt.Location = new System.Drawing.Point(71, 63);
            this.senha_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.senha_txt.Name = "senha_txt";
            this.senha_txt.Size = new System.Drawing.Size(220, 22);
            this.senha_txt.TabIndex = 1;
            this.senha_txt.UseSystemPasswordChar = true;
            // 
            // status_cb
            // 
            this.status_cb.AutoSize = true;
            this.status_cb.Location = new System.Drawing.Point(71, 111);
            this.status_cb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.status_cb.Name = "status_cb";
            this.status_cb.Size = new System.Drawing.Size(70, 21);
            this.status_cb.TabIndex = 2;
            this.status_cb.Text = "Status";
            this.status_cb.UseVisualStyleBackColor = true;
            // 
            // criar_btn
            // 
            this.criar_btn.Location = new System.Drawing.Point(101, 162);
            this.criar_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.criar_btn.Name = "criar_btn";
            this.criar_btn.Size = new System.Drawing.Size(100, 28);
            this.criar_btn.TabIndex = 3;
            this.criar_btn.Text = "Criar Usuario";
            this.criar_btn.UseVisualStyleBackColor = true;
            this.criar_btn.Click += new System.EventHandler(this.criar_btn_Click);
            // 
            // nome_lbl
            // 
            this.nome_lbl.AutoSize = true;
            this.nome_lbl.Location = new System.Drawing.Point(16, 17);
            this.nome_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nome_lbl.Name = "nome_lbl";
            this.nome_lbl.Size = new System.Drawing.Size(45, 17);
            this.nome_lbl.TabIndex = 4;
            this.nome_lbl.Text = "Nome";
            // 
            // senha_lbl
            // 
            this.senha_lbl.AutoSize = true;
            this.senha_lbl.Location = new System.Drawing.Point(16, 66);
            this.senha_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.senha_lbl.Name = "senha_lbl";
            this.senha_lbl.Size = new System.Drawing.Size(49, 17);
            this.senha_lbl.TabIndex = 5;
            this.senha_lbl.Text = "Senha";
            // 
            // FormCriar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 206);
            this.Controls.Add(this.senha_lbl);
            this.Controls.Add(this.nome_lbl);
            this.Controls.Add(this.criar_btn);
            this.Controls.Add(this.status_cb);
            this.Controls.Add(this.senha_txt);
            this.Controls.Add(this.nome_txt);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormCriar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nome_txt;
        private System.Windows.Forms.TextBox senha_txt;
        private System.Windows.Forms.CheckBox status_cb;
        private System.Windows.Forms.Button criar_btn;
        private System.Windows.Forms.Label nome_lbl;
        private System.Windows.Forms.Label senha_lbl;
    }
}