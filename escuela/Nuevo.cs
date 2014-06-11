/*
 * Created by SharpDevelop.
 * User: virtual
 * Date: 17/05/2014
 * Time: 08:07 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace clientes
{
	/// <summary>
	/// Description of Nuevo.
	/// </summary>
	public partial class Nuevo : Form
	{
		private MainForm main;
		public Nuevo(MainForm main)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.main=main;
		}
		
		void BtnGuardarClick(object sender, EventArgs e)
		{
			if(this.txtRfc.Text.Trim()!="" && this.txtNombre.Text.Trim()!="" && this.txtDomicilio.Text.Trim()!="" && this.txtCiudad.Text.Trim()!=""&& this.txtTel.Text.Trim()!=""){
				clientes cliente = new clientes();
				cliente.insertarRegistroNuevo(this.txtRfc.Text.Trim(), this.txtNombre.Text.Trim(), this.txtDomicilio.Text.Trim(), this.txtCiudad.Text.Trim(), this.txtTel.Text.Trim());
				this.main.actualizarTabla();
				System.Windows.Forms.DialogResult result = MessageBox.Show(
					"El cliente se agregó con exito ¿Desea agregar otro Cliente?", "Nuevo cliente",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question,
					MessageBoxDefaultButton.Button1
				);
				
				if(result != System.Windows.Forms.DialogResult.Yes){
					this.Close();
				}else{
					this.txtRfc.Clear();
					this.txtNombre.Clear();
				}
			}
		}
		
		void TextBox3TextChanged(object sender, EventArgs e)
		{
			
		}
	}
}
