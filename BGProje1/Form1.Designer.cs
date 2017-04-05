namespace BGProje1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.çizgiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dikdörtgenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çokgenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tasiToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.olcekToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dondurToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.nesnelerComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.degisimToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.çizgiRengiDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dolguRengiDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kalınlıkDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.saydamlıkDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desenDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çiçekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.damalıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.köpekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çapaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cizdirToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.saydamlikTrackBar = new System.Windows.Forms.TrackBar();
            this.aciTrackBar = new System.Windows.Forms.TrackBar();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saydamlikTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aciTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.tasiToolStripButton,
            this.olcekToolStripButton,
            this.dondurToolStripButton,
            this.nesnelerComboBox,
            this.degisimToolStripDropDownButton,
            this.silToolStripButton,
            this.cizdirToolStripLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(845, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çizgiToolStripMenuItem,
            this.dikdörtgenToolStripMenuItem,
            this.elipsToolStripMenuItem,
            this.çokgenToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(45, 36);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.ToolTipText = "Nesne Ekleme";
            // 
            // çizgiToolStripMenuItem
            // 
            this.çizgiToolStripMenuItem.Name = "çizgiToolStripMenuItem";
            this.çizgiToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.çizgiToolStripMenuItem.Text = "Çizgi";
            this.çizgiToolStripMenuItem.Click += new System.EventHandler(this.çizgiToolStripMenuItem_Click);
            // 
            // dikdörtgenToolStripMenuItem
            // 
            this.dikdörtgenToolStripMenuItem.Name = "dikdörtgenToolStripMenuItem";
            this.dikdörtgenToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.dikdörtgenToolStripMenuItem.Text = "Dikdörtgen";
            this.dikdörtgenToolStripMenuItem.Click += new System.EventHandler(this.dikdörtgenToolStripMenuItem_Click);
            // 
            // elipsToolStripMenuItem
            // 
            this.elipsToolStripMenuItem.Name = "elipsToolStripMenuItem";
            this.elipsToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.elipsToolStripMenuItem.Text = "Elips";
            this.elipsToolStripMenuItem.Click += new System.EventHandler(this.elipsToolStripMenuItem_Click);
            // 
            // çokgenToolStripMenuItem
            // 
            this.çokgenToolStripMenuItem.Name = "çokgenToolStripMenuItem";
            this.çokgenToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.çokgenToolStripMenuItem.Text = "Çokgen..";
            this.çokgenToolStripMenuItem.Click += new System.EventHandler(this.çokgenToolStripMenuItem_Click);
            // 
            // tasiToolStripButton
            // 
            this.tasiToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tasiToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("tasiToolStripButton.Image")));
            this.tasiToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tasiToolStripButton.Name = "tasiToolStripButton";
            this.tasiToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.tasiToolStripButton.Text = "toolStripButton2";
            this.tasiToolStripButton.ToolTipText = "Taşıma";
            this.tasiToolStripButton.Click += new System.EventHandler(this.tasiToolStripButton_Click);
            // 
            // olcekToolStripButton
            // 
            this.olcekToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.olcekToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("olcekToolStripButton.Image")));
            this.olcekToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.olcekToolStripButton.Name = "olcekToolStripButton";
            this.olcekToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.olcekToolStripButton.Text = "toolStripButton4";
            this.olcekToolStripButton.ToolTipText = "Ölçeklendirme";
            this.olcekToolStripButton.Click += new System.EventHandler(this.olcekToolStripButton_Click);
            // 
            // dondurToolStripButton
            // 
            this.dondurToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dondurToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("dondurToolStripButton.Image")));
            this.dondurToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dondurToolStripButton.Name = "dondurToolStripButton";
            this.dondurToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.dondurToolStripButton.Text = "toolStripButton3";
            this.dondurToolStripButton.ToolTipText = "Döndürme";
            this.dondurToolStripButton.Click += new System.EventHandler(this.dondurToolStripButton_Click);
            // 
            // nesnelerComboBox
            // 
            this.nesnelerComboBox.Name = "nesnelerComboBox";
            this.nesnelerComboBox.Size = new System.Drawing.Size(121, 39);
            this.nesnelerComboBox.SelectedIndexChanged += new System.EventHandler(this.nesnelerComboBox_SelectedIndexChanged);
            // 
            // degisimToolStripDropDownButton
            // 
            this.degisimToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.degisimToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çizgiRengiDeğiştirToolStripMenuItem,
            this.dolguRengiDeğiştirToolStripMenuItem,
            this.kalınlıkDeğiştirToolStripMenuItem,
            this.saydamlıkDeğiştirToolStripMenuItem,
            this.desenDeğiştirToolStripMenuItem});
            this.degisimToolStripDropDownButton.Image = global::BGProje1.Properties.Resources.degisim;
            this.degisimToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.degisimToolStripDropDownButton.Name = "degisimToolStripDropDownButton";
            this.degisimToolStripDropDownButton.Size = new System.Drawing.Size(45, 36);
            this.degisimToolStripDropDownButton.Tag = "Değişim";
            this.degisimToolStripDropDownButton.Text = "Değişim";
            this.degisimToolStripDropDownButton.Visible = false;
            this.degisimToolStripDropDownButton.Click += new System.EventHandler(this.degisimToolStripDropDownButton_Click);
            // 
            // çizgiRengiDeğiştirToolStripMenuItem
            // 
            this.çizgiRengiDeğiştirToolStripMenuItem.Name = "çizgiRengiDeğiştirToolStripMenuItem";
            this.çizgiRengiDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.çizgiRengiDeğiştirToolStripMenuItem.Text = "Çizgi Rengi Değiştir";
            this.çizgiRengiDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.çizgiRengiDeğiştirToolStripMenuItem_Click);
            // 
            // dolguRengiDeğiştirToolStripMenuItem
            // 
            this.dolguRengiDeğiştirToolStripMenuItem.Name = "dolguRengiDeğiştirToolStripMenuItem";
            this.dolguRengiDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.dolguRengiDeğiştirToolStripMenuItem.Text = "Dolgu Rengi Değiştir";
            this.dolguRengiDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.dolguRengiDeğiştirToolStripMenuItem_Click);
            // 
            // kalınlıkDeğiştirToolStripMenuItem
            // 
            this.kalınlıkDeğiştirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.kalınlıkDeğiştirToolStripMenuItem.Name = "kalınlıkDeğiştirToolStripMenuItem";
            this.kalınlıkDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.kalınlıkDeğiştirToolStripMenuItem.Text = "Kalınlık Değiştir";
            this.kalınlıkDeğiştirToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.kalınlıkDeğiştirToolStripMenuItem_DropDownItemClicked);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem2.Text = "1";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem3.Text = "2";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem4.Text = "3";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem5.Text = "4";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem6.Text = "5";
            // 
            // saydamlıkDeğiştirToolStripMenuItem
            // 
            this.saydamlıkDeğiştirToolStripMenuItem.Name = "saydamlıkDeğiştirToolStripMenuItem";
            this.saydamlıkDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.saydamlıkDeğiştirToolStripMenuItem.Text = "Saydamlık Değiştir";
            this.saydamlıkDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.saydamlıkDeğiştirToolStripMenuItem_Click);
            // 
            // desenDeğiştirToolStripMenuItem
            // 
            this.desenDeğiştirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çiçekToolStripMenuItem,
            this.damalıToolStripMenuItem,
            this.köpekToolStripMenuItem,
            this.çapaToolStripMenuItem});
            this.desenDeğiştirToolStripMenuItem.Name = "desenDeğiştirToolStripMenuItem";
            this.desenDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.desenDeğiştirToolStripMenuItem.Text = "Desen Değiştir";
            this.desenDeğiştirToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.desenDeğiştirToolStripMenuItem_DropDownItemClicked);
            // 
            // çiçekToolStripMenuItem
            // 
            this.çiçekToolStripMenuItem.Name = "çiçekToolStripMenuItem";
            this.çiçekToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.çiçekToolStripMenuItem.Text = "Pug";
            // 
            // damalıToolStripMenuItem
            // 
            this.damalıToolStripMenuItem.Name = "damalıToolStripMenuItem";
            this.damalıToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.damalıToolStripMenuItem.Text = "Yıldız";
            // 
            // köpekToolStripMenuItem
            // 
            this.köpekToolStripMenuItem.Name = "köpekToolStripMenuItem";
            this.köpekToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.köpekToolStripMenuItem.Text = "At";
            // 
            // çapaToolStripMenuItem
            // 
            this.çapaToolStripMenuItem.Name = "çapaToolStripMenuItem";
            this.çapaToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.çapaToolStripMenuItem.Text = "Çapa";
            // 
            // silToolStripButton
            // 
            this.silToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.silToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("silToolStripButton.Image")));
            this.silToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.silToolStripButton.Name = "silToolStripButton";
            this.silToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.silToolStripButton.Text = "Silme";
            this.silToolStripButton.Visible = false;
            this.silToolStripButton.Click += new System.EventHandler(this.silToolStripButton_Click);
            // 
            // cizdirToolStripLabel
            // 
            this.cizdirToolStripLabel.Name = "cizdirToolStripLabel";
            this.cizdirToolStripLabel.Size = new System.Drawing.Size(81, 36);
            this.cizdirToolStripLabel.Text = "Çokgen Çizdir";
            this.cizdirToolStripLabel.ToolTipText = "Çizdir";
            this.cizdirToolStripLabel.Visible = false;
            this.cizdirToolStripLabel.Click += new System.EventHandler(this.cizdirToolStripLabel_Click);
            this.cizdirToolStripLabel.MouseLeave += new System.EventHandler(this.cizdirToolStripLabel_MouseLeave);
            this.cizdirToolStripLabel.MouseHover += new System.EventHandler(this.cizdirToolStripLabel_MouseHover);
            // 
            // saydamlikTrackBar
            // 
            this.saydamlikTrackBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.saydamlikTrackBar.Location = new System.Drawing.Point(533, 39);
            this.saydamlikTrackBar.Maximum = 255;
            this.saydamlikTrackBar.Name = "saydamlikTrackBar";
            this.saydamlikTrackBar.Size = new System.Drawing.Size(312, 461);
            this.saydamlikTrackBar.TabIndex = 1;
            this.saydamlikTrackBar.TickFrequency = 25;
            this.saydamlikTrackBar.Value = 255;
            this.saydamlikTrackBar.Visible = false;
            this.saydamlikTrackBar.Scroll += new System.EventHandler(this.saydamlikTrackBar_Scroll);
            this.saydamlikTrackBar.MouseLeave += new System.EventHandler(this.saydamlikTrackBar_MouseLeave);
            // 
            // aciTrackBar
            // 
            this.aciTrackBar.AutoSize = false;
            this.aciTrackBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.aciTrackBar.Location = new System.Drawing.Point(0, 455);
            this.aciTrackBar.Maximum = 360;
            this.aciTrackBar.Name = "aciTrackBar";
            this.aciTrackBar.Size = new System.Drawing.Size(533, 45);
            this.aciTrackBar.TabIndex = 2;
            this.aciTrackBar.Visible = false;
            this.aciTrackBar.Scroll += new System.EventHandler(this.aciTrackBar_Scroll);
            this.aciTrackBar.MouseLeave += new System.EventHandler(this.aciTrackBar_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 500);
            this.Controls.Add(this.aciTrackBar);
            this.Controls.Add(this.saydamlikTrackBar);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "2D Çizim Programı";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saydamlikTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aciTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripButton tasiToolStripButton;
        private System.Windows.Forms.ToolStripButton olcekToolStripButton;
        private System.Windows.Forms.ToolStripButton dondurToolStripButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem çizgiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dikdörtgenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elipsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çokgenToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripComboBox nesnelerComboBox;
        private System.Windows.Forms.ToolStripLabel cizdirToolStripLabel;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ToolStripDropDownButton degisimToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem çizgiRengiDeğiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dolguRengiDeğiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kalınlıkDeğiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saydamlıkDeğiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desenDeğiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.TrackBar saydamlikTrackBar;
        private System.Windows.Forms.ToolStripMenuItem çiçekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem damalıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem köpekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çapaToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton silToolStripButton;
        private System.Windows.Forms.TrackBar aciTrackBar;
    }
}

