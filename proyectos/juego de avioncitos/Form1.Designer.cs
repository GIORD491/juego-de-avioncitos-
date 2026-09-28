namespace juego_de_avioncitos;
partial class Form1
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.PictureBox contiene;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) { components.Dispose(); }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.contiene = new System.Windows.Forms.PictureBox();
        this.statusStrip1 = new System.Windows.Forms.StatusStrip();
        this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
        this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
        ((System.ComponentModel.ISupportInitialize)(this.contiene)).BeginInit();
        this.statusStrip1.SuspendLayout();
        this.SuspendLayout();
        //
        // contiene
        //
        this.contiene.BackColor = System.Drawing.Color.AliceBlue;
        this.contiene.Dock = System.Windows.Forms.DockStyle.Fill;
        this.contiene.Location = new System.Drawing.Point(0, 0);
        this.contiene.Name = "contiene";
        this.contiene.Size = new System.Drawing.Size(900, 574);
        this.contiene.TabIndex = 0;
        this.contiene.TabStop = false;
        //
        // statusStrip1
        //
        this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
        this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        this.toolStripStatusLabel1,
        this.toolStripStatusLabel2});
        this.statusStrip1.Location = new System.Drawing.Point(0, 574);
        this.statusStrip1.Name = "statusStrip1";
        this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
        this.statusStrip1.Size = new System.Drawing.Size(900, 30);
        this.statusStrip1.TabIndex = 1;
        this.statusStrip1.Text = "statusStrip1";
        //
        // toolStripStatusLabel1
        //
        this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
        this.toolStripStatusLabel1.Size = new System.Drawing.Size(58, 25);
        this.toolStripStatusLabel1.Text = "Mi Rival";
        //
        // toolStripStatusLabel2
        //
        this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
        this.toolStripStatusLabel2.Size = new System.Drawing.Size(66, 25);
        this.toolStripStatusLabel2.Text = "Mi Avion";
        //
        // Form1
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(900, 604);
        this.Controls.Add(this.statusStrip1);
        this.Controls.Add(this.contiene);
        this.Name = "form1";
        this.Text = "juego de avioncitos";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        ((System.ComponentModel.ISupportInitialize)(this.contiene)).EndInit();
        this.statusStrip1.ResumeLayout(false);
        this.statusStrip1.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}