namespace QuanLyThucAn.Console
{
    partial class DoiPassWord
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
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.pasCu = new DevExpress.XtraEditors.TextEdit();
            this.pasMoi1 = new DevExpress.XtraEditors.TextEdit();
            this.pasMoi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lab_status = new DevExpress.XtraEditors.LabelControl();
            this.btn_changer = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasCu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasMoi1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasMoi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(617, 29);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // pasCu
            // 
            this.pasCu.Location = new System.Drawing.Point(83, 90);
            this.pasCu.Name = "pasCu";
            this.pasCu.Properties.UseSystemPasswordChar = true;
            this.pasCu.Size = new System.Drawing.Size(469, 24);
            this.pasCu.TabIndex = 3;
            // 
            // pasMoi1
            // 
            this.pasMoi1.Location = new System.Drawing.Point(83, 208);
            this.pasMoi1.Name = "pasMoi1";
            this.pasMoi1.Properties.UseSystemPasswordChar = true;
            this.pasMoi1.Size = new System.Drawing.Size(469, 24);
            this.pasMoi1.TabIndex = 4;
            this.pasMoi1.TextChanged += new System.EventHandler(this.pasMoi1_TextChanged);
            // 
            // pasMoi
            // 
            this.pasMoi.Location = new System.Drawing.Point(83, 149);
            this.pasMoi.Name = "pasMoi";
            this.pasMoi.Properties.UseSystemPasswordChar = true;
            this.pasMoi.Size = new System.Drawing.Size(469, 24);
            this.pasMoi.TabIndex = 5;
            this.pasMoi.TextChanged += new System.EventHandler(this.pasMoi1_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(83, 67);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(78, 17);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Mật khẩu cũ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(83, 126);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(88, 17);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Mật khẩu mới";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(83, 185);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(144, 17);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Nhập lại Mật khẩu mới";
            // 
            // lab_status
            // 
            this.lab_status.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lab_status.Appearance.Options.UseForeColor = true;
            this.lab_status.Location = new System.Drawing.Point(83, 248);
            this.lab_status.Name = "lab_status";
            this.lab_status.Size = new System.Drawing.Size(0, 17);
            this.lab_status.TabIndex = 9;
            // 
            // btn_changer
            // 
            this.btn_changer.Location = new System.Drawing.Point(430, 238);
            this.btn_changer.Name = "btn_changer";
            this.btn_changer.Size = new System.Drawing.Size(122, 37);
            this.btn_changer.TabIndex = 10;
            this.btn_changer.Text = "Đổi mật khẩu";
            this.btn_changer.Click += new System.EventHandler(this.btn_changer_Click);
            // 
            // DoiPassWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 330);
            this.Controls.Add(this.btn_changer);
            this.Controls.Add(this.lab_status);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pasMoi);
            this.Controls.Add(this.pasMoi1);
            this.Controls.Add(this.pasCu);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "DoiPassWord";
            this.Text = "DoiPassWord";
            this.Load += new System.EventHandler(this.DoiPassWord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasCu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasMoi1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasMoi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit pasMoi;
        private DevExpress.XtraEditors.TextEdit pasMoi1;
        private DevExpress.XtraEditors.TextEdit pasCu;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lab_status;
        private DevExpress.XtraEditors.SimpleButton btn_changer;
    }
}