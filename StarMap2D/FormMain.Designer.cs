#region License
/*
MIT License

Copyright(c) 2022 Petteri Kautonen

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
#endregion

namespace StarMap2D
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSkyMap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuObjectDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLocalize = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDumpLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.sunMoonPlot = new ScottPlot.FormsPlot();
            this.lbMoonRise = new System.Windows.Forms.Label();
            this.tbMoonRiseValue = new System.Windows.Forms.TextBox();
            this.tbMoonSetValue = new System.Windows.Forms.TextBox();
            this.lbMoonSet = new System.Windows.Forms.Label();
            this.tbSunSetValue = new System.Windows.Forms.TextBox();
            this.lbSunSet = new System.Windows.Forms.Label();
            this.tblbSunRiseValue = new System.Windows.Forms.TextBox();
            this.lbSunRise = new System.Windows.Forms.Label();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sky Map";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(158, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Object details";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.helpToolStripMenuItem,
            this.mnuTools});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(760, 24);
            this.mnuMain.TabIndex = 4;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSkyMap,
            this.mnuObjectDetails});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuSkyMap
            // 
            this.mnuSkyMap.Name = "mnuSkyMap";
            this.mnuSkyMap.Size = new System.Drawing.Size(146, 22);
            this.mnuSkyMap.Text = "Sky map";
            this.mnuSkyMap.Click += new System.EventHandler(this.mnuSkyMap_Click);
            // 
            // mnuObjectDetails
            // 
            this.mnuObjectDetails.Name = "mnuObjectDetails";
            this.mnuObjectDetails.Size = new System.Drawing.Size(146, 22);
            this.mnuObjectDetails.Text = "Object details";
            this.mnuObjectDetails.Click += new System.EventHandler(this.mnuObjectDetails_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLocalize});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // mnuLocalize
            // 
            this.mnuLocalize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDumpLanguage});
            this.mnuLocalize.Name = "mnuLocalize";
            this.mnuLocalize.Size = new System.Drawing.Size(116, 22);
            this.mnuLocalize.Text = "Localize";
            this.mnuLocalize.Click += new System.EventHandler(this.mnuLocalize_Click);
            // 
            // mnuDumpLanguage
            // 
            this.mnuDumpLanguage.Name = "mnuDumpLanguage";
            this.mnuDumpLanguage.Size = new System.Drawing.Size(159, 22);
            this.mnuDumpLanguage.Text = "Dump language";
            this.mnuDumpLanguage.Click += new System.EventHandler(this.mnuDumpLanguage_Click);
            // 
            // mnuTools
            // 
            this.mnuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSettings});
            this.mnuTools.Name = "mnuTools";
            this.mnuTools.Size = new System.Drawing.Size(46, 20);
            this.mnuTools.Text = "Tools";
            // 
            // mnuSettings
            // 
            this.mnuSettings.Name = "mnuSettings";
            this.mnuSettings.Size = new System.Drawing.Size(116, 22);
            this.mnuSettings.Text = "Settings";
            this.mnuSettings.Click += new System.EventHandler(this.mnuSettings_Click);
            // 
            // sunMoonPlot
            // 
            this.sunMoonPlot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sunMoonPlot.Location = new System.Drawing.Point(13, 100);
            this.sunMoonPlot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sunMoonPlot.Name = "sunMoonPlot";
            this.sunMoonPlot.Size = new System.Drawing.Size(734, 362);
            this.sunMoonPlot.TabIndex = 6;
            this.sunMoonPlot.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formsPlot1_MouseMove);
            // 
            // lbMoonRise
            // 
            this.lbMoonRise.AutoSize = true;
            this.lbMoonRise.Location = new System.Drawing.Point(12, 56);
            this.lbMoonRise.Name = "lbMoonRise";
            this.lbMoonRise.Size = new System.Drawing.Size(60, 15);
            this.lbMoonRise.TabIndex = 7;
            this.lbMoonRise.Text = "Moon rise";
            // 
            // tbMoonRiseValue
            // 
            this.tbMoonRiseValue.BackColor = System.Drawing.SystemColors.Control;
            this.tbMoonRiseValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMoonRiseValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbMoonRiseValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbMoonRiseValue.Location = new System.Drawing.Point(110, 56);
            this.tbMoonRiseValue.Name = "tbMoonRiseValue";
            this.tbMoonRiseValue.ReadOnly = true;
            this.tbMoonRiseValue.Size = new System.Drawing.Size(150, 16);
            this.tbMoonRiseValue.TabIndex = 53;
            this.tbMoonRiseValue.Tag = "1";
            // 
            // tbMoonSetValue
            // 
            this.tbMoonSetValue.BackColor = System.Drawing.SystemColors.Control;
            this.tbMoonSetValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMoonSetValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbMoonSetValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbMoonSetValue.Location = new System.Drawing.Point(110, 78);
            this.tbMoonSetValue.Name = "tbMoonSetValue";
            this.tbMoonSetValue.ReadOnly = true;
            this.tbMoonSetValue.Size = new System.Drawing.Size(150, 16);
            this.tbMoonSetValue.TabIndex = 55;
            this.tbMoonSetValue.Tag = "1";
            // 
            // lbMoonSet
            // 
            this.lbMoonSet.AutoSize = true;
            this.lbMoonSet.Location = new System.Drawing.Point(12, 78);
            this.lbMoonSet.Name = "lbMoonSet";
            this.lbMoonSet.Size = new System.Drawing.Size(57, 15);
            this.lbMoonSet.TabIndex = 54;
            this.lbMoonSet.Text = "Moon set";
            // 
            // tbSunSetValue
            // 
            this.tbSunSetValue.BackColor = System.Drawing.SystemColors.Control;
            this.tbSunSetValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSunSetValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbSunSetValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbSunSetValue.Location = new System.Drawing.Point(398, 78);
            this.tbSunSetValue.Name = "tbSunSetValue";
            this.tbSunSetValue.ReadOnly = true;
            this.tbSunSetValue.Size = new System.Drawing.Size(150, 16);
            this.tbSunSetValue.TabIndex = 59;
            this.tbSunSetValue.Tag = "1";
            // 
            // lbSunSet
            // 
            this.lbSunSet.AutoSize = true;
            this.lbSunSet.Location = new System.Drawing.Point(300, 78);
            this.lbSunSet.Name = "lbSunSet";
            this.lbSunSet.Size = new System.Drawing.Size(45, 15);
            this.lbSunSet.TabIndex = 58;
            this.lbSunSet.Text = "Sun set";
            // 
            // tblbSunRiseValue
            // 
            this.tblbSunRiseValue.BackColor = System.Drawing.SystemColors.Control;
            this.tblbSunRiseValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblbSunRiseValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tblbSunRiseValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.tblbSunRiseValue.Location = new System.Drawing.Point(398, 56);
            this.tblbSunRiseValue.Name = "tblbSunRiseValue";
            this.tblbSunRiseValue.ReadOnly = true;
            this.tblbSunRiseValue.Size = new System.Drawing.Size(150, 16);
            this.tblbSunRiseValue.TabIndex = 57;
            this.tblbSunRiseValue.Tag = "1";
            // 
            // lbSunRise
            // 
            this.lbSunRise.AutoSize = true;
            this.lbSunRise.Location = new System.Drawing.Point(300, 56);
            this.lbSunRise.Name = "lbSunRise";
            this.lbSunRise.Size = new System.Drawing.Size(48, 15);
            this.lbSunRise.TabIndex = 56;
            this.lbSunRise.Text = "Sun rise";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 474);
            this.Controls.Add(this.tbSunSetValue);
            this.Controls.Add(this.lbSunSet);
            this.Controls.Add(this.tblbSunRiseValue);
            this.Controls.Add(this.lbSunRise);
            this.Controls.Add(this.tbMoonSetValue);
            this.Controls.Add(this.lbMoonSet);
            this.Controls.Add(this.tbMoonRiseValue);
            this.Controls.Add(this.lbMoonRise);
            this.Controls.Add(this.sunMoonPlot);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.mnuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
            this.Name = "FormMain";
            this.Text = "StarMap2D";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button2;
        private Button button3;
        private MenuStrip mnuMain;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem mnuLocalize;
        private ToolStripMenuItem mnuDumpLanguage;
        private ToolStripMenuItem mnuTools;
        private ToolStripMenuItem mnuSettings;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuSkyMap;
        private ToolStripMenuItem mnuObjectDetails;
        private ScottPlot.FormsPlot sunMoonPlot;
        private Label lbMoonRise;
        private TextBox tbMoonRiseValue;
        private TextBox tbMoonSetValue;
        private Label lbMoonSet;
        private TextBox tbSunSetValue;
        private Label lbSunSet;
        private TextBox tblbSunRiseValue;
        private Label lbSunRise;
    }
}