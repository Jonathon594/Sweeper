namespace Sweeper
{
    partial class SweeperControlView
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SweeperControlView));
            mainToolStrip = new ToolStrip();
            fileStripButton = new ToolStripButton();
            optionsStripButton = new ToolStripButton();
            label1 = new Label();
            locationBox = new ComboBox();
            panel1 = new Panel();
            deleteEmptyCheckBox = new CheckBox();
            subfoldersCheckBox = new CheckBox();
            sortButton = new Button();
            panel2 = new Panel();
            containerItems = new SplitContainer();
            treeView = new TreeView();
            extensionsView = new ListView();
            columnExtension = new ColumnHeader();
            columnPath = new ColumnHeader();
            extensionViewContextMenu = new ContextMenuStrip(components);
            addToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            labelStatus = new ToolStripStatusLabel();
            progressBar = new ToolStripProgressBar();
            nodeTreeBuilder = new System.ComponentModel.BackgroundWorker();
            sortWorker = new System.ComponentModel.BackgroundWorker();
            mainToolStrip.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)containerItems).BeginInit();
            containerItems.Panel1.SuspendLayout();
            containerItems.Panel2.SuspendLayout();
            containerItems.SuspendLayout();
            extensionViewContextMenu.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // mainToolStrip
            // 
            mainToolStrip.BackColor = SystemColors.Window;
            mainToolStrip.Font = new Font("Segoe UI", 9F);
            mainToolStrip.GripStyle = ToolStripGripStyle.Hidden;
            mainToolStrip.ImageScalingSize = new Size(20, 20);
            mainToolStrip.Items.AddRange(new ToolStripItem[] { fileStripButton, optionsStripButton });
            mainToolStrip.Location = new Point(0, 0);
            mainToolStrip.Name = "mainToolStrip";
            mainToolStrip.Size = new Size(1340, 27);
            mainToolStrip.TabIndex = 0;
            // 
            // fileStripButton
            // 
            fileStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            fileStripButton.ForeColor = SystemColors.ActiveCaptionText;
            fileStripButton.Image = (Image)resources.GetObject("fileStripButton.Image");
            fileStripButton.ImageTransparentColor = Color.Magenta;
            fileStripButton.Name = "fileStripButton";
            fileStripButton.Size = new Size(36, 24);
            fileStripButton.Text = "File";
            // 
            // optionsStripButton
            // 
            optionsStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            optionsStripButton.ForeColor = SystemColors.ActiveCaptionText;
            optionsStripButton.Image = (Image)resources.GetObject("optionsStripButton.Image");
            optionsStripButton.ImageTransparentColor = Color.Magenta;
            optionsStripButton.Name = "optionsStripButton";
            optionsStripButton.Size = new Size(65, 24);
            optionsStripButton.Text = "Options";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 1;
            label1.Text = "Location:";
            // 
            // locationBox
            // 
            locationBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            locationBox.BackColor = SystemColors.Window;
            locationBox.ForeColor = SystemColors.ActiveCaptionText;
            locationBox.FormattingEnabled = true;
            locationBox.Location = new Point(78, 3);
            locationBox.Name = "locationBox";
            locationBox.Size = new Size(521, 28);
            locationBox.TabIndex = 2;
            locationBox.SelectedIndexChanged += locationBox_SelectedIndexChanged;
            locationBox.TextUpdate += locationBox_TextUpdate;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(deleteEmptyCheckBox);
            panel1.Controls.Add(subfoldersCheckBox);
            panel1.Controls.Add(sortButton);
            panel1.Controls.Add(locationBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(704, 125);
            panel1.TabIndex = 3;
            // 
            // deleteEmptyCheckBox
            // 
            deleteEmptyCheckBox.AutoSize = true;
            deleteEmptyCheckBox.Location = new Point(7, 67);
            deleteEmptyCheckBox.Name = "deleteEmptyCheckBox";
            deleteEmptyCheckBox.Size = new Size(173, 24);
            deleteEmptyCheckBox.TabIndex = 5;
            deleteEmptyCheckBox.Text = "Delete Empty Folders";
            deleteEmptyCheckBox.UseVisualStyleBackColor = true;
            deleteEmptyCheckBox.CheckedChanged += deleteEmptyCheckBox_CheckedChanged;
            // 
            // subfoldersCheckBox
            // 
            subfoldersCheckBox.AutoSize = true;
            subfoldersCheckBox.Location = new Point(7, 37);
            subfoldersCheckBox.Name = "subfoldersCheckBox";
            subfoldersCheckBox.Size = new Size(154, 24);
            subfoldersCheckBox.TabIndex = 4;
            subfoldersCheckBox.Text = "Include Subfolders";
            subfoldersCheckBox.UseVisualStyleBackColor = true;
            subfoldersCheckBox.CheckedChanged += subfoldersCheckBox_CheckedChanged;
            // 
            // sortButton
            // 
            sortButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sortButton.BackColor = SystemColors.Window;
            sortButton.ForeColor = SystemColors.ActiveCaptionText;
            sortButton.Location = new Point(605, 2);
            sortButton.Name = "sortButton";
            sortButton.Size = new Size(94, 29);
            sortButton.TabIndex = 3;
            sortButton.Text = "Sort";
            sortButton.UseVisualStyleBackColor = false;
            sortButton.Click += sortButton_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(722, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(606, 125);
            panel2.TabIndex = 4;
            // 
            // containerItems
            // 
            containerItems.BorderStyle = BorderStyle.FixedSingle;
            containerItems.Location = new Point(12, 161);
            containerItems.Name = "containerItems";
            // 
            // containerItems.Panel1
            // 
            containerItems.Panel1.Controls.Add(treeView);
            // 
            // containerItems.Panel2
            // 
            containerItems.Panel2.Controls.Add(extensionsView);
            containerItems.Size = new Size(1316, 486);
            containerItems.SplitterDistance = 766;
            containerItems.TabIndex = 5;
            // 
            // treeView
            // 
            treeView.Dock = DockStyle.Fill;
            treeView.Location = new Point(0, 0);
            treeView.Name = "treeView";
            treeView.Size = new Size(764, 484);
            treeView.TabIndex = 0;
            treeView.NodeMouseDoubleClick += treeView_NodeMouseDoubleClick;
            // 
            // extensionsView
            // 
            extensionsView.BorderStyle = BorderStyle.None;
            extensionsView.Columns.AddRange(new ColumnHeader[] { columnExtension, columnPath });
            extensionsView.ContextMenuStrip = extensionViewContextMenu;
            extensionsView.Dock = DockStyle.Fill;
            extensionsView.Location = new Point(0, 0);
            extensionsView.Name = "extensionsView";
            extensionsView.Size = new Size(544, 484);
            extensionsView.TabIndex = 0;
            extensionsView.UseCompatibleStateImageBehavior = false;
            extensionsView.View = View.Details;
            extensionsView.MouseDoubleClick += extensionsView_MouseDoubleClick;
            // 
            // columnExtension
            // 
            columnExtension.Text = "Extension";
            columnExtension.Width = 100;
            // 
            // columnPath
            // 
            columnPath.Text = "Path";
            columnPath.Width = 100;
            // 
            // extensionViewContextMenu
            // 
            extensionViewContextMenu.ImageScalingSize = new Size(20, 20);
            extensionViewContextMenu.Items.AddRange(new ToolStripItem[] { addToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem });
            extensionViewContextMenu.Name = "extensionViewContextMenu";
            extensionViewContextMenu.Size = new Size(123, 76);
            extensionViewContextMenu.Opening += extensionViewContextMenu_Opening;
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(122, 24);
            addToolStripMenuItem.Text = "Add";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(122, 24);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(122, 24);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { labelStatus, progressBar });
            statusStrip1.Location = new Point(0, 647);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1340, 26);
            statusStrip1.TabIndex = 6;
            statusStrip1.Text = "statusStrip1";
            // 
            // labelStatus
            // 
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(50, 20);
            labelStatus.Text = "Ready";
            // 
            // progressBar
            // 
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(200, 18);
            // 
            // nodeTreeBuilder
            // 
            nodeTreeBuilder.WorkerReportsProgress = true;
            nodeTreeBuilder.DoWork += searchWorker_DoWork;
            nodeTreeBuilder.ProgressChanged += searchWorker_ProgressChanged;
            nodeTreeBuilder.RunWorkerCompleted += searchWorker_RunWorkerCompleted;
            // 
            // sortWorker
            // 
            sortWorker.WorkerReportsProgress = true;
            sortWorker.DoWork += directoryCacheWorker_DoWork;
            sortWorker.ProgressChanged += sortWorker_ProgressChanged;
            sortWorker.RunWorkerCompleted += sortWorker_RunWorkerCompleted;
            // 
            // SweeperControlView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1340, 673);
            Controls.Add(statusStrip1);
            Controls.Add(containerItems);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(mainToolStrip);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "SweeperControlView";
            Text = "Sweeper";
            Load += Sweeper_Load;
            mainToolStrip.ResumeLayout(false);
            mainToolStrip.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            containerItems.Panel1.ResumeLayout(false);
            containerItems.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)containerItems).EndInit();
            containerItems.ResumeLayout(false);
            extensionViewContextMenu.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip mainToolStrip;
        private ToolStripButton fileStripButton;
        private ToolStripButton optionsStripButton;
        private Label label1;
        private ComboBox locationBox;
        private Panel panel1;
        private Panel panel2;
        private Button sortButton;
        private SplitContainer containerItems;
        private ListView extensionsView;
        private ColumnHeader columnExtension;
        private ColumnHeader columnPath;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar progressBar;
        private TreeView treeView;
        private ToolStripStatusLabel labelStatus;
        private System.ComponentModel.BackgroundWorker nodeTreeBuilder;
        private ContextMenuStrip extensionViewContextMenu;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private CheckBox deleteEmptyCheckBox;
        private CheckBox subfoldersCheckBox;
        private System.ComponentModel.BackgroundWorker sortWorker;
    }
}
