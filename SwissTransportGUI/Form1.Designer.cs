﻿using System;
using System.Windows.Forms;

namespace SwissTransportGUI
{
    partial class Form1
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabSearchConnection = new System.Windows.Forms.TabPage();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.lstVwConnections = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnMinuteOn = new System.Windows.Forms.Button();
            this.btnMinuteBack = new System.Windows.Forms.Button();
            this.btnDayOn = new System.Windows.Forms.Button();
            this.btnDayBack = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btSearchConnection = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.MTxtbxDate = new System.Windows.Forms.MaskedTextBox();
            this.MTxtbxTime = new System.Windows.Forms.MaskedTextBox();
            this.rBArrive = new System.Windows.Forms.RadioButton();
            this.rBGo = new System.Windows.Forms.RadioButton();
            this.cmbBxGoal = new System.Windows.Forms.ComboBox();
            this.cmbBxStart = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabTimetable = new System.Windows.Forms.TabPage();
            this.btShowTimeTable = new System.Windows.Forms.Button();
            this.lblTimeTable = new System.Windows.Forms.Label();
            this.cmbBxTimeTable = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl.SuspendLayout();
            this.tabSearchConnection.SuspendLayout();
            this.tabTimetable.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabSearchConnection);
            this.tabControl.Controls.Add(this.tabTimetable);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(764, 573);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            // 
            // tabSearchConnection
            // 
            this.tabSearchConnection.Controls.Add(this.lblInfo2);
            this.tabSearchConnection.Controls.Add(this.lstVwConnections);
            this.tabSearchConnection.Controls.Add(this.dateTimePicker1);
            this.tabSearchConnection.Controls.Add(this.btnMinuteOn);
            this.tabSearchConnection.Controls.Add(this.btnMinuteBack);
            this.tabSearchConnection.Controls.Add(this.btnDayOn);
            this.tabSearchConnection.Controls.Add(this.btnDayBack);
            this.tabSearchConnection.Controls.Add(this.lblInfo);
            this.tabSearchConnection.Controls.Add(this.btSearchConnection);
            this.tabSearchConnection.Controls.Add(this.lblTime);
            this.tabSearchConnection.Controls.Add(this.lblDate);
            this.tabSearchConnection.Controls.Add(this.MTxtbxDate);
            this.tabSearchConnection.Controls.Add(this.MTxtbxTime);
            this.tabSearchConnection.Controls.Add(this.rBArrive);
            this.tabSearchConnection.Controls.Add(this.rBGo);
            this.tabSearchConnection.Controls.Add(this.cmbBxGoal);
            this.tabSearchConnection.Controls.Add(this.cmbBxStart);
            this.tabSearchConnection.Controls.Add(this.label2);
            this.tabSearchConnection.Controls.Add(this.label1);
            this.tabSearchConnection.Location = new System.Drawing.Point(4, 22);
            this.tabSearchConnection.Name = "tabSearchConnection";
            this.tabSearchConnection.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearchConnection.Size = new System.Drawing.Size(756, 547);
            this.tabSearchConnection.TabIndex = 0;
            this.tabSearchConnection.Text = "Verbindung suchen";
            this.tabSearchConnection.UseVisualStyleBackColor = true;
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblInfo2.Location = new System.Drawing.Point(13, 128);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(0, 26);
            this.lblInfo2.TabIndex = 17;
            // 
            // lstVwConnections
            // 
            this.lstVwConnections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader2,
            this.columnHeader4});
            this.lstVwConnections.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lstVwConnections.FullRowSelect = true;
            this.lstVwConnections.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstVwConnections.Location = new System.Drawing.Point(8, 147);
            this.lstVwConnections.MultiSelect = false;
            this.lstVwConnections.Name = "lstVwConnections";
            this.lstVwConnections.Size = new System.Drawing.Size(738, 389);
            this.lstVwConnections.TabIndex = 13;
            this.lstVwConnections.UseCompatibleStateImageBehavior = false;
            this.lstVwConnections.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Abfahrtszeit";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Abfahrtszeit";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Dauer";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Gleis / Kante (Abfahrt)";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 188;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Gleis / Kante (Ankunft)";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 181;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker1.Location = new System.Drawing.Point(370, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(17, 23);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // btnMinuteOn
            // 
            this.btnMinuteOn.Location = new System.Drawing.Point(478, 58);
            this.btnMinuteOn.Name = "btnMinuteOn";
            this.btnMinuteOn.Size = new System.Drawing.Size(29, 20);
            this.btnMinuteOn.TabIndex = 9;
            this.btnMinuteOn.Text = ">>";
            this.btnMinuteOn.UseVisualStyleBackColor = true;
            this.btnMinuteOn.Click += new System.EventHandler(this.BtnMinuteOn_Click);
            // 
            // btnMinuteBack
            // 
            this.btnMinuteBack.Location = new System.Drawing.Point(443, 58);
            this.btnMinuteBack.Name = "btnMinuteBack";
            this.btnMinuteBack.Size = new System.Drawing.Size(29, 20);
            this.btnMinuteBack.TabIndex = 8;
            this.btnMinuteBack.Text = "<<";
            this.btnMinuteBack.UseVisualStyleBackColor = true;
            this.btnMinuteBack.Click += new System.EventHandler(this.BtnMinuteBack_Click);
            // 
            // btnDayOn
            // 
            this.btnDayOn.Location = new System.Drawing.Point(358, 58);
            this.btnDayOn.Name = "btnDayOn";
            this.btnDayOn.Size = new System.Drawing.Size(29, 20);
            this.btnDayOn.TabIndex = 6;
            this.btnDayOn.Text = ">>";
            this.btnDayOn.UseVisualStyleBackColor = true;
            this.btnDayOn.Click += new System.EventHandler(this.BtnDayOn_Click);
            // 
            // btnDayBack
            // 
            this.btnDayBack.Location = new System.Drawing.Point(302, 58);
            this.btnDayBack.Name = "btnDayBack";
            this.btnDayBack.Size = new System.Drawing.Size(29, 20);
            this.btnDayBack.TabIndex = 5;
            this.btnDayBack.Text = "<<";
            this.btnDayBack.UseVisualStyleBackColor = true;
            this.btnDayBack.Click += new System.EventHandler(this.BtnDayBack_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblInfo.Location = new System.Drawing.Point(3, 102);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(266, 26);
            this.lblInfo.TabIndex = 16;
            this.lblInfo.Text = "Verbindungsinfromationen";
            // 
            // btSearchConnection
            // 
            this.btSearchConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btSearchConnection.Location = new System.Drawing.Point(607, 12);
            this.btSearchConnection.Name = "btSearchConnection";
            this.btSearchConnection.Size = new System.Drawing.Size(139, 66);
            this.btSearchConnection.TabIndex = 12;
            this.btSearchConnection.Text = "Verbindung suchen";
            this.btSearchConnection.UseVisualStyleBackColor = true;
            this.btSearchConnection.Click += new System.EventHandler(this.BtSearchConnection_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTime.Location = new System.Drawing.Point(451, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(36, 17);
            this.lblTime.TabIndex = 14;
            this.lblTime.Text = "Zeit:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDate.Location = new System.Drawing.Point(299, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 17);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "Datum:";
            // 
            // MTxtbxDate
            // 
            this.MTxtbxDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MTxtbxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MTxtbxDate.Location = new System.Drawing.Point(302, 29);
            this.MTxtbxDate.Mask = "00/00/0000";
            this.MTxtbxDate.Name = "MTxtbxDate";
            this.MTxtbxDate.Size = new System.Drawing.Size(72, 23);
            this.MTxtbxDate.TabIndex = 3;
            this.MTxtbxDate.ValidatingType = typeof(System.DateTime);
            // 
            // MTxtbxTime
            // 
            this.MTxtbxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MTxtbxTime.Location = new System.Drawing.Point(454, 29);
            this.MTxtbxTime.Mask = "90:00";
            this.MTxtbxTime.Name = "MTxtbxTime";
            this.MTxtbxTime.Size = new System.Drawing.Size(42, 23);
            this.MTxtbxTime.TabIndex = 7;
            this.MTxtbxTime.ValidatingType = typeof(System.DateTime);
            // 
            // rBArrive
            // 
            this.rBArrive.AutoSize = true;
            this.rBArrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rBArrive.Location = new System.Drawing.Point(525, 57);
            this.rBArrive.Name = "rBArrive";
            this.rBArrive.Size = new System.Drawing.Size(74, 21);
            this.rBArrive.TabIndex = 11;
            this.rBArrive.TabStop = true;
            this.rBArrive.Text = "Ankunft";
            this.rBArrive.UseVisualStyleBackColor = true;
            // 
            // rBGo
            // 
            this.rBGo.AutoSize = true;
            this.rBGo.Checked = true;
            this.rBGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rBGo.Location = new System.Drawing.Point(525, 31);
            this.rBGo.Name = "rBGo";
            this.rBGo.Size = new System.Drawing.Size(72, 21);
            this.rBGo.TabIndex = 10;
            this.rBGo.TabStop = true;
            this.rBGo.Text = "Abfahrt";
            this.rBGo.UseVisualStyleBackColor = true;
            // 
            // cmbBxGoal
            // 
            this.cmbBxGoal.FormattingEnabled = true;
            this.cmbBxGoal.Location = new System.Drawing.Point(53, 53);
            this.cmbBxGoal.Name = "cmbBxGoal";
            this.cmbBxGoal.Size = new System.Drawing.Size(192, 21);
            this.cmbBxGoal.TabIndex = 2;
            this.cmbBxGoal.DropDown += new System.EventHandler(this.comboBox_DropDown);
            // 
            // cmbBxStart
            // 
            this.cmbBxStart.FormattingEnabled = true;
            this.cmbBxStart.Location = new System.Drawing.Point(53, 27);
            this.cmbBxStart.Name = "cmbBxStart";
            this.cmbBxStart.Size = new System.Drawing.Size(192, 21);
            this.cmbBxStart.TabIndex = 1;
            this.cmbBxStart.DropDown += new System.EventHandler(this.comboBox_DropDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(10, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nach:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Von:";
            // 
            // tabTimetable
            // 
            this.tabTimetable.Controls.Add(this.btShowTimeTable);
            this.tabTimetable.Controls.Add(this.lblTimeTable);
            this.tabTimetable.Controls.Add(this.cmbBxTimeTable);
            this.tabTimetable.Controls.Add(this.listView1);
            this.tabTimetable.Location = new System.Drawing.Point(4, 22);
            this.tabTimetable.Name = "tabTimetable";
            this.tabTimetable.Padding = new System.Windows.Forms.Padding(3);
            this.tabTimetable.Size = new System.Drawing.Size(756, 547);
            this.tabTimetable.TabIndex = 1;
            this.tabTimetable.Text = "Abfahrtstafel";
            this.tabTimetable.UseVisualStyleBackColor = true;
            // 
            // btShowTimeTable
            // 
            this.btShowTimeTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btShowTimeTable.Location = new System.Drawing.Point(6, 158);
            this.btShowTimeTable.Name = "btShowTimeTable";
            this.btShowTimeTable.Size = new System.Drawing.Size(192, 57);
            this.btShowTimeTable.TabIndex = 4;
            this.btShowTimeTable.Text = "Anzeigen";
            this.btShowTimeTable.UseVisualStyleBackColor = true;
            this.btShowTimeTable.Click += new System.EventHandler(this.btShowTimeTable_Click);
            // 
            // lblTimeTable
            // 
            this.lblTimeTable.AutoSize = true;
            this.lblTimeTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTimeTable.Location = new System.Drawing.Point(3, 7);
            this.lblTimeTable.Name = "lblTimeTable";
            this.lblTimeTable.Size = new System.Drawing.Size(203, 100);
            this.lblTimeTable.TabIndex = 3;
            this.lblTimeTable.Text = "Wählen Sie eine\r\nHaltestelle um\r\neinen Abfahrtsplan\r\nvon dieser zu erhalten";
            // 
            // cmbBxTimeTable
            // 
            this.cmbBxTimeTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbBxTimeTable.FormattingEnabled = true;
            this.cmbBxTimeTable.Location = new System.Drawing.Point(6, 119);
            this.cmbBxTimeTable.Name = "cmbBxTimeTable";
            this.cmbBxTimeTable.Size = new System.Drawing.Size(192, 32);
            this.cmbBxTimeTable.TabIndex = 2;
            this.cmbBxTimeTable.DropDown += new System.EventHandler(this.comboBox_DropDown);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.listView1.Location = new System.Drawing.Point(213, 7);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(533, 529);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Linie";
            this.columnHeader6.Width = 108;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Abfahrt";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 149;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Zielhaltestelle";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 271;
            // 
            // Form1
            // 
            this.AcceptButton = this.btSearchConnection;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 570);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabSearchConnection.ResumeLayout(false);
            this.tabSearchConnection.PerformLayout();
            this.tabTimetable.ResumeLayout(false);
            this.tabTimetable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabSearchConnection;
        private System.Windows.Forms.TabPage tabTimetable;
        private System.Windows.Forms.MaskedTextBox MTxtbxTime;
        private System.Windows.Forms.RadioButton rBArrive;
        private System.Windows.Forms.RadioButton rBGo;
        private System.Windows.Forms.ComboBox cmbBxGoal;
        private System.Windows.Forms.ComboBox cmbBxStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSearchConnection;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.MaskedTextBox MTxtbxDate;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnDayOn;
        private System.Windows.Forms.Button btnDayBack;
        private System.Windows.Forms.Button btnMinuteOn;
        private System.Windows.Forms.Button btnMinuteBack;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private EventHandler cmbBxGoal_DropDown;
        private EventHandler dateTimePicker1_ValueChanged;
        private EventHandler btnMinuteOn_Click;
        private EventHandler btnDayOn_Click;
        private EventHandler btnMinuteBack_Click;
        private EventHandler btnDayBack_Click;
        private DataGridViewCellEventHandler dataGridView1_CellContentClick;
        private EventHandler btSearchConnection_Click;
        private EventHandler cmbBxStart_DropDown;
        private DataGridViewCellEventHandler dataGridView1_CellContentClick_1;
        private ListView lstVwConnections;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader4;
        private Label lblInfo2;
        private Label lblTimeTable;
        private ComboBox cmbBxTimeTable;
        private ListView listView1;
        private Button btShowTimeTable;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
    }
}
