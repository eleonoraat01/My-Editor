namespace MyEditor
{
    partial class UserInfoForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.epFirstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epLastName = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLastName)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last name:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(67, 52);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(185, 20);
            this.tbFirstName.TabIndex = 2;
            this.tbFirstName.TextChanged += new System.EventHandler(this.tbFirstName_TextChanged);
            this.tbFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.tbFirstName_Validating);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(67, 116);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(185, 20);
            this.tbLastName.TabIndex = 3;
            this.tbLastName.TextChanged += new System.EventHandler(this.tbLastName_TextChanged);
            this.tbLastName.Validated += new System.EventHandler(this.tbLastName_Validated);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(98, 164);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(117, 36);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Proceed to system";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // epFirstName
            // 
            this.epFirstName.ContainerControl = this;
            // 
            // epLastName
            // 
            this.epLastName.ContainerControl = this;
            // 
            // UserInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 226);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserInfoForm";
            this.Text = "User Info";
            ((System.ComponentModel.ISupportInitialize)(this.epFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLastName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ErrorProvider epFirstName;
        private System.Windows.Forms.ErrorProvider epLastName;
    }
}

