using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerContatos
{
    public class Contacts
    {
        public int id { get; set; }
        public string name { get; set; }
        public string image { get; set; }

        public string telefone { get; set; }
        public string email { get; set; }

        public Bitmap imageBmp { get; set; }


        public bool Add(Contacts contacts, bool image)
        {
            bool result = false;

            DataBaseAcess dba = new DataBaseAcess();

            try
            {
                if (image)
                {
                    //Gravação com imagem
                    using (NpgsqlCommand cmd = new NpgsqlCommand())
                    {
                        cmd.CommandText = @"INSERT INTO contatos (name, image, telefone, email) " +
                                          @"VALUES (@name, @image, @telefone, @email);";


                        cmd.Parameters.AddWithValue("@name", contacts.name);
                        cmd.Parameters.AddWithValue("@image", contacts.image);
                        cmd.Parameters.AddWithValue("@telefone", contacts.telefone);
                        cmd.Parameters.AddWithValue("@email", contacts.email);

                        using (cmd.Connection = dba.OpenConnection())
                        {
                            cmd.ExecuteNonQuery();
                        }
                        result = true;
                    }
                }
                else
                {
                    //Gravação sem imagem
                    using (NpgsqlCommand cmd = new NpgsqlCommand())
                    {
                        cmd.CommandText = @"INSERT INTO contatos (name, telefone, email) " +
                                          @"VALUES (@name, @telefone, @email);";


                        cmd.Parameters.AddWithValue("@name", contacts.name);
                        cmd.Parameters.AddWithValue("@telefone", contacts.telefone);
                        cmd.Parameters.AddWithValue("@email", contacts.email);

                        using (cmd.Connection = dba.OpenConnection())
                        {
                            cmd.ExecuteNonQuery();
                        }
                        result = true;
                    }
                }
            }
            catch
            { }
            return result;
        }

        public bool SaveImageToFile(string sourcePath, string savePath, string name)
        {
            bool result = false;

            try
            {
                if (!Directory.Exists(savePath))
                {
                    Directory.CreateDirectory(savePath);


                }
                Bitmap bitmap = new Bitmap(sourcePath);
                bitmap.Save(Path.Combine(savePath, name));
                result = true;
            }
            catch (Exception ex)
            { }

            return result;
        }

        public Contacts Get(int id)
        {

            Contacts result = new Contacts();
            DataBaseAcess dba = new DataBaseAcess();

            try
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.CommandText = @"SELECT * FROM contatos " +
                                      @"WHERE id = @id;";

                    cmd.Parameters.AddWithValue("@id", id);

                    using (cmd.Connection = dba.OpenConnection())
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            result.id = Convert.ToInt32(reader["id"]);
                            result.name = reader["name"].ToString();
                           
                            result.telefone = reader["telefone"].ToString();
                            result.email = reader["email"].ToString();

                            if (reader["image"] != DBNull.Value)
                                result.image = reader["image"].ToString();
                            else
                                result.image = string.Empty;

                            if (!string.IsNullOrEmpty(result.image))
                            {
                                using(var stream = new FileStream(Path.Combine(Config.imageFolder, result.image), FileMode.Open))
                                {
                                    Bitmap bmp = new Bitmap(stream);
                                    result.imageBmp = bmp;
                                }
                            }
                            else
                            {
                                result.imageBmp = new Bitmap(Path.Combine(Config.imageDefaultPath));

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            { }

            return result;
        }

        public List<Contacts> GetAll()
        {
            List<Contacts> result = new List<Contacts>();
            DataBaseAcess dba = new DataBaseAcess();

            try
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.CommandText = @"SELECT p.id, p.name, p.email, p.telefone, p.image " +
                                      @"FROM contatos p " +
                                      @"ORDER BY p.id;";

                    using (cmd.Connection = dba.OpenConnection())
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Contacts contacts = new Contacts();

                            contacts.id = Convert.ToInt32(reader["id"]);
                            contacts.name = reader["name"].ToString();
                            contacts.email = reader["email"].ToString();
                            contacts.telefone = reader["telefone"].ToString();

                            //contacts.imageBmp = new Bitmap(Path.Combine(Config.appRootFolder, Config.imageFolder, contacts.image));

                            if (reader["image"] != DBNull.Value)
                                contacts.image = reader["image"].ToString();
                            else
                                contacts.image = string.Empty;

                            if (!string.IsNullOrEmpty(contacts.image))
                            {
                                using (var stream = new FileStream(Path.Combine(Config.imageFolder, contacts.image), FileMode.Open))
                                {
                                    Bitmap bmp = new Bitmap(stream);
                                    contacts.imageBmp = bmp;
                                }
                            }
                            else
                            {
                                contacts.imageBmp = new Bitmap(Path.Combine(Config.imageDefaultPath));
                            }

                            result.Add(contacts);

                        }
                    }
                }
            }
            catch (Exception ex)
            { }

            return result;
        }
      
        public bool Delete(int id)
        {
            bool result = false;
            DataBaseAcess dba = new DataBaseAcess();

            try
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.CommandText = @"DELETE FROM contatos " +
                                      @"WHERE id = @id;";

                    cmd.Parameters.AddWithValue("@id", id);

                    using (cmd.Connection = dba.OpenConnection())
                    {
                        cmd.ExecuteNonQuery();
                        result = true;
                    }
                }
            }
            catch (Exception ex)
            { }

            return result;
        }

        public bool DeleteImageFile(string filePath)
        {
            bool result = false;
            try
            {
                File.Delete(filePath); 
                result = true;
            }catch(Exception ex) 
                { }

            return result;
        }
        public bool Update(Contacts contacts, bool image)
        {
            bool result = false;
            DataBaseAcess dba = new DataBaseAcess();

            try
            {
                if (image) { 
                    using (NpgsqlCommand cmd = new NpgsqlCommand())
                    {
                        cmd.CommandText = @"UPDATE contatos " +
                                          @"SET id = @id, name = @name, email = @email, image = @image, telefone = @telefone " +
                                          @"WHERE id = @id;";

                        cmd.Parameters.AddWithValue("@id", contacts.id);
                        cmd.Parameters.AddWithValue("@name", contacts.name);
                        cmd.Parameters.AddWithValue("@email", contacts.email);
                        cmd.Parameters.AddWithValue("@telefone", contacts.telefone);
                        cmd.Parameters.AddWithValue("@image", contacts.image);


                        using (cmd.Connection = dba.OpenConnection())
                        {
                            cmd.ExecuteNonQuery();
                            result = true;
                        }
                    }
            }
                else
                {
                    using (NpgsqlCommand cmd = new NpgsqlCommand())
                    {
                        cmd.CommandText = @"UPDATE contatos " +
                                          @"SET id = @id, name = @name, email = @email, telefone = @telefone " +
                                          @"WHERE id = @id;";

                        cmd.Parameters.AddWithValue("@id", contacts.id);
                        cmd.Parameters.AddWithValue("@name", contacts.name);
                        cmd.Parameters.AddWithValue("@email", contacts.email);
                        cmd.Parameters.AddWithValue("@telefone", contacts.telefone);



                        using (cmd.Connection = dba.OpenConnection())
                        {
                            cmd.ExecuteNonQuery();
                            result = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            { }

            return result;
        }

       
    }
}
