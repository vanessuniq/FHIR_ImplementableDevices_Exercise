namespace PatientDevices
{
    partial class FormPatientDevices
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearchPatient = new System.Windows.Forms.Button();
            this.lblFamily = new System.Windows.Forms.Label();
            this.lblGivenName = new System.Windows.Forms.Label();
            this.txtFamilyName = new System.Windows.Forms.TextBox();
            this.txtGivenName = new System.Windows.Forms.TextBox();
            this.lblEndpoint = new System.Windows.Forms.Label();
            this.txtFHIREndpoint = new System.Windows.Forms.TextBox();
            this.lblTitlePatient = new System.Windows.Forms.Label();
            this.listCandidates = new System.Windows.Forms.ListBox();
            this.btnShowDevices = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listDevices = new System.Windows.Forms.ListBox();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSearchPatient
            // 
            this.btnSearchPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.06283F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPatient.Location = new System.Drawing.Point(460, 69);
            this.btnSearchPatient.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchPatient.Name = "btnSearchPatient";
            this.btnSearchPatient.Size = new System.Drawing.Size(109, 59);
            this.btnSearchPatient.TabIndex = 2;
            this.btnSearchPatient.Text = "Search Patient";
            this.btnSearchPatient.UseVisualStyleBackColor = true;
            this.btnSearchPatient.Click += new System.EventHandler(this.BtnSearchPatient_Click);
            // 
            // lblFamily
            // 
            this.lblFamily.AutoSize = true;
            this.lblFamily.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.06283F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFamily.Location = new System.Drawing.Point(19, 69);
            this.lblFamily.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFamily.Name = "lblFamily";
            this.lblFamily.Size = new System.Drawing.Size(112, 20);
            this.lblFamily.TabIndex = 1;
            this.lblFamily.Text = "Family Name:";
            // 
            // lblGivenName
            // 
            this.lblGivenName.AutoSize = true;
            this.lblGivenName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.06283F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGivenName.Location = new System.Drawing.Point(24, 100);
            this.lblGivenName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGivenName.Name = "lblGivenName";
            this.lblGivenName.Size = new System.Drawing.Size(106, 20);
            this.lblGivenName.TabIndex = 2;
            this.lblGivenName.Text = "Given Name:";
            // 
            // txtFamilyName
            // 
            this.txtFamilyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.06283F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFamilyName.Location = new System.Drawing.Point(126, 67);
            this.txtFamilyName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFamilyName.Name = "txtFamilyName";
            this.txtFamilyName.Size = new System.Drawing.Size(328, 26);
            this.txtFamilyName.TabIndex = 0;
            // 
            // txtGivenName
            // 
            this.txtGivenName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.06283F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGivenName.Location = new System.Drawing.Point(126, 99);
            this.txtGivenName.Margin = new System.Windows.Forms.Padding(2);
            this.txtGivenName.Name = "txtGivenName";
            this.txtGivenName.Size = new System.Drawing.Size(328, 26);
            this.txtGivenName.TabIndex = 1;
            // 
            // lblEndpoint
            // 
            this.lblEndpoint.AutoSize = true;
            this.lblEndpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.06283F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndpoint.Location = new System.Drawing.Point(17, 12);
            this.lblEndpoint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndpoint.Name = "lblEndpoint";
            this.lblEndpoint.Size = new System.Drawing.Size(125, 20);
            this.lblEndpoint.TabIndex = 5;
            this.lblEndpoint.Text = "FHIR EndPoint:";
            // 
            // txtFHIREndpoint
            // 
            this.txtFHIREndpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.06283F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFHIREndpoint.Location = new System.Drawing.Point(161, 9);
            this.txtFHIREndpoint.Margin = new System.Windows.Forms.Padding(2);
            this.txtFHIREndpoint.Name = "txtFHIREndpoint";
            this.txtFHIREndpoint.Size = new System.Drawing.Size(294, 26);
            this.txtFHIREndpoint.TabIndex = 6;
            this.txtFHIREndpoint.Text = "http://fhir.hl7fundamentals.org/r4";
            // 
            // lblTitlePatient
            // 
            this.lblTitlePatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblTitlePatient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitlePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.06283F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePatient.Location = new System.Drawing.Point(19, 38);
            this.lblTitlePatient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitlePatient.Name = "lblTitlePatient";
            this.lblTitlePatient.Size = new System.Drawing.Size(434, 22);
            this.lblTitlePatient.TabIndex = 7;
            this.lblTitlePatient.Text = "SEARCH AND SELECT PATIENT";
            this.lblTitlePatient.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listCandidates
            // 
            this.listCandidates.DisplayMember = "Text";
            this.listCandidates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCandidates.FormattingEnabled = true;
            this.listCandidates.HorizontalScrollbar = true;
            this.listCandidates.ItemHeight = 20;
            this.listCandidates.Location = new System.Drawing.Point(20, 132);
            this.listCandidates.Margin = new System.Windows.Forms.Padding(2);
            this.listCandidates.Name = "listCandidates";
            this.listCandidates.ScrollAlwaysVisible = true;
            this.listCandidates.Size = new System.Drawing.Size(434, 104);
            this.listCandidates.TabIndex = 3;
            // 
            // btnShowDevices
            // 
            this.btnShowDevices.Enabled = false;
            this.btnShowDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.06283F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDevices.Location = new System.Drawing.Point(460, 152);
            this.btnShowDevices.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowDevices.Name = "btnShowDevices";
            this.btnShowDevices.Size = new System.Drawing.Size(109, 59);
            this.btnShowDevices.TabIndex = 4;
            this.btnShowDevices.Text = "Show Devices";
            this.btnShowDevices.UseVisualStyleBackColor = true;
            this.btnShowDevices.Click += new System.EventHandler(this.BtnShowDevices_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.06283F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 257);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "IMPLANTABLE DEVICES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listDevices
            // 
            this.listDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDevices.FormattingEnabled = true;
            this.listDevices.ItemHeight = 20;
            this.listDevices.Location = new System.Drawing.Point(20, 287);
            this.listDevices.Margin = new System.Windows.Forms.Padding(2);
            this.listDevices.Name = "listDevices";
            this.listDevices.Size = new System.Drawing.Size(711, 164);
            this.listDevices.TabIndex = 5;
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoEllipsis = true;
            this.lblErrorMessage.BackColor = System.Drawing.Color.White;
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(18, 455);
            this.lblErrorMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(713, 47);
            this.lblErrorMessage.TabIndex = 12;
            this.lblErrorMessage.Text = "lblErrorMessage";
            this.lblErrorMessage.Visible = false;
            // 
            // FormPatientDevices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 511);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.listDevices);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowDevices);
            this.Controls.Add(this.listCandidates);
            this.Controls.Add(this.lblTitlePatient);
            this.Controls.Add(this.txtFHIREndpoint);
            this.Controls.Add(this.lblEndpoint);
            this.Controls.Add(this.txtGivenName);
            this.Controls.Add(this.txtFamilyName);
            this.Controls.Add(this.lblGivenName);
            this.Controls.Add(this.lblFamily);
            this.Controls.Add(this.btnSearchPatient);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPatientDevices";
            this.Text = "HL7 FHIR Intermediate Course -Implantable Devices";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchPatient;
        private System.Windows.Forms.Label lblFamily;
        private System.Windows.Forms.Label lblGivenName;
        private System.Windows.Forms.TextBox txtFamilyName;
        private System.Windows.Forms.TextBox txtGivenName;
        private System.Windows.Forms.Label lblEndpoint;
        private System.Windows.Forms.TextBox txtFHIREndpoint;
        private System.Windows.Forms.Label lblTitlePatient;
        private System.Windows.Forms.ListBox listCandidates;
        private System.Windows.Forms.Button btnShowDevices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listDevices;
        private System.Windows.Forms.Label lblErrorMessage;
    }
}

