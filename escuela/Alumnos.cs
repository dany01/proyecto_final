/*
 * Created by SharpDevelop.
 * User: virtual
 * Date: 17/05/2014
 * Time: 08:15 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using MySql.Data.MySqlClient;

namespace clientes
{
	/// <summary>
	/// Description of Alumnos.
	/// </summary>
	public class clientes : MySQL
	{
		public clientes ()
		{
		}
		
		public void mostrarTodos(){
			this.abrirConexion();
            MySqlCommand myCommand = new MySqlCommand(this.querySelect(), 
			                                          myConnection);
            MySqlDataReader myReader = myCommand.ExecuteReader();	
	        while (myReader.Read()){
	            string id = myReader["id"].ToString();
	            string Rfc = myReader["Rfc"].ToString();
	            string nombre = myReader["nombre"].ToString();
	            string Domicilio = myReader["Domicilio"].ToString();
	            string Ciudad = myReader["Ciudad"].ToString();
	            string Tel = myReader ["Telefono"].ToString();
	            Console.WriteLine("ID: " + id +
				                  "Rfc: " + Rfc +
								  "Nombre" + nombre +
								  "Domicilio" + Domicilio+								  
				                  "Ciudad: " + Ciudad+
				                  "Telefono" + Tel);
	       }
			
            myReader.Close();
			myReader = null;
            myCommand.Dispose();
			myCommand = null;
			this.cerrarConexion();
		}
		
		public Hashtable obtenerPorId(string id){
			Hashtable registro = new Hashtable();
			this.abrirConexion();
            MySqlCommand myCommand = new MySqlCommand("SELECT * FROM clientes WHERE id = '"+id+"'", 
			                                          myConnection);
            MySqlDataReader myReader = myCommand.ExecuteReader();	
            if(myReader.HasRows){
	        	myReader.Read();
	        	registro["id"] = myReader["id"].ToString();
	            registro["Rfc"] = myReader["Rfc"].ToString();
	            registro["nombre"] = myReader["nombre"].ToString();
	            registro["Domicilio"] = myReader["Domicilio"].ToString();
	       		registro["Ciudad"] = myReader["Ciudad"].ToString();
	       		registro["Telefono"] = myReader["Telefono"].ToString();
            }
            
          
            myReader.Close();
			myReader = null;
            myCommand.Dispose();
			myCommand = null;
			this.cerrarConexion();
			return registro;
		}
		
		public void insertarRegistroNuevo(string Rfc, string Nombre, string Domicilio, string Ciudad, string Telefono ){
			this.abrirConexion();
			string sql = "INSERT INTO `clientes` (`Rfc`, `nombre`, `Domicilio`,`Ciudad`,`Telefono`) VALUES ('" + Rfc + "', '" + Nombre + "','" + Domicilio+ "','" + Ciudad + "','" + Telefono + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}
		public void editar(string id, string Rfc, string nombre, string Domicilio, string Ciudad, string Telefono){
			this.abrirConexion();
			string sql = "UPDATE `clientes` SET `Rfc`='" + Rfc + "', `nombre`='" + nombre + "',`Domicilio`='" + Domicilio + "',`Ciudad`='" + Ciudad + "',`Telefono`='" + Telefono + "' WHERE (`id`='" + id + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}
		
		public void editarCodigoRegistro(string id, string Rfc, string Domcilio, string Ciudad, string Telefono){
			this.abrirConexion();
			string sql = "UPDATE `clientes` SET `Rfc`='" + Rfc + "' WHERE (`id`='" + id + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}
		
		public void editarNombreRegistro(string id, string nombre,  string Domcilio, string Ciudad, string Telefono){
			this.abrirConexion();
			string sql = "UPDATE `clientes` SET `nombre`='" + nombre + "' WHERE (`id`='" + id + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}
		
		public void editarDomicilioRegistro(string id, string nombre,  string Domcilio, string Ciudad, string Telefono){
			this.abrirConexion();
			string sql = "UPDATE `clientes` SET `Domicilio`='" + Domcilio + "' WHERE (`id`='" + id + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}
		
		public void eliminarRegistroPorId(string id){
			this.abrirConexion();
			string sql = "DELETE FROM `clientes` WHERE (`id`='" + id + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}
		
		private int ejecutarComando(string sql){
			MySqlCommand myCommand = new MySqlCommand(sql,this.myConnection);
			int afectadas = myCommand.ExecuteNonQuery();
			myCommand.Dispose();
			myCommand = null;
			return afectadas;
		}
		
		private string querySelect(){
			return "SELECT * " +
	           	"FROM clientes";
		}
	}
}
