namespace DatingApp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblWelcomeUser = new System.Windows.Forms.Label();
            this.pnlPref = new System.Windows.Forms.Panel();
            this.btnSetPref = new System.Windows.Forms.Button();
            this.numMaxAge = new System.Windows.Forms.NumericUpDown();
            this.numMinAge = new System.Windows.Forms.NumericUpDown();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlSuggestions = new System.Windows.Forms.Panel();
            this.lbxApprovedSuggestions = new System.Windows.Forms.ListBox();
            this.BtnDeclineSuggestion = new System.Windows.Forms.Button();
            this.btnApproveSuggestion = new System.Windows.Forms.Button();
            this.lblSuggestionAge = new System.Windows.Forms.Label();
            this.lblSuggestionName = new System.Windows.Forms.Label();
            this.pnlLogin.SuspendLayout();
            this.pnlPref.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinAge)).BeginInit();
            this.pnlSuggestions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(166, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dating App";
            // 
            // tbxUserName
            // 
            this.tbxUserName.Location = new System.Drawing.Point(23, 82);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(176, 23);
            this.tbxUserName.TabIndex = 6;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(23, 134);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(176, 23);
            this.tbxPassword.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(73, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sign In";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(23, 178);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(175, 23);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.tbxUserName);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.tbxPassword);
            this.pnlLogin.Controls.Add(this.label3);
            this.pnlLogin.Controls.Add(this.label4);
            this.pnlLogin.Controls.Add(this.label2);
            this.pnlLogin.Location = new System.Drawing.Point(9, 12);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(562, 404);
            this.pnlLogin.TabIndex = 12;
            // 
            // lblWelcomeUser
            // 
            this.lblWelcomeUser.AutoSize = true;
            this.lblWelcomeUser.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWelcomeUser.Location = new System.Drawing.Point(16, 25);
            this.lblWelcomeUser.Name = "lblWelcomeUser";
            this.lblWelcomeUser.Size = new System.Drawing.Size(211, 36);
            this.lblWelcomeUser.TabIndex = 13;
            this.lblWelcomeUser.Text = "Welcome _USER_";
            // 
            // pnlPref
            // 
            this.pnlPref.Controls.Add(this.btnSetPref);
            this.pnlPref.Controls.Add(this.numMaxAge);
            this.pnlPref.Controls.Add(this.numMinAge);
            this.pnlPref.Controls.Add(this.cbxGender);
            this.pnlPref.Controls.Add(this.label8);
            this.pnlPref.Controls.Add(this.label7);
            this.pnlPref.Controls.Add(this.label6);
            this.pnlPref.Controls.Add(this.label5);
            this.pnlPref.Controls.Add(this.lblWelcomeUser);
            this.pnlPref.Location = new System.Drawing.Point(310, 57);
            this.pnlPref.Name = "pnlPref";
            this.pnlPref.Size = new System.Drawing.Size(247, 275);
            this.pnlPref.TabIndex = 14;
            this.pnlPref.Visible = false;
            // 
            // btnSetPref
            // 
            this.btnSetPref.Location = new System.Drawing.Point(69, 231);
            this.btnSetPref.Name = "btnSetPref";
            this.btnSetPref.Size = new System.Drawing.Size(105, 26);
            this.btnSetPref.TabIndex = 20;
            this.btnSetPref.Text = "Set Pref";
            this.btnSetPref.UseVisualStyleBackColor = true;
            this.btnSetPref.Click += new System.EventHandler(this.btnSetPref_Click);
            // 
            // numMaxAge
            // 
            this.numMaxAge.Location = new System.Drawing.Point(159, 125);
            this.numMaxAge.Name = "numMaxAge";
            this.numMaxAge.Size = new System.Drawing.Size(47, 23);
            this.numMaxAge.TabIndex = 19;
            // 
            // numMinAge
            // 
            this.numMinAge.Location = new System.Drawing.Point(81, 125);
            this.numMinAge.Name = "numMinAge";
            this.numMinAge.Size = new System.Drawing.Size(47, 23);
            this.numMinAge.TabIndex = 18;
            // 
            // cbxGender
            // 
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "male",
            "female"});
            this.cbxGender.Location = new System.Drawing.Point(81, 176);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(121, 23);
            this.cbxGender.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(134, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "To";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(31, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 36);
            this.label5.TabIndex = 14;
            this.label5.Text = "Select your pref";
            // 
            // pnlSuggestions
            // 
            this.pnlSuggestions.Controls.Add(this.lbxApprovedSuggestions);
            this.pnlSuggestions.Controls.Add(this.BtnDeclineSuggestion);
            this.pnlSuggestions.Controls.Add(this.btnApproveSuggestion);
            this.pnlSuggestions.Controls.Add(this.lblSuggestionAge);
            this.pnlSuggestions.Controls.Add(this.lblSuggestionName);
            this.pnlSuggestions.Location = new System.Drawing.Point(577, 57);
            this.pnlSuggestions.Name = "pnlSuggestions";
            this.pnlSuggestions.Size = new System.Drawing.Size(379, 275);
            this.pnlSuggestions.TabIndex = 21;
            this.pnlSuggestions.Visible = false;
            // 
            // lbxApprovedSuggestions
            // 
            this.lbxApprovedSuggestions.FormattingEnabled = true;
            this.lbxApprovedSuggestions.ItemHeight = 15;
            this.lbxApprovedSuggestions.Location = new System.Drawing.Point(246, 64);
            this.lbxApprovedSuggestions.Name = "lbxApprovedSuggestions";
            this.lbxApprovedSuggestions.Size = new System.Drawing.Size(120, 199);
            this.lbxApprovedSuggestions.TabIndex = 22;
            // 
            // BtnDeclineSuggestion
            // 
            this.BtnDeclineSuggestion.Location = new System.Drawing.Point(124, 195);
            this.BtnDeclineSuggestion.Name = "BtnDeclineSuggestion";
            this.BtnDeclineSuggestion.Size = new System.Drawing.Size(105, 62);
            this.BtnDeclineSuggestion.TabIndex = 21;
            this.BtnDeclineSuggestion.Text = "NO";
            this.BtnDeclineSuggestion.UseVisualStyleBackColor = true;
            this.BtnDeclineSuggestion.Click += new System.EventHandler(this.BtnDeclineSuggestion_Click);
            // 
            // btnApproveSuggestion
            // 
            this.btnApproveSuggestion.Location = new System.Drawing.Point(16, 195);
            this.btnApproveSuggestion.Name = "btnApproveSuggestion";
            this.btnApproveSuggestion.Size = new System.Drawing.Size(105, 62);
            this.btnApproveSuggestion.TabIndex = 20;
            this.btnApproveSuggestion.Text = "YES";
            this.btnApproveSuggestion.UseVisualStyleBackColor = true;
            this.btnApproveSuggestion.Click += new System.EventHandler(this.btnApproveSuggestion_Click);
            // 
            // lblSuggestionAge
            // 
            this.lblSuggestionAge.AutoSize = true;
            this.lblSuggestionAge.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSuggestionAge.Location = new System.Drawing.Point(31, 53);
            this.lblSuggestionAge.Name = "lblSuggestionAge";
            this.lblSuggestionAge.Size = new System.Drawing.Size(190, 36);
            this.lblSuggestionAge.TabIndex = 14;
            this.lblSuggestionAge.Text = "SuggestionAge";
            // 
            // lblSuggestionName
            // 
            this.lblSuggestionName.AutoSize = true;
            this.lblSuggestionName.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSuggestionName.Location = new System.Drawing.Point(16, 17);
            this.lblSuggestionName.Name = "lblSuggestionName";
            this.lblSuggestionName.Size = new System.Drawing.Size(215, 36);
            this.lblSuggestionName.TabIndex = 13;
            this.lblSuggestionName.Text = "Suggestion name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(955, 450);
            this.Controls.Add(this.pnlSuggestions);
            this.Controls.Add(this.pnlPref);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlPref.ResumeLayout(false);
            this.pnlPref.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinAge)).EndInit();
            this.pnlSuggestions.ResumeLayout(false);
            this.pnlSuggestions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbxUserName;
        private TextBox tbxPassword;
        private Label label4;
        private Label label2;
        private Label label3;
        private Button btnLogin;
        private Panel pnlLogin;
        private Label lblWelcomeUser;
        private Panel pnlPref;
        private Button btnSetPref;
        private NumericUpDown numMaxAge;
        private NumericUpDown numMinAge;
        private ComboBox cbxGender;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Panel pnlSuggestions;
        private Button BtnDeclineSuggestion;
        private Button btnApproveSuggestion;
        private Label lblSuggestionAge;
        private Label lblSuggestionName;
        private ListBox lbxApprovedSuggestions;
    }
}