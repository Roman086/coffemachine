/*
 * Created by SharpDevelop.
 * User: Roman
 * Date: 12.06.2017
 * Time: 20:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace cofe
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int money; // Вносимые деньги
		int[] portions={20,20,20,20,20}; // Сколько порций осталось (для каждого вида)
		int[] price={45,50,55,60,65}; // Цена порции (для каждого вида)
		int sdacha; // Оставшаяся сдача в автомате
		int[] stat={0,0,0,0,0}; // Статистика покупок кофе
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}	
        void MainFormLoad(object sender, EventArgs e)
        { 
        	money=0;
        	sdacha=1000;
        	create_or_read_base();
        }
        void create_or_read_base()
        {
        	String str;
            SqlConnection myConn = new SqlConnection ("Server=localhost;Integrated security=SSPI;database=master");
            myConn.Open();
       	
        	if (File.Exists("C:\\MyDatabaseData.mdf"))
        	{ // Считать статистику из базы в массив и отобразить на форме
        		
        		str = "SELECT * FROM stat";
        		SqlCommand myCommand = new SqlCommand(str,myConn);
        		SqlDataReader reader = myCommand.ExecuteReader();
        		
        		
           
        		
        		
        	} else { //Создать базу, таблицу stat(поля "id" (номер кофе)и "rating"(популярность)
        		     // и добавить в нее нулевые значения популярности для всех видов кофе   
              str = "CREATE DATABASE MyDatabase ON PRIMARY " +
                  "(NAME = MyDatabase_Data, " +
                  "FILENAME = 'C:\\MyDatabaseData.mdf', " +
                  "SIZE = 4MB, MAXSIZE = 10MB, FILEGROWTH = 10%) " +
                  "LOG ON (NAME = MyDatabase_Log, " +
                  "FILENAME = 'C:\\MyDatabaseLog.ldf', " +
                  "SIZE = 4MB, " +
                  "MAXSIZE = 5MB, " +
                  "FILEGROWTH = 10%)";

              
              SqlCommand myCommand = new SqlCommand(str, myConn);
              myCommand.ExecuteNonQuery();
              
              str = "CREATE TABLE stat (id INT, rating INT) ";
              SqlCommand myCommand2 = new SqlCommand(str, myConn);
              myCommand2.ExecuteNonQuery();  
              for (int i=0;i<5;i++)
              {
              	str = "INSERT INTO stat VALUES ('" + i.ToString()+ "', '0') ";
         //     SqlCommand myCommand3 = new SqlCommand(str, myConn);
              	(new SqlCommand(str, myConn)).ExecuteNonQuery();
              }
        	}
        	myConn.Close();
        }	
		void TrackBar1Scroll(object sender, EventArgs e) /// Ввод денег в автомат
		{
			money=trackBar1.Value;
			label_money.Text=trackBar1.Value.ToString()+" руб.";
		}		
		void Button1Click(object sender, EventArgs e)
		{
			start_avtomat(0);
		}
		void Button2Click(object sender, EventArgs e)
		{
			start_avtomat(1);
		}		
		void Button3Click(object sender, EventArgs e)
		{
			start_avtomat(2);
		}		
		void Button4Click(object sender, EventArgs e)
		{
			start_avtomat(3);
		}		
		void Button5Click(object sender, EventArgs e)
		{
			start_avtomat(4);
		}
		void start_avtomat(int nomer_cofe)
		{
			if (portions[nomer_cofe]==0)
			{
				MessageBox.Show("Кофе вида " + (nomer_cofe+1).ToString() + " больше не осталось");
				return;
			} 			
			if (money < price[0])
			{
				MessageBox.Show("Недостаточно денег для покупки кофе вида " + (nomer_cofe+1).ToString());
				return;
			}
			if (money - price[0] > sdacha)
			{
				MessageBox.Show("Недостаточно денег для выдачи сдачи за кофе вида " + (nomer_cofe+1).ToString());
				return;
			}
			///Если все нормально
			portions[nomer_cofe]--; // Порций этого вида кофе стало на 1 меньше
			stat[nomer_cofe]++;
			
			// ЗДЕСЬ добвлять +1 к статистике в БД
			
			sdacha = sdacha - (money - price[nomer_cofe]); // Сдачи в автомате стало меньше на разницу между
			                                               // вставленными деньгами и ценой порции
			label_sdacha.Text=sdacha.ToString()+" руб.";   // Вывод нового числа оставшейся сдачи 
			switch (nomer_cofe) { // Вывод нового числа оставшихся порций 
					case 0: 
						por1.Text=portions[nomer_cofe].ToString();
						stat1.Text=stat[nomer_cofe].ToString();
						break;
					case 1: 
						por2.Text=portions[nomer_cofe].ToString();
						stat2.Text=stat[nomer_cofe].ToString();				
						break;
					case 2: 
						por3.Text=portions[nomer_cofe].ToString(); 
						stat3.Text=stat[nomer_cofe].ToString();						
						break;
					case 3: 
						por4.Text=portions[nomer_cofe].ToString();
						stat4.Text=stat[nomer_cofe].ToString();
						break;
					case 4: 
						por5.Text=portions[nomer_cofe].ToString();
						stat5.Text=stat[nomer_cofe].ToString();
						break;
			}			
		}
	}
}
