using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	/*
	 * Класс для контроля доступа пользователей к функционалу
	 * И тут же хранится информация об авторизированном пользователе
	 * Сделал статичным, чтобы можно было получать доступ с любого места программы
	 * Короче пихаем сюда всё, что связано с авторизацией и контролем доступа
	*/
	static class AccessControl
	{
		/*
		 * Константы для ролей
		 * Сделал степенями двойки, чтобы можно было несколько ролей одним числом хранить
		*/
		public enum Role{
			chief_of_agency = 1,
			chief_of_department = 2,
			team_leader = 4,
			customer_relations_officer = 8,
			creative_officer = 16,
			production_officer = 32, 
			media_officer = 64,
			administrative_officer = 128
		}

		/*
		 * Словарь, отображающий идентификатор роли в её название в БД
		 * */
		public static Dictionary<Role, string> idRole2nameRole = new Dictionary<Role, string>
		{
			{ Role.chief_of_agency, "chief_of_agency"},
			{ Role.chief_of_department, "chief_of_department"},
			{ Role.team_leader, "team_leader"},
			{ Role.customer_relations_officer, "customer_relations_officer"},
			{ Role.creative_officer, "creative_officer"},
			{ Role.production_officer, "production_officer"},
			{ Role.media_officer, "media_officer"},
			{ Role.administrative_officer, "administrative_officer"},
		};

		/*
		 * Словарь, отображающий название роли в идентификатор роли
		 * */
		public static Dictionary<string, Role> nameRole2idRole = new Dictionary<string, Role>
		{
			{ "chief_of_agency", Role.chief_of_agency},
			{ "chief_of_department", Role.chief_of_department},
			{ "team_leader", Role.team_leader},
			{ "customer_relations_officer", Role.customer_relations_officer},
			{ "creative_officer", Role.creative_officer},
			{ "production_officer", Role.production_officer},
			{ "media_officer", Role.media_officer},
			{ "administrative_officer", Role.administrative_officer},
		};


		/*Роль авторизированного пользователя*/
		private static Role curentRole = 0;
		public static Role CurentRole { get => curentRole;}


		/*
		 * Возвращает строку из ролей
		 * Просто для тестирования **/
		public static string get_name_cur_role()
		{
			//ArrayList roles = new ArrayList();
			string res = "";
			foreach (KeyValuePair<Role, string> role in idRole2nameRole)
				if ((curentRole & role.Key) != 0)
					//roles.Add(role.Value);
					res += role.Value + "  ";
			return res;

			//return (string[])roles.ToArray();
		}


		/*
		 * Авторизация пользователя
		 * Здесь устанавливается соединение с БД
		 * и определяются роли пользователя
		 * */
		public static bool log_in(string login, string pass)
		{
			string connectionString = "Server=database-2.cx7kyl76gv42.us-east-2.rds.amazonaws.com;Port=5432;User="
							+ login + ";Password=" + pass + ";Database=Database2;";

            //Создание соединения с БД
            
            ConnectionSettings.npgSqlConnection = new NpgsqlConnection(connectionString);
            ConnectionSettings.npgSqlConnection.Open();


			//Тут надо как-то проверять, что такой юзер есть и соединение установлено
			

			//Создаём и выполняем запрос на членство пользователя в ролях
			String query_roles = "select \"role_name\" from \"information_schema\".\"applicable_roles\" where \"grantee\" = '" + login + "';";
			NpgsqlCommand npgSqlCommand = new NpgsqlCommand(query_roles, ConnectionSettings.npgSqlConnection);
			NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();

			if (npgSqlDataReader.HasRows)
			{
				//Проходим по всем ролям авторизированного пользователя и заполняем curentRole
				foreach (DbDataRecord dbDataRecord in npgSqlDataReader)
					if (nameRole2idRole.ContainsKey(dbDataRecord["role_name"].ToString()))
						curentRole |= nameRole2idRole[dbDataRecord["role_name"].ToString()];
			}
			else
				return false;       //У пользователя вообще нет ролей

			//Если curentRole = 0, то у пользователя нет интересующих нас ролей
			//return curentRole != 0;
			return true;
		}

		static void create_main_menu()
		{

		}
	}
}
