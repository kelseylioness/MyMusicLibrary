using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Content Dialog item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MyMusicLibrary.View
{
    public sealed partial class ContentDialog1 : ContentDialog
    {
        //public static readonly DependencyProperty TextProperty = DependencyProperty.Register(
        //    "Text", typeof(string), typeof(ContentDialog1), new PropertyMetadata(default(string)));
        DialogBinding binding = new DialogBinding();

        public ContentDialog1()
        {
            this.InitializeComponent();
            DataContext = binding;
  
        }
        //class dialog binding at bottom is object that contains data (the text box input) 
        
        public string Text
        {
            get { return  binding.Text; }
            set { binding.Text = value; }
        }
        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {

        }
        private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
    class DialogBinding
    {
        public String Text { get; set; }
    }
     //sets the texts from user 
}