﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsLogin
/// </summary>
class clsLogin
{
    private SqlConnection con = clsDatabase.Connect();
    private SqlCommand cmd = clsDatabase.Command();
    private SqlDataAdapter adapt = clsDatabase.DataAdapter();

    public static int ID = 0;

    public bool checkCredentials(string username, string password)
    {
        con.Open();
        cmd = new SqlCommand(
            "SELECT * FROM Gebruiker WHERE Gebruikersnaam='" + username + "' AND Wachtwoord='" + password + "'; SELECT SCOPE_IDENTITY()",
            con);
        adapt = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adapt.Fill(ds);
        ID = Convert.ToInt32(cmd.ExecuteScalar());
        con.Close();

        int count = ds.Tables[0].Rows.Count;
        if (count == 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}