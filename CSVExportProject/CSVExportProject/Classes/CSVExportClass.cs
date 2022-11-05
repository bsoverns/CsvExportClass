using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVExportProject
{
    public class CSVExportClass
    {
        //public DataTable export = new DataTable();
        //public string extract_location;

        public bool Export(DataTable export, string extract_location, string delimiter_type, string quoted_type)
        //public bool Export(DataTable export, string extract_location)
        {
            string delimiter;
            string quote;

            if (delimiter_type == "comma (,)")
            {
                delimiter = ",";
            }

            else if (delimiter_type == "pip (|)")
            {
                delimiter = "|";
            }

            else
            {
                delimiter = "F";
            }

            if (quoted_type == "Yes")
            {
                quote = "\"";
            }

            else
            {
                quote = "";
            }

            if (delimiter == "," || delimiter == "|")
            {
                try
                {
                    FileStream _file = new FileStream(extract_location.ToString(), FileMode.Create);
                    if (export.Rows.Count != 0)
                    {
                        using (StreamWriter sw = new StreamWriter(_file))
                        {
                            int count = 1;
                            foreach (DataColumn col in export.Columns)
                            {
                                if (count < export.Columns.Count)
                                {
                                    sw.Write(col.ColumnName + delimiter);
                                }

                                else
                                {
                                    sw.WriteLine(col.ColumnName);
                                }
                                count++;
                            }

                            if (quoted_type == "Yes")
                            {
                                for (int k = 0; k < export.Rows.Count; k++)
                                {
                                    for (int j = 0; j < export.Columns.Count; j++)
                                    {
                                        if ((j + 1).Equals(export.Columns.Count))
                                        {
                                            sw.WriteLine(quote + export.Rows[k][j].ToString().Replace(quote, "") + quote);
                                        }
                                        else
                                        {
                                            sw.Write(quote + export.Rows[k][j].ToString().Replace(quote, "") + quote + delimiter);
                                        }
                                    }
                                }
                            }

                            else
                            {
                                for (int k = 0; k < export.Rows.Count; k++)
                                {
                                    for (int j = 0; j < export.Columns.Count; j++)
                                    {
                                        if ((j + 1).Equals(export.Columns.Count))
                                        {
                                            sw.WriteLine(export.Rows[k][j].ToString().Replace(delimiter, ""));
                                        }
                                        else
                                        {
                                            sw.Write(export.Rows[k][j].ToString().Replace(delimiter, "") + delimiter);
                                        }
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

                catch (Exception ex)
                {
                    return false;
                }

                finally
                {
                    export.Dispose();
                }
            }

            if(delimiter == "F")
            {
                try
                {
                    FileStream _file = new FileStream(extract_location.ToString(), FileMode.Create);
                    if (export.Rows.Count != 0)
                    {
                        using (StreamWriter sw = new StreamWriter(_file))
                        {
                            int count = 1;
                            foreach (DataColumn col in export.Columns)
                            {
                                if (count < export.Columns.Count)
                                {
                                    sw.Write(col.ColumnName + delimiter);
                                }

                                else
                                {
                                    sw.WriteLine(col.ColumnName);
                                }
                                count++;
                            }

                            if (quoted_type == "Yes")
                            {
                                for (int k = 0; k < export.Rows.Count; k++)
                                {
                                    for (int j = 0; j < export.Columns.Count; j++)
                                    {
                                        if ((j + 1).Equals(export.Columns.Count))
                                        {
                                            sw.WriteLine(quote + export.Rows[k][j].ToString());
                                        }
                                        else
                                        {
                                            sw.Write(quote + export.Rows[k][j].ToString());
                                        }
                                    }
                                }
                            }

                            else
                            {
                                for (int k = 0; k < export.Rows.Count; k++)
                                {
                                    for (int j = 0; j < export.Columns.Count; j++)
                                    {
                                        if ((j + 1).Equals(export.Columns.Count))
                                        {
                                            sw.WriteLine(export.Rows[k][j].ToString());
                                        }
                                        else
                                        {
                                            sw.Write(export.Rows[k][j].ToString());
                                        }
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

                catch (Exception ex)
                {
                    return false;
                }

                finally
                {
                    export.Dispose();
                }
            }

            else //Fixed Width => doesn't work
            {
                try
                {
                    FileStream _file = new FileStream(extract_location.ToString(), FileMode.Create);
                    if (export.Rows.Count != 0)
                    {
                        using (StreamWriter sw = new StreamWriter(_file))
                        {
                            int count = 1;
                            foreach (DataColumn col in export.Columns)
                            {
                                if (count < export.Columns.Count)
                                {
                                    sw.Write(col.ColumnName + delimiter);
                                }

                                else
                                {
                                    sw.WriteLine(col.ColumnName);
                                }
                                count++;
                            }

                            if (quoted_type == "Yes")
                            {
                                for (int k = 0; k < export.Rows.Count; k++)
                                {
                                    for (int j = 0; j < export.Columns.Count; j++)
                                    {
                                        if ((j + 1).Equals(export.Columns.Count))
                                        {
                                            sw.WriteLine(quote + export.Rows[k][j].ToString().Replace(quote, "") + quote);
                                        }
                                        else
                                        {
                                            sw.Write(quote + export.Rows[k][j].ToString().Replace(quote, "") + quote + delimiter);
                                        }
                                    }
                                }
                            }

                            else
                            {
                                for (int k = 0; k < export.Rows.Count; k++)
                                {
                                    for (int j = 0; j < export.Columns.Count; j++)
                                    {
                                        if ((j + 1).Equals(export.Columns.Count))
                                        {
                                            sw.WriteLine(export.Rows[k][j].ToString().Replace(delimiter, ""));
                                        }
                                        else
                                        {
                                            sw.Write(export.Rows[k][j].ToString().Replace(delimiter, "") + delimiter);
                                        }
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

                catch (Exception ex)
                {
                    return false;
                }

                finally
                {
                    export.Dispose();
                }
            }
        }



        //public bool Export()
        //{
        //    try
        //    {
        //        if (export.Rows.Count != 0)
        //        {
        //            using (StreamWriter sw = new StreamWriter(extract_location.ToString()))
        //            {
        //                int count = 1;
        //                foreach (DataColumn col in export.Columns)
        //                {
        //                    if (count < export.Columns.Count)
        //                    {
        //                        sw.Write(col.ColumnName + ",");
        //                    }

        //                    else
        //                    {
        //                        sw.WriteLine(col.ColumnName);
        //                    }
        //                    count++;
        //                }

        //                for (int k = 0; k < export.Rows.Count; k++)
        //                {
        //                    for (int j = 0; j < export.Columns.Count; j++)
        //                    {
        //                        if ((j + 1).Equals(export.Columns.Count))
        //                        {
        //                            sw.WriteLine("\"" + export.Rows[k][j].ToString().Replace("\"", "") + "\"");
        //                        }
        //                        else
        //                        {
        //                            sw.Write("\"" + export.Rows[k][j].ToString().Replace("\"", "") + "\",");
        //                        }
        //                    }
        //                }
        //            }

        //            return true;
        //        }

        //        else
        //        {
        //            return false;
        //        }
        //    }

        //    catch (Exception)
        //    {
        //        return false;
        //    }

        //    finally
        //    {
        //        export.Dispose();
        //    }

        //}
    }
}
