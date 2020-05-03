using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Revenge_Account_Nuker
{
	public class Form1 : Form
	{
		public Form1()
		{
			this.InitializeComponent();
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}

		private async void Form1_Load(object sender, EventArgs e)
		{
			this.handlers = default(DiscordRpc.EventHandlers);
			DiscordRpc.Initialize("672004737192820737", ref this.handlers, true, null);
			this.handlers = default(DiscordRpc.EventHandlers);
			DiscordRpc.Initialize("672004737192820737", ref this.handlers, true, null);
			this.presence.details = "Revnge Account Nuker - Nuking Accounts";
			this.presence.state = "Logging in";
			this.presence.largeImageKey = "Nuking Accounts";
			this.presence.smallImageKey = "Nuking Accounts";
			this.presence.largeImageText = "RevengeLogoForRpc";
			DiscordRpc.UpdatePresence(ref this.presence);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Nuker.LoadToken(this.textBox1.Text);
			this.handlers = default(DiscordRpc.EventHandlers);
			DiscordRpc.Initialize("672004737192820737", ref this.handlers, true, null);
			this.handlers = default(DiscordRpc.EventHandlers);
			DiscordRpc.Initialize("672004737192820737", ref this.handlers, true, null);
			this.presence.details = "Revnge Account Nuker - Nuking Accounts";
			this.presence.state = "Nuking " + Nuker.Client.User.Username + "'s account";
			this.presence.largeImageKey = "Nuking Accounts";
			this.presence.smallImageKey = "Nuking Accounts";
			this.presence.largeImageText = "RevengeLogoForRpc";
			DiscordRpc.UpdatePresence(ref this.presence);
			Nuker.nuker();
		}

		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
			this.panel1 = new Panel();
			this.pictureBox1 = new PictureBox();
			this.textBox1 = new TextBox();
			this.label1 = new Label();
			this.button1 = new Button();
			this.panel1.SuspendLayout();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.panel1.BackColor = Color.PowderBlue;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(441, 83);
			this.panel1.TabIndex = 0;
			this.pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new Point(124, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new Size(161, 101);
			this.pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.textBox1.Location = new Point(156, 162);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new Size(116, 20);
			this.textBox1.TabIndex = 1;
			this.textBox1.TextChanged += this.textBox1_TextChanged;
			this.label1.AutoSize = true;
			this.label1.Location = new Point(153, 137);
			this.label1.Name = "label1";
			this.label1.Size = new Size(38, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Token";
			this.button1.Location = new Point(172, 188);
			this.button1.Name = "button1";
			this.button1.Size = new Size(75, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Nuke";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += this.button1_Click;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(440, 282);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.panel1);
			base.Name = "Form1";
			this.Text = "Revenge Account Nuker";
			base.Load += this.Form1_Load;
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private DiscordRpc.EventHandlers handlers;

		private DiscordRpc.RichPresence presence;

		private IContainer components = null;

		private Panel panel1;

		private PictureBox pictureBox1;

		private TextBox textBox1;

		private Label label1;

		private Button button1;
	}
}
