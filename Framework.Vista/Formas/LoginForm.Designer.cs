namespace Framework.Vista
{
    partial class LoginForm
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
            this.btnIngresar = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.txtContrasenia = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.pnlError = new MetroFramework.Controls.MetroPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlError.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(132, 114);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(239, 27);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "&Ingresar";
            this.btnIngresar.UseSelectable = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.btnIngresar);
            this.metroPanel2.Controls.Add(this.txtContrasenia);
            this.metroPanel2.Controls.Add(this.pictureBox1);
            this.metroPanel2.Controls.Add(this.txtUsuario);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(20, 133);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(385, 164);
            this.metroPanel2.TabIndex = 5;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtContrasenia.CustomButton.Image = null;
            this.txtContrasenia.CustomButton.Location = new System.Drawing.Point(217, 1);
            this.txtContrasenia.CustomButton.Name = "";
            this.txtContrasenia.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtContrasenia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtContrasenia.CustomButton.TabIndex = 1;
            this.txtContrasenia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtContrasenia.CustomButton.UseSelectable = true;
            this.txtContrasenia.CustomButton.Visible = false;
            this.txtContrasenia.DisplayIcon = true;
            this.txtContrasenia.Icon = global::Framework.Vista.Properties.Resources.lock_14px;
            this.txtContrasenia.Lines = new string[0];
            this.txtContrasenia.Location = new System.Drawing.Point(132, 64);
            this.txtContrasenia.MaxLength = 32767;
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.PasswordChar = '●';
            this.txtContrasenia.PromptText = "Constraseña";
            this.txtContrasenia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContrasenia.SelectedText = "";
            this.txtContrasenia.SelectionLength = 0;
            this.txtContrasenia.SelectionStart = 0;
            this.txtContrasenia.ShortcutsEnabled = true;
            this.txtContrasenia.Size = new System.Drawing.Size(239, 23);
            this.txtContrasenia.TabIndex = 2;
            this.txtContrasenia.UseSelectable = true;
            this.txtContrasenia.UseSystemPasswordChar = true;
            this.txtContrasenia.WaterMark = "Constraseña";
            this.txtContrasenia.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtContrasenia.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtContrasenia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContrasenia_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Framework.Vista.Properties.Resources.Login_Manager_128px;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(4, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 134);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtUsuario.CustomButton.Image = null;
            this.txtUsuario.CustomButton.Location = new System.Drawing.Point(217, 1);
            this.txtUsuario.CustomButton.Name = "";
            this.txtUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsuario.CustomButton.TabIndex = 1;
            this.txtUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsuario.CustomButton.UseSelectable = true;
            this.txtUsuario.CustomButton.Visible = false;
            this.txtUsuario.DisplayIcon = true;
            this.txtUsuario.Icon = global::Framework.Vista.Properties.Resources.user_male_14px;
            this.txtUsuario.Lines = new string[0];
            this.txtUsuario.Location = new System.Drawing.Point(132, 25);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.PromptText = "Nombre de Usuario";
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.ShortcutsEnabled = true;
            this.txtUsuario.Size = new System.Drawing.Size(239, 23);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.UseSelectable = true;
            this.txtUsuario.WaterMark = "Nombre de Usuario";
            this.txtUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // pnlError
            // 
            this.pnlError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(211)))), ((int)(((byte)(206)))));
            this.pnlError.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlError.Controls.Add(this.pictureBox2);
            this.pnlError.Controls.Add(this.label2);
            this.pnlError.Controls.Add(this.label1);
            this.pnlError.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlError.HorizontalScrollbarBarColor = false;
            this.pnlError.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlError.HorizontalScrollbarSize = 10;
            this.pnlError.Location = new System.Drawing.Point(20, 60);
            this.pnlError.Name = "pnlError";
            this.pnlError.Size = new System.Drawing.Size(385, 73);
            this.pnlError.Style = MetroFramework.MetroColorStyle.Blue;
            this.pnlError.TabIndex = 4;
            this.pnlError.Tag = "";
            this.pnlError.UseCustomBackColor = true;
            this.pnlError.UseCustomForeColor = true;
            this.pnlError.UseStyleColors = true;
            this.pnlError.VerticalScrollbarBarColor = false;
            this.pnlError.VerticalScrollbarHighlightOnWheel = false;
            this.pnlError.VerticalScrollbarSize = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Framework.Vista.Properties.Resources.high_importance_14px;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(17, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 17);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(12)))), ((int)(((byte)(38)))));
            this.label2.Location = new System.Drawing.Point(14, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre de Usuario y/o contraseña incorrectos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(12)))), ((int)(((byte)(38)))));
            this.label1.Location = new System.Drawing.Point(35, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario no valido";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 317);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.pnlError);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "LoginForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            this.Text = "Login CalzadoSmart";
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlError.ResumeLayout(false);
            this.pnlError.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox txtUsuario;
        private MetroFramework.Controls.MetroTextBox txtContrasenia;
        private MetroFramework.Controls.MetroButton btnIngresar;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroPanel pnlError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}