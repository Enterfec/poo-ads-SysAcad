namespace SysAcadApp
{
    partial class EntryPoint
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
            this.btnGenAluno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenAluno
            // 
            this.btnGenAluno.Location = new System.Drawing.Point(13, 13);
            this.btnGenAluno.Name = "btnGenAluno";
            this.btnGenAluno.Size = new System.Drawing.Size(116, 37);
            this.btnGenAluno.TabIndex = 0;
            this.btnGenAluno.Text = "Gestão de Aluno";
            this.btnGenAluno.UseVisualStyleBackColor = true;
            this.btnGenAluno.Click += new System.EventHandler(this.btnGenAluno_Click);
            // 
            // EntryPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 357);
            this.Controls.Add(this.btnGenAluno);
            this.Name = "EntryPoint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SysAcad";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenAluno;
    }
}

