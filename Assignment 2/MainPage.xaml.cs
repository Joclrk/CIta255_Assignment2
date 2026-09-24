namespace Assignment_2
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            snacksList.ItemsSource = Food;
            priceList.ItemsSource = prices;
        }

        List<string> Food = new List<string>
        {
            "Pretzels", "Apple", "Yogurt", "Eggs", "Milk", "Banna", "Lunchable","Bread","Cheese", "Meat", 
        };

        List<double> prices = new List<double>
        {
            5.1, 1.4, 6.7,5.5,3.0,5.6,4.5,7.9,9.9,1.0
        };

        private void TestButtonClicked(object sender, EventArgs e)
        {
            double total = 0;
            foreach (double price in prices)
            {
                total = total + price;
                Console.WriteLine(total);
            }

            totalLabel.Text = $"Your price is: {total:C}";
        }
    }
}