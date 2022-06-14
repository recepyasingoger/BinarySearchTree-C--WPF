
namespace BinarySearchTree
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbTree = new System.Windows.Forms.PictureBox();
            this.Ekle = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNode = new System.Windows.Forms.TextBox();
            this.Sil = new Guna.UI.WinForms.GunaButton();
            this.Ara = new Guna.UI.WinForms.GunaButton();
            this.lblInfo = new System.Windows.Forms.Label();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaGradient2Panel2 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.liste = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gunaGradient2Panel1.SuspendLayout();
            this.gunaGradient2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbTree
            // 
            this.pbTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.pbTree.Location = new System.Drawing.Point(248, 112);
            this.pbTree.Margin = new System.Windows.Forms.Padding(2);
            this.pbTree.Name = "pbTree";
            this.pbTree.Size = new System.Drawing.Size(920, 565);
            this.pbTree.TabIndex = 15;
            this.pbTree.TabStop = false;
            // 
            // Ekle
            // 
            this.Ekle.AnimationHoverSpeed = 0.07F;
            this.Ekle.AnimationSpeed = 0.03F;
            this.Ekle.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(119)))), ((int)(((byte)(80)))));
            this.Ekle.BorderColor = System.Drawing.Color.Black;
            this.Ekle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Ekle.FocusedColor = System.Drawing.Color.Empty;
            this.Ekle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ekle.ForeColor = System.Drawing.Color.White;
            this.Ekle.Image = ((System.Drawing.Image)(resources.GetObject("Ekle.Image")));
            this.Ekle.ImageSize = new System.Drawing.Size(30, 30);
            this.Ekle.Location = new System.Drawing.Point(37, 300);
            this.Ekle.Margin = new System.Windows.Forms.Padding(2);
            this.Ekle.Name = "Ekle";
            this.Ekle.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Ekle.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Ekle.OnHoverForeColor = System.Drawing.Color.White;
            this.Ekle.OnHoverImage = null;
            this.Ekle.OnPressedColor = System.Drawing.Color.Black;
            this.Ekle.Size = new System.Drawing.Size(169, 48);
            this.Ekle.TabIndex = 18;
            this.Ekle.Text = "Ekle";
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Veri Gir";
            // 
            // tbNode
            // 
            this.tbNode.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbNode.Location = new System.Drawing.Point(37, 258);
            this.tbNode.Margin = new System.Windows.Forms.Padding(2);
            this.tbNode.Name = "tbNode";
            this.tbNode.Size = new System.Drawing.Size(169, 32);
            this.tbNode.TabIndex = 20;
            // 
            // Sil
            // 
            this.Sil.AnimationHoverSpeed = 0.07F;
            this.Sil.AnimationSpeed = 0.03F;
            this.Sil.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(119)))), ((int)(((byte)(80)))));
            this.Sil.BorderColor = System.Drawing.Color.Black;
            this.Sil.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Sil.FocusedColor = System.Drawing.Color.Empty;
            this.Sil.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sil.ForeColor = System.Drawing.Color.White;
            this.Sil.Image = ((System.Drawing.Image)(resources.GetObject("Sil.Image")));
            this.Sil.ImageSize = new System.Drawing.Size(30, 30);
            this.Sil.Location = new System.Drawing.Point(37, 364);
            this.Sil.Margin = new System.Windows.Forms.Padding(2);
            this.Sil.Name = "Sil";
            this.Sil.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Sil.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Sil.OnHoverForeColor = System.Drawing.Color.White;
            this.Sil.OnHoverImage = null;
            this.Sil.OnPressedColor = System.Drawing.Color.Black;
            this.Sil.Size = new System.Drawing.Size(169, 48);
            this.Sil.TabIndex = 21;
            this.Sil.Text = "Sil";
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // Ara
            // 
            this.Ara.AnimationHoverSpeed = 0.07F;
            this.Ara.AnimationSpeed = 0.03F;
            this.Ara.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(119)))), ((int)(((byte)(80)))));
            this.Ara.BorderColor = System.Drawing.Color.Black;
            this.Ara.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Ara.FocusedColor = System.Drawing.Color.Empty;
            this.Ara.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ara.ForeColor = System.Drawing.Color.White;
            this.Ara.Image = ((System.Drawing.Image)(resources.GetObject("Ara.Image")));
            this.Ara.ImageSize = new System.Drawing.Size(30, 30);
            this.Ara.Location = new System.Drawing.Point(37, 428);
            this.Ara.Margin = new System.Windows.Forms.Padding(2);
            this.Ara.Name = "Ara";
            this.Ara.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Ara.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Ara.OnHoverForeColor = System.Drawing.Color.White;
            this.Ara.OnHoverImage = null;
            this.Ara.OnPressedColor = System.Drawing.Color.Black;
            this.Ara.Size = new System.Drawing.Size(169, 48);
            this.Ara.TabIndex = 22;
            this.Ara.Text = "Ara";
            this.Ara.Click += new System.EventHandler(this.Ara_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInfo.Location = new System.Drawing.Point(11, 597);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 18);
            this.lblInfo.TabIndex = 25;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaControlBox1.IconColor = System.Drawing.Color.White;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(853, 7);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(59, 48);
            this.gunaControlBox1.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BinarySearchTree.Properties.Resources.ikiliaramagacı;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.Controls.Add(this.tbNode);
            this.gunaGradient2Panel1.Controls.Add(this.gunaButton1);
            this.gunaGradient2Panel1.Controls.Add(this.Ekle);
            this.gunaGradient2Panel1.Controls.Add(this.Sil);
            this.gunaGradient2Panel1.Controls.Add(this.pictureBox1);
            this.gunaGradient2Panel1.Controls.Add(this.Ara);
            this.gunaGradient2Panel1.Controls.Add(this.lblInfo);
            this.gunaGradient2Panel1.Controls.Add(this.label1);
            this.gunaGradient2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(63)))), ((int)(((byte)(55)))));
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(119)))), ((int)(((byte)(68)))));
            this.gunaGradient2Panel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(0, 0);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(256, 677);
            this.gunaGradient2Panel1.TabIndex = 28;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(119)))), ((int)(((byte)(80)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButton1.Location = new System.Drawing.Point(37, 492);
            this.gunaButton1.Margin = new System.Windows.Forms.Padding(2);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(169, 48);
            this.gunaButton1.TabIndex = 28;
            this.gunaButton1.Text = "Agac Kaldır";
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaGradient2Panel2
            // 
            this.gunaGradient2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaGradient2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel2.Controls.Add(this.label7);
            this.gunaGradient2Panel2.Controls.Add(this.label6);
            this.gunaGradient2Panel2.Controls.Add(this.label5);
            this.gunaGradient2Panel2.Controls.Add(this.label4);
            this.gunaGradient2Panel2.Controls.Add(this.label3);
            this.gunaGradient2Panel2.Controls.Add(this.label2);
            this.gunaGradient2Panel2.Controls.Add(this.liste);
            this.gunaGradient2Panel2.Controls.Add(this.gunaControlBox1);
            this.gunaGradient2Panel2.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(63)))), ((int)(((byte)(55)))));
            this.gunaGradient2Panel2.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(119)))), ((int)(((byte)(68)))));
            this.gunaGradient2Panel2.Location = new System.Drawing.Point(256, -2);
            this.gunaGradient2Panel2.Name = "gunaGradient2Panel2";
            this.gunaGradient2Panel2.Size = new System.Drawing.Size(915, 116);
            this.gunaGradient2Panel2.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(14, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "PostOrder Listeleme :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(19, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "PreOrder Listeleme : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(28, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "İnOrder Listeleme : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(174, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(174, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(174, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 30;
            // 
            // liste
            // 
            this.liste.AutoSize = true;
            this.liste.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.liste.ForeColor = System.Drawing.Color.White;
            this.liste.Location = new System.Drawing.Point(377, 30);
            this.liste.Name = "liste";
            this.liste.Size = new System.Drawing.Size(0, 25);
            this.liste.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 677);
            this.Controls.Add(this.gunaGradient2Panel2);
            this.Controls.Add(this.gunaGradient2Panel1);
            this.Controls.Add(this.pbTree);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gunaGradient2Panel1.ResumeLayout(false);
            this.gunaGradient2Panel1.PerformLayout();
            this.gunaGradient2Panel2.ResumeLayout(false);
            this.gunaGradient2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbTree;
        private Guna.UI.WinForms.GunaButton Ekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNode;
        private Guna.UI.WinForms.GunaButton Sil;
        private Guna.UI.WinForms.GunaButton Ara;
        private System.Windows.Forms.Label lblInfo;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel2;
        public System.Windows.Forms.Label liste;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

