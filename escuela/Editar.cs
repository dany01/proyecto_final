/*
 * Created by SharpDevelop.
 * User: virtual
 * Date: 17/05/2014
 * Time: 08:24 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace clientes
{
	/// <summary>
	/// Description of Editar.
	/// </summary>
	public partial class Editar : Form
	{
		private MainForm main;
		private string id;
		
		public Editar(MainForm main, string id)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.main = main;
			this.id = id;
		}
		
		public void BtnGuardarClick(object sender, EventArgs e)
		{
			if(this.txtRfc.Text.Trim()!="" && this.txtNombre.Text.Trim()!=""&&
			    this.txtDomicilio.Text.Trim()!="" && this.txtCiudad.Text.Trim()!=""&& this.txtTel.Text.Trim()!=""){
				clientes cliente = new clientes();
				cliente.editar(this.id, this.txtRfc.Text.Trim(), this.txtNombre.Text.Trim(), this.txtDomicilio.Text.Trim(), this.txtCiudad.Text.Trim(), this.txtTel.Text.Trim());
				this.main.actualizarTabla();
				MessageBox.Show("Se editó con exito");
				this.Close();
			}
		}
		
		
		void EditarLoad(object sender, EventArgs e)
		{
			System.Collections.Hashtable registro = new System.Collections.Hashtable();
			clientes cliente = new clientes();
			registro = cliente.obtenerPorId(this.id);
			this.txtRfc.Text =registro["Rfc"].ToString();
			this.txtNombre.Text =registro["nombre"].ToString();
			this.txtDomicilio.Text = registro["Domicilio"].ToString();
			this.txtCiudad.Text = registro["Ciudad"].ToString();
			this.txtTel.Text = registro["Telefono"].ToString();
		}
		
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void Label3Click(object sender, EventArgs e)
		{
			
		}
		
		void TxtDomicilioTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void Label4Click(object sender, EventArgs e)
		{
			
		}
		
		void TxtTelTextChanged(object sender, EventArgs e)
		{
			
		}
	}
}
