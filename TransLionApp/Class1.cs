using System;

public class Class1
{
	
	public Class1()
	{
		string myConnectionString = "Server=www.db4free.net;Port=3306;User Id=translion_annak;Password=09262000;Database=translion_db;OldGuids=True";
		MySqlConnection conn = new MySqlConnection(myConnectionString);
		conn.Open();
		conn.Close();
		//string query1 = "CREATE TABLE Company(CompanyKey INTEGER NOT NULL,Name CHAR(30) NULL,Email CHAR(30) NULL,Adress CHAR(50) NULL,PersonName CHAR(30) NULL,Phone CHAR(11) NULL,Postcode CHAR(6) NULL,City CHAR(30) NULL);ALTER TABLE Company ADD CONSTRAINT XPKCompany PRIMARY KEY(CompanyKey);CREATE TABLE Entry(EntryKey CHAR(18) NOT NULL,Login CHAR(18) NULL,Password CHAR(18) NULL,UserKey INTEGER NOT NULL,AdminKey INTEGER NOT NULL); ALTER TABLE Entry ADD CONSTRAINT XPKEntry PRIMARY KEY(EntryKey, UserKey, AdminKey); CREATE TABLE StatusKey(StatusKey INTEGER NOT NULL,Name CHAR(18) NULL);ALTER TABLE StatusKey ADD CONSTRAINT XPKStatusKey PRIMARY KEY(StatusKey); CREATE TABLE UserInfo2(Doc1 CHAR(50) NULL,Doc2 CHAR(50) NULL,Doc3 CHAR(50) NULL,Password CHAR(18) NULL,Name CHAR(30) NULL, FirstDayOfSickness DATE NULL,LastDayOfSickness DATE NULL,LastGuidanceDay DATE NULL,CompanyName CHAR(30) NULL,CompanyDate DATE NULL,WIADate DATE NULL,WIAStatusKey INTEGER NULL,CompanyStatusKey INTEGER NULL,Login CHAR(30) NULL,UserKey INTEGER NOT NULL); ALTER TABLE UserInfo2 ADD CONSTRAINT XPKUserInfo2 PRIMARY KEY(UserKey); ALTER TABLE Entry ADD CONSTRAINT R_23 FOREIGN KEY(UserKey) REFERENCES UserInfo2(UserKey); ALTER TABLE UserInfo2 ADD CONSTRAINT R_16 FOREIGN KEY(WIAStatusKey) REFERENCES StatusKey(StatusKey); ALTER TABLE UserInfo2 ADD CONSTRAINT R_17 FOREIGN KEY(WIAStatusKey) REFERENCES StatusKey(StatusKey); ALTER TABLE UserInfo2 ADD CONSTRAINT R_18 FOREIGN KEY(CompanyStatusKey) REFERENCES StatusKey(StatusKey); ";
		string query2 = "AlTER TABLE UserInfo2";
		//MySqlCommand mysql_query = conn.CreateCommand();
		//mysql_query.CommandText = query1;
	}
}
