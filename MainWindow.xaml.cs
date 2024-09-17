public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void AboutMenuItem_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Copyright 2024 David Weinbach", "About", MessageBoxButton.OK, MessageBoxImage.Information);
    }

    // ... rest of your window code ...
}