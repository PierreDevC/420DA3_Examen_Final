namespace _420DA3_Examen_Final.Presentation;

partial class EtudiantView
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
        this.topBar = new Panel();
        this.bottomBar = new Panel();
        this.quitButton = new Button();
        this.centerTLP = new TableLayoutPanel();
        this.leftPanel = new Panel();
        this.searchEtudiantTLP = new TableLayoutPanel();
        this.searchEtudiantPanel = new Panel();
        this.searchResultsListBox = new ListBox();
        this.searchEtudiantsTextBox = new TextBox();
        this.tableLayoutPanel1 = new TableLayoutPanel();
        this.createEtudiantButtonPanel = new Panel();
        this.createEtudiantButton = new Button();
        this.EtudiantsManagementHeader = new Label();
        this.rightPanel = new Panel();
        this.actionButtonsTLP = new TableLayoutPanel();
        this.deleteButtonPanel = new Panel();
        this.deleteButton = new Button();
        this.panel2 = new Panel();
        this.actionButtonPanel = new Panel();
        this.actionButton = new Button();
        this.coursesGroupBox = new GroupBox();
        this.etudiantsCoursesValues = new ListBox();
        this.etudiantManagementBox = new GroupBox();
        this.lastNameValue = new TextBox();
        this.firstNameValue = new TextBox();
        this.idValue = new NumericUpDown();
        this.lastNameLabel = new Label();
        this.firstNameLabel = new Label();
        this.idLabel = new Label();
        this.EtudiantManagementHeader = new Label();
        this.bottomBar.SuspendLayout();
        this.centerTLP.SuspendLayout();
        this.leftPanel.SuspendLayout();
        this.searchEtudiantTLP.SuspendLayout();
        this.searchEtudiantPanel.SuspendLayout();
        this.tableLayoutPanel1.SuspendLayout();
        this.createEtudiantButtonPanel.SuspendLayout();
        this.rightPanel.SuspendLayout();
        this.actionButtonsTLP.SuspendLayout();
        this.deleteButtonPanel.SuspendLayout();
        this.actionButtonPanel.SuspendLayout();
        this.coursesGroupBox.SuspendLayout();
        this.etudiantManagementBox.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)this.idValue).BeginInit();
        this.SuspendLayout();
        // 
        // topBar
        // 
        this.topBar.Dock = DockStyle.Top;
        this.topBar.Location = new Point(0, 0);
        this.topBar.Name = "topBar";
        this.topBar.Size = new Size(984, 50);
        this.topBar.TabIndex = 0;
        // 
        // bottomBar
        // 
        this.bottomBar.Controls.Add(this.quitButton);
        this.bottomBar.Dock = DockStyle.Bottom;
        this.bottomBar.Location = new Point(0, 511);
        this.bottomBar.Name = "bottomBar";
        this.bottomBar.Size = new Size(984, 50);
        this.bottomBar.TabIndex = 1;
        // 
        // quitButton
        // 
        this.quitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        this.quitButton.Location = new Point(875, 15);
        this.quitButton.Name = "quitButton";
        this.quitButton.Size = new Size(97, 23);
        this.quitButton.TabIndex = 0;
        this.quitButton.Text = "Quitter";
        this.quitButton.UseVisualStyleBackColor = true;
        this.quitButton.Click += this.quitButton_Click;
        // 
        // centerTLP
        // 
        this.centerTLP.ColumnCount = 4;
        this.centerTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.centerTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 400F));
        this.centerTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 400F));
        this.centerTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.centerTLP.Controls.Add(this.leftPanel, 1, 0);
        this.centerTLP.Controls.Add(this.rightPanel, 2, 0);
        this.centerTLP.Dock = DockStyle.Fill;
        this.centerTLP.Location = new Point(0, 50);
        this.centerTLP.Name = "centerTLP";
        this.centerTLP.RowCount = 1;
        this.centerTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.centerTLP.Size = new Size(984, 461);
        this.centerTLP.TabIndex = 2;
        // 
        // leftPanel
        // 
        this.leftPanel.Controls.Add(this.searchEtudiantTLP);
        this.leftPanel.Controls.Add(this.tableLayoutPanel1);
        this.leftPanel.Controls.Add(this.EtudiantsManagementHeader);
        this.leftPanel.Dock = DockStyle.Fill;
        this.leftPanel.Location = new Point(95, 3);
        this.leftPanel.Name = "leftPanel";
        this.leftPanel.Size = new Size(394, 455);
        this.leftPanel.TabIndex = 0;
        // 
        // searchEtudiantTLP
        // 
        this.searchEtudiantTLP.ColumnCount = 3;
        this.searchEtudiantTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.searchEtudiantTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
        this.searchEtudiantTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.searchEtudiantTLP.Controls.Add(this.searchEtudiantPanel, 1, 0);
        this.searchEtudiantTLP.Dock = DockStyle.Fill;
        this.searchEtudiantTLP.Location = new Point(0, 100);
        this.searchEtudiantTLP.Name = "searchEtudiantTLP";
        this.searchEtudiantTLP.RowCount = 1;
        this.searchEtudiantTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.searchEtudiantTLP.Size = new Size(394, 355);
        this.searchEtudiantTLP.TabIndex = 2;
        // 
        // searchEtudiantPanel
        // 
        this.searchEtudiantPanel.Controls.Add(this.searchResultsListBox);
        this.searchEtudiantPanel.Controls.Add(this.searchEtudiantsTextBox);
        this.searchEtudiantPanel.Dock = DockStyle.Fill;
        this.searchEtudiantPanel.Location = new Point(50, 3);
        this.searchEtudiantPanel.Name = "searchEtudiantPanel";
        this.searchEtudiantPanel.Size = new Size(294, 349);
        this.searchEtudiantPanel.TabIndex = 0;
        // 
        // searchResultsListBox
        // 
        this.searchResultsListBox.Dock = DockStyle.Fill;
        this.searchResultsListBox.FormattingEnabled = true;
        this.searchResultsListBox.ItemHeight = 15;
        this.searchResultsListBox.Location = new Point(0, 23);
        this.searchResultsListBox.Name = "searchResultsListBox";
        this.searchResultsListBox.Size = new Size(294, 326);
        this.searchResultsListBox.TabIndex = 1;
        this.searchResultsListBox.SelectedIndexChanged += this.searchResultsListBox_SelectedIndexChanged;
        // 
        // searchEtudiantsTextBox
        // 
        this.searchEtudiantsTextBox.Dock = DockStyle.Top;
        this.searchEtudiantsTextBox.Location = new Point(0, 0);
        this.searchEtudiantsTextBox.Name = "searchEtudiantsTextBox";
        this.searchEtudiantsTextBox.PlaceholderText = "Rechercher un étudiant";
        this.searchEtudiantsTextBox.Size = new Size(294, 23);
        this.searchEtudiantsTextBox.TabIndex = 0;
        this.searchEtudiantsTextBox.TextChanged += this.searchEtudiantsTextBox_TextChanged;
        // 
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.ColumnCount = 3;
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel1.Controls.Add(this.createEtudiantButtonPanel, 1, 0);
        this.tableLayoutPanel1.Dock = DockStyle.Top;
        this.tableLayoutPanel1.Location = new Point(0, 40);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 1;
        this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tableLayoutPanel1.Size = new Size(394, 60);
        this.tableLayoutPanel1.TabIndex = 1;
        // 
        // createEtudiantButtonPanel
        // 
        this.createEtudiantButtonPanel.Controls.Add(this.createEtudiantButton);
        this.createEtudiantButtonPanel.Dock = DockStyle.Fill;
        this.createEtudiantButtonPanel.Location = new Point(100, 3);
        this.createEtudiantButtonPanel.Name = "createEtudiantButtonPanel";
        this.createEtudiantButtonPanel.Size = new Size(194, 54);
        this.createEtudiantButtonPanel.TabIndex = 0;
        // 
        // createEtudiantButton
        // 
        this.createEtudiantButton.Location = new Point(3, 3);
        this.createEtudiantButton.Name = "createEtudiantButton";
        this.createEtudiantButton.Size = new Size(188, 48);
        this.createEtudiantButton.TabIndex = 0;
        this.createEtudiantButton.Text = "Créer un nouvel étudiant";
        this.createEtudiantButton.UseVisualStyleBackColor = true;
        this.createEtudiantButton.Click += this.createEtudiantButton_Click;
        // 
        // EtudiantsManagementHeader
        // 
        this.EtudiantsManagementHeader.Dock = DockStyle.Top;
        this.EtudiantsManagementHeader.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        this.EtudiantsManagementHeader.Location = new Point(0, 0);
        this.EtudiantsManagementHeader.Name = "EtudiantsManagementHeader";
        this.EtudiantsManagementHeader.Size = new Size(394, 40);
        this.EtudiantsManagementHeader.TabIndex = 0;
        this.EtudiantsManagementHeader.Text = "Gestion des étudiants";
        this.EtudiantsManagementHeader.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // rightPanel
        // 
        this.rightPanel.Controls.Add(this.actionButtonsTLP);
        this.rightPanel.Controls.Add(this.coursesGroupBox);
        this.rightPanel.Controls.Add(this.etudiantManagementBox);
        this.rightPanel.Controls.Add(this.EtudiantManagementHeader);
        this.rightPanel.Dock = DockStyle.Fill;
        this.rightPanel.Location = new Point(495, 3);
        this.rightPanel.Name = "rightPanel";
        this.rightPanel.Size = new Size(394, 455);
        this.rightPanel.TabIndex = 1;
        // 
        // actionButtonsTLP
        // 
        this.actionButtonsTLP.ColumnCount = 4;
        this.actionButtonsTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.actionButtonsTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
        this.actionButtonsTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
        this.actionButtonsTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.actionButtonsTLP.Controls.Add(this.deleteButtonPanel, 2, 0);
        this.actionButtonsTLP.Controls.Add(this.panel2, 0, 0);
        this.actionButtonsTLP.Controls.Add(this.actionButtonPanel, 1, 0);
        this.actionButtonsTLP.Dock = DockStyle.Top;
        this.actionButtonsTLP.Location = new Point(0, 384);
        this.actionButtonsTLP.Name = "actionButtonsTLP";
        this.actionButtonsTLP.RowCount = 1;
        this.actionButtonsTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.actionButtonsTLP.Size = new Size(394, 68);
        this.actionButtonsTLP.TabIndex = 4;
        // 
        // deleteButtonPanel
        // 
        this.deleteButtonPanel.Controls.Add(this.deleteButton);
        this.deleteButtonPanel.Dock = DockStyle.Fill;
        this.deleteButtonPanel.Location = new Point(200, 3);
        this.deleteButtonPanel.Name = "deleteButtonPanel";
        this.deleteButtonPanel.Size = new Size(144, 62);
        this.deleteButtonPanel.TabIndex = 2;
        // 
        // deleteButton
        // 
        this.deleteButton.Enabled = false;
        this.deleteButton.Location = new Point(3, 3);
        this.deleteButton.Name = "deleteButton";
        this.deleteButton.Size = new Size(138, 56);
        this.deleteButton.TabIndex = 0;
        this.deleteButton.Text = "Supprimer un étudiant";
        this.deleteButton.UseVisualStyleBackColor = true;
        this.deleteButton.Click += this.deleteButton_Click;
        // 
        // panel2
        // 
        this.panel2.Dock = DockStyle.Fill;
        this.panel2.Location = new Point(3, 3);
        this.panel2.Name = "panel2";
        this.panel2.Size = new Size(41, 62);
        this.panel2.TabIndex = 1;
        // 
        // actionButtonPanel
        // 
        this.actionButtonPanel.Controls.Add(this.actionButton);
        this.actionButtonPanel.Dock = DockStyle.Fill;
        this.actionButtonPanel.Location = new Point(50, 3);
        this.actionButtonPanel.Name = "actionButtonPanel";
        this.actionButtonPanel.Size = new Size(144, 62);
        this.actionButtonPanel.TabIndex = 0;
        // 
        // actionButton
        // 
        this.actionButton.Enabled = false;
        this.actionButton.Location = new Point(3, 3);
        this.actionButton.Name = "actionButton";
        this.actionButton.Size = new Size(138, 56);
        this.actionButton.TabIndex = 0;
        this.actionButton.Text = "PLACEHOLDER";
        this.actionButton.UseVisualStyleBackColor = true;
        this.actionButton.Click += this.actionButton_Click;
        // 
        // coursesGroupBox
        // 
        this.coursesGroupBox.Controls.Add(this.etudiantsCoursesValues);
        this.coursesGroupBox.Dock = DockStyle.Top;
        this.coursesGroupBox.Location = new Point(0, 211);
        this.coursesGroupBox.Name = "coursesGroupBox";
        this.coursesGroupBox.Size = new Size(394, 173);
        this.coursesGroupBox.TabIndex = 3;
        this.coursesGroupBox.TabStop = false;
        this.coursesGroupBox.Text = "Cours de l'étudiant";
        // 
        // etudiantsCoursesValues
        // 
        this.etudiantsCoursesValues.FormattingEnabled = true;
        this.etudiantsCoursesValues.ItemHeight = 15;
        this.etudiantsCoursesValues.Location = new Point(0, 32);
        this.etudiantsCoursesValues.Name = "etudiantsCoursesValues";
        this.etudiantsCoursesValues.SelectionMode = SelectionMode.MultiSimple;
        this.etudiantsCoursesValues.Size = new Size(388, 139);
        this.etudiantsCoursesValues.TabIndex = 0;
        // 
        // etudiantManagementBox
        // 
        this.etudiantManagementBox.Controls.Add(this.lastNameValue);
        this.etudiantManagementBox.Controls.Add(this.firstNameValue);
        this.etudiantManagementBox.Controls.Add(this.idValue);
        this.etudiantManagementBox.Controls.Add(this.lastNameLabel);
        this.etudiantManagementBox.Controls.Add(this.firstNameLabel);
        this.etudiantManagementBox.Controls.Add(this.idLabel);
        this.etudiantManagementBox.Dock = DockStyle.Top;
        this.etudiantManagementBox.Location = new Point(0, 40);
        this.etudiantManagementBox.Name = "etudiantManagementBox";
        this.etudiantManagementBox.Size = new Size(394, 171);
        this.etudiantManagementBox.TabIndex = 2;
        this.etudiantManagementBox.TabStop = false;
        this.etudiantManagementBox.Text = "Détails de l'étudiant";
        // 
        // lastNameValue
        // 
        this.lastNameValue.Location = new Point(182, 126);
        this.lastNameValue.Name = "lastNameValue";
        this.lastNameValue.PlaceholderText = "Nom de l'étudiant";
        this.lastNameValue.Size = new Size(206, 23);
        this.lastNameValue.TabIndex = 5;
        // 
        // firstNameValue
        // 
        this.firstNameValue.Location = new Point(182, 92);
        this.firstNameValue.Name = "firstNameValue";
        this.firstNameValue.PlaceholderText = "Prénom de l'étudiant";
        this.firstNameValue.Size = new Size(206, 23);
        this.firstNameValue.TabIndex = 4;
        // 
        // idValue
        // 
        this.idValue.Enabled = false;
        this.idValue.Location = new Point(182, 58);
        this.idValue.Maximum = new decimal(new int[] { -1539607552, 11, 0, 0 });
        this.idValue.Name = "idValue";
        this.idValue.Size = new Size(206, 23);
        this.idValue.TabIndex = 3;
        // 
        // lastNameLabel
        // 
        this.lastNameLabel.Location = new Point(44, 124);
        this.lastNameLabel.Margin = new Padding(5);
        this.lastNameLabel.Name = "lastNameLabel";
        this.lastNameLabel.Size = new Size(130, 23);
        this.lastNameLabel.TabIndex = 2;
        this.lastNameLabel.Text = "Nom :";
        this.lastNameLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // firstNameLabel
        // 
        this.firstNameLabel.Location = new Point(44, 91);
        this.firstNameLabel.Margin = new Padding(5);
        this.firstNameLabel.Name = "firstNameLabel";
        this.firstNameLabel.Size = new Size(130, 23);
        this.firstNameLabel.TabIndex = 1;
        this.firstNameLabel.Text = "Prénom :";
        this.firstNameLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // idLabel
        // 
        this.idLabel.Location = new Point(44, 58);
        this.idLabel.Margin = new Padding(5);
        this.idLabel.Name = "idLabel";
        this.idLabel.Size = new Size(130, 23);
        this.idLabel.TabIndex = 0;
        this.idLabel.Text = "ID : ";
        this.idLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // EtudiantManagementHeader
        // 
        this.EtudiantManagementHeader.Dock = DockStyle.Top;
        this.EtudiantManagementHeader.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        this.EtudiantManagementHeader.Location = new Point(0, 0);
        this.EtudiantManagementHeader.Name = "EtudiantManagementHeader";
        this.EtudiantManagementHeader.Size = new Size(394, 40);
        this.EtudiantManagementHeader.TabIndex = 1;
        this.EtudiantManagementHeader.Text = "Gestion d'un étudiant";
        this.EtudiantManagementHeader.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // EtudiantView
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(984, 561);
        this.Controls.Add(this.centerTLP);
        this.Controls.Add(this.bottomBar);
        this.Controls.Add(this.topBar);
        this.MinimumSize = new Size(1000, 600);
        this.Name = "EtudiantView";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Gestion des étudiants";
        this.bottomBar.ResumeLayout(false);
        this.centerTLP.ResumeLayout(false);
        this.leftPanel.ResumeLayout(false);
        this.searchEtudiantTLP.ResumeLayout(false);
        this.searchEtudiantPanel.ResumeLayout(false);
        this.searchEtudiantPanel.PerformLayout();
        this.tableLayoutPanel1.ResumeLayout(false);
        this.createEtudiantButtonPanel.ResumeLayout(false);
        this.rightPanel.ResumeLayout(false);
        this.actionButtonsTLP.ResumeLayout(false);
        this.deleteButtonPanel.ResumeLayout(false);
        this.actionButtonPanel.ResumeLayout(false);
        this.coursesGroupBox.ResumeLayout(false);
        this.etudiantManagementBox.ResumeLayout(false);
        this.etudiantManagementBox.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)this.idValue).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private Panel topBar;
    private Panel bottomBar;
    private TableLayoutPanel centerTLP;
    private Panel leftPanel;
    private TableLayoutPanel searchEtudiantTLP;
    private Panel searchEtudiantPanel;
    private TableLayoutPanel tableLayoutPanel1;
    private Panel createEtudiantButtonPanel;
    private Button createEtudiantButton;
    private Label EtudiantsManagementHeader;
    private Panel rightPanel;
    private Label EtudiantManagementHeader;
    private ListBox searchResultsListBox;
    private TextBox searchEtudiantsTextBox;
    private GroupBox coursesGroupBox;
    private GroupBox etudiantManagementBox;
    private NumericUpDown idValue;
    private Label lastNameLabel;
    private Label firstNameLabel;
    private Label idLabel;
    private Button quitButton;
    private TableLayoutPanel actionButtonsTLP;
    private Panel actionButtonPanel;
    private Button actionButton;
    private ListBox etudiantsCoursesValues;
    private TextBox lastNameValue;
    private TextBox firstNameValue;
    private Panel deleteButtonPanel;
    private Button deleteButton;
    private Panel panel2;
}