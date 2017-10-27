using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WinniesService
{
    class Utils
    {
        public static string compararTablasConPrioridadRemota(DataTable tablaLocal, DataTable tablaRemota)
        {

            string query = string.Empty;

            if (tablaRemota.Columns.Count > tablaLocal.Columns.Count)
            {
                foreach(DataColumn columna in tablaRemota.Columns)
                {
                    if (tablaLocal.Columns[columna.ColumnName] == null)
                    {
                        Console.WriteLine("hola");
                    }
                }
            }

            
            DataTable diferencia = new DataTable();
            
            foreach (DataRow fila in tablaRemota.AsEnumerable())
            {
                
            }

            return query;
        }

        
        public static string compararEstructuras(DataTable tablaLocal, DataTable tablaRemota, string tabla)
        {

            string query = string.Empty;

            if (tablaRemota.Rows.Count > tablaLocal.Rows.Count)
            {
                
                for (int i = 0; i < tablaRemota.Rows.Count; i++ )
                {
                    if (i < tablaLocal.Rows.Count)
                    {
                        Console.WriteLine(tablaLocal.Rows[i][0].ToString());
                        
                    }
                    else
                    {
                        query += "alter table " + tabla + " add ";
                        query += tablaRemota.Rows[i][0].ToString();
                        switch (tablaRemota.Rows[i][1].ToString())
                        {
                            case "char":
                                query += " char(12); ";
                                break;
                            case "varchar":
                                query += " varchar(30);  ";
                                break;
                            default:
                                query += " " + tablaRemota.Rows[i][1].ToString() + " ;";
                                break;

                        }
                        Console.WriteLine(query);
                    }
                }
            }


            query = query.Replace("), ", "); ");
            return query;
        }

        public static string armarQueryActualizacion(DataTable estructuraTablaRemota, DataTable datosLocales, DataTable datosRemotos, string tabla)
        {

            string query = string.Empty;
            string queryUpdate = string.Empty;


            for (int l = 0; l < datosRemotos.Rows.Count; l++)
            {
                for (int m = 0; m < datosLocales.Rows.Count; m++)
                {
                    if (datosRemotos.Rows[l][0].Equals(datosLocales.Rows[m][0]))
                    {
                        queryUpdate += " update " + tabla + " set ";
                        for (int j = 1; j < estructuraTablaRemota.Rows.Count; j++)
                        {
                            queryUpdate += " " + estructuraTablaRemota.Rows[j][0] + " = ";
                            switch (estructuraTablaRemota.Rows[j][1].ToString())
                            {
                                case "int":
                                case "money":
                                case "float":
                                case "long":
                                case "decimal":
                                    string moneda = datosRemotos.Rows[l][j].ToString().Replace(",", ".");
                                    if (!string.IsNullOrEmpty(moneda))
                                    {
                                        queryUpdate += moneda + " ,";
                                    }
                                    else
                                    {
                                        queryUpdate += " null ,";
                                    }
                                    
                                    break;
                                case "char":
                                case "varchar":
                                
                                case "bit":
                                    queryUpdate += " '" + datosRemotos.Rows[l][j] + "' ,";
                                    break;
                                case "datetime":

                                    string fechaStr = datosRemotos.Rows[l][j].ToString();
                                    if(!string.IsNullOrEmpty(fechaStr))
                                    {
                                        DateTime dt = DateTime.Parse(fechaStr);

                                        string fecha = dt.ToString("yyyy-MM-dd HH:mm:ss");
                                        queryUpdate += " '" + fecha + "',  \n ";
                                    
                                    }
                                    else
                                    {
                                        queryUpdate += " null,  \n ";
                                    }
                                    break;

                            }


                        }
                        queryUpdate += " where ";
                        queryUpdate = queryUpdate.Replace(", where ", "where ");
                        queryUpdate += estructuraTablaRemota.Rows[0][0] + " = ";
                        switch (estructuraTablaRemota.Rows[0][1].ToString())
                        {
                            case "int":
                            case "money":
                            case "float":
                            case "long":
                            case "decimal":
                            
                                string moneda = datosRemotos.Rows[l][0].ToString().Replace(",", ".");
                                if(!string.IsNullOrEmpty(moneda))
                                {
                                    queryUpdate +=  moneda+ "\n ";
                                }
                                else
                                {
                                    queryUpdate += " null \n ";
                                }
                                
                                break;
                            case "char":
                            case "varchar":
                            case "bit":
                                queryUpdate += " '" + datosRemotos.Rows[l][0] + "' \n ";
                                break;
                            case "datetime":
                                string fechaStr = datosRemotos.Rows[l][0].ToString();

                                if(!string.IsNullOrEmpty(fechaStr))
                                {
                                    DateTime dt = DateTime.Parse(fechaStr);
                                    string fecha = dt.ToString("yyyy-MM-dd HH:mm:ss");
                                    queryUpdate += " '" + fecha + "' \n ";
                                
                                }
                                else
                                {
                                    queryUpdate += " null \n ";
                                }
                                break;

                        }


                    }
                }

            }

         
            query = queryUpdate ;


            return query;
        }


        public static string insertarDatosLocales(DataTable estructuraTablaRemota, DataTable datosLocales, DataTable datosRemotos, string tabla, bool identity = false)
        {
            string queryInsert = string.Empty;


            for (int l = 0; l < datosRemotos.Rows.Count; l++)
            {
                string query = string.Empty;
                if (datosLocales.Rows.Count > 0)
                {
                    for (int m = 0; m < datosLocales.Rows.Count; m++)
                    {
                        if (datosRemotos.Rows[l][0].Equals(datosLocales.Rows[m][0]))
                        {
                            query = string.Empty;
                            break;
                        }
                        else
                        {
                            string codigoIdentitity = "set identity_insert " + tabla + " on;";
                            query = " \n insert into " + tabla + "(";
                            if (identity)
                            {
                                query = codigoIdentitity + query;
                            }

                            string cadenaInicial = query;
                            for (int j = 0; j < estructuraTablaRemota.Rows.Count; j++)
                            {
                                if (query == cadenaInicial)
                                {
                                    query += estructuraTablaRemota.Rows[j][0] + " ";
                                }
                                else
                                {
                                    query += ", " + estructuraTablaRemota.Rows[j][0] + " ";
                                }

                            }

                            query += ") values (";

                            // valores

                            for (int k = 0; k < datosRemotos.Columns.Count; k++)
                            {
                                switch (estructuraTablaRemota.Rows[k][1].ToString())
                                {
                                    case "int":
                                    case "money":
                                    case "float":
                                    case "long":
                                    case "decimal":
                                        string moneda = datosRemotos.Rows[l][k].ToString().Replace(",", ".");
                                        if (!string.IsNullOrEmpty(moneda))
                                        {
                                            query += moneda + " ,";
                                        }
                                        else
                                        {
                                            query += " null ,"; 
                                        }

                                        
                                        break;
                                    case "char":
                                    case "varchar":
                                    case "bit":
                                        query += " '" + datosRemotos.Rows[l][k] + "' ,";
                                        break;

                                    case "datetime":
                                        
                                        string fechaStr = datosRemotos.Rows[l][k].ToString();
                                        if (!string.IsNullOrEmpty(fechaStr))
                                        {
                                            DateTime dt = DateTime.Parse(fechaStr);

                                            string fecha = dt.ToString("yyyy-MM-dd HH:mm:ss");
                                            query += " '" + fecha + "' ,";
                                        }
                                        else
                                        {
                                            query += " null , ";
                                        }
                                        break;

                                }
                            }

                            query += ");";

                            query = query.Replace(",);", "); \n ");
                        }
                    }
                }
                else
                {
                    string codigoIdentitity = "set identity_insert " + tabla + " on;";
                    query = " \n insert into " + tabla + "(";
                    if (identity)
                    {
                        query = codigoIdentitity + query;
                    }

                    string cadenaInicial = query;
                    for (int j = 0; j < estructuraTablaRemota.Rows.Count; j++)
                    {
                        if (query == cadenaInicial)
                        {
                            query += estructuraTablaRemota.Rows[j][0] + " ";
                        }
                        else
                        {
                            query += ", " + estructuraTablaRemota.Rows[j][0] + " ";
                        }

                    }

                    query += ") values (";

                    // valores

                    for (int k = 0; k < datosRemotos.Columns.Count; k++)
                    {
                        switch (estructuraTablaRemota.Rows[k][1].ToString())
                        {
                            case "int":
                            case "money":
                            case "float":
                            case "long":
                            case "decimal":

                                string moneda = datosRemotos.Rows[l][k].ToString();
                                if(string.IsNullOrEmpty(moneda)){
                                    query += " null ,";
                                }
                                else{
                                    query += moneda.Replace(",", ".") + " ,";
                                }
                                break;
                            case "char":
                            case "varchar":
                            case "bit":
                                query += " '" + datosRemotos.Rows[l][k] + "' ,";
                                break;

                            case "datetime":
                                string fechaStr = datosRemotos.Rows[l][k].ToString();
                                if (string.IsNullOrEmpty(fechaStr))
                                {
                                    query += " null ,";
                                }
                                else
                                {
                                    DateTime dt = DateTime.Parse(fechaStr);

                                    string fecha = dt.ToString("yyyy-MM-dd HH:mm:ss");
                                    query += " '" + fecha + "' ,";
                                }
                               
                                break;

                        }
                    }

                    query += ");";

                    query = query.Replace(",);", "); \n ");
                }
                queryInsert += query;                
            }
           
            return queryInsert;
        }
 
        public static string armarQueryDeleteLocal(DataTable estructuraTablaRemota, DataTable datosLocales, DataTable datosRemotos, string tabla)
        {
            string query = string.Empty;

            //comparamos que de manera local 
            // si los datos locales son mas que los remotos entonces se tiene que eliminar lo que no este en el servidor
            if (datosLocales.Rows.Count > datosRemotos.Rows.Count)
            {
                for (int i = 0; i < datosLocales.Rows.Count; i++)
                {
                    string id = string.Empty;
                    for (int j = 0; j < datosRemotos.Rows.Count; j++ )
                    {
                        if (datosLocales.Rows[i][0].Equals(datosRemotos.Rows[j][0]))
                        {
                            id = string.Empty;
                            break;
                        }
                        else
                        {
                            id = datosLocales.Rows[i][0].ToString();
                        }
                    }

                    if (!string.IsNullOrEmpty(id))
                    {
                        query += " \n delete " + tabla + " where " + estructuraTablaRemota.Rows[0][0] + " = ";
                        switch (estructuraTablaRemota.Rows[0][1].ToString())
                        {
                            case "int":
                            case "money":
                            case "float":
                            case "long":
                            case "decimal":
                            case "bit":

                                query += datosLocales.Rows[i][0].ToString().Replace(",", ".") + " ; ";
                                break;
                            case "char":
                            case "varchar":
                            case "datetime":
                                string fechaStr =  datosLocales.Rows[i][0].ToString();

                                if (string.IsNullOrEmpty(fechaStr))
                                {
                                    query += " null ;";
                                }
                                else
                                {
                                    query += " '" + datosLocales.Rows[i][0] + "' ;";
                                }
                               
                                break;

                        }
                    }
                }
            }

            return query;
            
        }
    }
}
