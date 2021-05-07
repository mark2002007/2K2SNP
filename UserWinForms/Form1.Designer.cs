
namespace UserWinForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Units_Tab = new System.Windows.Forms.TabControl();
            this.Authors_tab = new System.Windows.Forms.TabPage();
            this.Authors_dataGrid = new System.Windows.Forms.DataGridView();
            this.Books_tab = new System.Windows.Forms.TabPage();
            this.Books_dataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Controls_Panel = new System.Windows.Forms.Panel();
            this.Fields_Panel = new System.Windows.Forms.Panel();
            this.ID_label = new System.Windows.Forms.Label();
            this.ID_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Field5 = new System.Windows.Forms.TextBox();
            this.Field4 = new System.Windows.Forms.TextBox();
            this.Field3 = new System.Windows.Forms.TextBox();
            this.Field2 = new System.Windows.Forms.TextBox();
            this.Field1 = new System.Windows.Forms.TextBox();
            this.Buttons_Panel = new System.Windows.Forms.Panel();
            this.Refresh_button = new System.Windows.Forms.Button();
            this.Remove_button = new System.Windows.Forms.Button();
            this.Units_Tab.SuspendLayout();
            this.Authors_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Authors_dataGrid)).BeginInit();
            this.Books_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Books_dataGrid)).BeginInit();
            this.Controls_Panel.SuspendLayout();
            this.Fields_Panel.SuspendLayout();
            this.Buttons_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Units_Tab
            // 
            this.Units_Tab.Controls.Add(this.Authors_tab);
            this.Units_Tab.Controls.Add(this.Books_tab);
            this.Units_Tab.Dock = System.Windows.Forms.DockStyle.Top;
            this.Units_Tab.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Units_Tab.Location = new System.Drawing.Point(0, 0);
            this.Units_Tab.Name = "Units_Tab";
            this.Units_Tab.SelectedIndex = 0;
            this.Units_Tab.Size = new System.Drawing.Size(1018, 646);
            this.Units_Tab.TabIndex = 1;
            this.Units_Tab.SelectedIndexChanged += new System.EventHandler(this.Units_Tab_SelectedIndexChanged);
            // 
            // Authors_tab
            // 
            this.Authors_tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Authors_tab.Controls.Add(this.Authors_dataGrid);
            this.Authors_tab.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Authors_tab.Location = new System.Drawing.Point(4, 37);
            this.Authors_tab.Name = "Authors_tab";
            this.Authors_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Authors_tab.Size = new System.Drawing.Size(1010, 605);
            this.Authors_tab.TabIndex = 1;
            this.Authors_tab.Text = "Authors";
            // 
            // Authors_dataGrid
            // 
            this.Authors_dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Authors_dataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.Authors_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Authors_dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Authors_dataGrid.Location = new System.Drawing.Point(3, 3);
            this.Authors_dataGrid.MultiSelect = false;
            this.Authors_dataGrid.Name = "Authors_dataGrid";
            this.Authors_dataGrid.RowHeadersWidth = 62;
            this.Authors_dataGrid.RowTemplate.Height = 33;
            this.Authors_dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Authors_dataGrid.Size = new System.Drawing.Size(1004, 599);
            this.Authors_dataGrid.TabIndex = 2;
            this.Authors_dataGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Authors_dataGrid_KeyDown);
            // 
            // Books_tab
            // 
            this.Books_tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Books_tab.Controls.Add(this.Books_dataGrid);
            this.Books_tab.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Books_tab.Location = new System.Drawing.Point(4, 37);
            this.Books_tab.Name = "Books_tab";
            this.Books_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Books_tab.Size = new System.Drawing.Size(1010, 605);
            this.Books_tab.TabIndex = 0;
            this.Books_tab.Text = "Books";
            // 
            // Books_dataGrid
            // 
            this.Books_dataGrid.AllowUserToOrderColumns = true;
            this.Books_dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Books_dataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.Books_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Books_dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Books_dataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.Books_dataGrid.Location = new System.Drawing.Point(3, 3);
            this.Books_dataGrid.MultiSelect = false;
            this.Books_dataGrid.Name = "Books_dataGrid";
            this.Books_dataGrid.RowHeadersWidth = 62;
            this.Books_dataGrid.RowTemplate.Height = 33;
            this.Books_dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Books_dataGrid.Size = new System.Drawing.Size(1004, 599);
            this.Books_dataGrid.TabIndex = 0;
            this.Books_dataGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Books_dataGrid_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // Add_Button
            // 
            this.Add_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Add_Button.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Add_Button.Location = new System.Drawing.Point(0, 0);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(232, 63);
            this.Add_Button.TabIndex = 2;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = false;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Controls_Panel
            // 
            this.Controls_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.Controls_Panel.Controls.Add(this.Fields_Panel);
            this.Controls_Panel.Controls.Add(this.Buttons_Panel);
            this.Controls_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Controls_Panel.Location = new System.Drawing.Point(0, 652);
            this.Controls_Panel.Name = "Controls_Panel";
            this.Controls_Panel.Size = new System.Drawing.Size(1018, 131);
            this.Controls_Panel.TabIndex = 4;
            // 
            // Fields_Panel
            // 
            this.Fields_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.Fields_Panel.Controls.Add(this.ID_label);
            this.Fields_Panel.Controls.Add(this.ID_textBox);
            this.Fields_Panel.Controls.Add(this.label5);
            this.Fields_Panel.Controls.Add(this.label4);
            this.Fields_Panel.Controls.Add(this.label3);
            this.Fields_Panel.Controls.Add(this.label2);
            this.Fields_Panel.Controls.Add(this.label1);
            this.Fields_Panel.Controls.Add(this.Field5);
            this.Fields_Panel.Controls.Add(this.Field4);
            this.Fields_Panel.Controls.Add(this.Field3);
            this.Fields_Panel.Controls.Add(this.Field2);
            this.Fields_Panel.Controls.Add(this.Field1);
            this.Fields_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Fields_Panel.Location = new System.Drawing.Point(0, 0);
            this.Fields_Panel.Name = "Fields_Panel";
            this.Fields_Panel.Size = new System.Drawing.Size(778, 131);
            this.Fields_Panel.TabIndex = 5;
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ID_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ID_label.Location = new System.Drawing.Point(704, 82);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(32, 23);
            this.ID_label.TabIndex = 11;
            this.ID_label.Text = "ID";
            // 
            // ID_textBox
            // 
            this.ID_textBox.Location = new System.Drawing.Point(740, 79);
            this.ID_textBox.Name = "ID_textBox";
            this.ID_textBox.Size = new System.Drawing.Size(33, 31);
            this.ID_textBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label5.Location = new System.Drawing.Point(624, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label4.Location = new System.Drawing.Point(469, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label3.Location = new System.Drawing.Point(314, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label2.Location = new System.Drawing.Point(159, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // Field5
            // 
            this.Field5.Location = new System.Drawing.Point(624, 32);
            this.Field5.Name = "Field5";
            this.Field5.Size = new System.Drawing.Size(149, 31);
            this.Field5.TabIndex = 4;
            // 
            // Field4
            // 
            this.Field4.Location = new System.Drawing.Point(469, 32);
            this.Field4.Name = "Field4";
            this.Field4.Size = new System.Drawing.Size(149, 31);
            this.Field4.TabIndex = 3;
            // 
            // Field3
            // 
            this.Field3.Location = new System.Drawing.Point(314, 32);
            this.Field3.Name = "Field3";
            this.Field3.Size = new System.Drawing.Size(149, 31);
            this.Field3.TabIndex = 2;
            // 
            // Field2
            // 
            this.Field2.Location = new System.Drawing.Point(159, 32);
            this.Field2.Name = "Field2";
            this.Field2.Size = new System.Drawing.Size(149, 31);
            this.Field2.TabIndex = 1;
            // 
            // Field1
            // 
            this.Field1.Location = new System.Drawing.Point(4, 32);
            this.Field1.Name = "Field1";
            this.Field1.Size = new System.Drawing.Size(149, 31);
            this.Field1.TabIndex = 0;
            // 
            // Buttons_Panel
            // 
            this.Buttons_Panel.Controls.Add(this.Refresh_button);
            this.Buttons_Panel.Controls.Add(this.Remove_button);
            this.Buttons_Panel.Controls.Add(this.Add_Button);
            this.Buttons_Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.Buttons_Panel.Location = new System.Drawing.Point(779, 0);
            this.Buttons_Panel.Name = "Buttons_Panel";
            this.Buttons_Panel.Size = new System.Drawing.Size(239, 131);
            this.Buttons_Panel.TabIndex = 4;
            // 
            // Refresh_button
            // 
            this.Refresh_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Refresh_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Refresh_button.BackgroundImage")));
            this.Refresh_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Refresh_button.Location = new System.Drawing.Point(177, 69);
            this.Refresh_button.Name = "Refresh_button";
            this.Refresh_button.Size = new System.Drawing.Size(55, 55);
            this.Refresh_button.TabIndex = 4;
            this.Refresh_button.UseVisualStyleBackColor = false;
            this.Refresh_button.Click += new System.EventHandler(this.Refresh_button_Click);
            // 
            // Remove_button
            // 
            this.Remove_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Remove_button.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Remove_button.Location = new System.Drawing.Point(0, 69);
            this.Remove_button.Name = "Remove_button";
            this.Remove_button.Size = new System.Drawing.Size(171, 55);
            this.Remove_button.TabIndex = 3;
            this.Remove_button.Text = "Remove";
            this.Remove_button.UseVisualStyleBackColor = false;
            this.Remove_button.Click += new System.EventHandler(this.Remove_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1018, 783);
            this.Controls.Add(this.Units_Tab);
            this.Controls.Add(this.Controls_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserWinFormsApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Units_Tab.ResumeLayout(false);
            this.Authors_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Authors_dataGrid)).EndInit();
            this.Books_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Books_dataGrid)).EndInit();
            this.Controls_Panel.ResumeLayout(false);
            this.Fields_Panel.ResumeLayout(false);
            this.Fields_Panel.PerformLayout();
            this.Buttons_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl Units_Tab;
        private System.Windows.Forms.TabPage Books_tab;
        private System.Windows.Forms.TabPage Authors_tab;
        private System.Windows.Forms.DataGridView Books_dataGrid;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Panel Controls_Panel;
        private System.Windows.Forms.Panel Buttons_Panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Fields_Panel;
        private System.Windows.Forms.TextBox Field5;
        private System.Windows.Forms.TextBox Field4;
        private System.Windows.Forms.TextBox Field3;
        private System.Windows.Forms.TextBox Field2;
        private System.Windows.Forms.TextBox Field1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Authors_dataGrid;
        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.TextBox ID_textBox;
        private System.Windows.Forms.Button Remove_button;
        private System.Windows.Forms.Button Refresh_button;
    }
}

