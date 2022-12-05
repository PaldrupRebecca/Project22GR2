namespace Project22GR2.Models
{
    public class BlogPost
    {
		private string _name;
        private int _id;
        
		public string Name { get; set; }
		public int Id { get; set; }
		public DateTime EndDate { get; private set; }

		public BlogPost(string name, int id)
		{
			_name = name;
			_id = id;
			EndDate = DateTime.Now;

		}

	}
}
