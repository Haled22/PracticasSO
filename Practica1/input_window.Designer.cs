namespace Practica1
{
    partial class input_window
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
            this.ProcessesTable = new System.Windows.Forms.TabControl();
            this.processes = new System.Windows.Forms.TabPage();
            this.inputNumProcesses = new System.Windows.Forms.TextBox();
            this.lblNumProcesses = new System.Windows.Forms.Label();
            this.blockedTimer3 = new System.Windows.Forms.Label();
            this.blockedTimer2 = new System.Windows.Forms.Label();
            this.blockedTimer1 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listViewPastProcesses = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.operacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tiempo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.arrivalT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.finishT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.returnTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.responseT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.waitT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.serviceT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxInProgress = new System.Windows.Forms.GroupBox();
            this._lblnewProcesses = new System.Windows.Forms.Label();
            this._newProcesses = new System.Windows.Forms.Label();
            this._contLotesOutput = new System.Windows.Forms.Label();
            this._contLoteslbl = new System.Windows.Forms.Label();
            this.labelProgrammerName = new System.Windows.Forms.Label();
            this.labelOperation = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.processTimertxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.timeTxt = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.processTableTab = new System.Windows.Forms.TabPage();
            this.processTable = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblQuant = new System.Windows.Forms.Label();
            this.quantInput = new System.Windows.Forms.TextBox();
            this.ProcessesTable.SuspendLayout();
            this.processes.SuspendLayout();
            this.groupBoxInProgress.SuspendLayout();
            this.processTableTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProcessesTable
            // 
            this.ProcessesTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProcessesTable.Controls.Add(this.processes);
            this.ProcessesTable.Controls.Add(this.processTableTab);
            this.ProcessesTable.Location = new System.Drawing.Point(0, 1);
            this.ProcessesTable.Name = "ProcessesTable";
            this.ProcessesTable.SelectedIndex = 0;
            this.ProcessesTable.Size = new System.Drawing.Size(1222, 450);
            this.ProcessesTable.TabIndex = 13;
            // 
            // processes
            // 
            this.processes.BackColor = System.Drawing.Color.SeaShell;
            this.processes.Controls.Add(this.quantInput);
            this.processes.Controls.Add(this.lblQuant);
            this.processes.Controls.Add(this.inputNumProcesses);
            this.processes.Controls.Add(this.lblNumProcesses);
            this.processes.Controls.Add(this.blockedTimer3);
            this.processes.Controls.Add(this.blockedTimer2);
            this.processes.Controls.Add(this.blockedTimer1);
            this.processes.Controls.Add(this.groupBox6);
            this.processes.Controls.Add(this.groupBox5);
            this.processes.Controls.Add(this.groupBox4);
            this.processes.Controls.Add(this.listViewPastProcesses);
            this.processes.Controls.Add(this.groupBoxInProgress);
            this.processes.Controls.Add(this.label1);
            this.processes.Controls.Add(this.btnStart);
            this.processes.Controls.Add(this.timeTxt);
            this.processes.Controls.Add(this.groupBox3);
            this.processes.Controls.Add(this.groupBox2);
            this.processes.Controls.Add(this.groupBox1);
            this.processes.Location = new System.Drawing.Point(4, 25);
            this.processes.Name = "processes";
            this.processes.Padding = new System.Windows.Forms.Padding(3);
            this.processes.Size = new System.Drawing.Size(1214, 421);
            this.processes.TabIndex = 1;
            this.processes.Text = "Procesos";
            this.processes.Click += new System.EventHandler(this.tabPage2_Click);
            this.processes.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.tabPage2_PreviewKeyDown);
            // 
            // inputNumProcesses
            // 
            this.inputNumProcesses.Location = new System.Drawing.Point(431, 32);
            this.inputNumProcesses.Name = "inputNumProcesses";
            this.inputNumProcesses.Size = new System.Drawing.Size(166, 22);
            this.inputNumProcesses.TabIndex = 20;
            // 
            // lblNumProcesses
            // 
            this.lblNumProcesses.AutoSize = true;
            this.lblNumProcesses.Location = new System.Drawing.Point(428, 13);
            this.lblNumProcesses.Name = "lblNumProcesses";
            this.lblNumProcesses.Size = new System.Drawing.Size(137, 16);
            this.lblNumProcesses.TabIndex = 19;
            this.lblNumProcesses.Text = "Numero de procesos:";
            // 
            // blockedTimer3
            // 
            this.blockedTimer3.AutoSize = true;
            this.blockedTimer3.Location = new System.Drawing.Point(288, 150);
            this.blockedTimer3.Name = "blockedTimer3";
            this.blockedTimer3.Size = new System.Drawing.Size(0, 16);
            this.blockedTimer3.TabIndex = 17;
            // 
            // blockedTimer2
            // 
            this.blockedTimer2.AutoSize = true;
            this.blockedTimer2.Location = new System.Drawing.Point(288, 121);
            this.blockedTimer2.Name = "blockedTimer2";
            this.blockedTimer2.Size = new System.Drawing.Size(0, 16);
            this.blockedTimer2.TabIndex = 16;
            // 
            // blockedTimer1
            // 
            this.blockedTimer1.AutoSize = true;
            this.blockedTimer1.Location = new System.Drawing.Point(288, 93);
            this.blockedTimer1.Name = "blockedTimer1";
            this.blockedTimer1.Size = new System.Drawing.Size(0, 16);
            this.blockedTimer1.TabIndex = 15;
            this.blockedTimer1.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.LightCoral;
            this.groupBox6.Location = new System.Drawing.Point(291, 66);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(96, 24);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Bloqueado";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Aquamarine;
            this.groupBox5.Location = new System.Drawing.Point(291, 36);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(96, 24);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ejecucion";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.LimeGreen;
            this.groupBox4.Location = new System.Drawing.Point(291, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(96, 24);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Listo";
            // 
            // listViewPastProcesses
            // 
            this.listViewPastProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewPastProcesses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.operacion,
            this.tiempo,
            this.arrivalT,
            this.finishT,
            this.returnTime,
            this.responseT,
            this.waitT,
            this.serviceT});
            this.listViewPastProcesses.HideSelection = false;
            this.listViewPastProcesses.Location = new System.Drawing.Point(311, 193);
            this.listViewPastProcesses.Name = "listViewPastProcesses";
            this.listViewPastProcesses.ShowItemToolTips = true;
            this.listViewPastProcesses.Size = new System.Drawing.Size(883, 210);
            this.listViewPastProcesses.TabIndex = 11;
            this.listViewPastProcesses.UseCompatibleStateImageBehavior = false;
            this.listViewPastProcesses.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "Id";
            // 
            // operacion
            // 
            this.operacion.Text = "Operacion";
            // 
            // tiempo
            // 
            this.tiempo.Text = "Tiempo";
            // 
            // arrivalT
            // 
            this.arrivalT.Text = "Llegada";
            this.arrivalT.Width = 66;
            // 
            // finishT
            // 
            this.finishT.Text = "Finalización";
            this.finishT.Width = 93;
            // 
            // returnTime
            // 
            this.returnTime.Text = "Retorno";
            this.returnTime.Width = 68;
            // 
            // responseT
            // 
            this.responseT.Text = "Respuesta";
            this.responseT.Width = 96;
            // 
            // waitT
            // 
            this.waitT.Text = "Espera";
            this.waitT.Width = 65;
            // 
            // serviceT
            // 
            this.serviceT.Text = "Servicio";
            this.serviceT.Width = 82;
            // 
            // groupBoxInProgress
            // 
            this.groupBoxInProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxInProgress.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxInProgress.Controls.Add(this._lblnewProcesses);
            this.groupBoxInProgress.Controls.Add(this._newProcesses);
            this.groupBoxInProgress.Controls.Add(this._contLotesOutput);
            this.groupBoxInProgress.Controls.Add(this._contLoteslbl);
            this.groupBoxInProgress.Controls.Add(this.labelProgrammerName);
            this.groupBoxInProgress.Controls.Add(this.labelOperation);
            this.groupBoxInProgress.Controls.Add(this.labelId);
            this.groupBoxInProgress.Controls.Add(this.label4);
            this.groupBoxInProgress.Controls.Add(this.label2);
            this.groupBoxInProgress.Controls.Add(this.label3);
            this.groupBoxInProgress.Controls.Add(this.processTimertxt);
            this.groupBoxInProgress.Location = new System.Drawing.Point(8, 193);
            this.groupBoxInProgress.Name = "groupBoxInProgress";
            this.groupBoxInProgress.Size = new System.Drawing.Size(280, 181);
            this.groupBoxInProgress.TabIndex = 10;
            this.groupBoxInProgress.TabStop = false;
            this.groupBoxInProgress.Text = "Proceso en ejecución";
            // 
            // _lblnewProcesses
            // 
            this._lblnewProcesses.AutoSize = true;
            this._lblnewProcesses.Location = new System.Drawing.Point(160, 135);
            this._lblnewProcesses.Name = "_lblnewProcesses";
            this._lblnewProcesses.Size = new System.Drawing.Size(14, 16);
            this._lblnewProcesses.TabIndex = 17;
            this._lblnewProcesses.Text = "0";
            // 
            // _newProcesses
            // 
            this._newProcesses.AutoSize = true;
            this._newProcesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._newProcesses.Location = new System.Drawing.Point(17, 136);
            this._newProcesses.Name = "_newProcesses";
            this._newProcesses.Size = new System.Drawing.Size(133, 16);
            this._newProcesses.TabIndex = 16;
            this._newProcesses.Text = "Nuevos procesos:";
            // 
            // _contLotesOutput
            // 
            this._contLotesOutput.AutoSize = true;
            this._contLotesOutput.Location = new System.Drawing.Point(160, 110);
            this._contLotesOutput.Name = "_contLotesOutput";
            this._contLotesOutput.Size = new System.Drawing.Size(14, 16);
            this._contLotesOutput.TabIndex = 15;
            this._contLotesOutput.Text = "0";
            // 
            // _contLoteslbl
            // 
            this._contLoteslbl.AutoSize = true;
            this._contLoteslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._contLoteslbl.Location = new System.Drawing.Point(17, 111);
            this._contLoteslbl.Name = "_contLoteslbl";
            this._contLoteslbl.Size = new System.Drawing.Size(145, 16);
            this._contLoteslbl.TabIndex = 14;
            this._contLoteslbl.Text = "Procesos restantes:";
            // 
            // labelProgrammerName
            // 
            this.labelProgrammerName.AutoSize = true;
            this.labelProgrammerName.Location = new System.Drawing.Point(147, 85);
            this.labelProgrammerName.Name = "labelProgrammerName";
            this.labelProgrammerName.Size = new System.Drawing.Size(0, 16);
            this.labelProgrammerName.TabIndex = 13;
            // 
            // labelOperation
            // 
            this.labelOperation.AutoSize = true;
            this.labelOperation.Location = new System.Drawing.Point(147, 86);
            this.labelOperation.Name = "labelOperation";
            this.labelOperation.Size = new System.Drawing.Size(0, 16);
            this.labelOperation.TabIndex = 12;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(147, 57);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(0, 16);
            this.labelId.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Operacion: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tiempo restante:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "ID Programa:";
            // 
            // processTimertxt
            // 
            this.processTimertxt.AutoSize = true;
            this.processTimertxt.Location = new System.Drawing.Point(160, 28);
            this.processTimertxt.Name = "processTimertxt";
            this.processTimertxt.Size = new System.Drawing.Size(14, 16);
            this.processTimertxt.TabIndex = 6;
            this.processTimertxt.Text = "0";
            this.processTimertxt.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tiempo Total:";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStart.Location = new System.Drawing.Point(213, 380);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Empezar";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.startBtn);
            // 
            // timeTxt
            // 
            this.timeTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.timeTxt.AutoSize = true;
            this.timeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTxt.Location = new System.Drawing.Point(125, 383);
            this.timeTxt.Name = "timeTxt";
            this.timeTxt.Size = new System.Drawing.Size(55, 16);
            this.timeTxt.TabIndex = 4;
            this.timeTxt.Text = "00:00:00";
            this.timeTxt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.timeTxt.Click += new System.EventHandler(this.label6_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DimGray;
            this.groupBox3.Location = new System.Drawing.Point(219, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(46, 160);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DimGray;
            this.groupBox2.Location = new System.Drawing.Point(126, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(43, 160);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(28, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(45, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // processTableTab
            // 
            this.processTableTab.BackColor = System.Drawing.Color.SeaShell;
            this.processTableTab.Controls.Add(this.processTable);
            this.processTableTab.Location = new System.Drawing.Point(4, 25);
            this.processTableTab.Name = "processTableTab";
            this.processTableTab.Padding = new System.Windows.Forms.Padding(3);
            this.processTableTab.Size = new System.Drawing.Size(1214, 421);
            this.processTableTab.TabIndex = 2;
            this.processTableTab.Text = "Tabal de Procesos";
            // 
            // processTable
            // 
            this.processTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.processTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader10,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader11,
            this.columnHeader9});
            this.processTable.HideSelection = false;
            this.processTable.Location = new System.Drawing.Point(24, 105);
            this.processTable.Name = "processTable";
            this.processTable.ShowItemToolTips = true;
            this.processTable.Size = new System.Drawing.Size(1159, 210);
            this.processTable.TabIndex = 12;
            this.processTable.UseCompatibleStateImageBehavior = false;
            this.processTable.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Estado";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Operacion";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tiempo";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Llegada";
            this.columnHeader4.Width = 127;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Finalización";
            this.columnHeader5.Width = 137;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Retorno";
            this.columnHeader6.Width = 68;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Respuesta";
            this.columnHeader7.Width = 96;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Espera";
            this.columnHeader8.Width = 65;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Restante";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Servicio";
            this.columnHeader9.Width = 82;
            // 
            // lblQuant
            // 
            this.lblQuant.AutoSize = true;
            this.lblQuant.Location = new System.Drawing.Point(431, 61);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(60, 16);
            this.lblQuant.TabIndex = 21;
            this.lblQuant.Text = "Quantum";
            // 
            // quantInput
            // 
            this.quantInput.Location = new System.Drawing.Point(431, 80);
            this.quantInput.Name = "quantInput";
            this.quantInput.Size = new System.Drawing.Size(166, 22);
            this.quantInput.TabIndex = 22;
            // 
            // input_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1221, 450);
            this.Controls.Add(this.ProcessesTable);
            this.KeyPreview = true;
            this.Name = "input_window";
            this.Text = "Practica 5";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.input_window_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_window_KeyPress);
            this.ProcessesTable.ResumeLayout(false);
            this.processes.ResumeLayout(false);
            this.processes.PerformLayout();
            this.groupBoxInProgress.ResumeLayout(false);
            this.groupBoxInProgress.PerformLayout();
            this.processTableTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl ProcessesTable;
        private System.Windows.Forms.TabPage processes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStart;

        private System.Windows.Forms.Label timeTxt;
        private System.Windows.Forms.Label processTimertxt;
        private System.Windows.Forms.GroupBox groupBoxInProgress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelProgrammerName;
        private System.Windows.Forms.Label labelOperation;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.ListView listViewPastProcesses;
        private System.Windows.Forms.Label _contLoteslbl;
        private System.Windows.Forms.Label _contLotesOutput;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader operacion;
        private System.Windows.Forms.ColumnHeader tiempo;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label blockedTimer3;
        private System.Windows.Forms.Label blockedTimer2;
        private System.Windows.Forms.Label blockedTimer1;
        private System.Windows.Forms.Label lblNumProcesses;
        private System.Windows.Forms.TextBox inputNumProcesses;
        private System.Windows.Forms.ColumnHeader arrivalT;
        private System.Windows.Forms.ColumnHeader finishT;
        private System.Windows.Forms.ColumnHeader returnTime;
        private System.Windows.Forms.ColumnHeader responseT;
        private System.Windows.Forms.ColumnHeader waitT;
        private System.Windows.Forms.ColumnHeader serviceT;
        private System.Windows.Forms.TabPage processTableTab;
        private System.Windows.Forms.ListView processTable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label _lblnewProcesses;
        private System.Windows.Forms.Label _newProcesses;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.TextBox quantInput;
        private System.Windows.Forms.Label lblQuant;
    }
}

