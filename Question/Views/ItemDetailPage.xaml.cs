﻿using Question.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Question.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}