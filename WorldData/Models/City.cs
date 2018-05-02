using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;

namespace WorldData.Models
{
  public class City
  {
    private string _name;
    private string _code;
    private string _district;

    public City(string name, string code, string district)
    {
      _name = name;
      _code = code;
      _district = district;
    }
    public string GetName()
    {
      return _name;
    }
    public string GetCode()
    {
      return _code;
    }
    public string GetDistrict()
    {
      return _district;
    }
    public static List<City> GetAll()
      {
        List<City> all Cities = new List <Item> {};
        MySqlConnection conn = DB.Connection();
        conn.Open();
        MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
        cmd.CommandText = @"SELECT * FROM items;";
        MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
        while (rdr.Read()
        {
          string Name = rdr.GetString(1);
          string Code = rdr.GetCode(2);
          string District = rdr.GetDistrict(3);
          allCitites.Add(newCity);
        }
        conn.Close();
        if(conn !=null)
        {
          conn.Dispose();
        }
        return allCitites;
      }
  }
}
