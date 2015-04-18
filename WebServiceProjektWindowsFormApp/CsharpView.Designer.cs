namespace WebServiceProjektWindowsFormApp
{
    partial class CsharpView
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
            this.openFileBtn = new System.Windows.Forms.Button();
            this.textBoxOpenFile = new System.Windows.Forms.TextBox();
            this.apartmentsBtn = new System.Windows.Forms.Button();
            this.apartmentsComboBox = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cronusDescLbl = new System.Windows.Forms.Label();
            this.headerCronusLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCronus = new System.Windows.Forms.ComboBox();
            this.cronusBtn = new System.Windows.Forms.Button();
            this.dataGridViewCronus = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.firstNameAddEmpTxtBox = new System.Windows.Forms.TextBox();
            this.idAddEmptxtBox = new System.Windows.Forms.TextBox();
            this.addEmpBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.firstNameSearchTxtBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.idSearchTxtBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.updateEmpBtn = new System.Windows.Forms.Button();
            this.deleteEmployeeBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCronus)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileBtn
            // 
            this.openFileBtn.Location = new System.Drawing.Point(492, 137);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(72, 23);
            this.openFileBtn.TabIndex = 0;
            this.openFileBtn.Text = "Bläddra";
            this.openFileBtn.UseVisualStyleBackColor = true;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // textBoxOpenFile
            // 
            this.textBoxOpenFile.Location = new System.Drawing.Point(9, 137);
            this.textBoxOpenFile.Multiline = true;
            this.textBoxOpenFile.Name = "textBoxOpenFile";
            this.textBoxOpenFile.Size = new System.Drawing.Size(477, 146);
            this.textBoxOpenFile.TabIndex = 1;
            // 
            // apartmentsBtn
            // 
            this.apartmentsBtn.Location = new System.Drawing.Point(136, 75);
            this.apartmentsBtn.Name = "apartmentsBtn";
            this.apartmentsBtn.Size = new System.Drawing.Size(93, 23);
            this.apartmentsBtn.TabIndex = 2;
            this.apartmentsBtn.Text = "Visa lägenheter";
            this.apartmentsBtn.UseVisualStyleBackColor = true;
            this.apartmentsBtn.Click += new System.EventHandler(this.apartmentsBtn_Click);
            // 
            // apartmentsComboBox
            // 
            this.apartmentsComboBox.FormattingEnabled = true;
            this.apartmentsComboBox.Location = new System.Drawing.Point(9, 75);
            this.apartmentsComboBox.Name = "apartmentsComboBox";
            this.apartmentsComboBox.Size = new System.Drawing.Size(121, 21);
            this.apartmentsComboBox.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(578, 335);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.apartmentsComboBox);
            this.tabPage1.Controls.Add(this.openFileBtn);
            this.tabPage1.Controls.Add(this.apartmentsBtn);
            this.tabPage1.Controls.Add(this.textBoxOpenFile);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(570, 309);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Webservice 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Sökväg: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ladda objekt från databas samt öppna fil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Uppgift 1 och 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Öppna och ladda fil:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Visa lägenheter:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.cronusDescLbl);
            this.tabPage2.Controls.Add(this.headerCronusLbl);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.comboBoxCronus);
            this.tabPage2.Controls.Add(this.cronusBtn);
            this.tabPage2.Controls.Add(this.dataGridViewCronus);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(570, 309);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cronus";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // cronusDescLbl
            // 
            this.cronusDescLbl.AutoSize = true;
            this.cronusDescLbl.Location = new System.Drawing.Point(6, 31);
            this.cronusDescLbl.Name = "cronusDescLbl";
            this.cronusDescLbl.Size = new System.Drawing.Size(178, 13);
            this.cronusDescLbl.TabIndex = 6;
            this.cronusDescLbl.Text = "Ladda information från NAV databas";
            // 
            // headerCronusLbl
            // 
            this.headerCronusLbl.AutoSize = true;
            this.headerCronusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerCronusLbl.Location = new System.Drawing.Point(6, 15);
            this.headerCronusLbl.Name = "headerCronusLbl";
            this.headerCronusLbl.Size = new System.Drawing.Size(150, 16);
            this.headerCronusLbl.TabIndex = 5;
            this.headerCronusLbl.Text = "Uppgift ERP A och B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Visa information från NAV Databas:";
            // 
            // comboBoxCronus
            // 
            this.comboBoxCronus.FormattingEnabled = true;
            this.comboBoxCronus.Location = new System.Drawing.Point(338, 50);
            this.comboBoxCronus.Name = "comboBoxCronus";
            this.comboBoxCronus.Size = new System.Drawing.Size(161, 21);
            this.comboBoxCronus.TabIndex = 3;
            // 
            // cronusBtn
            // 
            this.cronusBtn.Location = new System.Drawing.Point(505, 50);
            this.cronusBtn.Name = "cronusBtn";
            this.cronusBtn.Size = new System.Drawing.Size(60, 23);
            this.cronusBtn.TabIndex = 1;
            this.cronusBtn.Text = "Visa";
            this.cronusBtn.UseVisualStyleBackColor = true;
            this.cronusBtn.Click += new System.EventHandler(this.cronusBtn_Click);
            // 
            // dataGridViewCronus
            // 
            this.dataGridViewCronus.AllowUserToAddRows = false;
            this.dataGridViewCronus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCronus.Location = new System.Drawing.Point(6, 77);
            this.dataGridViewCronus.Name = "dataGridViewCronus";
            this.dataGridViewCronus.Size = new System.Drawing.Size(558, 226);
            this.dataGridViewCronus.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.clearBtn);
            this.tabPage3.Controls.Add(this.deleteEmployeeBtn);
            this.tabPage3.Controls.Add(this.updateEmpBtn);
            this.tabPage3.Controls.Add(this.firstNameAddEmpTxtBox);
            this.tabPage3.Controls.Add(this.idAddEmptxtBox);
            this.tabPage3.Controls.Add(this.addEmpBtn);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.firstNameSearchTxtBox);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.idSearchTxtBox);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(570, 309);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cronus Personal";
            // 
            // firstNameAddEmpTxtBox
            // 
            this.firstNameAddEmpTxtBox.Location = new System.Drawing.Point(331, 121);
            this.firstNameAddEmpTxtBox.Name = "firstNameAddEmpTxtBox";
            this.firstNameAddEmpTxtBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameAddEmpTxtBox.TabIndex = 10;
            // 
            // idAddEmptxtBox
            // 
            this.idAddEmptxtBox.Location = new System.Drawing.Point(331, 80);
            this.idAddEmptxtBox.Name = "idAddEmptxtBox";
            this.idAddEmptxtBox.Size = new System.Drawing.Size(100, 20);
            this.idAddEmptxtBox.TabIndex = 9;
            // 
            // addEmpBtn
            // 
            this.addEmpBtn.Location = new System.Drawing.Point(331, 168);
            this.addEmpBtn.Name = "addEmpBtn";
            this.addEmpBtn.Size = new System.Drawing.Size(75, 23);
            this.addEmpBtn.TabIndex = 8;
            this.addEmpBtn.Text = "Lägg till";
            this.addEmpBtn.UseVisualStyleBackColor = true;
            this.addEmpBtn.Click += new System.EventHandler(this.addEmp_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Förnamn:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Id:";
            // 
            // firstNameSearchTxtBox
            // 
            this.firstNameSearchTxtBox.Location = new System.Drawing.Point(9, 121);
            this.firstNameSearchTxtBox.Name = "firstNameSearchTxtBox";
            this.firstNameSearchTxtBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameSearchTxtBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sök";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.searchEmp_Click);
            // 
            // idSearchTxtBox
            // 
            this.idSearchTxtBox.Location = new System.Drawing.Point(9, 77);
            this.idSearchTxtBox.Name = "idSearchTxtBox";
            this.idSearchTxtBox.Size = new System.Drawing.Size(100, 20);
            this.idSearchTxtBox.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(288, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Hitta, uppdatera, tabort och lägga till anställd i NAV databas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Personal ERP";
            // 
            // updateEmpBtn
            // 
            this.updateEmpBtn.Location = new System.Drawing.Point(6, 168);
            this.updateEmpBtn.Name = "updateEmpBtn";
            this.updateEmpBtn.Size = new System.Drawing.Size(75, 23);
            this.updateEmpBtn.TabIndex = 11;
            this.updateEmpBtn.Text = "Uppdatera";
            this.updateEmpBtn.UseVisualStyleBackColor = true;
            this.updateEmpBtn.Visible = false;
            this.updateEmpBtn.Click += new System.EventHandler(this.updateEmpBtn_Click);
            // 
            // deleteEmployeeBtn
            // 
            this.deleteEmployeeBtn.Location = new System.Drawing.Point(87, 168);
            this.deleteEmployeeBtn.Name = "deleteEmployeeBtn";
            this.deleteEmployeeBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteEmployeeBtn.TabIndex = 12;
            this.deleteEmployeeBtn.Text = "Ta bort";
            this.deleteEmployeeBtn.UseVisualStyleBackColor = true;
            this.deleteEmployeeBtn.Visible = false;
            this.deleteEmployeeBtn.Click += new System.EventHandler(this.deleteEmployeeBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(115, 105);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 13;
            this.clearBtn.Text = "Rensa fält";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(328, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Id:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(328, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Förnamn:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(253, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "label13";
            // 
            // CsharpView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 342);
            this.Controls.Add(this.tabControl1);
            this.Name = "CsharpView";
            this.Text = "Webservice";
            this.Load += new System.EventHandler(this.CsharpView_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCronus)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openFileBtn;
        private System.Windows.Forms.TextBox textBoxOpenFile;
        private System.Windows.Forms.Button apartmentsBtn;
        private System.Windows.Forms.ComboBox apartmentsComboBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cronusBtn;
        private System.Windows.Forms.DataGridView dataGridViewCronus;
        private System.Windows.Forms.ComboBox comboBoxCronus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label cronusDescLbl;
        private System.Windows.Forms.Label headerCronusLbl;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox firstNameSearchTxtBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox idSearchTxtBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox firstNameAddEmpTxtBox;
        private System.Windows.Forms.TextBox idAddEmptxtBox;
        private System.Windows.Forms.Button addEmpBtn;
        private System.Windows.Forms.Button updateEmpBtn;
        private System.Windows.Forms.Button deleteEmployeeBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
    }
}

