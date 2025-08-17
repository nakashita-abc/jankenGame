namespace BlazorApp1.Entities
{
    public class User
    {
        //メンバー変数
        public int Id { get; set; }
        public string? Name { get; set; }


        //コンストラクター
        public User()
        {

        }

        public User(int id)
        {
            Id = id;
        }

        public User(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
