/* * Created by SharpDevelop.
 * User: virtual
 * Date: 17/05/2014
 * Time: 08:15 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MySql.Data.MySqlClient;

namespace clientes
{
	/// <summary>
	/// Description of MySQL.
	/// </summary>
	public class MySQL
	{
		protected MySqlConnection myConnection;
		public MySQL ()
		{
		}
		
		protected void abrirConexion(){
			string connectionString =
          		"Server=127.0.0.1;" +
	          	"Database=proyecto;" +
	          	"User ID=root;" +
	          	"Password=1602;" +
	          	"Pooling=false;";
	       this.myConnection = new MySqlConnection(connectionString);
	       this.myConnection.Open();
		}
		
		protected void cerrarConexion(){
			this.myConnection.Close(); 
			this.myConnection = null;
		}
	}
}
