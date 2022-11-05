using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVExport
{
    public class Exporter
    {        
        public DataTable export = new DataTable();
        public string extract_location;

        public bool Export()
        {
            try
            {
                if (export.Rows.Count != 0)
                {
                    using (StreamWriter sw = new StreamWriter(extract_location.ToString()))
                    {
                        int count = 1;
                        foreach (DataColumn col in export.Columns)
                        {
                            if (count < export.Columns.Count)
                            {
                                sw.Write(col.ColumnName + ",");
                            }

                            else
                            {
                                sw.WriteLine(col.ColumnName);
                            }
                            count++;
                        }

                        for (int k = 0; k < export.Rows.Count; k++)
                        {
                            for (int j = 0; j < export.Columns.Count; j++)
                            {
                                if ((j + 1).Equals(export.Columns.Count))
                                {
                                    sw.WriteLine("\"" + export.Rows[k][j].ToString().Replace("\"", "") + "\"");
                                }
                                else
                                {
                                    sw.Write("\"" + export.Rows[k][j].ToString().Replace("\"", "") + "\",");
                                }
                            }
                        }
                    }

                    return true;
                }

                else
                {
                    return false;
                }
            }

            catch (Exception)
            {
                return false;
            }

            finally
            {
                export.Dispose();
            }
        
        }
    }
}
