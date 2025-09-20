using System.Drawing;
using System.Windows.Forms;

namespace DonationManagement
{
    partial class LoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.loginContanior = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoginwithEmail = new System.Windows.Forms.Label();
            this.Welcome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.checkEmailError = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loginContanior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEmailError)).BeginInit();
            this.SuspendLayout();
            // 
            // loginContanior
            // 
            this.loginContanior.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginContanior.AutoScroll = true;
            this.loginContanior.AutoSize = true;
            this.loginContanior.BackColor = System.Drawing.Color.White;
            this.loginContanior.ColumnCount = 2;
            this.loginContanior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.loginContanior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.loginContanior.Controls.Add(this.pictureBox1, 1, 0);
            this.loginContanior.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.loginContanior.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.loginContanior.Location = new System.Drawing.Point(0, 0);
            this.loginContanior.Name = "loginContanior";
            this.loginContanior.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.loginContanior.RowCount = 1;
            this.loginContanior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.loginContanior.Size = new System.Drawing.Size(966, 360);
            this.loginContanior.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(451, 354);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.91482F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.loginBtn, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(460, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.79105F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.20895F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(503, 354);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LoginwithEmail);
            this.panel1.Controls.Add(this.Welcome);
            this.panel1.Location = new System.Drawing.Point(5, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 115);
            this.panel1.TabIndex = 0;
            // 
            // LoginwithEmail
            // 
            this.LoginwithEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginwithEmail.AutoSize = true;
            this.LoginwithEmail.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.LoginwithEmail.Location = new System.Drawing.Point(190, 75);
            this.LoginwithEmail.Name = "LoginwithEmail";
            this.LoginwithEmail.Size = new System.Drawing.Size(155, 28);
            this.LoginwithEmail.TabIndex = 2;
            this.LoginwithEmail.Text = "Login with Email";
            // 
            // Welcome
            // 
            this.Welcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(80)), true);
            this.Welcome.Location = new System.Drawing.Point(171, 31);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(197, 54);
            this.Welcome.TabIndex = 1;
            this.Welcome.Text = "Welcome";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.passwordInput);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.emailInput);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(497, 163);
            this.panel2.TabIndex = 1;
            // 
            // passwordInput
            // 
            this.passwordInput.AccessibleName = "passwordInput";
            this.passwordInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordInput.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.passwordInput.Location = new System.Drawing.Point(40, 109);
            this.passwordInput.MaximumSize = new System.Drawing.Size(421, 40);
            this.passwordInput.MinimumSize = new System.Drawing.Size(421, 40);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passwordInput.Size = new System.Drawing.Size(421, 38);
            this.passwordInput.TabIndex = 5;
            this.passwordInput.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(37, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // emailInput
            // 
            this.emailInput.AccessibleName = "emailInput";
            this.emailInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailInput.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.emailInput.ForeColor = System.Drawing.Color.Black;
            this.checkEmailError.SetIconPadding(this.emailInput, 10);
            this.emailInput.Location = new System.Drawing.Point(39, 29);
            this.emailInput.Name = "emailInput";
            this.emailInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.emailInput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.emailInput.Size = new System.Drawing.Size(421, 35);
            this.emailInput.TabIndex = 2;
            this.emailInput.Text = "";
            this.emailInput.TextChanged += new System.EventHandler(this.EmailInput_TextChanged_1);
            this.emailInput.Leave += new System.EventHandler(this.richTextBox1_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(36, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email Id";
            // 
            // loginBtn
            // 
            this.loginBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.loginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(154, 302);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(195, 39);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Tag = "Login";
            this.loginBtn.Text = "LOGIN";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // checkEmailError
            // 
            this.checkEmailError.ContainerControl = this;
            this.checkEmailError.Icon = ((System.Drawing.Icon)(resources.GetObject("checkEmailError.Icon")));
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // LoginPage
            // 
            this.AccessibleName = "Login";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(965, 360);
            this.Controls.Add(this.loginContanior);
            this.Name = "LoginPage";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.loginContanior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEmailError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel loginContanior;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label LoginwithEmail;
        private Label Welcome;
        private Panel panel2;
        private Label label2;
        private RichTextBox emailInput;
        private Label label1;
        private Button loginBtn;
        private ErrorProvider checkEmailError;
        private TextBox passwordInput;
        private ContextMenuStrip contextMenuStrip1;
    }
}

