namespace Atividade_Senai
{
    partial class frmTelaPrincipal
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 125);
            this.button1.TabIndex = 0;
            this.button1.Text = "Listar usuários";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(324, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 125);
            this.button2.TabIndex = 1;
            this.button2.Text = "Gerenciar relatórios";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(49, 220);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(197, 125);
            this.button4.TabIndex = 3;
            this.button4.Text = "Gerenciar campainha";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(620, 47);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(197, 125);
            this.button5.TabIndex = 4;
            this.button5.Text = "Gerenciar avião";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(324, 47);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(197, 125);
            this.button6.TabIndex = 5;
            this.button6.Text = "Listar aviões";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 548);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmTelaPrincipal";
            this.Text = "Tela Principal - AirSystem";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}