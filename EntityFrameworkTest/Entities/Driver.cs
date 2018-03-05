namespace EntityFrameworkTest.Entities
{
    public class Driver
    {
        public int DriverID { get; set; }
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            var t = (Driver)obj;
            return t.Name == this.Name;
        }

        public override int GetHashCode()
        {
            int prime = 31;
            int result = 1;
            result = result * prime + Name.GetHashCode();
            return result;
        }
    }
}