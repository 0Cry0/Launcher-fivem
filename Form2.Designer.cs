
namespace Germany_Life_vRP
{
    partial class Form2
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Label1 = new MetroFramework.Controls.MetroLabel();
            this.Label2 = new MetroFramework.Controls.MetroLabel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox1.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.metroTextBox1.Location = new System.Drawing.Point(194, 415);
            this.metroTextBox1.Multiline = false;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.Size = new System.Drawing.Size(413, 23);
            this.metroTextBox1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTextBox1.StyleManager = null;
            this.metroTextBox1.TabIndex = 11;
            this.metroTextBox1.Text = "This Launcher developed by NOerror#1776, Copyright to UC";
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox1.UseStyleColors = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(340, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 196);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.FontSize = MetroFramework.MetroProgressBarSize.Medium;
            this.metroProgressBar1.FontWeight = MetroFramework.MetroProgressBarWeight.Light;
            this.metroProgressBar1.HideProgressText = true;
            this.metroProgressBar1.Location = new System.Drawing.Point(237, 336);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.metroProgressBar1.Size = new System.Drawing.Size(338, 23);
            this.metroProgressBar1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroProgressBar1.StyleManager = null;
            this.metroProgressBar1.TabIndex = 13;
            this.metroProgressBar1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroProgressBar1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.CustomBackground = false;
            this.Label1.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.Label1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.Label1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.Label1.Location = new System.Drawing.Point(12, 378);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(38, 19);
            this.Label1.Style = MetroFramework.MetroColorStyle.Silver;
            this.Label1.StyleManager = null;
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Time";
            this.Label1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Label1.UseStyleColors = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.CustomBackground = false;
            this.Label2.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.Label2.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.Label2.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.Label2.Location = new System.Drawing.Point(12, 415);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(36, 19);
            this.Label2.Style = MetroFramework.MetroColorStyle.Silver;
            this.Label2.StyleManager = null;
            this.Label2.TabIndex = 15;
            this.Label2.Text = "Date";
            this.Label2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Label2.UseStyleColors = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Germany Life vRP";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroLabel Label1;
        private MetroFramework.Controls.MetroLabel Label2;
        private System.Windows.Forms.Timer timer2;
    }
}

