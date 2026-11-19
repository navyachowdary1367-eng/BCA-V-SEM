using System;
using MySql.Data.MySqlClient;
class Program56
{
static void Main56()
{
string conStr = " server=localhost ; database=college ; uid=root ; pwd= ; " ;
using (MySqlConnection con =new MySqlConnection(conStr))
{
try
{
con. Open();
Console.WriteLine( "Database Connected Successfully!" );
}
catch (Exception ex)
{
Console. WriteLine(ex . Message) ;
}
}
}
}
