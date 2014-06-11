/*
 * Created by SharpDevelop.
 * User: virtual
 * Date: 17/05/2014
 * Time: 08:07 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace clientes
{
	partial class Nuevo
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nuevo));
			this.txtRfc = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.txtTel = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtDomicilio = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtCiudad = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtRfc
			// 
			this.txtRfc.Location = new System.Drawing.Point(25, 62);
			this.txtRfc.MaxLength = 10;
			this.txtRfc.Name = "txtRfc";
			this.txtRfc.Size = new System.Drawing.Size(100, 20);
			this.txtRfc.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(25, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 7;
			this.label1.Text = "Rfc";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(25, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nombre";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(25, 116);
			this.txtNombre.MaxLength = 256;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(255, 20);
			this.txtNombre.TabIndex = 1;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
			this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardar.Location = new System.Drawing.Point(25, 356);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(255, 47);
			this.btnGuardar.TabIndex = 5;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// txtTel
			// 
			this.txtTel.Location = new System.Drawing.Point(25, 313);
			this.txtTel.Name = "txtTel";
			this.txtTel.Size = new System.Drawing.Size(255, 20);
			this.txtTel.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(25, 286);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 20;
			this.label5.Text = "Telefono";
			// 
			// txtDomicilio
			// 
			this.txtDomicilio.Location = new System.Drawing.Point(25, 242);
			this.txtDomicilio.Name = "txtDomicilio";
			this.txtDomicilio.Size = new System.Drawing.Size(255, 20);
			this.txtDomicilio.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(25, 215);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 18;
			this.label4.Text = "Domicilio";
			// 
			// txtCiudad
			// 
			this.txtCiudad.Location = new System.Drawing.Point(25, 176);
			this.txtCiudad.Name = "txtCiudad";
			this.txtCiudad.Size = new System.Drawing.Size(255, 20);
			this.txtCiudad.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(25, 150);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 16;
			this.label3.Text = "Ciudad";
			// 
			// Nuevo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(340, 415);
			this.Controls.Add(this.txtTel);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtDomicilio);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtCiudad);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtRfc);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Nuevo";
			this.Text = "Nuevo";
			this.Load += new System.EventHandler(this.NuevoLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCiudad;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtDomicilio;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtTel;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtRfc;
		
		void Label3Click(object sender, System.EventArgs e)
		{
			
		}
		
		void DomainUpDown1SelectedItemChanged(object sender, System.EventArgs e)
		{
			
		}
		
		void NuevoLoad(object sender, System.EventArgs e)
		{
			
		}
		
		void CheckedListBox1SelectedIndexChanged(object sender, System.EventArgs e)
		{
			
		}
	}
}
