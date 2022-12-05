namespace Project22GR2.Models
{
    public class BlogPost
    {
		private string _name;
        private int _id;
        
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}
		public int Id
		{
			get { return _id; }
			set { _id = value; }
		}
		public DateTime EndDate { get; private set; }

		public BlogPost(string name, int id)
		{
			_name = name;
			_id = id;
			EndDate = DateTime.Now;

		}

	}
}
