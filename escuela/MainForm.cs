/*
 * Created by SharpDevelop.
 * User: virtual
 * Date: 17/05/2014
 * Time: 07:18 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace clientes
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private MySqlCommand myCmdQuery;
		private MySqlDataAdapter myDataAdapter;
		private BindingSource myBindingSource;
		private MySqlCommandBuilder myCommandBuilder;
		private DataSet myDataSet;
		private MySqlConnection myConnection;
		private string myStringCon;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.myCmdQuery= new MySqlCommand();
			this.myDataAdapter=new MySqlDataAdapter();
			this.myBindingSource=new BindingSource();
			this.myCommandBuilder =new MySqlCommandBuilder();
			this.myDataSet=new DataSet();
			this.myStringCon=
				"Server=127.0.0.1;" +
				"Database=proyecto;" +
				"User ID=root;" +
				"Password=1602;" +
				"Pooling=false;";
			

		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			//create an instance of MySqlConnection class
			this.myConnection = new MySqlConnection(this.myStringCon);
			try{
				this.myConnection.Open();
			}catch(MySqlException ex){
				MessageBox.Show(ex.Message);
				System.Environment.Exit(1);
			}
			
			this.myCmdQuery.CommandText="SELECT * FROM clientes";
			this.myCmdQuery.CommandType=CommandType.Text;
			this.myCmdQuery.Connection=this.myConnection;
			
			this.myDataAdapter.SelectCommand=this.myCmdQuery;
			this.myCommandBuilder.DataAdapter=this.myDataAdapter;

			//Llenar el dataset
			this.myDataAdapter.Fill(this.myDataSet,"clientes");
			this.myBindingSource.DataSource=this.myDataSet;
			this.myBindingSource.DataMember="clientes";
			this.myDataGrid.DataSource=this.myBindingSource;

		}
		
		void BtnAgregarClick(object sender, EventArgs e)
		{
			Nuevo nuevo = new Nuevo(this);
			nuevo.Show();
		}
		
		void BtnEditarClick(object sender, EventArgs e)
		{
			if(this.myDataGrid.SelectedRows.Count>0){
				DataGridViewRow row = this.myDataGrid.SelectedRows[0];
				DataGridViewCell cell0 = row.Cells[0];
				DataGridViewCell cell1 = row.Cells[1];
				DataGridViewCell cell2 = row.Cells[2];
				DataGridViewCell cell3 = row.Cells[3];
				DataGridViewCell cell4 = row.Cells[4];
				DataGridViewCell cell5 = row.Cells[5];
				string id = cell0.Value.ToString();
				string nombre = cell1.Value.ToString();
				string Rfc = cell2.Value.ToString();
				string Domicilio = cell3.Value.ToString();
				string Ciudad = cell4.Value.ToString();
				string Telefono = cell5.Value.ToString();
				Editar editar = new Editar(this, id);
				editar.Show();
			}
		}
		
		void BtnEliminarClick(object sender, EventArgs e)
		{
			if(this.myDataGrid.SelectedRows.Count>0){
				DataGridViewRow row = this.myDataGrid.SelectedRows[0];
				DataGridViewCell cell0 = row.Cells[0];
				DataGridViewCell cell1 = row.Cells[1];
				DataGridViewCell cell2 = row.Cells[2];
				DataGridViewCell cell3 = row.Cells[3];
				DataGridViewCell cell4 = row.Cells[4];
				DataGridViewCell cell5 = row.Cells[5];
				string id = cell0.Value.ToString();
				string nombre = cell1.Value.ToString();
				string Rfc = cell2.Value.ToString();
				string Domicilio = cell3.Value.ToString();
				string Ciudad = cell4.Value.ToString();
				string Telefono = cell5.Value.ToString();
				System.Windows.Forms.DialogResult result = MessageBox.Show(
					"¿Está seguro que desea eliminar al cliente con el nombre " + nombre + "?", "Confirmar eliminación",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question,
					MessageBoxDefaultButton.Button1
				);
				
				if(result == System.Windows.Forms.DialogResult.Yes){
					this.eliminarAlumno(id);
					this.actualizarTabla();
					MessageBox.Show("El Cliente con el Nombre " + nombre + " fue eliminado con exito.");
				}
			}
		}
		
		private void eliminarAlumno(string id){
			string sql = "DELETE FROM `clientes` WHERE (`id`='" + id + "')";
			this.ejecutarComando(sql);
		}
		
		private int ejecutarComando(string sql){
			MySqlCommand myCommand = new MySqlCommand(sql,this.myConnection);
			int afectadas = myCommand.ExecuteNonQuery();
			myCommand.Dispose();
			myCommand = null;
			return afectadas;
		}
		
		public void actualizarTabla(){
			try{
				this.myDataSet.Clear();
				this.myDataAdapter.Fill(this.myDataSet,"clientes");
				this.myBindingSource.DataSource=this.myDataSet;
				this.myBindingSource.DataMember="clientes";
				this.myDataGrid.DataSource=this.myBindingSource;
				this.myDataGrid.Update();
				this.myDataGrid.Refresh();
			}catch(MySqlException ex){
				MessageBox.Show(ex.Message);
			}
		}
		
		
		private void btnClose_Click(){

  			 this.Close();

				}
			}
		}
	
