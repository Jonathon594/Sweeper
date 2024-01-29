namespace Sweeper
{
    partial class ExtensionDialog
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
            labelExtension = new Label();
            labelPath = new Label();
            textboxExtension = new TextBox();
            textboxPath = new TextBox();
            buttonConfirm = new Button();
            SuspendLayout();
            // 
            // labelExtension
            // 
            labelExtension.AutoSize = true;
            labelExtension.Location = new Point(12, 15);
            labelExtension.Name = "labelExtension";
            labelExtension.Size = new Size(75, 20);
            labelExtension.TabIndex = 0;
            labelExtension.Text = "Extension:";
            // 
            // labelPath
            // 
            labelPath.AutoSize = true;
            labelPath.Location = new Point(47, 48);
            labelPath.Name = "labelPath";
            labelPath.Size = new Size(40, 20);
            labelPath.TabIndex = 1;
            labelPath.Text = "Path:";
            // 
            // textboxExtension
            // 
            textboxExtension.Location = new Point(93, 12);
            textboxExtension.Name = "textboxExtension";
            textboxExtension.Size = new Size(217, 27);
            textboxExtension.TabIndex = 2;
            textboxExtension.TextChanged += textboxExtension_TextChanged;
            // 
            // textboxPath
            // 
            textboxPath.Location = new Point(93, 45);
            textboxPath.Name = "textboxPath";
            textboxPath.Size = new Size(217, 27);
            textboxPath.TabIndex = 3;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Location = new Point(216, 78);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(94, 29);
            buttonConfirm.TabIndex = 4;
            buttonConfirm.Text = "Add";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // ExtensionDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 116);
            Controls.Add(buttonConfirm);
            Controls.Add(textboxPath);
            Controls.Add(textboxExtension);
            Controls.Add(labelPath);
            Controls.Add(labelExtension);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ExtensionDialog";
            Text = "Extension Editor";
            Load += ExtensionDialog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelExtension;
        private Label labelPath;
        private TextBox textboxExtension;
        private TextBox textboxPath;
        private Button buttonConfirm;
    }
}