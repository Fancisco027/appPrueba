using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using LinqToExcel;
using ExcelDataReader;
using ExcelDataReader;
using System.IO;
using MySql.Data.MySqlClient;


namespace appPrueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta oprimiendo el boton");
            //El dialogo solo Muetra los Archivos .txt
            Examinar.ShowDialog();
        }

        private void Examinar_FileOk(object sender, CancelEventArgs e)
        {
            String[] arr = new String[10];
            arr[1] = "asdasd";

            string path = Examinar.FileName;

            string p = "";

            //MessageBox.Show("El path es " + path);

            #region"Excel DataReader"
            using (var stream = File.Open(path, FileMode.Open, FileAccess.Read))
            {
                // Auto-detect format, supports:
                //  - Binary Excel files (2.0-2003 format; *.xls)
                //  - OpenXml Excel files (2007 format; *.xlsx)
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    // Choose one of either 1 or 2:

                    // 1. Use the reader methods
                    do
                    {
                        while (reader.Read())
                        {
                             string instruccionPrueba = "INSERT INTO `dblagaceroprocess`.`comisiones_sistema` (`cliente`, `factura`,`fecha`, `importe`) VALUES ('{0}', '{1}', '{2}');";
                             instruccionPrueba = string.Format(instruccionPrueba, "Francisco", "000E3322", 123.2);
                             p+= reader.GetString(0);
                        }
                    } while (reader.NextResult());

                    // 2. Use the AsDataSet extension method
                    var result = reader.AsDataSet();
                    var has = reader.AsDataSet().GetHashCode();

                    gvDatosExcel.DataSource = result.Tables[0];

                    // The result of each spreadsheet is in result.Tables
                    MessageBox.Show( has.ToString() );
                }
            }

            #endregion

            #region "linq excel"
            //var book = new ExcelQueryFactory(path);

            //var res = (from row in book.Worksheet("Hoja1")
            //           let item = row[0].Cast<String>()
            //           select item).ToList();

            //Console.Write(res.ToString());


            #endregion

        }

        private void btnDataBase_Click(object sender, EventArgs e)
        {
            dbAccess db = new dbAccess();

            //hacer la conexion de base de datos
            string instruccionPrueba = "INSERT INTO `dblagaceroprocess`.`comisiones_sistema` (`cliente`, `factura`, `importe`) VALUES ('{0}', '{1}', '{2}');";
            instruccionPrueba = string.Format(instruccionPrueba, "Francisco", "000E3322", 123.2);

            int resultado = db.consulta(instruccionPrueba);
            if (resultado > 0)
            {
                MessageBox.Show("El registro prueba se hiso con exito");

            }
            else
            {
                MessageBox.Show("Ocurrio un problema");
            }
            //cargarGrid();

        }


    }
}
