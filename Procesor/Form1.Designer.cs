
namespace Procesor
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;

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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Reset_Button = new System.Windows.Forms.Button();
            this.AX_Text = new System.Windows.Forms.TextBox();
            this.BX_Text = new System.Windows.Forms.TextBox();
            this.CX_Text = new System.Windows.Forms.TextBox();
            this.DX_Text = new System.Windows.Forms.TextBox();
            this.MOV_AX_BX = new System.Windows.Forms.Button();
            this.MOV_AX_CX = new System.Windows.Forms.Button();
            this.MOV_AX_DX = new System.Windows.Forms.Button();
            this.MOV_BX_AX = new System.Windows.Forms.Button();
            this.MOV_BX_CX = new System.Windows.Forms.Button();
            this.MOV_BX_DX = new System.Windows.Forms.Button();
            this.MOV_CX_AX = new System.Windows.Forms.Button();
            this.MOV_CX_BX = new System.Windows.Forms.Button();
            this.MOV_CX_DX = new System.Windows.Forms.Button();
            this.MOV_DX_AX = new System.Windows.Forms.Button();
            this.MOV_DX_BX = new System.Windows.Forms.Button();
            this.MOV_DX_CX = new System.Windows.Forms.Button();
            this.XCHG_AX_BX = new System.Windows.Forms.Button();
            this.XCHG_AX_CX = new System.Windows.Forms.Button();
            this.XCHG_AX_DX = new System.Windows.Forms.Button();
            this.XCHG_BX_AX = new System.Windows.Forms.Button();
            this.XCHG_BX_CX = new System.Windows.Forms.Button();
            this.XCHG_BX_DX = new System.Windows.Forms.Button();
            this.XCHG_CX_AX = new System.Windows.Forms.Button();
            this.XCHG_CX_BX = new System.Windows.Forms.Button();
            this.XCHG_CX_DX = new System.Windows.Forms.Button();
            this.XCHG_DX_AX = new System.Windows.Forms.Button();
            this.XCHG_DX_BX = new System.Windows.Forms.Button();
            this.XCHG_DX_CX = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Okno_Błędu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Reset_Button
            // 
            resources.ApplyResources(this.Reset_Button, "Reset_Button");
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.UseVisualStyleBackColor = true;
            this.Reset_Button.Click += new System.EventHandler(this.Reset_button);
            // 
            // AX_Text
            // 
            resources.ApplyResources(this.AX_Text, "AX_Text");
            this.AX_Text.Name = "AX_Text";
            this.AX_Text.TextChanged += new System.EventHandler(this.AX_Text_TextChanged);
            // 
            // BX_Text
            // 
            resources.ApplyResources(this.BX_Text, "BX_Text");
            this.BX_Text.Name = "BX_Text";
            this.BX_Text.TextChanged += new System.EventHandler(this.BX_Text_TextChanged);
            // 
            // CX_Text
            // 
            resources.ApplyResources(this.CX_Text, "CX_Text");
            this.CX_Text.Name = "CX_Text";
            // 
            // DX_Text
            // 
            resources.ApplyResources(this.DX_Text, "DX_Text");
            this.DX_Text.Name = "DX_Text";
            // 
            // MOV_AX_BX
            // 
            resources.ApplyResources(this.MOV_AX_BX, "MOV_AX_BX");
            this.MOV_AX_BX.Name = "MOV_AX_BX";
            this.MOV_AX_BX.UseVisualStyleBackColor = true;
            this.MOV_AX_BX.Click += new System.EventHandler(this.MOV_AX_BX_Click);
            // 
            // MOV_AX_CX
            // 
            resources.ApplyResources(this.MOV_AX_CX, "MOV_AX_CX");
            this.MOV_AX_CX.Name = "MOV_AX_CX";
            this.MOV_AX_CX.UseVisualStyleBackColor = true;
            this.MOV_AX_CX.Click += new System.EventHandler(this.MOV_AX_CX_Click);
            // 
            // MOV_AX_DX
            // 
            resources.ApplyResources(this.MOV_AX_DX, "MOV_AX_DX");
            this.MOV_AX_DX.Name = "MOV_AX_DX";
            this.MOV_AX_DX.UseVisualStyleBackColor = true;
            this.MOV_AX_DX.Click += new System.EventHandler(this.MOV_AX_DX_Click);
            // 
            // MOV_BX_AX
            // 
            resources.ApplyResources(this.MOV_BX_AX, "MOV_BX_AX");
            this.MOV_BX_AX.Name = "MOV_BX_AX";
            this.MOV_BX_AX.UseVisualStyleBackColor = true;
            this.MOV_BX_AX.Click += new System.EventHandler(this.MOV_BX_AX_Click);
            // 
            // MOV_BX_CX
            // 
            resources.ApplyResources(this.MOV_BX_CX, "MOV_BX_CX");
            this.MOV_BX_CX.Name = "MOV_BX_CX";
            this.MOV_BX_CX.UseVisualStyleBackColor = true;
            this.MOV_BX_CX.Click += new System.EventHandler(this.MOV_BX_CX_Click);
            // 
            // MOV_BX_DX
            // 
            resources.ApplyResources(this.MOV_BX_DX, "MOV_BX_DX");
            this.MOV_BX_DX.Name = "MOV_BX_DX";
            this.MOV_BX_DX.UseVisualStyleBackColor = true;
            this.MOV_BX_DX.Click += new System.EventHandler(this.MOV_BX_DX_Click);
            // 
            // MOV_CX_AX
            // 
            resources.ApplyResources(this.MOV_CX_AX, "MOV_CX_AX");
            this.MOV_CX_AX.Name = "MOV_CX_AX";
            this.MOV_CX_AX.UseVisualStyleBackColor = true;
            this.MOV_CX_AX.Click += new System.EventHandler(this.MOV_CX_AX_Click);
            // 
            // MOV_CX_BX
            // 
            resources.ApplyResources(this.MOV_CX_BX, "MOV_CX_BX");
            this.MOV_CX_BX.Name = "MOV_CX_BX";
            this.MOV_CX_BX.UseVisualStyleBackColor = true;
            this.MOV_CX_BX.Click += new System.EventHandler(this.MOV_CX_BX_Click);
            // 
            // MOV_CX_DX
            // 
            resources.ApplyResources(this.MOV_CX_DX, "MOV_CX_DX");
            this.MOV_CX_DX.Name = "MOV_CX_DX";
            this.MOV_CX_DX.UseVisualStyleBackColor = true;
            this.MOV_CX_DX.Click += new System.EventHandler(this.MOV_CX_DX_Click);
            // 
            // MOV_DX_AX
            // 
            resources.ApplyResources(this.MOV_DX_AX, "MOV_DX_AX");
            this.MOV_DX_AX.Name = "MOV_DX_AX";
            this.MOV_DX_AX.UseVisualStyleBackColor = true;
            this.MOV_DX_AX.Click += new System.EventHandler(this.MOV_DX_AX_Click);
            // 
            // MOV_DX_BX
            // 
            resources.ApplyResources(this.MOV_DX_BX, "MOV_DX_BX");
            this.MOV_DX_BX.Name = "MOV_DX_BX";
            this.MOV_DX_BX.UseVisualStyleBackColor = true;
            this.MOV_DX_BX.Click += new System.EventHandler(this.MOV_DX_BX_Click);
            // 
            // MOV_DX_CX
            // 
            resources.ApplyResources(this.MOV_DX_CX, "MOV_DX_CX");
            this.MOV_DX_CX.Name = "MOV_DX_CX";
            this.MOV_DX_CX.UseVisualStyleBackColor = true;
            this.MOV_DX_CX.Click += new System.EventHandler(this.MOV_DX_CX_Click);
            // 
            // XCHG_AX_BX
            // 
            resources.ApplyResources(this.XCHG_AX_BX, "XCHG_AX_BX");
            this.XCHG_AX_BX.Name = "XCHG_AX_BX";
            this.XCHG_AX_BX.UseVisualStyleBackColor = true;
            this.XCHG_AX_BX.Click += new System.EventHandler(this.XCHG_AX_BX_Click);
            // 
            // XCHG_AX_CX
            // 
            resources.ApplyResources(this.XCHG_AX_CX, "XCHG_AX_CX");
            this.XCHG_AX_CX.Name = "XCHG_AX_CX";
            this.XCHG_AX_CX.UseVisualStyleBackColor = true;
            this.XCHG_AX_CX.Click += new System.EventHandler(this.XCHG_AX_CX_Click);
            // 
            // XCHG_AX_DX
            // 
            resources.ApplyResources(this.XCHG_AX_DX, "XCHG_AX_DX");
            this.XCHG_AX_DX.Name = "XCHG_AX_DX";
            this.XCHG_AX_DX.UseVisualStyleBackColor = true;
            this.XCHG_AX_DX.Click += new System.EventHandler(this.XCHG_AX_DX_Click);
            // 
            // XCHG_BX_AX
            // 
            resources.ApplyResources(this.XCHG_BX_AX, "XCHG_BX_AX");
            this.XCHG_BX_AX.Name = "XCHG_BX_AX";
            this.XCHG_BX_AX.UseVisualStyleBackColor = true;
            this.XCHG_BX_AX.Click += new System.EventHandler(this.XCHG_BX_AX_Click);
            // 
            // XCHG_BX_CX
            // 
            resources.ApplyResources(this.XCHG_BX_CX, "XCHG_BX_CX");
            this.XCHG_BX_CX.Name = "XCHG_BX_CX";
            this.XCHG_BX_CX.UseVisualStyleBackColor = true;
            this.XCHG_BX_CX.Click += new System.EventHandler(this.XCHG_BX_CX_Click);
            // 
            // XCHG_BX_DX
            // 
            resources.ApplyResources(this.XCHG_BX_DX, "XCHG_BX_DX");
            this.XCHG_BX_DX.Name = "XCHG_BX_DX";
            this.XCHG_BX_DX.UseVisualStyleBackColor = true;
            this.XCHG_BX_DX.Click += new System.EventHandler(this.XCHG_BX_DX_Click);
            // 
            // XCHG_CX_AX
            // 
            resources.ApplyResources(this.XCHG_CX_AX, "XCHG_CX_AX");
            this.XCHG_CX_AX.Name = "XCHG_CX_AX";
            this.XCHG_CX_AX.UseVisualStyleBackColor = true;
            this.XCHG_CX_AX.Click += new System.EventHandler(this.XCHG_CX_AX_Click);
            // 
            // XCHG_CX_BX
            // 
            resources.ApplyResources(this.XCHG_CX_BX, "XCHG_CX_BX");
            this.XCHG_CX_BX.Name = "XCHG_CX_BX";
            this.XCHG_CX_BX.UseVisualStyleBackColor = true;
            this.XCHG_CX_BX.Click += new System.EventHandler(this.XCHG_CX_BX_Click);
            // 
            // XCHG_CX_DX
            // 
            resources.ApplyResources(this.XCHG_CX_DX, "XCHG_CX_DX");
            this.XCHG_CX_DX.Name = "XCHG_CX_DX";
            this.XCHG_CX_DX.UseVisualStyleBackColor = true;
            this.XCHG_CX_DX.Click += new System.EventHandler(this.XCHG_CX_DX_Click);
            // 
            // XCHG_DX_AX
            // 
            resources.ApplyResources(this.XCHG_DX_AX, "XCHG_DX_AX");
            this.XCHG_DX_AX.Name = "XCHG_DX_AX";
            this.XCHG_DX_AX.UseVisualStyleBackColor = true;
            this.XCHG_DX_AX.Click += new System.EventHandler(this.XCHG_DX_AX_Click);
            // 
            // XCHG_DX_BX
            // 
            resources.ApplyResources(this.XCHG_DX_BX, "XCHG_DX_BX");
            this.XCHG_DX_BX.Name = "XCHG_DX_BX";
            this.XCHG_DX_BX.UseVisualStyleBackColor = true;
            this.XCHG_DX_BX.Click += new System.EventHandler(this.XCHG_DX_BX_Click);
            // 
            // XCHG_DX_CX
            // 
            resources.ApplyResources(this.XCHG_DX_CX, "XCHG_DX_CX");
            this.XCHG_DX_CX.Name = "XCHG_DX_CX";
            this.XCHG_DX_CX.UseVisualStyleBackColor = true;
            this.XCHG_DX_CX.Click += new System.EventHandler(this.XCHG_DX_CX_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.SpringGreen;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // Okno_Błędu
            // 
            resources.ApplyResources(this.Okno_Błędu, "Okno_Błędu");
            this.Okno_Błędu.Name = "Okno_Błędu";
            this.Okno_Błędu.Click += new System.EventHandler(this.Okno_Błędu_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.Controls.Add(this.Okno_Błędu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.XCHG_DX_CX);
            this.Controls.Add(this.XCHG_DX_BX);
            this.Controls.Add(this.XCHG_DX_AX);
            this.Controls.Add(this.XCHG_CX_DX);
            this.Controls.Add(this.XCHG_CX_BX);
            this.Controls.Add(this.XCHG_CX_AX);
            this.Controls.Add(this.XCHG_BX_DX);
            this.Controls.Add(this.XCHG_BX_CX);
            this.Controls.Add(this.XCHG_BX_AX);
            this.Controls.Add(this.XCHG_AX_DX);
            this.Controls.Add(this.XCHG_AX_CX);
            this.Controls.Add(this.XCHG_AX_BX);
            this.Controls.Add(this.MOV_DX_CX);
            this.Controls.Add(this.MOV_DX_BX);
            this.Controls.Add(this.MOV_DX_AX);
            this.Controls.Add(this.MOV_CX_DX);
            this.Controls.Add(this.MOV_CX_BX);
            this.Controls.Add(this.MOV_CX_AX);
            this.Controls.Add(this.MOV_BX_DX);
            this.Controls.Add(this.MOV_BX_CX);
            this.Controls.Add(this.MOV_BX_AX);
            this.Controls.Add(this.MOV_AX_DX);
            this.Controls.Add(this.MOV_AX_CX);
            this.Controls.Add(this.MOV_AX_BX);
            this.Controls.Add(this.DX_Text);
            this.Controls.Add(this.CX_Text);
            this.Controls.Add(this.BX_Text);
            this.Controls.Add(this.AX_Text);
            this.Controls.Add(this.Reset_Button);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Reset_Button;
        private System.Windows.Forms.TextBox AX_Text;
        private System.Windows.Forms.TextBox BX_Text;
        private System.Windows.Forms.TextBox CX_Text;
        private System.Windows.Forms.TextBox DX_Text;
        private System.Windows.Forms.Button MOV_AX_BX;
        private System.Windows.Forms.Button MOV_AX_CX;
        private System.Windows.Forms.Button MOV_AX_DX;
        private System.Windows.Forms.Button MOV_BX_AX;
        private System.Windows.Forms.Button MOV_BX_CX;
        private System.Windows.Forms.Button MOV_BX_DX;
        private System.Windows.Forms.Button MOV_CX_AX;
        private System.Windows.Forms.Button MOV_CX_BX;
        private System.Windows.Forms.Button MOV_CX_DX;
        private System.Windows.Forms.Button MOV_DX_AX;
        private System.Windows.Forms.Button MOV_DX_BX;
        private System.Windows.Forms.Button MOV_DX_CX;
        private System.Windows.Forms.Button XCHG_AX_BX;
        private System.Windows.Forms.Button XCHG_AX_CX;
        private System.Windows.Forms.Button XCHG_AX_DX;
        private System.Windows.Forms.Button XCHG_BX_AX;
        private System.Windows.Forms.Button XCHG_BX_CX;
        private System.Windows.Forms.Button XCHG_BX_DX;
        private System.Windows.Forms.Button XCHG_CX_AX;
        private System.Windows.Forms.Button XCHG_CX_BX;
        private System.Windows.Forms.Button XCHG_CX_DX;
        private System.Windows.Forms.Button XCHG_DX_AX;
        private System.Windows.Forms.Button XCHG_DX_BX;
        private System.Windows.Forms.Button XCHG_DX_CX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Okno_Błędu;
    }
}

