namespace SDV701Project2
{
    class clsBeansList
    {
        public clsBeansList() { }

        public int BeanID { get; set; }
        public string BeanType { get; set; }
        public string RoastType { get; set; }
        public int Quantity { get; set; }
        public string CountryOfOrigin { get; set; }

        public override string ToString()
        {
            return BeanID.ToString() + " " + BeanType + " " + RoastType + " " + Quantity.ToString() + " " + CountryOfOrigin;
        }
    }
}
