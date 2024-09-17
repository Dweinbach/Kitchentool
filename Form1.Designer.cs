namespace KitchenUnitConverter
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtVolumeFrom = new System.Windows.Forms.TextBox();
            this.txtVolumeTo = new System.Windows.Forms.TextBox();
            this.cboVolumeFrom = new System.Windows.Forms.ComboBox();
            this.cboVolumeTo = new System.Windows.Forms.ComboBox();
            this.btnConvertVolume = new System.Windows.Forms.Button();
            this.txtWeightFrom = new System.Windows.Forms.TextBox();
            this.txtWeightTo = new System.Windows.Forms.TextBox();
            this.cboWeightFrom = new System.Windows.Forms.ComboBox();
            this.cboWeightTo = new System.Windows.Forms.ComboBox();
            this.btnConvertWeight = new System.Windows.Forms.Button();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtVolumeFrom
            // 
            this.txtVolumeFrom.Location = new System.Drawing.Point(20, 40);
            this.txtVolumeFrom.Name = "txtVolumeFrom";
            this.txtVolumeFrom.Size = new System.Drawing.Size(100, 20);
            this.txtVolumeFrom.TabIndex = 0;
            // 
            // txtVolumeTo
            // 
            this.txtVolumeTo.Location = new System.Drawing.Point(280, 40);
            this.txtVolumeTo.Name = "txtVolumeTo";
            this.txtVolumeTo.ReadOnly = true;
            this.txtVolumeTo.Size = new System.Drawing.Size(100, 20);
            this.txtVolumeTo.TabIndex = 1;
            // 
            // cboVolumeFrom
            // 
            this.cboVolumeFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVolumeFrom.FormattingEnabled = true;
            this.cboVolumeFrom.Location = new System.Drawing.Point(130, 40);
            this.cboVolumeFrom.Name = "cboVolumeFrom";
            this.cboVolumeFrom.Size = new System.Drawing.Size(60, 21);
            this.cboVolumeFrom.TabIndex = 2;
            // 
            // cboVolumeTo
            // 
            this.cboVolumeTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVolumeTo.FormattingEnabled = true;
            this.cboVolumeTo.Location = new System.Drawing.Point(390, 40);
            this.cboVolumeTo.Name = "cboVolumeTo";
            this.cboVolumeTo.Size = new System.Drawing.Size(60, 21);
            this.cboVolumeTo.TabIndex = 3;
            // 
            // btnConvertVolume
            // 
            this.btnConvertVolume.Location = new System.Drawing.Point(200, 38);
            this.btnConvertVolume.Name = "btnConvertVolume";
            this.btnConvertVolume.Size = new System.Drawing.Size(75, 23);
            this.btnConvertVolume.TabIndex = 4;
            this.btnConvertVolume.Text = "Convert";
            this.btnConvertVolume.UseVisualStyleBackColor = true;
            this.btnConvertVolume.Click += new System.EventHandler(this.btnConvertVolume_Click);
            // 
            // txtWeightFrom
            // 
            this.txtWeightFrom.Location = new System.Drawing.Point(20, 100);
            this.txtWeightFrom.Name = "txtWeightFrom";
            this.txtWeightFrom.Size = new System.Drawing.Size(100, 20);
            this.txtWeightFrom.TabIndex = 5;
            // 
            // txtWeightTo
            // 
            this.txtWeightTo.Location = new System.Drawing.Point(280, 100);
            this.txtWeightTo.Name = "txtWeightTo";
            this.txtWeightTo.ReadOnly = true;
            this.txtWeightTo.Size = new System.Drawing.Size(100, 20);
            this.txtWeightTo.TabIndex = 6;
            // 
            // cboWeightFrom
            // 
            this.cboWeightFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWeightFrom.FormattingEnabled = true;
            this.cboWeightFrom.Location = new System.Drawing.Point(130, 100);
            this.cboWeightFrom.Name = "cboWeightFrom";
            this.cboWeightFrom.Size = new System.Drawing.Size(60, 21);
            this.cboWeightFrom.TabIndex = 7;
            // 
            // cboWeightTo
            // 
            this.cboWeightTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWeightTo.FormattingEnabled = true;
            this.cboWeightTo.Location = new System.Drawing.Point(390, 100);
            this.cboWeightTo.Name = "cboWeightTo";
            this.cboWeightTo.Size = new System.Drawing.Size(60, 21);
            this.cboWeightTo.TabIndex = 8;
            // 
            // btnConvertWeight
            // 
            this.btnConvertWeight.Location = new System.Drawing.Point(200, 98);
            this.btnConvertWeight.Name = "btnConvertWeight";
            this.btnConvertWeight.Size = new System.Drawing.Size(75, 23);
            this.btnConvertWeight.TabIndex = 9;
            this.btnConvertWeight.Text = "Convert";
            this.btnConvertWeight.UseVisualStyleBackColor = true;
            this.btnConvertWeight.Click += new System.EventHandler(this.btnConvertWeight_Click);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(20, 20);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(42, 13);
            this.lblVolume.TabIndex = 10;
            this.lblVolume.Text = "Volume";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(20, 80);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(41, 13);
            this.lblWeight.TabIndex = 11;
            this.lblWeight.Text = "Weight";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 161);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.btnConvertWeight);
            this.Controls.Add(this.cboWeightTo);
            this.Controls.Add(this.cboWeightFrom);
            this.Controls.Add(this.txtWeightTo);
            this.Controls.Add(this.txtWeightFrom);
            this.Controls.Add(this.btnConvertVolume);
            this.Controls.Add(this.cboVolumeTo);
            this.Controls.Add(this.cboVolumeFrom);
            this.Controls.Add(this.txtVolumeTo);
            this.Controls.Add(this.txtVolumeFrom);
            this.Name = "Form1";
            this.Text = "Kitchen Unit Converter";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtVolumeFrom;
        private System.Windows.Forms.TextBox txtVolumeTo;
        private System.Windows.Forms.ComboBox cboVolumeFrom;
        private System.Windows.Forms.ComboBox cboVolumeTo;
        private System.Windows.Forms.Button btnConvertVolume;
        private System.Windows.Forms.TextBox txtWeightFrom;
        private System.Windows.Forms.TextBox txtWeightTo;
        private System.Windows.Forms.ComboBox cboWeightFrom;
        private System.Windows.Forms.ComboBox cboWeightTo;
        private System.Windows.Forms.Button btnConvertWeight;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblWeight;
    }
}